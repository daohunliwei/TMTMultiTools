using DevComponents.DotNetBar;
using System.Windows.Forms;

namespace TMTMultiTools
{
    partial class Launcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.bt_autoupdate = new DevComponents.DotNetBar.ButtonX();
            this.imageList_main = new System.Windows.Forms.ImageList(this.components);
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.sbt_weibo = new DevComponents.DotNetBar.ButtonX();
            this.bt_weixin = new DevComponents.DotNetBar.ButtonX();
            this.cb_themes = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.SuspendLayout();
            // 
            // bt_autoupdate
            // 
            this.bt_autoupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_autoupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.bt_autoupdate.Location = new System.Drawing.Point(855, 12);
            this.bt_autoupdate.Name = "bt_autoupdate";
            this.bt_autoupdate.Size = new System.Drawing.Size(75, 23);
            this.bt_autoupdate.TabIndex = 0;
            this.bt_autoupdate.Text = "检查更新";
            this.bt_autoupdate.Click += new System.EventHandler(this.bt_autoupdate_Click);
            // 
            // imageList_main
            // 
            this.imageList_main.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_main.ImageStream")));
            this.imageList_main.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_main.Images.SetKeyName(0, "alipay.ico");
            this.imageList_main.Images.SetKeyName(1, "douban.ico");
            this.imageList_main.Images.SetKeyName(2, "logo.ico");
            this.imageList_main.Images.SetKeyName(3, "qq.ico");
            this.imageList_main.Images.SetKeyName(4, "qzone.ico");
            this.imageList_main.Images.SetKeyName(5, "renren.ico");
            this.imageList_main.Images.SetKeyName(6, "sina_weibo.ico");
            this.imageList_main.Images.SetKeyName(7, "snapchat.ico");
            this.imageList_main.Images.SetKeyName(8, "taobao.ico");
            this.imageList_main.Images.SetKeyName(9, "tencent_weibo.ico");
            this.imageList_main.Images.SetKeyName(10, "tumblr.ico");
            this.imageList_main.Images.SetKeyName(11, "twitter.ico");
            this.imageList_main.Images.SetKeyName(12, "vine.ico");
            this.imageList_main.Images.SetKeyName(13, "wechat.ico");
            this.imageList_main.Images.SetKeyName(14, "whatsapp.ico");
            this.imageList_main.Images.SetKeyName(15, "youdao.ico");
            this.imageList_main.Images.SetKeyName(16, "youku.ico");
            this.imageList_main.Images.SetKeyName(17, "zhihu.ico");
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))));
            // 
            // sbt_weibo
            // 
            this.sbt_weibo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.sbt_weibo.BackColor = System.Drawing.Color.Transparent;
            this.sbt_weibo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sbt_weibo.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.sbt_weibo.Image = global::TMTMultiTools.Properties.Resources.sina_weibo;
            this.sbt_weibo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.sbt_weibo.Location = new System.Drawing.Point(264, 170);
            this.sbt_weibo.Name = "sbt_weibo";
            this.sbt_weibo.Size = new System.Drawing.Size(120, 120);
            this.sbt_weibo.TabIndex = 5;
            this.sbt_weibo.Click += new System.EventHandler(this.sbt_weibo_Click);
            // 
            // bt_weixin
            // 
            this.bt_weixin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_weixin.BackColor = System.Drawing.Color.Transparent;
            this.bt_weixin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_weixin.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.bt_weixin.Image = global::TMTMultiTools.Properties.Resources.sina_weibo;
            this.bt_weixin.ImagePosition = DevComponents.DotNetBar.eImagePosition.Bottom;
            this.bt_weixin.Location = new System.Drawing.Point(538, 170);
            this.bt_weixin.Name = "bt_weixin";
            this.bt_weixin.Size = new System.Drawing.Size(120, 120);
            this.bt_weixin.TabIndex = 6;
            this.bt_weixin.Click += new System.EventHandler(this.sbt_weixin_Click);
            // 
            // cb_themes
            // 
            this.cb_themes.DisplayMember = "Text";
            this.cb_themes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_themes.ForeColor = System.Drawing.Color.White;
            this.cb_themes.FormattingEnabled = true;
            this.cb_themes.ItemHeight = 15;
            this.cb_themes.Location = new System.Drawing.Point(657, 14);
            this.cb_themes.Name = "cb_themes";
            this.cb_themes.Size = new System.Drawing.Size(153, 21);
            this.cb_themes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_themes.TabIndex = 7;
            this.cb_themes.SelectionChangeCommitted += new System.EventHandler(this.cb_themes_SelectionChangeCommitted);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 503);
            this.Controls.Add(this.cb_themes);
            this.Controls.Add(this.bt_weixin);
            this.Controls.Add(this.sbt_weibo);
            this.Controls.Add(this.bt_autoupdate);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.Text = "Launcher";
            this.TitleText = "启动入口";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonX bt_autoupdate;
        private ImageList imageList_main;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private ButtonX sbt_weibo;
        private ButtonX bt_weixin;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_themes;
    }
}