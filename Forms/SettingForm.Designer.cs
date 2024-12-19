namespace WinLauncher.Forms {
    partial class SettingForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.AppsFloder = new System.Windows.Forms.TextBox();
            this.DelFloderBtn = new System.Windows.Forms.Button();
            this.AddFloderBtn = new System.Windows.Forms.Button();
            this.AppsFloderList = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.appIconSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.searchDelay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.enableSearch = new System.Windows.Forms.CheckBox();
            this.searchOpenFirst = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.appListMarginBottom = new System.Windows.Forms.NumericUpDown();
            this.appListLocationYLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.appListMarginRight = new System.Windows.Forms.NumericUpDown();
            this.appListLocationXLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.autoStart = new System.Windows.Forms.CheckBox();
            this.autoAddDesktopLnk = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.submitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.AppsFloderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDelay)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appListMarginBottom)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appListMarginRight)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(613, 322);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Controls.Add(this.AppsFloder);
            this.tabPage5.Controls.Add(this.DelFloderBtn);
            this.tabPage5.Controls.Add(this.AddFloderBtn);
            this.tabPage5.Controls.Add(this.AppsFloderList);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(605, 293);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "目录监听";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(345, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "浏览";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SelectFloder);
            // 
            // AppsFloder
            // 
            this.AppsFloder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AppsFloder.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AppsFloder.Location = new System.Drawing.Point(6, 250);
            this.AppsFloder.Name = "AppsFloder";
            this.AppsFloder.Size = new System.Drawing.Size(321, 25);
            this.AppsFloder.TabIndex = 1;
            this.AppsFloder.WordWrap = false;
            // 
            // DelFloderBtn
            // 
            this.DelFloderBtn.Enabled = false;
            this.DelFloderBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.DelFloderBtn.Location = new System.Drawing.Point(509, 245);
            this.DelFloderBtn.Name = "DelFloderBtn";
            this.DelFloderBtn.Size = new System.Drawing.Size(75, 36);
            this.DelFloderBtn.TabIndex = 2;
            this.DelFloderBtn.Text = "删除";
            this.DelFloderBtn.UseVisualStyleBackColor = true;
            this.DelFloderBtn.Click += new System.EventHandler(this.DelFloderBtn_Click);
            // 
            // AddFloderBtn
            // 
            this.AddFloderBtn.Enabled = false;
            this.AddFloderBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.AddFloderBtn.Location = new System.Drawing.Point(426, 245);
            this.AddFloderBtn.Name = "AddFloderBtn";
            this.AddFloderBtn.Size = new System.Drawing.Size(75, 36);
            this.AddFloderBtn.TabIndex = 1;
            this.AddFloderBtn.Text = "添加";
            this.AddFloderBtn.UseVisualStyleBackColor = true;
            this.AddFloderBtn.Click += new System.EventHandler(this.AddFloderBtn_Click);
            // 
            // AppsFloderList
            // 
            this.AppsFloderList.FormattingEnabled = true;
            this.AppsFloderList.ItemHeight = 15;
            this.AppsFloderList.Location = new System.Drawing.Point(6, 0);
            this.AppsFloderList.Name = "AppsFloderList";
            this.AppsFloderList.Size = new System.Drawing.Size(593, 229);
            this.AppsFloderList.TabIndex = 0;
            this.AppsFloderList.SelectedValueChanged += new System.EventHandler(this.AppsFloderList_SelectedValueChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.appIconSize);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(605, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图标设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // appIconSize
            // 
            this.appIconSize.FormattingEnabled = true;
            this.appIconSize.Items.AddRange(new object[] {
            "32x32",
            "48x48",
            "64x64"});
            this.appIconSize.Location = new System.Drawing.Point(119, 28);
            this.appIconSize.Margin = new System.Windows.Forms.Padding(4);
            this.appIconSize.Name = "appIconSize";
            this.appIconSize.Size = new System.Drawing.Size(160, 23);
            this.appIconSize.TabIndex = 1;
            this.appIconSize.SelectedIndexChanged += new System.EventHandler(this.AppIconSize_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "图标大小";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.searchDelay);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.enableSearch);
            this.tabPage2.Controls.Add(this.searchOpenFirst);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(605, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "界面设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // searchDelay
            // 
            this.searchDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.searchDelay.Location = new System.Drawing.Point(237, 169);
            this.searchDelay.Margin = new System.Windows.Forms.Padding(4);
            this.searchDelay.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.searchDelay.Name = "searchDelay";
            this.searchDelay.Size = new System.Drawing.Size(160, 25);
            this.searchDelay.TabIndex = 6;
            this.searchDelay.ValueChanged += new System.EventHandler(this.SearchDelay_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "搜索执行延迟(毫秒)";
            // 
            // enableSearch
            // 
            this.enableSearch.AutoSize = true;
            this.enableSearch.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enableSearch.Location = new System.Drawing.Point(95, 134);
            this.enableSearch.Margin = new System.Windows.Forms.Padding(4);
            this.enableSearch.Name = "enableSearch";
            this.enableSearch.Size = new System.Drawing.Size(149, 19);
            this.enableSearch.TabIndex = 4;
            this.enableSearch.Text = "开启实时搜索功能";
            this.enableSearch.UseVisualStyleBackColor = true;
            this.enableSearch.CheckedChanged += new System.EventHandler(this.EnableSearch_CheckedChanged);
            // 
            // searchOpenFirst
            // 
            this.searchOpenFirst.AutoSize = true;
            this.searchOpenFirst.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchOpenFirst.Enabled = false;
            this.searchOpenFirst.Location = new System.Drawing.Point(79, 204);
            this.searchOpenFirst.Margin = new System.Windows.Forms.Padding(4);
            this.searchOpenFirst.Name = "searchOpenFirst";
            this.searchOpenFirst.Size = new System.Drawing.Size(164, 19);
            this.searchOpenFirst.TabIndex = 3;
            this.searchOpenFirst.Text = "搜索后回车打开首个";
            this.searchOpenFirst.UseVisualStyleBackColor = true;
            this.searchOpenFirst.CheckedChanged += new System.EventHandler(this.SearchOpenFirst_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.appListMarginBottom);
            this.panel2.Controls.Add(this.appListLocationYLabel);
            this.panel2.Location = new System.Drawing.Point(40, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 38);
            this.panel2.TabIndex = 2;
            // 
            // appListMarginBottom
            // 
            this.appListMarginBottom.Location = new System.Drawing.Point(200, 6);
            this.appListMarginBottom.Margin = new System.Windows.Forms.Padding(4);
            this.appListMarginBottom.Name = "appListMarginBottom";
            this.appListMarginBottom.Size = new System.Drawing.Size(160, 25);
            this.appListMarginBottom.TabIndex = 1;
            this.appListMarginBottom.ValueChanged += new System.EventHandler(this.AppListMarginBottom_ValueChanged);
            // 
            // appListLocationYLabel
            // 
            this.appListLocationYLabel.Location = new System.Drawing.Point(7, 6);
            this.appListLocationYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appListLocationYLabel.Name = "appListLocationYLabel";
            this.appListLocationYLabel.Size = new System.Drawing.Size(187, 26);
            this.appListLocationYLabel.TabIndex = 0;
            this.appListLocationYLabel.Text = "窗口位置与屏幕下边距离";
            this.appListLocationYLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.appListMarginRight);
            this.panel1.Controls.Add(this.appListLocationXLabel);
            this.panel1.Location = new System.Drawing.Point(40, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 38);
            this.panel1.TabIndex = 0;
            // 
            // appListMarginRight
            // 
            this.appListMarginRight.Location = new System.Drawing.Point(201, 6);
            this.appListMarginRight.Margin = new System.Windows.Forms.Padding(4);
            this.appListMarginRight.Name = "appListMarginRight";
            this.appListMarginRight.Size = new System.Drawing.Size(160, 25);
            this.appListMarginRight.TabIndex = 1;
            this.appListMarginRight.ValueChanged += new System.EventHandler(this.AppListMarginRight_ValueChanged);
            // 
            // appListLocationXLabel
            // 
            this.appListLocationXLabel.Location = new System.Drawing.Point(7, 6);
            this.appListLocationXLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appListLocationXLabel.Name = "appListLocationXLabel";
            this.appListLocationXLabel.Size = new System.Drawing.Size(187, 26);
            this.appListLocationXLabel.TabIndex = 0;
            this.appListLocationXLabel.Text = "窗口位置与屏幕右边距离";
            this.appListLocationXLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.autoStart);
            this.tabPage3.Controls.Add(this.autoAddDesktopLnk);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(605, 293);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "其他设置";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // autoStart
            // 
            this.autoStart.AutoSize = true;
            this.autoStart.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoStart.Location = new System.Drawing.Point(136, 59);
            this.autoStart.Margin = new System.Windows.Forms.Padding(4);
            this.autoStart.Name = "autoStart";
            this.autoStart.Size = new System.Drawing.Size(89, 19);
            this.autoStart.TabIndex = 1;
            this.autoStart.Text = "开机启动";
            this.autoStart.UseVisualStyleBackColor = true;
            this.autoStart.CheckedChanged += new System.EventHandler(this.AutoStart_CheckedChanged);
            // 
            // autoAddDesktopLnk
            // 
            this.autoAddDesktopLnk.AutoSize = true;
            this.autoAddDesktopLnk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.autoAddDesktopLnk.Location = new System.Drawing.Point(40, 31);
            this.autoAddDesktopLnk.Margin = new System.Windows.Forms.Padding(4);
            this.autoAddDesktopLnk.Name = "autoAddDesktopLnk";
            this.autoAddDesktopLnk.Size = new System.Drawing.Size(179, 19);
            this.autoAddDesktopLnk.TabIndex = 0;
            this.autoAddDesktopLnk.Text = "自动添加桌面快捷方式";
            this.autoAddDesktopLnk.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(605, 293);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "信息";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(421, 345);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(100, 29);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "确定";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(529, 345);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 29);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AppsFloderDialog
            // 
            this.AppsFloderDialog.ShowNewFolderButton = false;
            this.AppsFloderDialog.HelpRequest += new System.EventHandler(this.AppsFloderDialog_HelpRequest);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 389);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingForm";
            this.Text = "设置";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDelay)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appListMarginBottom)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appListMarginRight)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label appListLocationXLabel;
        private System.Windows.Forms.NumericUpDown appListMarginRight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown appListMarginBottom;
        private System.Windows.Forms.Label appListLocationYLabel;
        private System.Windows.Forms.ComboBox appIconSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox autoAddDesktopLnk;
        private System.Windows.Forms.CheckBox autoStart;
        private System.Windows.Forms.CheckBox searchOpenFirst;
        private System.Windows.Forms.CheckBox enableSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown searchDelay;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListBox AppsFloderList;
        private System.Windows.Forms.Button DelFloderBtn;
        private System.Windows.Forms.Button AddFloderBtn;
        private System.Windows.Forms.FolderBrowserDialog AppsFloderDialog;
        private System.Windows.Forms.TextBox AppsFloder;
        private System.Windows.Forms.Button button3;
    }
}