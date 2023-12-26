namespace WinLauncher.Forms {
    partial class AppListForm {
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
            this.appLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchApp = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.appListFormTitle = new System.Windows.Forms.Label();
            this.selectApp = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // appLayoutPanel
            // 
            this.appLayoutPanel.AutoScroll = true;
            this.appLayoutPanel.Location = new System.Drawing.Point(9, 40);
            this.appLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.appLayoutPanel.Name = "appLayoutPanel";
            this.appLayoutPanel.Size = new System.Drawing.Size(715, 400);
            this.appLayoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.searchApp);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.appListFormTitle);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.panel1.Size = new System.Drawing.Size(670, 32);
            this.panel1.TabIndex = 1;
            // 
            // searchApp
            // 
            this.searchApp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchApp.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchApp.Location = new System.Drawing.Point(396, 8);
            this.searchApp.MaxLength = 30;
            this.searchApp.Name = "searchApp";
            this.searchApp.Size = new System.Drawing.Size(100, 14);
            this.searchApp.TabIndex = 3;
            this.searchApp.WordWrap = false;
            this.searchApp.TextChanged += new System.EventHandler(this.SearchApp_TextChanged);
            this.searchApp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchApp_KeyDown);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(583, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "关闭";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(502, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "添加";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // appListFormTitle
            // 
            this.appListFormTitle.Location = new System.Drawing.Point(9, 0);
            this.appListFormTitle.Margin = new System.Windows.Forms.Padding(0);
            this.appListFormTitle.Name = "appListFormTitle";
            this.appListFormTitle.Size = new System.Drawing.Size(60, 32);
            this.appListFormTitle.TabIndex = 0;
            this.appListFormTitle.Text = "应用列表";
            this.appListFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectApp
            // 
            this.selectApp.FileName = "appLocation";
            this.selectApp.FileOk += new System.ComponentModel.CancelEventHandler(this.SelectApp_FileOk);
            // 
            // AppListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.appLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppListForm";
            this.ShowInTaskbar = false;
            this.Text = "应用列表";
            this.Load += new System.EventHandler(this.ApplicationListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel appLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label appListFormTitle;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.OpenFileDialog selectApp;
        private System.Windows.Forms.TextBox searchApp;
    }
}