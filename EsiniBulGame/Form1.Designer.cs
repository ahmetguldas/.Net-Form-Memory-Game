
namespace EsiniBulGame
{
    partial class Form1
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
            this.pnlKartlar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pnlKartlar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlKartlar
            // 
            this.pnlKartlar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlKartlar.Location = new System.Drawing.Point(21, 21);
            this.pnlKartlar.Margin = new System.Windows.Forms.Padding(12);
            this.pnlKartlar.Name = "pnlKartlar";
            this.pnlKartlar.Size = new System.Drawing.Size(1000, 1000);
            this.pnlKartlar.TabIndex = 0;
            this.pnlKartlar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 1043);
            this.Controls.Add(this.pnlKartlar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esini Bul";
            ((System.ComponentModel.ISupportInitialize)(this.pnlKartlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pnlKartlar;
    }
}

