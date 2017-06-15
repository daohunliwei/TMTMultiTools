namespace TMTMultiTools
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.bt_single = new System.Windows.Forms.Button();
            this.rt_input = new System.Windows.Forms.RichTextBox();
            this.rt_output = new System.Windows.Forms.RichTextBox();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.label_origin = new System.Windows.Forms.Label();
            this.label_new = new System.Windows.Forms.Label();
            this.bt_batch = new System.Windows.Forms.Button();
            this.cb_https = new System.Windows.Forms.CheckBox();
            this.cb_isnew = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_single
            // 
            this.bt_single.Location = new System.Drawing.Point(532, 95);
            this.bt_single.Name = "bt_single";
            this.bt_single.Size = new System.Drawing.Size(75, 23);
            this.bt_single.TabIndex = 0;
            this.bt_single.Text = "获取";
            this.bt_single.UseVisualStyleBackColor = true;
            this.bt_single.Click += new System.EventHandler(this.Test_Click);
            // 
            // rt_input
            // 
            this.rt_input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rt_input.EnableAutoDragDrop = true;
            this.rt_input.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rt_input.Location = new System.Drawing.Point(12, 204);
            this.rt_input.Name = "rt_input";
            this.rt_input.Size = new System.Drawing.Size(377, 299);
            this.rt_input.TabIndex = 1;
            this.rt_input.Text = "";
            this.rt_input.WordWrap = false;
            // 
            // rt_output
            // 
            this.rt_output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rt_output.Location = new System.Drawing.Point(481, 204);
            this.rt_output.Name = "rt_output";
            this.rt_output.Size = new System.Drawing.Size(377, 299);
            this.rt_output.TabIndex = 2;
            this.rt_output.Text = "";
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(93, 96);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(414, 21);
            this.tb_input.TabIndex = 3;
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(93, 136);
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(414, 21);
            this.tb_output.TabIndex = 4;
            // 
            // label_origin
            // 
            this.label_origin.AutoSize = true;
            this.label_origin.Location = new System.Drawing.Point(16, 99);
            this.label_origin.Name = "label_origin";
            this.label_origin.Size = new System.Drawing.Size(71, 12);
            this.label_origin.TabIndex = 5;
            this.label_origin.Text = "原微博地址:";
            // 
            // label_new
            // 
            this.label_new.AutoSize = true;
            this.label_new.Location = new System.Drawing.Point(16, 139);
            this.label_new.Name = "label_new";
            this.label_new.Size = new System.Drawing.Size(71, 12);
            this.label_new.TabIndex = 6;
            this.label_new.Text = "新微博地址:";
            // 
            // bt_batch
            // 
            this.bt_batch.Location = new System.Drawing.Point(398, 246);
            this.bt_batch.Name = "bt_batch";
            this.bt_batch.Size = new System.Drawing.Size(75, 23);
            this.bt_batch.TabIndex = 7;
            this.bt_batch.Text = "获取";
            this.bt_batch.UseVisualStyleBackColor = true;
            this.bt_batch.Click += new System.EventHandler(this.bt_batch_Click);
            // 
            // cb_https
            // 
            this.cb_https.AutoSize = true;
            this.cb_https.Location = new System.Drawing.Point(18, 35);
            this.cb_https.Name = "cb_https";
            this.cb_https.Size = new System.Drawing.Size(102, 16);
            this.cb_https.TabIndex = 8;
            this.cb_https.Text = "是否启用HTTPS";
            this.cb_https.UseVisualStyleBackColor = true;
            // 
            // cb_isnew
            // 
            this.cb_isnew.AutoSize = true;
            this.cb_isnew.Location = new System.Drawing.Point(126, 35);
            this.cb_isnew.Name = "cb_isnew";
            this.cb_isnew.Size = new System.Drawing.Size(120, 16);
            this.cb_isnew.TabIndex = 9;
            this.cb_isnew.Text = "通过微博名称匹配";
            this.cb_isnew.UseVisualStyleBackColor = true;
            this.cb_isnew.CheckedChanged += new System.EventHandler(this.cb_isnew_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "默认通过微博地址进行匹配查找，勾选之后可以使用微博名称匹配，但不确定是否有限制";
            // 
            // Launcher
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(870, 515);
            this.Controls.Add(this.label1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Launcher";
            this.Text = "入口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_single;
        private System.Windows.Forms.RichTextBox rt_input;
        private System.Windows.Forms.RichTextBox rt_output;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Label label_origin;
        private System.Windows.Forms.Label label_new;
        private System.Windows.Forms.Button bt_batch;
        private System.Windows.Forms.CheckBox cb_https;
        private System.Windows.Forms.CheckBox cb_isnew;
        private System.Windows.Forms.Label label1;
    }
}

