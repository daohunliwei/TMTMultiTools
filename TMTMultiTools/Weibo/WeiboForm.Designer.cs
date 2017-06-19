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
            this.mainPanel = new DevComponents.DotNetBar.PanelEx();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.rt_detail = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.cb_isForceMate = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cb_isnew = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cb_https = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.bt_batch = new DevComponents.DotNetBar.ButtonX();
            this.label_origin = new DevComponents.DotNetBar.LabelX();
            this.tb_input = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bt_single = new DevComponents.DotNetBar.ButtonX();
            this.bt_cleanOutput = new DevComponents.DotNetBar.ButtonX();
            this.bt_cleanInput = new DevComponents.DotNetBar.ButtonX();
            this.pb_working = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.back_process = new System.ComponentModel.BackgroundWorker();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.bt_cleanDetail = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rt_input
            // 
            this.rt_input.BackColor = System.Drawing.Color.White;
            this.rt_input.BackColorRichTextBox = System.Drawing.SystemColors.MenuHighlight;
            // 
            // 
            // 
            this.rt_input.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rt_input.Dock = System.Windows.Forms.DockStyle.Left;
            this.rt_input.EnableAutoDragDrop = true;
            this.rt_input.ForeColor = System.Drawing.Color.Black;
            this.rt_input.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rt_input.Location = new System.Drawing.Point(0, 0);
            this.rt_input.Name = "rt_input";
            this.rt_input.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset" +
    "134 \\\'cb\\\'ce\\\'cc\\\'e5;}}\r\n{\\colortbl ;\\red0\\green0\\blue0;}\r\n\\viewkind4\\uc1\\pard\\c" +
    "f1\\lang2052\\f0\\fs18\\par\r\n}\r\n";
            this.rt_input.Size = new System.Drawing.Size(617, 157);
            this.rt_input.TabIndex = 1;
            this.rt_input.WordWrap = false;
            // 
            // dgv_output
            // 
            this.dgv_output.AllowUserToAddRows = false;
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
            this.dgv_output.Location = new System.Drawing.Point(0, 157);
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
            this.dgv_output.Size = new System.Drawing.Size(1193, 272);
            this.dgv_output.TabIndex = 13;
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
            this.ShortLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ShortLink.HeaderText = "短地址";
            this.ShortLink.Name = "ShortLink";
            this.ShortLink.Width = 66;
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
            this.Sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sex.HeaderText = "性别";
            this.Sex.Name = "Sex";
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.mainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mainPanel.Controls.Add(this.panelEx2);
            this.mainPanel.Controls.Add(this.dgv_output);
            this.mainPanel.DisabledBackColor = System.Drawing.Color.Empty;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(0, 260);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1193, 429);
            this.mainPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.mainPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.mainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.mainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.mainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.mainPanel.Style.GradientAngle = 90;
            this.mainPanel.TabIndex = 19;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.rt_detail);
            this.panelEx2.Controls.Add(this.rt_input);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(1193, 157);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 14;
            // 
            // rt_detail
            // 
            this.rt_detail.BackColor = System.Drawing.Color.White;
            this.rt_detail.BackColorRichTextBox = System.Drawing.SystemColors.InactiveBorder;
            // 
            // 
            // 
            this.rt_detail.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rt_detail.Dock = System.Windows.Forms.DockStyle.Right;
            this.rt_detail.EnableAutoDragDrop = true;
            this.rt_detail.ForeColor = System.Drawing.Color.Black;
            this.rt_detail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rt_detail.Location = new System.Drawing.Point(623, 0);
            this.rt_detail.Name = "rt_detail";
            this.rt_detail.Rtf = "{\\rtf1\\ansi\\ansicpg936\\deff0\\deflang1033\\deflangfe2052{\\fonttbl{\\f0\\fnil\\fcharset" +
    "134 \\\'cb\\\'ce\\\'cc\\\'e5;}}\r\n{\\colortbl ;\\red0\\green0\\blue0;}\r\n\\viewkind4\\uc1\\pard\\c" +
    "f1\\lang2052\\f0\\fs18\\par\r\n}\r\n";
            this.rt_detail.Size = new System.Drawing.Size(570, 157);
            this.rt_detail.TabIndex = 14;
            this.rt_detail.WordWrap = false;
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
            this.panelEx1.Size = new System.Drawing.Size(1193, 212);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 24;
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
            this.cb_isnew.CheckedChanged += new System.EventHandler(this.cb_isnew_CheckedChanged);
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
            // bt_cleanOutput
            // 
            this.bt_cleanOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_cleanOutput.Location = new System.Drawing.Point(994, 223);
            this.bt_cleanOutput.Name = "bt_cleanOutput";
            this.bt_cleanOutput.Size = new System.Drawing.Size(75, 23);
            this.bt_cleanOutput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_cleanOutput.TabIndex = 21;
            this.bt_cleanOutput.Text = "清空输出";
            this.bt_cleanOutput.Click += new System.EventHandler(this.bt_cleanOutput_Click);
            // 
            // bt_cleanInput
            // 
            this.bt_cleanInput.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_cleanInput.Location = new System.Drawing.Point(913, 223);
            this.bt_cleanInput.Name = "bt_cleanInput";
            this.bt_cleanInput.Size = new System.Drawing.Size(75, 23);
            this.bt_cleanInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_cleanInput.TabIndex = 21;
            this.bt_cleanInput.Text = "清空输入";
            this.bt_cleanInput.Click += new System.EventHandler(this.bt_cleanInput_Click);
            // 
            // pb_working
            // 
            this.pb_working.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.pb_working.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pb_working.ForeColor = System.Drawing.Color.Black;
            this.pb_working.Location = new System.Drawing.Point(175, 223);
            this.pb_working.Name = "pb_working";
            this.pb_working.Size = new System.Drawing.Size(712, 23);
            this.pb_working.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pb_working.TabIndex = 34;
            this.pb_working.TextVisible = true;
            // 
            // back_process
            // 
            this.back_process.WorkerReportsProgress = true;
            this.back_process.WorkerSupportsCancellation = true;
            this.back_process.DoWork += new System.ComponentModel.DoWorkEventHandler(this.back_process_DoWork);
            this.back_process.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.back_process_ProgressChanged);
            this.back_process.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.back_process_RunWorkerCompleted);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(87, 225);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(62, 18);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX2.TabIndex = 21;
            this.labelX2.Text = "执行进度:";
            // 
            // bt_cleanDetail
            // 
            this.bt_cleanDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_cleanDetail.Location = new System.Drawing.Point(1075, 223);
            this.bt_cleanDetail.Name = "bt_cleanDetail";
            this.bt_cleanDetail.Size = new System.Drawing.Size(75, 23);
            this.bt_cleanDetail.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_cleanDetail.TabIndex = 35;
            this.bt_cleanDetail.Text = "清空日志";
            this.bt_cleanDetail.Click += new System.EventHandler(this.bt_cleanDetail_Click);
            // 
            // WeiboForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1193, 689);
            this.Controls.Add(this.bt_cleanDetail);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.pb_working);
            this.Controls.Add(this.bt_cleanInput);
            this.Controls.Add(this.bt_cleanOutput);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeiboForm";
            this.Text = "微博工具";
            this.Load += new System.EventHandler(this.WeiboForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_output)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichTextBoxEx rt_input;
        private DataGridViewX dgv_output;
        private PanelEx mainPanel;
        private PanelEx panelEx1;
        private LabelX labelX1;
        private CheckBoxX cb_isnew;
        private CheckBoxX cb_https;
        private ButtonX bt_batch;
        private LabelX label_origin;
        private TextBoxX tb_input;
        private ButtonX bt_single;
        private CheckBoxX cb_isForceMate;
        private ButtonX bt_cleanOutput;
        private ButtonX bt_cleanInput;
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
        private ProgressBarX pb_working;
        private System.ComponentModel.BackgroundWorker back_process;
        private RichTextBoxEx rt_detail;
        private PanelEx panelEx2;
        private LabelX labelX2;
        private ButtonX bt_cleanDetail;
    }
}

