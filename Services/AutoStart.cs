using System;
using System.IO;

namespace WinLauncher.Services {
    internal class AutoStart {
        // 设置开机自动启动
        public static void SetAutoStart(string appName, string appPath) {
            string runPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string shortcutPath = Path.Combine(runPath, appName + ".lnk");
            if (File.Exists(shortcutPath)) {
                return;
            }

            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutPath);
            shortcut.TargetPath = appPath;
            shortcut.WorkingDirectory = Path.GetDirectoryName(appPath);
            shortcut.WindowStyle = 1;
            shortcut.Description = appName;
            shortcut.IconLocation = appPath;
            shortcut.Save();
        }

        // 取消开机自动启动
        public static void CancelAutoStart(string appName) {
            string runPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string shortcutPath = Path.Combine(runPath, appName + ".lnk");
            if (!File.Exists(shortcutPath)) {
                return;
            }

            File.Delete(shortcutPath);
        }
    }
}