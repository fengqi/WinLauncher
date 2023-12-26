using System;
using System.IO;
using System.Linq;
using Microsoft.Win32;
using Newtonsoft.Json;
using WinLauncher.Models;
using System.Configuration;
using System.Collections.Generic;

namespace WinLauncher.Services {
    internal class AppManager {
        private static string configPath = "";
        private static readonly List<AppInfo> apps = new List<AppInfo>();
        private readonly Pinyin pinyin = new Pinyin();

        public AppManager() {
            CheckConfigPath();
        }

        public List<AppInfo> ScanApplications() {
            ScanPublicDesktopApplications();
            ScanDesktopApplications();
            ScanRegistryApplications();

            return apps;
        }

        // 检查配置文件目录
        public void CheckConfigPath() {
            var userLevel = ConfigurationUserLevel.PerUserRoamingAndLocal;
            configPath = ConfigurationManager.OpenExeConfiguration(userLevel).FilePath;
            configPath = System.IO.Path.GetDirectoryName(configPath);
            if (!Directory.Exists(configPath)) {
                Directory.CreateDirectory(configPath);
            }
        }

        // 保存应用列表到文件
        public void SaveAppList() {
            string filePath = Path.Combine(configPath, "apps.json");
            string jsonString = JsonConvert.SerializeObject(apps);
            File.WriteAllText(filePath, jsonString);
        }

        // 从文件加载应用列表
        public List<AppInfo> LoadAppList() {
            if (apps.Count == 0) {
                string filePath = Path.Combine(configPath, "apps.json");
                if (!File.Exists(filePath)) {
                    return apps;
                }

                string jsonString = File.ReadAllText(filePath);
                apps.AddRange(JsonConvert.DeserializeObject<List<AppInfo>>(jsonString));
                //apps.AddRange(JsonSerializer.Deserialize<List<AppInfo>>(jsonString));
            }

            return apps.OrderBy(app => app.Name).OrderByDescending(app => app.LaunchCount).ToList();
        }

        // 通过应用名获取应用信息
        public void RemoteByExePath(string exePath) {
            var find = apps.Find(app => app.ExePath.Equals(exePath));
            if (find != null) {
                find.Deleted = true;
            }
        }

        // 启动次数加一
        public void IncreaseLaunchCount(string exePath) {
            int index = apps.FindIndex(app => app.ExePath.Equals(exePath));
            if (index != -1) {
                apps[index].LaunchCount++;
            }
        }

        // 置顶
        public void PinTop(string exePath) {
            int index = apps.FindIndex(app => app.ExePath.Equals(exePath));
            if (index != -1) {
                apps[index].LaunchCount = apps[0].LaunchCount + 2;
            }
        }

        public void UnPinTop(string exePath) {
            int index = apps.FindIndex(app => app.ExePath.Equals(exePath));
            if (index != -1) {
                apps[index].LaunchCount = 0;
            }
        }

        public void Edit(string oldExePath, AppInfo appInfo) {
            int index = apps.FindIndex(app => app.ExePath.Equals(oldExePath));
            if (index != -1) {
                apps[index].Name = appInfo.Name;
                apps[index].ExePath = appInfo.ExePath;
            }
        }

