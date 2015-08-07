namespace WindowsFormsApplication2
{
    partial class End
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Welcome_Label = new System.Windows.Forms.Label();
            this.Result_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(147, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 106);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Welcome_Label
            // 
            this.Welcome_Label.AutoSize = true;
            this.Welcome_Label.BackColor = System.Drawing.Color.Transparent;
            this.Welcome_Label.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome_Label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Welcome_Label.Location = new System.Drawing.Point(12, 9);
            this.Welcome_Label.Name = "Welcome_Label";
            this.Welcome_Label.Size = new System.Drawing.Size(253, 59);
            this.Welcome_Label.TabIndex = 2;
            this.Welcome_Label.Text = "End of Quiz";
            this.Welcome_Label.Click += new System.EventHandler(this.Welcome_Label_Click);
            // 
            // Result_lbl
            // 
            this.Result_lbl.AllowDrop = true;
            this.Result_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Result_lbl.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_lbl.Location = new System.Drawing.Point(12, 77);
            this.Result_lbl.Name = "Result_lbl";
            this.Result_lbl.Size = new System.Drawing.Size(413, 122);
            this.Result_lbl.TabIndex = 3;
            this.Result_lbl.Text = "Your Result:";
            // 
            // End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.DONT_DELETE_THIS_PATCH;
            this.ClientSize = new System.Drawing.Size(449, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Result_lbl);
            this.Controls.Add(this.Welcome_Label);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "End";
            this.Text = "End";
            this.Load += new System.EventHandler(this.End_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Welcome_Label;
        private System.Windows.Forms.Label Result_lbl;
    }
}