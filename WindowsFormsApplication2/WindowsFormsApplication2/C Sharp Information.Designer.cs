namespace WindowsFormsApplication2
{
    partial class C_Sharp_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C_Sharp_Info));
            this.C_Sharp_Label = new System.Windows.Forms.Label();
            this.C_Sharp_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // C_Sharp_Label
            // 
            this.C_Sharp_Label.AutoSize = true;
            this.C_Sharp_Label.BackColor = System.Drawing.Color.Transparent;
            this.C_Sharp_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Sharp_Label.Location = new System.Drawing.Point(12, 24);
            this.C_Sharp_Label.Name = "C_Sharp_Label";
            this.C_Sharp_Label.Size = new System.Drawing.Size(246, 31);
            this.C_Sharp_Label.TabIndex = 0;
            this.C_Sharp_Label.Text = "Information on C#";
            this.C_Sharp_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // C_Sharp_Text
            // 
            this.C_Sharp_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C_Sharp_Text.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.C_Sharp_Text.HideSelection = false;
            this.C_Sharp_Text.Location = new System.Drawing.Point(18, 146);
            this.C_Sharp_Text.Multiline = true;
            this.C_Sharp_Text.Name = "C_Sharp_Text";
            this.C_Sharp_Text.ReadOnly = true;
            this.C_Sharp_Text.Size = new System.Drawing.Size(407, 78);
            this.C_Sharp_Text.TabIndex = 1;
            this.C_Sharp_Text.Text = resources.GetString("C_Sharp_Text.Text");
            // 
            // C_Sharp_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.DONT_DELETE_THIS_PATCH;
            this.ClientSize = new System.Drawing.Size(450, 402);
            this.Controls.Add(this.C_Sharp_Text);
            this.Controls.Add(this.C_Sharp_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "C_Sharp_Info";
            this.Text = "C# Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label C_Sharp_Label;
        private System.Windows.Forms.TextBox C_Sharp_Text;
    }
}