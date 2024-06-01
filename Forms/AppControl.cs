using WinLauncher.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;

namespace WinLauncher {
    public partial class AppControl : UserControl {
        private readonly AppInfo appInfo;
        private readonly ToolTip toolTip;

        public event EventHandler<EventArgs> OnDelete;
        public event EventHandler<EventArgs> OnLaunch;
        public event EventHandler<EventArgs> OnPinTop;
        public event EventHandler<EventArgs> OnReset;
        public event EventHandler<EventArgs> OnEdit;

        // 导入user32.dll库，用于检测Ctrl键的状态
        [DllImport("user32.dll")]
        private static extern short GetKeyState(Keys key);

        public AppControl(AppInfo appInfo) {
            InitializeComponent();

            this.appInfo = appInfo;
            if (!string.IsNullOrEmpty(appInfo.IconPath) && System.IO.File.Exists(appInfo.IconPath)) {
                appIcon.Image = Icon.ExtractAssociatedIcon(appInfo.IconPath).ToBitmap();
            }
            appName.Text = appInfo.Name;

            toolTip = new ToolTip();
        }

        private void AppControl_Load(object sender, EventArgs e) {
            // todo 
        }

        public AppInfo GetAppInfo() {
            return this.appInfo;
        }

        // 打开应用
        private void OpenApp(object sender, MouseEventArgs e) {
            bool ctrlKeyDown = (GetKeyState(Keys.ControlKey) & 0x8000) != 0;
            if (e.Button == MouseButtons.Left) {
                if (ctrlKeyDown) {
                    System.Diagnostics.Process.Start("explorer.exe", $"/select,{this.appInfo.ExePath}");
                }
                else {
                    try {
                        OnLaunch?.Invoke(this, e);
                        ProcessStartInfo info = new ProcessStartInfo(this.appInfo.ExePath, this.appInfo.Args);
                        info.WorkingDirectory = Path.GetDirectoryName(this.appInfo.ExePath);

                        Process process = new Process();
                        process.StartInfo = info;
                        process.Start();
                    }
                    catch (Exception ex) {
                        MessageBox.Show($"无法打开应用：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // 修改名称
        private void EditNameToolStripMenuItem_Click(object sender, EventArgs e) {
            TextBox textBox = new TextBox {
                Text = this.appInfo.Name,
                Location = appName.Location,
                Size = appName.Size
            };

            Controls.Remove(appName);
            Controls.Add(textBox);

            textBox.KeyDown += NameEdit_KeyDown;
            textBox.KeyDown += NameEdit_EscDown;
            textBox.Focus();
        }

        // 取消修改名称
        private void NameEdit_EscDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                TextBox textBox = (TextBox)sender;
                Controls.Remove(textBox);
                Controls.Add(appName);
                appName.Text = this.appInfo.Name;
            }
        }

        // 修改名称回车键
        private void NameEdit_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                TextBox textBox = (TextBox)sender;
                this.appInfo.Name = textBox.Text;
                Controls.Remove(textBox);
                Controls.Add(appName);
                appName.Text = this.appInfo.Name;
                OnEdit?.Invoke(this, e);
            }
        }

        // 修改图标
        private void EditIconToolStripMenuItem_Click(object sender, EventArgs e) {
            // todo 
        }
        
        // 删除应用
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Dispose();
            OnDelete?.Invoke(this, e);
        }

        // 置顶应用
        private void PinTopToolStripMenuItem_Click(object sender, EventArgs e) {
            OnPinTop?.Invoke(this, e);
        }

        private void ResetToolStripMenuItem_Click(object sender, EventArgs e) {
            OnReset?.Invoke(this, e);
        }

        // 修改启动命令
        private void EditExePathToolStripMenuItem_Click(object sender, EventArgs e) {
            TextBox textBox = new TextBox {
                Text = this.appInfo.ExePath,
                Location = appName.Location,
                Size = appName.Size
            };

            Controls.Remove(appName);
            Controls.Add(textBox);

            textBox.KeyDown += ExePathEdit_KeyDown;
            textBox.KeyDown += ExePathEdit_EscDown;
            textBox.Focus();
        }

        // 取消修改启动命令
        private void ExePathEdit_EscDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                TextBox textBox = (TextBox)sender;
                Controls.Remove(textBox);
                Controls.Add(appName);
                appName.Text = this.appInfo.Name;
            }
        }

        // 修改启动命令回车键
        private void ExePathEdit_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                // todo
            }
        }

        // 鼠标放图标上
        private void AppIcon_MouseHover(object sender, EventArgs e) {
            var text = string.Format("启动次数：{2}\n路径：{0} {1}\n", this.appInfo.ExePath, this.appInfo.Args, this.appInfo.LaunchCount);
            toolTip.Show(text, appName);
        }

        // 鼠标离开
        private void AppIcon_MouseLeave(object sender, EventArgs e) {
            toolTip.Hide(appName);
        }
    }
}
