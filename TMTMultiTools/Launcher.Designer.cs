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
            this.bt_autoupdate = new System.Windows.Forms.Button();
            this.imageList_main = new System.Windows.Forms.ImageList(this.components);
            this.SkinToolTip = new ToolTip(this.components);
            this.sbt_weibo = new Button();
            this.sbt_weixin = new Button();
            this.SuspendLayout();
            // 
            // bt_autoupdate
            // 
            this.bt_autoupdate.Location = new System.Drawing.Point(851, 31);
            this.bt_autoupdate.Name = "bt_autoupdate";
            this.bt_autoupdate.Size = new System.Drawing.Size(75, 23);
            this.bt_autoupdate.TabIndex = 0;
            this.bt_autoupdate.Text = "检查更新";
            this.bt_autoupdate.UseVisualStyleBackColor = true;
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
            // SkinToolTip
            // 
            this.SkinToolTip.AutoPopDelay = 5000;
            this.SkinToolTip.InitialDelay = 500;
            this.SkinToolTip.OwnerDraw = true;
            this.SkinToolTip.ReshowDelay = 800;
            // 
            // sbt_weibo
            // 
            this.sbt_weibo.BackColor = System.Drawing.Color.Transparent;
            this.sbt_weibo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sbt_weibo.ImageKey = "sina_weibo.ico";
            this.sbt_weibo.ImageList = this.imageList_main;
            this.sbt_weibo.Location = new System.Drawing.Point(286, 170);
            this.sbt_weibo.Name = "sbt_weibo";
            this.sbt_weibo.Size = new System.Drawing.Size(120, 120);
            this.sbt_weibo.TabIndex = 3;
            this.SkinToolTip.SetToolTip(this.sbt_weibo, "这个是微博");
            this.sbt_weibo.UseVisualStyleBackColor = false;
            this.sbt_weibo.Click += new System.EventHandler(this.sbt_weibo_Click);
            // 
            // sbt_weixin
            // 
            this.sbt_weixin.BackColor = System.Drawing.Color.Transparent;
            this.sbt_weixin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sbt_weixin.ImageKey = "wechat.ico";
            this.sbt_weixin.ImageList = this.imageList_main;
            this.sbt_weixin.Location = new System.Drawing.Point(537, 170);
            this.sbt_weixin.Name = "sbt_weixin";
            this.sbt_weixin.Size = new System.Drawing.Size(120, 120);
            this.sbt_weixin.TabIndex = 4;
            this.SkinToolTip.SetToolTip(this.sbt_weixin, "这个是微信");
            this.sbt_weixin.UseVisualStyleBackColor = false;
            this.sbt_weixin.Click += new System.EventHandler(this.sbt_weixin_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 503);
            this.Controls.Add(this.sbt_weixin);
            this.Controls.Add(this.sbt_weibo);
            this.Controls.Add(this.bt_autoupdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.Text = "Launcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_autoupdate;
        private System.Windows.Forms.ImageList imageList_main;
        private ToolTip SkinToolTip;
        private Button sbt_weibo;
        private Button sbt_weixin;
    }
}