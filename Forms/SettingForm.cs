using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinLauncher.Forms {
    public partial class SettingForm : Form {
        public SettingForm() {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e) {
            SetLocation();
            appListMarginRight.Value = Properties.Settings.Default.appListMarginRight;
            appListMarginBottom.Value = Properties.Settings.Default.appListMarginBottom;
            autoStart.Checked = Properties.Settings.Default.autoStart;
            searchOpenFirst.Checked = Properties.Settings.Default.searchOpenFirst;
            enableSearch.Checked = Properties.Settings.Default.enableSearch;
            searchDelay.Value = Properties.Settings.Default.searchDelay;
            appIconSize.Text = Properties.Settings.Default.appIconSize;
        }

        // 居中显示
        private void SetLocation() {
            int x = Screen.PrimaryScreen.WorkingArea.Left;
            int y = Screen.PrimaryScreen.WorkingArea.Top;

            x += (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            y += (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;

            this.Location = new Point(x, y);
        }

        // 取消设置
        private void CancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        // 提交设置
        private void SubmitBtn_Click(object sender, EventArgs e) {
            Properties.Settings.Default.Save();

            // 设置开机自动启动
            string appName = Application.ProductName;
            string appPath = Application.ExecutablePath;
            if (Properties.Settings.Default.autoStart) {
                Services.AutoStart.SetAutoStart(appName, appPath);
            } else {
                Services.AutoStart.CancelAutoStart(appName);
            }

            this.Close();
        }

        // 应用列表下边距
        private void AppListMarginBottom_ValueChanged(object sender, EventArgs e) {
            Properties.Settings.Default.appListMarginBottom = (int)appListMarginBottom.Value;
        }

        // 应用列表右边距
        private void AppListMarginRight_ValueChanged(object sender, EventArgs e) {
            Properties.Settings.Default.appListMarginRight = (int)appListMarginRight.Value;
        }

        // 开机启动
        private void AutoStart_CheckedChanged(object sender, EventArgs e) {
            Properties.Settings.Default.autoStart = autoStart.Checked;
        }

        // 搜索后回车键打开第一个
        private void SearchOpenFirst_CheckedChanged(object sender, EventArgs e) {
            Properties.Settings.Default.searchOpenFirst = searchOpenFirst.Checked;
        }

        // 开启实时搜索
        private void EnableSearch_CheckedChanged(object sender, EventArgs e) {
            Properties.Settings.Default.enableSearch = enableSearch.Checked;
            searchOpenFirst.Enabled = enableSearch.Checked;
        }

        // 搜索延迟
        private void SearchDelay_ValueChanged(object sender, EventArgs e) {
            Properties.Settings.Default.searchDelay = (int)searchDelay.Value;
        }

        private void AppIconSize_SelectedIndexChanged(object sender, EventArgs e) {
            Properties.Settings.Default.appIconSize = appIconSize.Text;
        }
    }
}
