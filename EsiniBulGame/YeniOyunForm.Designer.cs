﻿
namespace EsiniBulGame
{
    partial class YeniOyunForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnZor = new System.Windows.Forms.RadioButton();
            this.rbtnOrta = new System.Windows.Forms.RadioButton();
            this.rbtnKolay = new System.Windows.Forms.RadioButton();
            this.btnOyunuBaslat = new System.Windows.Forms.Button();
            this.btnOyunuKapat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rbtnZor);
            this.groupBox1.Controls.Add(this.rbtnOrta);
            this.groupBox1.Controls.Add(this.rbtnKolay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(75, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ZORLUK SEVIYESI";
            // 
            // rbtnZor
            // 
            this.rbtnZor.AutoSize = true;
            this.rbtnZor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnZor.Location = new System.Drawing.Point(42, 250);
            this.rbtnZor.Name = "rbtnZor";
            this.rbtnZor.Size = new System.Drawing.Size(218, 48);
            this.rbtnZor.TabIndex = 0;
            this.rbtnZor.Text = "ZOR(8x8)";
            this.rbtnZor.UseVisualStyleBackColor = true;
            // 
            // rbtnOrta
            // 
            this.rbtnOrta.AutoSize = true;
            this.rbtnOrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOrta.Location = new System.Drawing.Point(42, 164);
            this.rbtnOrta.Name = "rbtnOrta";
            this.rbtnOrta.Size = new System.Drawing.Size(243, 48);
            this.rbtnOrta.TabIndex = 0;
            this.rbtnOrta.Text = "ORTA(6x6)";
            this.rbtnOrta.UseVisualStyleBackColor = true;
            // 
            // rbtnKolay
            // 
            this.rbtnKolay.AutoSize = true;
            this.rbtnKolay.Checked = true;
            this.rbtnKolay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnKolay.Location = new System.Drawing.Point(42, 78);
            this.rbtnKolay.Name = "rbtnKolay";
            this.rbtnKolay.Size = new System.Drawing.Size(263, 48);
            this.rbtnKolay.TabIndex = 0;
            this.rbtnKolay.TabStop = true;
            this.rbtnKolay.Text = "KOLAY(4x4)";
            this.rbtnKolay.UseVisualStyleBackColor = true;
            // 
            // btnOyunuBaslat
            // 
            this.btnOyunuBaslat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOyunuBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOyunuBaslat.Location = new System.Drawing.Point(75, 466);
            this.btnOyunuBaslat.Name = "btnOyunuBaslat";
            this.btnOyunuBaslat.Size = new System.Drawing.Size(338, 84);
            this.btnOyunuBaslat.TabIndex = 1;
            this.btnOyunuBaslat.Text = "OYUNU BASLAT";
            this.btnOyunuBaslat.UseVisualStyleBackColor = true;
            this.btnOyunuBaslat.Click += new System.EventHandler(this.btnOyunuBaslat_Click);
            // 
            // btnOyunuKapat
            // 
            this.btnOyunuKapat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOyunuKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOyunuKapat.Location = new System.Drawing.Point(75, 556);
            this.btnOyunuKapat.Name = "btnOyunuKapat";
            this.btnOyunuKapat.Size = new System.Drawing.Size(338, 84);
            this.btnOyunuKapat.TabIndex = 1;
            this.btnOyunuKapat.Text = "OYUNU KAPAT";
            this.btnOyunuKapat.UseVisualStyleBackColor = true;
            this.btnOyunuKapat.Click += new System.EventHandler(this.btnOyunuKapat_Click);
            // 
            // YeniOyunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 748);
            this.Controls.Add(this.btnOyunuKapat);
            this.Controls.Add(this.btnOyunuBaslat);
            this.Controls.Add(this.groupBox1);
            this.Name = "YeniOyunForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Oyun Esini Bul";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnZor;
        private System.Windows.Forms.RadioButton rbtnOrta;
        private System.Windows.Forms.RadioButton rbtnKolay;
        private System.Windows.Forms.Button btnOyunuBaslat;
        private System.Windows.Forms.Button btnOyunuKapat;
    }
}