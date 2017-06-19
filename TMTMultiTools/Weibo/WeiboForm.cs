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
using System.Threading;

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
            string parms = tb_input.Text;
            if (string.IsNullOrWhiteSpace(parms))
            {
                MessageBox.Show("请提供相关参数");
            }
            else
            {
                if (back_process.IsBusy)
                    MessageBox.Show("当前正在执行任务，请稍后再试");
                else
                {
                    pb_working.Value = 0;
                    pb_working.Maximum = parms.Length;
                    back_process.RunWorkerAsync(new string[] { parms });
                }
            }
        }
        private void bt_batch_Click(object sender, EventArgs e)
        {
            string[] parms = rt_input.Lines.Where(n=>!string.IsNullOrWhiteSpace(n)).ToArray();
            
            if (parms.Any())
            {
                if (back_process.IsBusy)
                    MessageBox.Show("当前正在执行任务，请稍后再试");
                else
                {
                    pb_working.Value = 0;
                    pb_working.Maximum = parms.Length;
                    back_process.RunWorkerAsync(parms);
                }
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
            dgv_output.Rows.Clear();
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
                    dgv.Rows[index].Cells["IsV"].Value = userInfo.IsV ? "是" : "否";
                    dgv.Rows[index].Cells["OriginParma"].Value = origin;
                    dgv.Rows[index].Cells["IsTruly"].Value = userInfo.IsTruly;

                    //头像和是短连接需要单独的处理
                    if (userInfo.IsTruly || !cb_isForceMate.Checked)
                    {
                        //完全匹配了之后就准备短连接了
                        dgv.Rows[index].Cells["ShortLink"].Value = (userInfo.UID == "-1") ? "未匹配到" : ((cb_https.Checked ? "https" : "http") + "://m.weibo.cn/u/" + userInfo.UID);
                    }
                }
            }
        }

        private void bt_cleanOutput_Click(object sender, EventArgs e)
        {
            CleanDataGrideView();
        }

        private void CleanDataGrideView()
        {
            dgv_output.Rows.Clear();
        }

        private void bt_cleanInput_Click(object sender, EventArgs e)
        {
            rt_input.Clear();
        }

        private void back_process_DoWork(object sender, DoWorkEventArgs e)
        {
            var parms = (string[])e.Argument;
            Dictionary<string, WeiboUserInfo> result = (cb_isnew.CheckState == CheckState.Checked) ? WeiboProvider.GetUIDByNameList(back_process.ReportProgress,parms) : WeiboProvider.GetUIDByURLList(back_process.ReportProgress,parms);
            e.Result = result;        
        }

        private void back_process_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var state = (UserProcessModel)e.UserState;
            pb_working.Value = e.ProgressPercentage;
            pb_working.Text = state.ProcessStr;
        }

        private void back_process_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //MessageBox.Show();
            pb_working.Value = pb_working.Maximum;
            if (e.Cancelled)
            {
                rt_detail.Text += "任务取消。" + "\r\n";
                pb_working.Text = "任务取消";
            }
            else if (e.Error != null)
            {
                rt_detail.Text += "出现异常: " + e.Error + "\r\n"; 
                pb_working.Text = "任务异常请看日志";
            }
            else
            {
                var result = (Dictionary<string, WeiboUserInfo>)e.Result;
                if (result == null)
                {
                    rt_detail.AppendText("\r\n执行失败，未获取到任何信息");
                    pb_working.Text = "任务异常请看日志";
                }
                else
                {
                    BindingDataGridView(this.dgv_output, result);
                    rt_detail.Text += $"获取完毕，共输入网址{pb_working.Maximum}个，共获取{result.Count}个，其中完全匹配{result.Count(n => n.Value.IsTruly)}个\r\n";
                    pb_working.Text = "任务完成";
                }
            }
        }

        private void bt_cleanDetail_Click(object sender, EventArgs e)
        {
            rt_detail.Clear();
        }
    }
}
