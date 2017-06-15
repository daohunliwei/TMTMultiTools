using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Runtime.InteropServices;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Ribbon;
using DevComponents.DotNetBar.Metro;
using TMTMultiTools.Helper;
using TMTMultiTools.Helper.Themes;

namespace TMTMultiTools
{
    public partial class Launcher : MetroForm
    { 
        Weibo.WeiboForm weiboForm = null;
        public Launcher()
        {
            InitializeComponent();
        } 
        private void bt_autoupdate_Click(object sender, EventArgs e)
        {
            var updater = FSLib.App.SimpleUpdater.Updater.Instance;
            updater.Context.LogFile = "c:\\log.txt";
           // FSLib.App.SimpleUpdater.Updater.CheckUpdateSimple("", updateInfoFile);

            FSLib.App.SimpleUpdater.Updater.CheckUpdateSimple("C:\\发布程序\\update.xml");
        }

        private void sbt_weibo_Click(object sender, EventArgs e)
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

        private void sbt_weixin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我还没实现……", "提示");
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            BindCombox();
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
            eStyle style = (eStyle)cb_themes.SelectedValue;
            styleManager1.ManagerStyle = style;
        }
    }
}
