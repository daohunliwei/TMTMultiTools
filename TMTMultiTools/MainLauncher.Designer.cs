namespace TMTMultiTools
{
    partial class MainLauncher
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_themes = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.bt_weibo = new DevComponents.DotNetBar.ButtonX();
            this.bt_autoupdate = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // cb_themes
            // 
            this.cb_themes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_themes.DisplayMember = "Text";
            this.cb_themes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_themes.ForeColor = System.Drawing.Color.Black;
            this.cb_themes.FormattingEnabled = true;
            this.cb_themes.ItemHeight = 15;
            this.cb_themes.Location = new System.Drawing.Point(463, 12);
            this.cb_themes.Name = "cb_themes";
            this.cb_themes.Size = new System.Drawing.Size(141, 21);
            this.cb_themes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_themes.TabIndex = 2;
            this.cb_themes.SelectionChangeCommitted += new System.EventHandler(this.cb_themes_SelectionChangeCommitted);
            // 
            // bt_weibo
            // 
            this.bt_weibo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_weibo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_weibo.Image = global::TMTMultiTools.Properties.Resources.sina_weibo;
            this.bt_weibo.Location = new System.Drawing.Point(250, 105);
            this.bt_weibo.Name = "bt_weibo";
            this.bt_weibo.Size = new System.Drawing.Size(111, 107);
            this.bt_weibo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_weibo.TabIndex = 3;
            this.bt_weibo.Tooltip = "我是微博";
            this.bt_weibo.Click += new System.EventHandler(this.bt_weibo_Click);
            // 
            // bt_autoupdate
            // 
            this.bt_autoupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_autoupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bt_autoupdate.Enabled = false;
            this.bt_autoupdate.Location = new System.Drawing.Point(1, 107);
            this.bt_autoupdate.Name = "bt_autoupdate";
            this.bt_autoupdate.Size = new System.Drawing.Size(75, 23);
            this.bt_autoupdate.TabIndex = 4;
            this.bt_autoupdate.Text = "开始更新";
            this.bt_autoupdate.Click += new System.EventHandler(this.bt_autoupdate_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(1, 27);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(200, 34);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "当前版本号：";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(1, 67);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(200, 34);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "线上版本号：";
            // 
            // MainLauncher
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(616, 357);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.bt_autoupdate);
            this.Controls.Add(this.bt_weibo);
            this.Controls.Add(this.cb_themes);
            this.Name = "MainLauncher";
            this.Text = "入口";
            this.Load += new System.EventHandler(this.MainLauncher_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_themes;
        private DevComponents.DotNetBar.ButtonX bt_weibo;
        private DevComponents.DotNetBar.ButtonX bt_autoupdate;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}
