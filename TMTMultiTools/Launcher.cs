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
namespace TMTMultiTools
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            string url = tb_input.Text.Trim();
            if (string.IsNullOrEmpty(url))
            { MessageBox.Show("请提供原微博网址"); }
            else
            {
                var result = WeiboProvider.GetUIDByURLList(url);
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
            string[] urls = rt_input.Lines;
            if (urls.Any())
            {
                var result = WeiboProvider.GetUIDByURLList(urls);
                StringBuilder sb = new StringBuilder();
                foreach (var keypair in result)
                {
                    sb.AppendLine(keypair.Value + "   " + (cb_https.Checked ? "https" : "http") + "://m.weibo.cn/u/" + keypair.Key);
                }
                rt_output.Text = sb.ToString();

                MessageBox.Show($"获取完毕，共输入网址{urls.Count()}个，成功获取{result.Count}个");
            }
            else
            {
                MessageBox.Show("请提供原微博网址，每行一条，注意换行");
            }
        }
    }
}
