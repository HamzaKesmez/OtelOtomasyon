namespace OtelOtomasyon
{
    partial class Oturum
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
            this.kulAdBox = new System.Windows.Forms.TextBox();
            this.parolaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.girisBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kulAdBox
            // 
            this.kulAdBox.Location = new System.Drawing.Point(137, 86);
            this.kulAdBox.Name = "kulAdBox";
            this.kulAdBox.Size = new System.Drawing.Size(91, 20);
            this.kulAdBox.TabIndex = 0;
            // 
            // parolaBox
            // 
            this.parolaBox.Location = new System.Drawing.Point(137, 108);
            this.parolaBox.Name = "parolaBox";
            this.parolaBox.PasswordChar = '*';
            this.parolaBox.Size = new System.Drawing.Size(91, 20);
            this.parolaBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola";
            // 
            // girisBut
            // 
            this.girisBut.Location = new System.Drawing.Point(137, 134);
            this.girisBut.Name = "girisBut";
            this.girisBut.Size = new System.Drawing.Size(75, 23);
            this.girisBut.TabIndex = 4;
            this.girisBut.Text = "Giris";
            this.girisBut.UseVisualStyleBackColor = true;
            this.girisBut.Click += new System.EventHandler(this.girisBut_Click);
            // 
            // Oturum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 239);
            this.Controls.Add(this.girisBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parolaBox);
            this.Controls.Add(this.kulAdBox);
            this.Name = "Oturum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oturum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kulAdBox;
        private System.Windows.Forms.TextBox parolaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button girisBut;
    }
}