        public AppInfo AddApp(string name, string exePath, string iconPath, string args = "") {
            if (string.IsNullOrEmpty(name)) {
                return null;
            }

            if (!System.IO.File.Exists(exePath) || !System.IO.File.Exists(iconPath) || !exePath.EndsWith(".exe")) {
                return null;
            }

            // todo 可设置
            if (exePath.IndexOf("install", StringComparison.OrdinalIgnoreCase) >= 0 ||
                exePath.IndexOf("uninst", StringComparison.OrdinalIgnoreCase) >= 0 ||
                exePath.IndexOf("unins0", StringComparison.OrdinalIgnoreCase) >= 0 ||
                exePath.IndexOf("setup", StringComparison.OrdinalIgnoreCase) >= 0 ||
                exePath.IndexOf("windowsdesktop-runtime", StringComparison.OrdinalIgnoreCase) >= 0 ||
                exePath.IndexOf("msedgewebview", StringComparison.OrdinalIgnoreCase) >= 0 ||
                exePath.IndexOf("vcredist", StringComparison.OrdinalIgnoreCase) >= 0 ||
                exePath.IndexOf("vc_redist", StringComparison.OrdinalIgnoreCase) >= 0) {
                return null;
            }

            int findName = apps.FindIndex(item => item.Name.Equals(name));
            if (findName != -1) {
                if (!apps[findName].Deleted) {
                    return null;
                }
                apps[findName].Deleted = false;
                return apps[findName];
            }

            int findExe = apps.FindIndex(item => item.ExePath.Equals(exePath) && item.Args == args);
            if (findExe != -1) {
                if (!apps[findExe].Deleted) {
                    return null;
                }
                apps[findExe].Deleted = false;
                return apps[findExe];
            }

            AppInfo app = new AppInfo {
                Name = name,
                ExePath = exePath,
                Args = args,
                IconPath = iconPath,
                CustomName = "",
                LaunchCount = 0,
                Sort = 0,
                Pinyin = this.pinyin.GetFirstPro(name),
            };
            apps.Add(app);
            return app;
        }

        // 扫描注册表
        private void ScanRegistryApplications() {
            var keys = new RegistryKey[] {
                Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"),
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"),
                Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall"),
                Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall")
            };

            foreach (var k in keys) {
                if (k == null) continue;
                foreach (var keyName in k.GetSubKeyNames()) {
                    var key = k.OpenSubKey(keyName);
                    if (key == null) continue;

                    var displayName = key.GetValue("DisplayName") as string;
                    var displayVersion = key.GetValue("DisplayVersion") as string;
                    if (displayName != null && displayVersion != null) {
                        displayName = displayName.Replace("v" + displayVersion, "");
                        displayName = displayName.Replace("v " + displayVersion, "");
                        displayName = displayName.Replace(displayVersion, "");
                        displayName = displayName.Trim();
                    }

                    var displayIcon = key.GetValue("DisplayIcon") as string;
                    var installPath = key.GetValue("InstallLocation") as string;

                    // .exe,0 .exe,1 这样的去掉末尾的 ,0 ,1
                    if (displayIcon != null && displayIcon.Contains(".exe,")) {
                        var index = displayIcon.LastIndexOf(',');
                        if (index != -1) {
                            displayIcon = displayIcon.Substring(0, index);
                        }
                    }

                    if ((installPath == null || !installPath.EndsWith(".exe")) && displayIcon != null) {
                        installPath = displayIcon;
                    }

                    AddApp(displayName, installPath, displayIcon);
                }
            }
        }

        //  扫描当前用户桌面
        private void ScanDesktopApplications() {
            String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            foreach (string file in System.IO.Directory.GetFiles(desktopPath)) {
                if (System.IO.Path.GetExtension(file) == ".exe") {
                    var name = System.IO.Path.GetFileNameWithoutExtension(file);
                    var exePath = System.IO.Path.GetDirectoryName(file);
                    AddApp(name, exePath, file);
                }
                else if (System.IO.Path.GetExtension(file) == ".lnk") {
                    IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
                    IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(file);
                    var name = System.IO.Path.GetFileNameWithoutExtension(shortcut.FullName);
                    AddApp(name, shortcut.TargetPath, shortcut.TargetPath, shortcut.Arguments);
                }
            }
        }

        // 扫描公共桌面
        private void ScanPublicDesktopApplications() {
            String desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
            foreach (string file in System.IO.Directory.GetFiles(desktopPath)) {
                if (System.IO.Path.GetExtension(file) == ".exe") {
                    var name = System.IO.Path.GetFileNameWithoutExtension(file);
                    var exePath = System.IO.Path.GetDirectoryName(file);
                    AddApp(name, exePath, file);
                }
                else if (System.IO.Path.GetExtension(file) == ".lnk") {
                    IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
                    IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(file);
                    var name = System.IO.Path.GetFileNameWithoutExtension(shortcut.FullName);
                    AddApp(name, shortcut.TargetPath, shortcut.TargetPath);
                }
            }
        }
    }
}
