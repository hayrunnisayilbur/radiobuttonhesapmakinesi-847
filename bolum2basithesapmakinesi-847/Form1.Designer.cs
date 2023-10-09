namespace bolum2basithesapmakinesi_847
{
    partial class pl
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
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.lblSayi2 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.rbTopla = new System.Windows.Forms.RadioButton();
            this.rbCikar = new System.Windows.Forms.RadioButton();
            this.rbCarp = new System.Windows.Forms.RadioButton();
            this.rbBol = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Location = new System.Drawing.Point(108, 65);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(34, 13);
            this.lblSayi1.TabIndex = 0;
            this.lblSayi1.Text = "sayi1:";
            // 
            // lblSayi2
            // 
            this.lblSayi2.AutoSize = true;
            this.lblSayi2.Location = new System.Drawing.Point(108, 101);
            this.lblSayi2.Name = "lblSayi2";
            this.lblSayi2.Size = new System.Drawing.Size(34, 13);
            this.lblSayi2.TabIndex = 1;
            this.lblSayi2.Text = "sayi2:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(108, 156);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(41, 13);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Text = "Sonuç:";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(161, 62);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(136, 20);
            this.txtSayi1.TabIndex = 3;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(161, 101);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(136, 20);
            this.txtSayi2.TabIndex = 4;
            // 
            // rbTopla
            // 
            this.rbTopla.AutoSize = true;
            this.rbTopla.Location = new System.Drawing.Point(106, 196);
            this.rbTopla.Name = "rbTopla";
            this.rbTopla.Size = new System.Drawing.Size(48, 17);
            this.rbTopla.TabIndex = 5;
            this.rbTopla.TabStop = true;
            this.rbTopla.Text = "topla";
            this.rbTopla.UseVisualStyleBackColor = true;
            // 
            // rbCikar
            // 
            this.rbCikar.AutoSize = true;
            this.rbCikar.Location = new System.Drawing.Point(212, 196);
            this.rbCikar.Name = "rbCikar";
            this.rbCikar.Size = new System.Drawing.Size(48, 17);
            this.rbCikar.TabIndex = 6;
            this.rbCikar.TabStop = true;
            this.rbCikar.Text = "çıkar";
            this.rbCikar.UseVisualStyleBackColor = true;
            // 
            // rbCarp
            // 
            this.rbCarp.AutoSize = true;
            this.rbCarp.Location = new System.Drawing.Point(106, 234);
            this.rbCarp.Name = "rbCarp";
            this.rbCarp.Size = new System.Drawing.Size(46, 17);
            this.rbCarp.TabIndex = 7;
            this.rbCarp.TabStop = true;
            this.rbCarp.Text = "çarp";
            this.rbCarp.UseVisualStyleBackColor = true;
            // 
            // rbBol
            // 
            this.rbBol.AutoSize = true;
            this.rbBol.Location = new System.Drawing.Point(212, 234);
            this.rbBol.Name = "rbBol";
            this.rbBol.Size = new System.Drawing.Size(39, 17);
            this.rbBol.TabIndex = 8;
            this.rbBol.TabStop = true;
            this.rbBol.Text = "böl";
            this.rbBol.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(106, 268);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(191, 37);
            this.btnHesapla.TabIndex = 9;
            this.btnHesapla.Text = "hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // pl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.rbBol);
            this.Controls.Add(this.rbCarp);
            this.Controls.Add(this.rbCikar);
            this.Controls.Add(this.rbTopla);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblSayi2);
            this.Controls.Add(this.lblSayi1);
            this.Name = "pl";
            this.Text = "topla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.Label lblSayi2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.RadioButton rbTopla;
        private System.Windows.Forms.RadioButton rbCikar;
        private System.Windows.Forms.RadioButton rbCarp;
        private System.Windows.Forms.RadioButton rbBol;
        private System.Windows.Forms.Button btnHesapla;
    }
}

