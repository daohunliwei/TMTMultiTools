using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TMTMultiTools.Helper;

namespace TMTMultiTools
{
    public partial class MainLauncher : BaseForm
    {
        Weibo.WeiboForm weiboForm = null;
        public MainLauncher()
        {
            InitializeComponent();
        }

        private void MainLauncher_Load(object sender, EventArgs e)
        {
            labelX1.Text = "当前版本号：" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\n";
            BindCombox();
            cb_themes.SelectedIndex = StaticData.ThemeDic.FindIndexByKey(StaticData.GlobalConfig.GlobalTheme.ToString());

            var updater = FSLib.App.SimpleUpdater.Updater.Instance;
            updater.Context.LogFile = "upgradelog.txt";
            FSLib.App.SimpleUpdater.Updater.CheckUpdateSimple("http://softupgrade.loongdream.com/TMTMultiTools/update.xml");
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
            var updater = FSLib.App.SimpleUpdater.Updater.Instance;
            updater.Context.LogFile = "upgradelog.txt"; 
            FSLib.App.SimpleUpdater.Updater.CheckUpdateSimple("http://softupgrade.loongdream.com/TMTMultiTools/update.xml");
        }
    }
}
