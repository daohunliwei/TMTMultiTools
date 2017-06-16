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
using TMTMultiTools.Model;
using DevComponents.DotNetBar.Controls;

namespace TMTMultiTools.Weibo
{
    public partial class WeiboForm : BaseForm
    {
        public WeiboForm()
        {
            InitializeComponent();
        }


        private void bt_single_Click(object sender, EventArgs e)
        {
            string parms = tb_input.Text.Trim();
            if (string.IsNullOrEmpty(parms))
            {
                MessageBox.Show("请提供相关参数");
            }
            else
            {
                Dictionary<string, WeiboUserInfo> result = (cb_isnew.CheckState == CheckState.Checked) ? WeiboProvider.GetUIDByNameList(parms) : WeiboProvider.GetUIDByURLList(parms);
                BindingDataGridView(this.dgv_output, result);
            }
        }
        private void bt_batch_Click(object sender, EventArgs e)
        {
            string[] parms = rt_input.Lines;
            if (parms.Any())
            {
                var result = (cb_isnew.CheckState == CheckState.Checked) ? WeiboProvider.GetUIDByNameList(parms) : WeiboProvider.GetUIDByURLList(parms);

                BindingDataGridView(this.dgv_output, result);

                MessageBox.Show($"获取完毕，共输入网址{parms.Count()}个，共获取{result.Count}个，其中完全匹配{result.Count(n=>n.Value.IsTruly)}个");
            }
            else
            {
                MessageBox.Show("请提供相关参数，每行一条，注意换行");
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
            DataGridViewCheckBoxXColumn cb =
                  dgv_output.Columns["IsTruly"] as DataGridViewCheckBoxXColumn;
            if (cb != null)
                cb.BeforeCellPaint += dgv_output_IsTruly_BeforeCellPaint;
        }

        private void dgv_output_IsTruly_BeforeCellPaint(object sender, BeforeCellPaintEventArgs e)
        {
            DataGridViewCheckBoxXColumn sc =
               sender as DataGridViewCheckBoxXColumn;

            if (sc != null)
            {
                switch (sc.CheckState)
                {
                    case CheckState.Checked:
                        sc.Text = "匹配";
                        sc.TextColor = Color.Green;
                        break;

                    case CheckState.Unchecked:
                        sc.Text = "不匹配";
                        sc.TextColor = Color.Red;
                        break;

                    default:
                        sc.Text = "难说";
                        sc.TextColor = Color.DarkGray;
                        break;
                }
            }
        }

        private void BindingDataGridView(DataGridView dgv, Dictionary<string, WeiboUserInfo> data)
        {
            if (data.Any())
            {
                foreach (var item in data)
                {
                    string origin = item.Key;
                    WeiboUserInfo userInfo = item.Value;
                    int index = dgv.Rows.Add();
                    dgv.Rows[index].Cells["UID"].Value = userInfo.UID;
                    dgv.Rows[index].Cells["FansNum"].Value = userInfo.FansNum;
                    dgv.Rows[index].Cells["NickName"].Value = userInfo.NickName;
                    dgv.Rows[index].Cells["Sex"].Value = userInfo.Sex;
                    dgv.Rows[index].Cells["IsV"].Value = userInfo.IsV?"是":"否";
                    dgv.Rows[index].Cells["OriginParma"].Value =origin; 
                    dgv.Rows[index].Cells["IsTruly"].Value = userInfo.IsTruly;

                    //头像和是短连接需要单独的处理
                    if (userInfo.IsTruly)
                    {
                        //完全匹配了之后就准备短连接了
                        dgv.Rows[index].Cells["ShortLink"].Value = (cb_https.Checked ? "https" : "http") + "://m.weibo.cn/u/"+userInfo.UID; 
                    }
                }
            }
        }

    }
}
