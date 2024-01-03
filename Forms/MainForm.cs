using System;
using System.Windows.Forms;
using WinLauncher.Forms;
using WinLauncher.Services;

namespace WinLauncher {
    public partial class MainForm : Form {
        private AppListForm appListForm;
        private SettingForm settingForm;

        public MainForm() {
            InitializeComponent();
            CheckInit();
            trayIcon.Icon = Properties.Resources.app;
        }

        private void MainForm_Load(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Visible = false;
        }

        // 检查首次启动
        private static void CheckInit() {
            if (Properties.Settings.Default.Init) {
                return;
            }

            AppManager appManager = new AppManager();
            appManager.ScanApplications();
            appManager.SaveAppList();

            Properties.Settings.Default.Init = true;
            Properties.Settings.Default.Save();
        }

        // 处理托盘图标点击事件
        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                //AppListForm appListForm = new AppListForm();
                if (appListForm == null || appListForm.IsDisposed) {
                    appListForm = new AppListForm();
                }
                if (appListForm.Visible) {
                    appListForm.Close();
                }
                else {
                    appListForm.ShowDialog();
                }
            }
        }

        // 处理关于菜单项点击事件
        private void AboutMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("应用启动器\n版本：1.0\n作者：风起", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 处理设置菜单项点击事件
        private void SettingsMenuItem_Click(object sender, EventArgs e) {
            if (settingForm == null || settingForm.IsDisposed) {
                settingForm = new SettingForm();
            }
            if (settingForm.Visible) {
                settingForm.WindowState = FormWindowState.Normal;
                settingForm.Activate();
            }
            else {
                settingForm.ShowDialog();
                settingForm.Activate();
            }
        }

        // 处理退出菜单项点击事件
        private void ExitMenuItem_Click(object sender, EventArgs e) {
            this.Close();
            Application.Exit();
        }
    }
}
