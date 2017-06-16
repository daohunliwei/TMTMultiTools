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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeiboForm));
            this.rt_input = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.dgv_output = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.mainPanel = new DevComponents.DotNetBar.PanelEx();
            this.IsTruly = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.NickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avatar = new System.Windows.Forms.DataGridViewImageColumn();
            this.OriginParma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FansNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cb_isnew = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cb_https = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.bt_batch = new DevComponents.DotNetBar.ButtonX();
            this.label_origin = new DevComponents.DotNetBar.LabelX();
            this.tb_input = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bt_single = new DevComponents.DotNetBar.ButtonX();
            this.cb_isForceMate = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rt_input
            // 
            this.rt_input.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.rt_input.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rt_input.Dock = System.Windows.Forms.DockStyle.Top;
            this.rt_input.EnableAutoDragDrop = true;
            this.rt_input.ForeColor = System.Drawing.Color.Black;
            this.rt_input.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rt_input.Location = new System.Drawing.Point(0, 0);
            this.rt_input.Name = "rt_input";
            this.rt_input.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset" +
    "134 \\\'cb\\\'ce\\\'cc\\\'e5;}}\r\n{\\colortbl ;\\red0\\green0\\blue0;}\r\n\\viewkind4\\uc1\\pard\\c" +
    "f1\\lang2052\\f0\\fs18\\par\r\n}\r\n";
            this.rt_input.Size = new System.Drawing.Size(1038, 181);
            this.rt_input.TabIndex = 1;
            this.rt_input.WordWrap = false;
            // 
            // dgv_output
            // 
            this.dgv_output.AllowUserToOrderColumns = true;
            this.dgv_output.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_output.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_output.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsTruly,
            this.NickName,
            this.ShortLink,
            this.IsV,
            this.Description,
            this.UID,
            this.Avatar,
            this.OriginParma,
            this.FansNum,
            this.Sex});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_output.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_output.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_output.EnableHeadersVisualStyles = false;
            this.dgv_output.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgv_output.Location = new System.Drawing.Point(0, 181);
            this.dgv_output.Name = "dgv_output";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_output.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_output.RowTemplate.Height = 23;
            this.dgv_output.Size = new System.Drawing.Size(1038, 272);
            this.dgv_output.TabIndex = 13;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.CanvasColor = System.Drawing.Color.Transparent;
            this.mainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mainPanel.Controls.Add(this.rt_input);
            this.mainPanel.Controls.Add(this.dgv_output);
            this.mainPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 256);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1038, 453);
            this.mainPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mainPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mainPanel.Style.GradientAngle = 90;
            this.mainPanel.TabIndex = 19;
            // 
            // IsTruly
            // 
            this.IsTruly.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IsTruly.Checked = true;
            this.IsTruly.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.IsTruly.CheckValue = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IsTruly.DefaultCellStyle = dataGridViewCellStyle2;
            this.IsTruly.HeaderText = "完全匹配";
            this.IsTruly.Name = "IsTruly";
            this.IsTruly.ReadOnly = true;
            this.IsTruly.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IsTruly.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsTruly.Width = 78;
            // 
            // NickName
            // 
            this.NickName.HeaderText = "昵称";
            this.NickName.Name = "NickName";
            // 
            // ShortLink
            // 
            this.ShortLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ShortLink.HeaderText = "短地址";
            this.ShortLink.Name = "ShortLink";
            // 
            // IsV
            // 
            this.IsV.HeaderText = "是否大V";
            this.IsV.Name = "IsV";
            // 
            // Description
            // 
            this.Description.HeaderText = "描述信息";
            this.Description.Name = "Description";
            // 
            // UID
            // 
            this.UID.HeaderText = "数字ID";
            this.UID.Name = "UID";
            // 
            // Avatar
            // 
            this.Avatar.HeaderText = "头像";
            this.Avatar.Name = "Avatar";
            // 
            // OriginParma
            // 
            this.OriginParma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OriginParma.HeaderText = "输入参数";
            this.OriginParma.Name = "OriginParma";
            this.OriginParma.Width = 78;
            // 
            // FansNum
            // 
            this.FansNum.HeaderText = "粉丝数";
            this.FansNum.Name = "FansNum";
            // 
            // Sex
            // 
            this.Sex.HeaderText = "性别";
            this.Sex.Name = "Sex";
            // 
            // panelEx1
            // 
            this.panelEx1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelEx1.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.cb_isForceMate);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.cb_isnew);
            this.panelEx1.Controls.Add(this.cb_https);
            this.panelEx1.Controls.Add(this.bt_batch);
            this.panelEx1.Controls.Add(this.label_origin);
            this.panelEx1.Controls.Add(this.tb_input);
            this.panelEx1.Controls.Add(this.bt_single);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1038, 212);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 24;
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
            this.labelX1.Location = new System.Drawing.Point(297, 44);
            this.labelX1.Name = "labelX1";
            this.labelX1.SingleLineColor = System.Drawing.Color.Chocolate;
            this.labelX1.Size = new System.Drawing.Size(491, 23);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "默认通过微博地址进行匹配查找，勾选之后可以使用微博名称匹配，但不确定是否有限制";
            // 
            // cb_isnew
            // 
            this.cb_isnew.AutoSize = true;
            this.cb_isnew.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cb_isnew.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cb_isnew.ForeColor = System.Drawing.Color.Black;
            this.cb_isnew.Location = new System.Drawing.Point(407, 73);
            this.cb_isnew.Name = "cb_isnew";
            this.cb_isnew.Size = new System.Drawing.Size(125, 18);
            this.cb_isnew.TabIndex = 18;
            this.cb_isnew.Text = "通过微博名称匹配";
            this.cb_isnew.Click += new System.EventHandler(this.cb_isnew_CheckedChanged);
            // 
            // cb_https
            // 
            this.cb_https.AutoSize = true;
            this.cb_https.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cb_https.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cb_https.ForeColor = System.Drawing.Color.Black;
            this.cb_https.Location = new System.Drawing.Point(297, 73);
            this.cb_https.Name = "cb_https";
            this.cb_https.Size = new System.Drawing.Size(107, 18);
            this.cb_https.TabIndex = 17;
            this.cb_https.Text = "是否启用HTTPS";
            // 
            // bt_batch
            // 
            this.bt_batch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_batch.Location = new System.Drawing.Point(608, 163);
            this.bt_batch.Name = "bt_batch";
            this.bt_batch.Size = new System.Drawing.Size(75, 23);
            this.bt_batch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_batch.TabIndex = 16;
            this.bt_batch.Text = "批量获取";
            this.bt_batch.Click += new System.EventHandler(this.bt_batch_Click);
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
            this.label_origin.Location = new System.Drawing.Point(297, 102);
            this.label_origin.Name = "label_origin";
            this.label_origin.Size = new System.Drawing.Size(74, 18);
            this.label_origin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.label_origin.TabIndex = 15;
            this.label_origin.Text = "原微博地址:";
            // 
            // tb_input
            // 
            this.tb_input.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_input.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_input.DisabledBackColor = System.Drawing.Color.Black;
            this.tb_input.ForeColor = System.Drawing.Color.Black;
            this.tb_input.Location = new System.Drawing.Point(377, 99);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(414, 21);
            this.tb_input.TabIndex = 14;
            // 
            // bt_single
            // 
            this.bt_single.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_single.Location = new System.Drawing.Point(407, 163);
            this.bt_single.Name = "bt_single";
            this.bt_single.Size = new System.Drawing.Size(75, 23);
            this.bt_single.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_single.TabIndex = 13;
            this.bt_single.Text = "单值获取";
            this.bt_single.Click += new System.EventHandler(this.bt_single_Click);
            // 
            // cb_isForceMate
            // 
            this.cb_isForceMate.AutoSize = true;
            this.cb_isForceMate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.cb_isForceMate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cb_isForceMate.ForeColor = System.Drawing.Color.Black;
            this.cb_isForceMate.Location = new System.Drawing.Point(535, 73);
            this.cb_isForceMate.Name = "cb_isForceMate";
            this.cb_isForceMate.Size = new System.Drawing.Size(125, 18);
            this.cb_isForceMate.TabIndex = 20;
            this.cb_isForceMate.Text = "是否要求完全匹配";
            // 
            // WeiboForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1038, 709);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeiboForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "微博工具";
            this.Load += new System.EventHandler(this.WeiboForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichTextBoxEx rt_input;
        private DataGridViewX dgv_output;
        private PanelEx mainPanel;
        private DataGridViewCheckBoxXColumn IsTruly;
        private DataGridViewTextBoxColumn NickName;
        private DataGridViewTextBoxColumn ShortLink;
        private DataGridViewTextBoxColumn IsV;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn UID;
        private DataGridViewImageColumn Avatar;
        private DataGridViewTextBoxColumn OriginParma;
        private DataGridViewTextBoxColumn FansNum;
        private DataGridViewTextBoxColumn Sex;
        private PanelEx panelEx1;
        private LabelX labelX1;
        private CheckBoxX cb_isnew;
        private CheckBoxX cb_https;
        private ButtonX bt_batch;
        private LabelX label_origin;
        private TextBoxX tb_input;
        private ButtonX bt_single;
        private CheckBoxX cb_isForceMate;
    }
}

