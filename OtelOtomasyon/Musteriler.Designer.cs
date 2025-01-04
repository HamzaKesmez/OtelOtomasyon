namespace OtelOtomasyon
{
    partial class Musteriler
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bulTextBox = new System.Windows.Forms.TextBox();
            this.bulButon = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(9, 10);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(580, 419);
            this.dgv.TabIndex = 0;
            // 
            // bulTextBox
            // 
            this.bulTextBox.Location = new System.Drawing.Point(627, 123);
            this.bulTextBox.Name = "bulTextBox";
            this.bulTextBox.Size = new System.Drawing.Size(81, 20);
            this.bulTextBox.TabIndex = 1;
            // 
            // bulButon
            // 
            this.bulButon.Location = new System.Drawing.Point(627, 189);
            this.bulButon.Name = "bulButon";
            this.bulButon.Size = new System.Drawing.Size(78, 28);
            this.bulButon.TabIndex = 2;
            this.bulButon.Text = "Ara";
            this.bulButon.UseVisualStyleBackColor = true;
            this.bulButon.Click += new System.EventHandler(this.bulButon_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Resepsiyon",
            "Online"});
            this.checkedListBox.Location = new System.Drawing.Point(627, 149);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(120, 34);
            this.checkedListBox.TabIndex = 3;
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 440);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.bulButon);
            this.Controls.Add(this.bulTextBox);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Musteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteriler";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox bulTextBox;
        private System.Windows.Forms.Button bulButon;
        private System.Windows.Forms.CheckedListBox checkedListBox;
    }
}