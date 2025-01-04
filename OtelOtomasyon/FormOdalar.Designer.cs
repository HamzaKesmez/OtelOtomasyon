namespace OtelOtomasyon
{
    partial class FormOdalar
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
            this.panelOdalar = new System.Windows.Forms.Panel();
            this.bilgiPanel = new System.Windows.Forms.Panel();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblYatakSayisi = new System.Windows.Forms.Label();
            this.lblKatNo = new System.Windows.Forms.Label();
            this.lblOdaNo = new System.Windows.Forms.Label();
            this.bilgiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOdalar
            // 
            this.panelOdalar.Location = new System.Drawing.Point(12, 12);
            this.panelOdalar.Name = "panelOdalar";
            this.panelOdalar.Size = new System.Drawing.Size(394, 426);
            this.panelOdalar.TabIndex = 0;
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.Controls.Add(this.lblDurum);
            this.bilgiPanel.Controls.Add(this.lblFiyat);
            this.bilgiPanel.Controls.Add(this.lblYatakSayisi);
            this.bilgiPanel.Controls.Add(this.lblKatNo);
            this.bilgiPanel.Controls.Add(this.lblOdaNo);
            this.bilgiPanel.Location = new System.Drawing.Point(412, 104);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(222, 241);
            this.bilgiPanel.TabIndex = 1;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(3, 121);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(44, 13);
            this.lblDurum.TabIndex = 4;
            this.lblDurum.Text = "Durum: ";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(3, 99);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(35, 13);
            this.lblFiyat.TabIndex = 3;
            this.lblFiyat.Text = "Fiyat: ";
            // 
            // lblYatakSayisi
            // 
            this.lblYatakSayisi.AutoSize = true;
            this.lblYatakSayisi.Location = new System.Drawing.Point(3, 77);
            this.lblYatakSayisi.Name = "lblYatakSayisi";
            this.lblYatakSayisi.Size = new System.Drawing.Size(71, 13);
            this.lblYatakSayisi.TabIndex = 2;
            this.lblYatakSayisi.Text = "Yatak Sayısı: ";
            // 
            // lblKatNo
            // 
            this.lblKatNo.AutoSize = true;
            this.lblKatNo.Location = new System.Drawing.Point(3, 54);
            this.lblKatNo.Name = "lblKatNo";
            this.lblKatNo.Size = new System.Drawing.Size(46, 13);
            this.lblKatNo.TabIndex = 1;
            this.lblKatNo.Text = "Kat No: ";
            // 
            // lblOdaNo
            // 
            this.lblOdaNo.AutoSize = true;
            this.lblOdaNo.Location = new System.Drawing.Point(3, 31);
            this.lblOdaNo.Name = "lblOdaNo";
            this.lblOdaNo.Size = new System.Drawing.Size(50, 13);
            this.lblOdaNo.TabIndex = 0;
            this.lblOdaNo.Text = "Oda No: ";
            // 
            // FormOdalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.bilgiPanel);
            this.Controls.Add(this.panelOdalar);
            this.Name = "FormOdalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOdalar";
            this.Load += new System.EventHandler(this.FormOdalar_Load);
            this.bilgiPanel.ResumeLayout(false);
            this.bilgiPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOdalar;
        private System.Windows.Forms.Panel bilgiPanel;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblYatakSayisi;
        private System.Windows.Forms.Label lblKatNo;
        private System.Windows.Forms.Label lblOdaNo;
    }
}