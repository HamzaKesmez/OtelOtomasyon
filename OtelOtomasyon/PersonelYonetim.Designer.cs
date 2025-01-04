namespace OtelOtomasyon
{
    partial class PersonelYonetim
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
            this.adBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soyadBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.parolaBox = new System.Windows.Forms.TextBox();
            this.pozisyonBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maasBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kayitBut = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // adBox
            // 
            this.adBox.Location = new System.Drawing.Point(614, 89);
            this.adBox.Name = "adBox";
            this.adBox.Size = new System.Drawing.Size(100, 20);
            this.adBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyad";
            // 
            // soyadBox
            // 
            this.soyadBox.Location = new System.Drawing.Point(614, 115);
            this.soyadBox.Name = "soyadBox";
            this.soyadBox.Size = new System.Drawing.Size(100, 20);
            this.soyadBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Parola";
            // 
            // parolaBox
            // 
            this.parolaBox.Location = new System.Drawing.Point(614, 193);
            this.parolaBox.Name = "parolaBox";
            this.parolaBox.Size = new System.Drawing.Size(100, 20);
            this.parolaBox.TabIndex = 12;
            // 
            // pozisyonBox
            // 
            this.pozisyonBox.Location = new System.Drawing.Point(614, 141);
            this.pozisyonBox.Name = "pozisyonBox";
            this.pozisyonBox.Size = new System.Drawing.Size(100, 20);
            this.pozisyonBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pozisyon";
            // 
            // maasBox
            // 
            this.maasBox.Location = new System.Drawing.Point(614, 167);
            this.maasBox.Name = "maasBox";
            this.maasBox.Size = new System.Drawing.Size(100, 20);
            this.maasBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Maas";
            // 
            // kayitBut
            // 
            this.kayitBut.Location = new System.Drawing.Point(614, 219);
            this.kayitBut.Name = "kayitBut";
            this.kayitBut.Size = new System.Drawing.Size(100, 23);
            this.kayitBut.TabIndex = 15;
            this.kayitBut.Text = "Kayıt";
            this.kayitBut.UseVisualStyleBackColor = true;
            this.kayitBut.Click += new System.EventHandler(this.kayitBut_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(541, 313);
            this.dgv.TabIndex = 16;
            // 
            // PersonelYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.kayitBut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.parolaBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maasBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pozisyonBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soyadBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adBox);
            this.Name = "PersonelYonetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelYonetim";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox soyadBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox parolaBox;
        private System.Windows.Forms.TextBox pozisyonBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maasBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button kayitBut;
        private System.Windows.Forms.DataGridView dgv;
    }
}