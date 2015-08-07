namespace WindowsFormsApplication2
{
    partial class Java_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Java_Info));
            this.Java_Info_Text = new System.Windows.Forms.TextBox();
            this.Java_Info_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Java_Info_Text
            // 
            this.Java_Info_Text.Cursor = System.Windows.Forms.Cursors.Default;
            this.Java_Info_Text.HideSelection = false;
            this.Java_Info_Text.Location = new System.Drawing.Point(12, 118);
            this.Java_Info_Text.Multiline = true;
            this.Java_Info_Text.Name = "Java_Info_Text";
            this.Java_Info_Text.ReadOnly = true;
            this.Java_Info_Text.Size = new System.Drawing.Size(424, 119);
            this.Java_Info_Text.TabIndex = 0;
            this.Java_Info_Text.Text = resources.GetString("Java_Info_Text.Text");
            this.Java_Info_Text.TextChanged += new System.EventHandler(this.Java_Info_Text_TextChanged);
            // 
            // Java_Info_Label
            // 
            this.Java_Info_Label.AutoSize = true;
            this.Java_Info_Label.BackColor = System.Drawing.Color.Transparent;
            this.Java_Info_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Java_Info_Label.Location = new System.Drawing.Point(6, 22);
            this.Java_Info_Label.Name = "Java_Info_Label";
            this.Java_Info_Label.Size = new System.Drawing.Size(271, 31);
            this.Java_Info_Label.TabIndex = 1;
            this.Java_Info_Label.Text = "Information on Java";
            // 
            // Java_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.DONT_DELETE_THIS_PATCH;
            this.ClientSize = new System.Drawing.Size(448, 390);
            this.Controls.Add(this.Java_Info_Label);
            this.Controls.Add(this.Java_Info_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Java_Info";
            this.Text = "Java Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Java_Info_Text;
        private System.Windows.Forms.Label Java_Info_Label;
    }
}