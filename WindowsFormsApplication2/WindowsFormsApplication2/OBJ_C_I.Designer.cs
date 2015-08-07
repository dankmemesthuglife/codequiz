namespace WindowsFormsApplication2
{
    partial class Obj_C_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Obj_C_info));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Obj_C_Info_Label = new System.Windows.Forms.Label();
            this.Obj_C_Info_Text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Obj_C_Info_Label
            // 
            this.Obj_C_Info_Label.AutoSize = true;
            this.Obj_C_Info_Label.BackColor = System.Drawing.Color.Transparent;
            this.Obj_C_Info_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Obj_C_Info_Label.Location = new System.Drawing.Point(2, 22);
            this.Obj_C_Info_Label.Name = "Obj_C_Info_Label";
            this.Obj_C_Info_Label.Size = new System.Drawing.Size(361, 31);
            this.Obj_C_Info_Label.TabIndex = 0;
            this.Obj_C_Info_Label.Text = "Information on Objective C";
            // 
            // Obj_C_Info_Text
            // 
            this.Obj_C_Info_Text.Location = new System.Drawing.Point(12, 133);
            this.Obj_C_Info_Text.Multiline = true;
            this.Obj_C_Info_Text.Name = "Obj_C_Info_Text";
            this.Obj_C_Info_Text.ReadOnly = true;
            this.Obj_C_Info_Text.Size = new System.Drawing.Size(426, 81);
            this.Obj_C_Info_Text.TabIndex = 1;
            this.Obj_C_Info_Text.Text = resources.GetString("Obj_C_Info_Text.Text");
            // 
            // Obj_C_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.DONT_DELETE_THIS_PATCH;
            this.ClientSize = new System.Drawing.Size(450, 392);
            this.Controls.Add(this.Obj_C_Info_Text);
            this.Controls.Add(this.Obj_C_Info_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Obj_C_info";
            this.Text = "Objective C Information";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox Obj_C_Info_Text;
        private System.Windows.Forms.Label Obj_C_Info_Label;
    }
}