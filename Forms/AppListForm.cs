using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using WinLauncher.Models;
using WinLauncher.Services;

namespace WinLauncher.Forms {
    public partial class AppListForm : Form {
        private readonly AppManager appManager = new AppManager();
        private readonly Timer searchTimer = new Timer();

        public AppListForm() {
            InitializeComponent();
            searchTimer.Tick += SearchTimer_Tick;
        }

        private void ApplicationListForm_Load(object sender, EventArgs e) {
            SetLocation();
            LoadAppList();
        }

        //  设置窗口位置
        private void SetLocation() {
            int screenRight = Screen.PrimaryScreen.WorkingArea.Right;
            int screenBottom = Screen.PrimaryScreen.WorkingArea.Bottom;

            int popupRight = screenRight - this.Width - Properties.Settings.Default.appListMarginRight;
            int popupBottom = screenBottom - this.Height - Properties.Settings.Default.appListMarginBottom;

            this.Location = new Point(popupRight, popupBottom);
        }

        // 窗口显示时
        private void AppListForm_VisibleChanged(object sender, EventArgs e) {
            if (Properties.Settings.Default.enableSearch) {
                searchTimer.Interval = Properties.Settings.Default.searchDelay;
                searchApp.TextChanged -= SearchApp_TextChanged;
                searchApp.Clear();
                searchApp.TextChanged += SearchApp_TextChanged;
                searchApp.Visible = true;
                searchApp.Focus();
            }
            else {
                searchApp.Visible = false;
            }
        }

        // 读取应用列表
        private void LoadAppList() {
            UpdateUI();
        }

        private void AppControl_OnDelete(object sender, EventArgs e) {
            AppControl appControl = (AppControl)sender;
            appManager.RemoteByExePath(appControl.GetAppInfo().ExePath);
            appManager.SaveAppList();
        }

        private void AppControl_OnLaunch(object sender, EventArgs e) {
            AppControl appControl = (AppControl)sender;

            // 实时调整位置，或依赖下次启动时调整位置
            //var appList = appManager.LoadAppList();
            //var lastIndex = appList.FindLastIndex(app => app.LaunchCount > appControl.GetAppInfo().LaunchCount);
            //appLayoutPanel.Controls.SetChildIndex(appControl, lastIndex+1);

            appManager.IncreaseLaunchCount(appControl.GetAppInfo().ExePath);
            appManager.SaveAppList();

            this.Close();
        }

        private void AppControl_OnEdit(object sender, EventArgs e) {
            AppControl appControl = (AppControl)sender;
            AppInfo appInfo = appControl.GetAppInfo();
            appManager.Edit(appInfo.ExePath, appInfo);
            appManager.SaveAppList();
        }

        private void AppControl_OnPinTop(object sender, EventArgs e) {
            AppControl appControl = (AppControl)sender;
            appLayoutPanel.Controls.SetChildIndex(appControl, 0);
            appManager.PinTop(appControl.GetAppInfo().ExePath);
            appManager.SaveAppList();
        }

        // 关闭窗口
        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        // 选择应用
        private void SelectApp_FileOk(object sender, CancelEventArgs e) {
            if (selectApp.FileName == null || selectApp.FileName == "") {
                return;
            }

            string name = Path.GetFileNameWithoutExtension(selectApp.FileName);
            AppInfo app = appManager.AddApp(name, selectApp.FileName, selectApp.FileName);
            if (app != null) {
                appManager.SaveAppList();
                UpdateUI();
            }
        }

        // 添加应用
        private void AddBtn_Click(object sender, EventArgs e) {
            selectApp.Filter = "应用程序(*.exe)|*.exe";
            selectApp.ShowDialog();
        }

        // 更新App列表
        private void UpdateUI(List<AppInfo> apps = null) {
            appLayoutPanel.Controls.Clear();

            if (apps == null || apps.Count == 0) {
                apps = appManager.LoadAppList();
            }

            foreach (var app in apps) {
                if (app.Deleted || !File.Exists(app.ExePath)) {
                    continue;
                }
                AppControl appControl = new AppControl(app);
                appControl.OnLaunch += AppControl_OnLaunch;
                appControl.OnEdit += AppControl_OnEdit;
                appControl.OnDelete += AppControl_OnDelete;
                appControl.OnPinTop += AppControl_OnPinTop;
                appControl.OnReset += AppControl_OnReset;
                appLayoutPanel.Controls.Add(appControl);
            }
        }

        private void AppControl_OnReset(object sender, EventArgs e) {
            AppControl appControl = (AppControl)sender;
            appLayoutPanel.Controls.SetChildIndex(appControl, -1);
            appManager.UnPinTop(appControl.GetAppInfo().ExePath);
            appManager.SaveAppList();
        }

        // 搜索输入
        private void SearchApp_TextChanged(object sender, EventArgs e) {
            Console.WriteLine(searchApp.Text);
            searchTimer.Stop();
            searchTimer.Start();
        }

        // 搜索定时器
        private void SearchTimer_Tick(object sender, EventArgs e) {
            Console.WriteLine("search");
            searchTimer.Stop();
            SearchApp_Perform();
        }

        // 执行搜索
        private void SearchApp_Perform() {
            if (!Properties.Settings.Default.enableSearch) {
                return;
            }

            var keywords = searchApp.Text.Replace("\r\n", "");
            List<AppInfo> apps = new List<AppInfo>();
            foreach (AppInfo appInfo in appManager.LoadAppList()) {
                if (appInfo.Pinyin.IndexOf(keywords, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    appInfo.Name.IndexOf(keywords, StringComparison.OrdinalIgnoreCase) >= 0) {
                    apps.Add(appInfo);
                }
            }

            Console.WriteLine(keywords);
            Console.WriteLine(apps.Count);
            UpdateUI(apps);
        }

        // 搜索后回车键打开第一个
        private void SearchApp_KeyDown(object sender, KeyEventArgs e) {
            if (!Properties.Settings.Default.searchOpenFirst) {
                return;
            }

            if (e.KeyCode == Keys.Enter && searchApp.Text != "") {
                AppControl appControl = (AppControl)appLayoutPanel.Controls[0];

                try {
                    AppControl_OnLaunch(appControl, e);
                    Process.Start(appControl.GetAppInfo().ExePath, appControl.GetAppInfo().Args);
                }
                catch (Exception ex) {
                    MessageBox.Show($"无法打开应用：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AppListForm_Deactivate(object sender, EventArgs e) {
            this.Close();
            GC.Collect();
        }

        private void timer1_Tick(object sender, EventArgs e) {

        }
    }
}
