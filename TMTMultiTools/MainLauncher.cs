using DevComponents.DotNetBar;
using FSLib.App.SimpleUpdater;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TMTMultiTools.Common.Providers;
using TMTMultiTools.Helper;

namespace TMTMultiTools
{
    public partial class MainLauncher : BaseForm
    {
        Weibo.WeiboForm weiboForm = null;
        Updater updater = Updater.CreateUpdaterInstance("http://softupgrade.loongdream.com/TMTMultiTools/{0}", "update.xml");
        public MainLauncher()
        {
            InitializeComponent();
        }

        private void MainLauncher_Load(object sender, EventArgs e)
        {
            labelX1.Text = "当前版本号：" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\n";
            BindCombox();
            cb_themes.SelectedIndex = StaticData.ThemeDic.FindIndexByKey(StaticData.GlobalConfig.GlobalTheme.ToString());

            updater.Context.LogFile = "upgradelog.txt";
            updater.CheckUpdateComplete += CheckUpdateComplete;
            updater.Context.EnableEmbedDialog = false;
            updater.BeginCheckUpdateInProcess();

            //添加自定义下拉的UseName
            if (StaticData.GlobalConfig.RecentUserName != null && StaticData.GlobalConfig.RecentUserName.Any())
            {
                tbdrop_username.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbdrop_username.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tbdrop_username.AutoCompleteCustomSource.AddRange(StaticData.GlobalConfig.RecentUserName.ToArray());

                foreach (var item in StaticData.GlobalConfig.RecentUserName)
                { 
                }
            }
        }

        private void CheckUpdateComplete(object sender, EventArgs e)
        {
             labelX2.Text = "线上版本号：" + updater.Context.LatestVersion.ToString() + "";
            //判断是否线上需要进行更新
            if (updater.Context.HasUpdate)
            {
                labelX2.Text += "(请升级)";
                labelX2.ForeColor = Color.Red;
                bt_autoupdate.Enabled = true;
            }
            else
            {
                labelX2.Text += "(已是最新)";
                labelX2.ForeColor = Color.Green;
                bt_autoupdate.Enabled = false;
            }
        }

        private void BindCombox()
        {  
            BindingSource bs = new BindingSource();
            bs.DataSource = StaticData.ThemeDic;
            cb_themes.DataSource = bs;
            cb_themes.ValueMember = "Value";
            cb_themes.DisplayMember = "Key";
        }

        private void cb_themes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            eStyle style = (eStyle)(cb_themes.SelectedValue);
            ChangeStyle(style);
        }

        private void bt_weibo_Click(object sender, EventArgs e)
        {
            if (weiboForm == null || weiboForm.IsDisposed)   //注意先判断null，再判断IsDisposed，不能先判断IsDisposed
            {
                weiboForm = new Weibo.WeiboForm(); 
                weiboForm.Show();
            }
            else
            {
                weiboForm.Show();
                weiboForm.Activate();
            }
        }

        private void bt_autoupdate_Click(object sender, EventArgs e)
        {
            Updater.CheckUpdateSimple();
        }

        private void cb_showpwd_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpwd.Checked)
                tb_password.PasswordChar = '\0';
            else
                tb_password.PasswordChar = '*';
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string username = tbdrop_username.Text;
            string password = tb_password.Text;

            var userinfo = UserProvider.Instance.Login(username, password);
            if (userinfo == null)
            {
                MessageBox.Show("登录失败请重试");

            }
            else
            {
                tb_Nickname.Text = userinfo.NickName;
                lb_registertime.Text = userinfo.RegisterTime.ToShortDateString();
                rtb_machineKey.Text = userinfo.MachineKey;

                p_info.Location = p_login.Location;
                p_info.Visible = true;
                p_login.Visible = false;

                StaticData.GlobalConfig.UserInfo = new Model.User.UserInfoModel() { UserId = userinfo.UserId, NickName = userinfo.NickName, RegisterTime = userinfo.RegisterTime, MachineKey = userinfo.MachineKey };
                if (StaticData.GlobalConfig.RecentUserName == null)
                    StaticData.GlobalConfig.RecentUserName = new List<string>() { username };
                else
                    StaticData.GlobalConfig.RecentUserName.Add(username);

                ConfigHelper.Save();
            }
        }
    }
}
