using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;

namespace TMTMultiTools.Weibo
{
    partial class WeiboForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeiboForm));
            this.bt_single = new DevComponents.DotNetBar.ButtonX();
            this.rt_input = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.rt_output = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tb_input = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_output = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label_origin = new DevComponents.DotNetBar.LabelX();
            this.label_new = new DevComponents.DotNetBar.LabelX();
            this.bt_batch = new DevComponents.DotNetBar.ButtonX();
            this.cb_https = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cb_isnew = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // bt_single
            // 
            this.bt_single.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_single.Location = new System.Drawing.Point(528, 81);
            this.bt_single.Name = "bt_single";
            this.bt_single.Size = new System.Drawing.Size(75, 23);
            this.bt_single.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_single.TabIndex = 0;
            this.bt_single.Text = "获取";
            this.bt_single.Click += new System.EventHandler(this.Test_Click);
            // 
            // rt_input
            // 
            this.rt_input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.rt_input.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rt_input.EnableAutoDragDrop = true;
            this.rt_input.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rt_input.Location = new System.Drawing.Point(12, 204);
            this.rt_input.Name = "rt_input";
            this.rt_input.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset" +
    "134 \\\'cb\\\'ce\\\'cc\\\'e5;}}\r\n{\\colortbl ;\\red240\\green240\\blue240;}\r\n\\viewkind4\\uc1\\" +
    "pard\\cf1\\lang2052\\f0\\fs18\\par\r\n}\r\n";
            this.rt_input.Size = new System.Drawing.Size(377, 299);
            this.rt_input.TabIndex = 1;
            this.rt_input.WordWrap = false;
            // 
            // rt_output
            // 
            this.rt_output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.rt_output.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rt_output.Location = new System.Drawing.Point(481, 204);
            this.rt_output.Name = "rt_output";
            this.rt_output.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset" +
    "134 \\\'cb\\\'ce\\\'cc\\\'e5;}}\r\n{\\colortbl ;\\red240\\green240\\blue240;}\r\n\\viewkind4\\uc1\\" +
    "pard\\cf1\\lang2052\\f0\\fs18\\par\r\n}\r\n";
            this.rt_output.Size = new System.Drawing.Size(377, 299);
            this.rt_output.TabIndex = 2;
            // 
            // tb_input
            // 
            this.tb_input.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_input.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_input.DisabledBackColor = System.Drawing.Color.Black;
            this.tb_input.Location = new System.Drawing.Point(89, 82);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(414, 21);
            this.tb_input.TabIndex = 3;
            // 
            // tb_output
            // 
            // 
            // 
            // 
            this.tb_output.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_output.DisabledBackColor = System.Drawing.Color.Black;
            this.tb_output.Location = new System.Drawing.Point(89, 122);
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(414, 21);
            this.tb_output.TabIndex = 4;
            // 
            // label_origin
            // 
            this.label_origin.AutoSize = true;
            this.label_origin.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.label_origin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_origin.ForeColor = System.Drawing.Color.Black;
            this.label_origin.Location = new System.Drawing.Point(12, 85);
            this.label_origin.Name = "label_origin";
            this.label_origin.Size = new System.Drawing.Size(74, 18);
            this.label_origin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.label_origin.TabIndex = 5;
            this.label_origin.Text = "原微博地址:";
            // 
            // label_new
            // 
            this.label_new.AutoSize = true;
            this.label_new.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.label_new.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label_new.ForeColor = System.Drawing.Color.Black;
            this.label_new.Location = new System.Drawing.Point(12, 125);
            this.label_new.Name = "label_new";
            this.label_new.Size = new System.Drawing.Size(74, 18);
            this.label_new.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.label_new.TabIndex = 6;
            this.label_new.Text = "新微博地址:";
            // 
            // bt_batch
            // 
            this.bt_batch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_batch.Location = new System.Drawing.Point(398, 246);
            this.bt_batch.Name = "bt_batch";
            this.bt_batch.Size = new System.Drawing.Size(75, 23);
            this.bt_batch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_batch.TabIndex = 7;
            this.bt_batch.Text = "获取";
            this.bt_batch.Click += new System.EventHandler(this.bt_batch_Click);
            // 
            // cb_https
            // 
            this.cb_https.AutoSize = true;
            this.cb_https.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cb_https.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cb_https.Location = new System.Drawing.Point(14, 56);
            this.cb_https.Name = "cb_https";
            this.cb_https.Size = new System.Drawing.Size(107, 18);
            this.cb_https.TabIndex = 8;
            this.cb_https.Text = "是否启用HTTPS";
            // 
            // cb_isnew
            // 
            this.cb_isnew.AutoSize = true;
            this.cb_isnew.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cb_isnew.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cb_isnew.Location = new System.Drawing.Point(122, 56);
            this.cb_isnew.Name = "cb_isnew";
            this.cb_isnew.Size = new System.Drawing.Size(125, 18);
            this.cb_isnew.TabIndex = 9;
            this.cb_isnew.Text = "通过微博名称匹配";
            this.cb_isnew.CheckedChanged += new System.EventHandler(this.cb_isnew_CheckedChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX1.FontBold = true;
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(12, 27);
            this.labelX1.Name = "labelX1";
            this.labelX1.SingleLineColor = System.Drawing.Color.Chocolate;
            this.labelX1.Size = new System.Drawing.Size(491, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX1.TabIndex = 12;
            this.labelX1.Text = "默认通过微博地址进行匹配查找，勾选之后可以使用微博名称匹配，但不确定是否有限制";
            // 
            // WeiboForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(870, 515);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cb_isnew);
            this.Controls.Add(this.cb_https);
            this.Controls.Add(this.bt_batch);
            this.Controls.Add(this.label_new);
            this.Controls.Add(this.label_origin);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.rt_output);
            this.Controls.Add(this.rt_input);
            this.Controls.Add(this.bt_single);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WeiboForm";
            this.Text = "入口";
            this.Load += new System.EventHandler(this.WeiboForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonX bt_single;
        private RichTextBoxEx rt_input;
        private RichTextBoxEx rt_output;
        private TextBoxX tb_input;
        private TextBoxX tb_output;
        private LabelX label_origin;
        private LabelX label_new;
        private ButtonX bt_batch;
        private CheckBoxX cb_https;
        private CheckBoxX cb_isnew;
        private LabelX labelX1;
    }
}

