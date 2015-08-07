namespace WindowsFormsApplication2
{
    partial class PHP_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PHP_Info));
            this.PHP_Info_Text = new System.Windows.Forms.TextBox();
            this.PHP_Info_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PHP_Info_Text
            // 
            this.PHP_Info_Text.Cursor = System.Windows.Forms.Cursors.Default;
            this.PHP_Info_Text.Location = new System.Drawing.Point(12, 127);
            this.PHP_Info_Text.Multiline = true;
            this.PHP_Info_Text.Name = "PHP_Info_Text";
            this.PHP_Info_Text.ReadOnly = true;
            this.PHP_Info_Text.Size = new System.Drawing.Size(425, 111);
            this.PHP_Info_Text.TabIndex = 0;
            this.PHP_Info_Text.Text = resources.GetString("PHP_Info_Text.Text");
            // 
            // PHP_Info_Label
            // 
            this.PHP_Info_Label.AutoSize = true;
            this.PHP_Info_Label.BackColor = System.Drawing.Color.Transparent;
            this.PHP_Info_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PHP_Info_Label.Location = new System.Drawing.Point(12, 20);
            this.PHP_Info_Label.Name = "PHP_Info_Label";
            this.PHP_Info_Label.Size = new System.Drawing.Size(268, 31);
            this.PHP_Info_Label.TabIndex = 1;
            this.PHP_Info_Label.Text = "Information on PHP";
            // 
            // PHP_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.DONT_DELETE_THIS_PATCH;
            this.ClientSize = new System.Drawing.Size(449, 397);
            this.Controls.Add(this.PHP_Info_Label);
            this.Controls.Add(this.PHP_Info_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PHP_Info";
            this.Text = "PHP Information";
            this.Load += new System.EventHandler(this.PHP_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PHP_Info_Text;
        private System.Windows.Forms.Label PHP_Info_Label;
    }
}