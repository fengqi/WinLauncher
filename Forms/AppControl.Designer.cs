namespace WinLauncher {
    partial class AppControl {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.appIcon = new System.Windows.Forms.PictureBox();
            this.appName = new System.Windows.Forms.Label();
            this.appMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pinTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editExePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).BeginInit();
            this.appMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // appIcon
            // 
            this.appIcon.Location = new System.Drawing.Point(2, 2);
            this.appIcon.Margin = new System.Windows.Forms.Padding(0);
            this.appIcon.Name = "appIcon";
            this.appIcon.Padding = new System.Windows.Forms.Padding(2);
            this.appIcon.Size = new System.Drawing.Size(88, 88);
            this.appIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.appIcon.TabIndex = 0;
            this.appIcon.TabStop = false;
            this.appIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OpenApp);
            this.appIcon.MouseLeave += new System.EventHandler(this.AppIcon_MouseLeave);
            this.appIcon.MouseHover += new System.EventHandler(this.AppIcon_MouseHover);
            // 
            // appName
            // 
            this.appName.Location = new System.Drawing.Point(2, 90);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(88, 32);
            this.appName.TabIndex = 1;
            this.appName.Text = "appName";
            this.appName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.appName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OpenApp);
            // 
            // appMenuStrip
            // 
            this.appMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pinTopToolStripMenuItem,
            this.resetOrderToolStripMenuItem,
            this.editNameToolStripMenuItem,
            this.editIconToolStripMenuItem,
            this.editExePathToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.appMenuStrip.Name = "appMenuStrip";
            this.appMenuStrip.Size = new System.Drawing.Size(149, 136);
            // 
            // pinTopToolStripMenuItem
            // 
            this.pinTopToolStripMenuItem.Name = "pinTopToolStripMenuItem";
            this.pinTopToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.pinTopToolStripMenuItem.Text = "置顶";
            this.pinTopToolStripMenuItem.ToolTipText = "移到第一位";
            this.pinTopToolStripMenuItem.Click += new System.EventHandler(this.PinTopToolStripMenuItem_Click);
            // 
            // resetOrderToolStripMenuItem
            // 
            this.resetOrderToolStripMenuItem.Name = "resetOrderToolStripMenuItem";
            this.resetOrderToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.resetOrderToolStripMenuItem.Text = "重置位置";
            this.resetOrderToolStripMenuItem.Click += new System.EventHandler(this.ResetToolStripMenuItem_Click);
            // 
            // editNameToolStripMenuItem
            // 
            this.editNameToolStripMenuItem.Name = "editNameToolStripMenuItem";
            this.editNameToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.editNameToolStripMenuItem.Text = "修改名称";
            this.editNameToolStripMenuItem.Click += new System.EventHandler(this.EditNameToolStripMenuItem_Click);
            // 
            // editIconToolStripMenuItem
            // 
            this.editIconToolStripMenuItem.Name = "editIconToolStripMenuItem";
            this.editIconToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.editIconToolStripMenuItem.Text = "修改图标";
            this.editIconToolStripMenuItem.Visible = false;
            this.editIconToolStripMenuItem.Click += new System.EventHandler(this.EditIconToolStripMenuItem_Click);
            // 
            // editExePathToolStripMenuItem
            // 
            this.editExePathToolStripMenuItem.Name = "editExePathToolStripMenuItem";
            this.editExePathToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.editExePathToolStripMenuItem.Text = "修改启动命令";
            this.editExePathToolStripMenuItem.ToolTipText = "修改启动命令或者添加自定义参数";
            this.editExePathToolStripMenuItem.Visible = false;
            this.editExePathToolStripMenuItem.Click += new System.EventHandler(this.EditExePathToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.deleteToolStripMenuItem.Text = "删除";
            this.deleteToolStripMenuItem.ToolTipText = "删除应用";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // AppControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CausesValidation = false;
            this.ContextMenuStrip = this.appMenuStrip;
            this.Controls.Add(this.appName);
            this.Controls.Add(this.appIcon);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AppControl";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(92, 130);
            this.Load += new System.EventHandler(this.AppControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).EndInit();
            this.appMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox appIcon;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.ContextMenuStrip appMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editExePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetOrderToolStripMenuItem;
    }
}
