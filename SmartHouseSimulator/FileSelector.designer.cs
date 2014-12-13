namespace ARM_Mobile_Multimedia_CMS
{
    partial class FileSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Browse = new System.Windows.Forms.Button();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Preview = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pic_Preview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(302, 27);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 0;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // txt_FileName
            // 
            this.txt_FileName.Location = new System.Drawing.Point(6, 29);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(290, 20);
            this.txt_FileName.TabIndex = 1;
            this.txt_FileName.TextChanged += new System.EventHandler(this.txt_FileName_TextChanged);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(3, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(30, 13);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Title:";
            // 
            // lbl_Preview
            // 
            this.lbl_Preview.AutoSize = true;
            this.lbl_Preview.Location = new System.Drawing.Point(380, 0);
            this.lbl_Preview.Name = "lbl_Preview";
            this.lbl_Preview.Size = new System.Drawing.Size(45, 13);
            this.lbl_Preview.TabIndex = 5;
            this.lbl_Preview.Text = "Preview";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All Files|*.*";
            this.openFileDialog1.SupportMultiDottedExtensions = true;
            this.openFileDialog1.Title = "Select File";
            // 
            // pic_Preview
            // 
            this.pic_Preview.Location = new System.Drawing.Point(386, 23);
            this.pic_Preview.Name = "pic_Preview";
            this.pic_Preview.Size = new System.Drawing.Size(34, 34);
            this.pic_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Preview.TabIndex = 4;
            this.pic_Preview.TabStop = false;
            this.pic_Preview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_Preview_MouseClick);
            // 
            // FileSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_Preview);
            this.Controls.Add(this.pic_Preview);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txt_FileName);
            this.Controls.Add(this.btn_Browse);
            this.Name = "FileSelector";
            this.Size = new System.Drawing.Size(428, 60);
            this.Load += new System.EventHandler(this.FileSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.TextBox txt_FileName;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox pic_Preview;
        private System.Windows.Forms.Label lbl_Preview;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
