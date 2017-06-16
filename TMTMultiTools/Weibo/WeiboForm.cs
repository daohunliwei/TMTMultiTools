using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMTMultiTools.Common.Providers;
using Newtonsoft.Json;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;

namespace TMTMultiTools.Weibo
{
    public partial class WeiboForm : BaseForm
    {
        public WeiboForm()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            string parms = tb_input.Text.Trim();
            if (string.IsNullOrEmpty(parms))
            { MessageBox.Show("请提供原微博网址"); }
            else
            {
                var result = (cb_isnew.CheckState==CheckState.Checked)?WeiboProvider.GetUIDByNameList(parms): WeiboProvider.GetUIDByURLList(parms);
                if (result != null && result.Any())
                {
                    var keypair = result.First();
                    tb_output.Text = keypair.Value + "   " + (cb_https.Checked ? "https" : "http") + "://m.weibo.cn/u/" + keypair.Key;
                }
                else
                {
                    tb_output.Text = "未获取到";
                }
            }  
        }

        private void bt_batch_Click(object sender, EventArgs e)
        {
            string[] parms = rt_input.Lines;
            if (parms.Any())
            {
                var result = (cb_isnew.CheckState == CheckState.Checked) ? WeiboProvider.GetUIDByNameList(parms) : WeiboProvider.GetUIDByURLList(parms);
                StringBuilder sb = new StringBuilder();
                foreach (var keypair in result)
                {
                    sb.AppendLine(keypair.Value + "   " + (cb_https.Checked ? "https" : "http") + "://m.weibo.cn/u/" + keypair.Key);
                }
                rt_output.Text = sb.ToString();

                MessageBox.Show($"获取完毕，共输入网址{parms.Count()}个，成功获取{result.Count}个");
            }
            else
            {
                MessageBox.Show("请提供原微博网址，每行一条，注意换行");
            }
        }

        private void cb_isnew_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_isnew.Checked)
            {
                label_origin.Text = "原微博名称：";
            }
            else
            { 
                label_origin.Text = "原微博地址：";
            }
        }

        private void WeiboForm_Load(object sender, EventArgs e)
        {
        }
    }
}
