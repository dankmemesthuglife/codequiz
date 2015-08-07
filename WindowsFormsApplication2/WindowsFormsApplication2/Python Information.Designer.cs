namespace WindowsFormsApplication2
{
    partial class Python_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Python_Info));
            this.Java_Info_Label = new System.Windows.Forms.Label();
            this.Java_Info_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Java_Info_Label
            // 
            this.Java_Info_Label.AutoSize = true;
            this.Java_Info_Label.BackColor = System.Drawing.Color.Transparent;
            this.Java_Info_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Java_Info_Label.Location = new System.Drawing.Point(12, 20);
            this.Java_Info_Label.Name = "Java_Info_Label";
            this.Java_Info_Label.Size = new System.Drawing.Size(300, 31);
            this.Java_Info_Label.TabIndex = 2;
            this.Java_Info_Label.Text = "Information on Python";
            // 
            // Java_Info_Text
            // 
            this.Java_Info_Text.Cursor = System.Windows.Forms.Cursors.Default;
            this.Java_Info_Text.HideSelection = false;
            this.Java_Info_Text.Location = new System.Drawing.Point(11, 130);
            this.Java_Info_Text.Multiline = true;
            this.Java_Info_Text.Name = "Java_Info_Text";
            this.Java_Info_Text.ReadOnly = true;
            this.Java_Info_Text.Size = new System.Drawing.Size(424, 119);
            this.Java_Info_Text.TabIndex = 3;
            this.Java_Info_Text.Text = resources.GetString("Java_Info_Text.Text");
            // 
            // Python_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.DONT_DELETE_THIS_PATCH;
            this.ClientSize = new System.Drawing.Size(447, 398);
            this.Controls.Add(this.Java_Info_Text);
            this.Controls.Add(this.Java_Info_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Python_Info";
            this.Text = "Python Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Java_Info_Label;
        private System.Windows.Forms.TextBox Java_Info_Text;
    }
}