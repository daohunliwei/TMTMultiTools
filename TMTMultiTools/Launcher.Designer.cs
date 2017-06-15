namespace TMTMultiTools
{
    partial class Launcher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_autoupdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_autoupdate
            // 
            this.bt_autoupdate.Location = new System.Drawing.Point(97, 64);
            this.bt_autoupdate.Name = "bt_autoupdate";
            this.bt_autoupdate.Size = new System.Drawing.Size(75, 23);
            this.bt_autoupdate.TabIndex = 0;
            this.bt_autoupdate.Text = "button1";
            this.bt_autoupdate.UseVisualStyleBackColor = true;
            this.bt_autoupdate.Click += new System.EventHandler(this.bt_autoupdate_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 503);
            this.Controls.Add(this.bt_autoupdate);
            this.Name = "Launcher";
            this.Text = "Launcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_autoupdate;
    }
}