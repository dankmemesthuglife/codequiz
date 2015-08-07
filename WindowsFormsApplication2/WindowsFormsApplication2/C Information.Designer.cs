namespace WindowsFormsApplication2
{
    partial class C_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_Info));
            this.C_Info_Text = new System.Windows.Forms.TextBox();
            this.C_Info_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // C_Info_Text
            // 
            this.C_Info_Text.AllowDrop = true;
            this.C_Info_Text.BackColor = System.Drawing.Color.Gainsboro;
            this.C_Info_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C_Info_Text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.C_Info_Text.Enabled = false;
            this.C_Info_Text.HideSelection = false;
            this.C_Info_Text.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.C_Info_Text.Location = new System.Drawing.Point(18, 124);
            this.C_Info_Text.Multiline = true;
            this.C_Info_Text.Name = "C_Info_Text";
            this.C_Info_Text.ReadOnly = true;
            this.C_Info_Text.Size = new System.Drawing.Size(422, 129);
            this.C_Info_Text.TabIndex = 0;
            this.C_Info_Text.Text = resources.GetString("C_Info_Text.Text");
            // 
            // C_Info_Label
            // 
            this.C_Info_Label.AutoSize = true;
            this.C_Info_Label.BackColor = System.Drawing.Color.Transparent;
            this.C_Info_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Info_Label.Location = new System.Drawing.Point(12, 25);
            this.C_Info_Label.Name = "C_Info_Label";
            this.C_Info_Label.Size = new System.Drawing.Size(230, 31);
            this.C_Info_Label.TabIndex = 1;
            this.C_Info_Label.Text = "Information on C";
            // 
            // C_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.DONT_DELETE_THIS_PATCH;
            this.ClientSize = new System.Drawing.Size(449, 395);
            this.Controls.Add(this.C_Info_Label);
            this.Controls.Add(this.C_Info_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "C_Info";
            this.Text = "C Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label C_Info_Label;
        public System.Windows.Forms.TextBox C_Info_Text;
    }
}