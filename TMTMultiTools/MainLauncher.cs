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
            BindCombox();
            cb_themes.SelectedIndex = StaticData.ThemeDic.FindIndexByKey(StaticData.GlobalConfig.GlobalTheme.ToString());
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
    }
}
