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
            this.p_login = new DevComponents.DotNetBar.PanelEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.tbdrop_username = new DevComponents.DotNetBar.Controls.TextBoxDropDown();
            this.tb_password = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cb_showpwd = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.bt_login = new DevComponents.DotNetBar.ButtonX();
            this.p_info = new DevComponents.DotNetBar.PanelEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.tb_Nickname = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lb_registertime = new DevComponents.DotNetBar.LabelX();
            this.rtb_machineKey = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.p_login.SuspendLayout();
            this.p_info.SuspendLayout();
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
            this.cb_themes.Location = new System.Drawing.Point(727, 12);
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
            this.bt_weibo.Location = new System.Drawing.Point(353, 196);
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
            this.labelX1.ForeColor = System.Drawing.Color.Black;
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
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(1, 67);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(200, 34);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "线上版本号：";
            // 
            // p_login
            // 
            this.p_login.CanvasColor = System.Drawing.SystemColors.Control;
            this.p_login.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.p_login.Controls.Add(this.bt_login);
            this.p_login.Controls.Add(this.cb_showpwd);
            this.p_login.Controls.Add(this.tb_password);
            this.p_login.Controls.Add(this.tbdrop_username);
            this.p_login.Controls.Add(this.labelX4);
            this.p_login.Controls.Add(this.labelX3);
            this.p_login.DisabledBackColor = System.Drawing.Color.Empty;
            this.p_login.Location = new System.Drawing.Point(233, 27);
            this.p_login.Name = "p_login";
            this.p_login.Size = new System.Drawing.Size(347, 149);
            this.p_login.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.p_login.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.p_login.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.p_login.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.p_login.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.p_login.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.p_login.Style.GradientAngle = 90;
            this.p_login.TabIndex = 7;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(15, 17);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "用户名：";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(15, 55);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "密码：";
            // 
            // tbdrop_username
            // 
            this.tbdrop_username.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tbdrop_username.BackgroundStyle.Class = "TextBoxBorder";
            this.tbdrop_username.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbdrop_username.ButtonDropDown.Visible = true;
            this.tbdrop_username.ForeColor = System.Drawing.Color.Black;
            this.tbdrop_username.Location = new System.Drawing.Point(70, 17);
            this.tbdrop_username.Name = "tbdrop_username";
            this.tbdrop_username.Size = new System.Drawing.Size(265, 20);
            this.tbdrop_username.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tbdrop_username.TabIndex = 2;
            this.tbdrop_username.Text = "";
            this.tbdrop_username.WatermarkText = "请输入或选择用户名";
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_password.Border.Class = "TextBoxBorder";
            this.tb_password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_password.DisabledBackColor = System.Drawing.Color.White;
            this.tb_password.ForeColor = System.Drawing.Color.Black;
            this.tb_password.Location = new System.Drawing.Point(70, 55);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.PreventEnterBeep = true;
            this.tb_password.Size = new System.Drawing.Size(209, 21);
            this.tb_password.TabIndex = 3;
            this.tb_password.WatermarkText = "请输入密码";
            // 
            // cb_showpwd
            // 
            // 
            // 
            // 
            this.cb_showpwd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cb_showpwd.ForeColor = System.Drawing.Color.Black;
            this.cb_showpwd.Location = new System.Drawing.Point(285, 53);
            this.cb_showpwd.Name = "cb_showpwd";
            this.cb_showpwd.Size = new System.Drawing.Size(50, 23);
            this.cb_showpwd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_showpwd.TabIndex = 4;
            this.cb_showpwd.Text = "显示";
            this.cb_showpwd.CheckedChanged += new System.EventHandler(this.cb_showpwd_CheckedChanged);
            // 
            // bt_login
            // 
            this.bt_login.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_login.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_login.Location = new System.Drawing.Point(134, 94);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(75, 23);
            this.bt_login.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_login.TabIndex = 5;
            this.bt_login.Text = "登陆";
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // p_info
            // 
            this.p_info.CanvasColor = System.Drawing.SystemColors.Control;
            this.p_info.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.p_info.Controls.Add(this.rtb_machineKey);
            this.p_info.Controls.Add(this.lb_registertime);
            this.p_info.Controls.Add(this.tb_Nickname);
            this.p_info.Controls.Add(this.labelX10);
            this.p_info.Controls.Add(this.labelX9);
            this.p_info.Controls.Add(this.labelX5);
            this.p_info.DisabledBackColor = System.Drawing.Color.Empty;
            this.p_info.Location = new System.Drawing.Point(491, 279);
            this.p_info.Name = "p_info";
            this.p_info.Size = new System.Drawing.Size(347, 149);
            this.p_info.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.p_info.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.p_info.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.p_info.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.p_info.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.p_info.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.p_info.Style.GradientAngle = 90;
            this.p_info.TabIndex = 14;
            this.p_info.Visible = false;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(14, 19);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "昵称：";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.labelX9.Location = new System.Drawing.Point(14, 77);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 5;
            this.labelX9.Text = "机器指纹：";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.ForeColor = System.Drawing.Color.Black;
            this.labelX10.Location = new System.Drawing.Point(14, 48);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 23);
            this.labelX10.TabIndex = 6;
            this.labelX10.Text = "注册时间：";
            // 
            // tb_Nickname
            // 
            this.tb_Nickname.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_Nickname.Border.Class = "TextBoxBorder";
            this.tb_Nickname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_Nickname.DisabledBackColor = System.Drawing.Color.White;
            this.tb_Nickname.ForeColor = System.Drawing.Color.Black;
            this.tb_Nickname.Location = new System.Drawing.Point(85, 19);
            this.tb_Nickname.Name = "tb_Nickname";
            this.tb_Nickname.PreventEnterBeep = true;
            this.tb_Nickname.ReadOnly = true;
            this.tb_Nickname.Size = new System.Drawing.Size(252, 21);
            this.tb_Nickname.TabIndex = 7;
            // 
            // lb_registertime
            // 
            // 
            // 
            // 
            this.lb_registertime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_registertime.ForeColor = System.Drawing.Color.Black;
            this.lb_registertime.Location = new System.Drawing.Point(85, 48);
            this.lb_registertime.Name = "lb_registertime";
            this.lb_registertime.Size = new System.Drawing.Size(252, 23);
            this.lb_registertime.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lb_registertime.TabIndex = 8;
            // 
            // rtb_machineKey
            // 
            // 
            // 
            // 
            this.rtb_machineKey.BackgroundStyle.Class = "RichTextBoxBorder";
            this.rtb_machineKey.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rtb_machineKey.Location = new System.Drawing.Point(85, 77);
            this.rtb_machineKey.Name = "rtb_machineKey";
            this.rtb_machineKey.ReadOnly = true;
            this.rtb_machineKey.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset" +
    "134 \\\'cb\\\'ce\\\'cc\\\'e5;}}\r\n\\viewkind4\\uc1\\pard\\lang2052\\f0\\fs18\\par\r\n}\r\n";
            this.rtb_machineKey.Size = new System.Drawing.Size(252, 57);
            this.rtb_machineKey.TabIndex = 9;
            // 
            // MainLauncher
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(880, 483);
            this.Controls.Add(this.p_info);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.bt_autoupdate);
            this.Controls.Add(this.bt_weibo);
            this.Controls.Add(this.cb_themes);
            this.Controls.Add(this.p_login);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainLauncher";
            this.Text = "入口";
            this.Load += new System.EventHandler(this.MainLauncher_Load);
            this.p_login.ResumeLayout(false);
            this.p_info.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_themes;
        private DevComponents.DotNetBar.ButtonX bt_weibo;
        private DevComponents.DotNetBar.ButtonX bt_autoupdate;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.PanelEx p_login;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxDropDown tbdrop_username;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_password;
        private DevComponents.DotNetBar.Controls.CheckBoxX cb_showpwd;
        private DevComponents.DotNetBar.ButtonX bt_login;
        private DevComponents.DotNetBar.PanelEx p_info;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_Nickname;
        private DevComponents.DotNetBar.LabelX lb_registertime;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx rtb_machineKey;
    }
}
