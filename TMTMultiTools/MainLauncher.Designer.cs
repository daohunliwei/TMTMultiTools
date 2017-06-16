﻿namespace TMTMultiTools
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
            this.SuspendLayout();
            // 
            // cb_themes
            // 
            this.cb_themes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_themes.DisplayMember = "Text";
            this.cb_themes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
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
            // MainLauncher
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(616, 357);
            this.Controls.Add(this.bt_weibo);
            this.Controls.Add(this.cb_themes);
            this.DoubleBuffered = true;
            this.Name = "MainLauncher";
            this.Text = "入口";
            this.Load += new System.EventHandler(this.MainLauncher_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_themes;
        private DevComponents.DotNetBar.ButtonX bt_weibo;
    }
}