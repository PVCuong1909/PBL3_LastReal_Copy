namespace PBL3_LastReal.View
{
    partial class fChooseComputer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbb_ChooseComp = new System.Windows.Forms.ComboBox();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PBL3_LastReal.Properties.Resources.icons8_monitor_40;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(70, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbb_ChooseComp
            // 
            this.cbb_ChooseComp.FormattingEnabled = true;
            this.cbb_ChooseComp.ItemHeight = 16;
            this.cbb_ChooseComp.Location = new System.Drawing.Point(136, 50);
            this.cbb_ChooseComp.Name = "cbb_ChooseComp";
            this.cbb_ChooseComp.Size = new System.Drawing.Size(121, 24);
            this.cbb_ChooseComp.TabIndex = 1;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(121, 100);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(80, 30);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // fChooseComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBL3_LastReal.Properties.Resources._6660efc642a59dfbc4b4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(332, 153);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.cbb_ChooseComp);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fChooseComputer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fChooseComputer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbb_ChooseComp;
        private System.Windows.Forms.Button btn_ok;
    }
}