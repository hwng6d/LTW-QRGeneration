namespace QuanLyMaQR_v2.Views
{
    partial class FormQRsInGrid
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
            this.picDetailedView = new System.Windows.Forms.PictureBox();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnSaveTo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDetailedView)).BeginInit();
            this.SuspendLayout();
            // 
            // picDetailedView
            // 
            this.picDetailedView.Location = new System.Drawing.Point(10, 34);
            this.picDetailedView.Name = "picDetailedView";
            this.picDetailedView.Size = new System.Drawing.Size(380, 380);
            this.picDetailedView.TabIndex = 0;
            this.picDetailedView.TabStop = false;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(1245, 1026);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAs.TabIndex = 1;
            this.btnSaveAs.Text = "Lưu vào...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            // 
            // btnSaveTo
            // 
            this.btnSaveTo.Location = new System.Drawing.Point(312, 5);
            this.btnSaveTo.Name = "btnSaveTo";
            this.btnSaveTo.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTo.TabIndex = 2;
            this.btnSaveTo.Text = "Lưu vào...";
            this.btnSaveTo.UseVisualStyleBackColor = true;
            this.btnSaveTo.Click += new System.EventHandler(this.btnSaveTo_Click);
            // 
            // FormQRsInGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(399, 420);
            this.Controls.Add(this.btnSaveTo);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.picDetailedView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQRsInGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem";
            this.Load += new System.EventHandler(this.FormQRsInGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDetailedView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDetailedView;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnSaveTo;
    }
}