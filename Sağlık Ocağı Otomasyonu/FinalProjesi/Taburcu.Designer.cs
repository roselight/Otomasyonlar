namespace FinalProjesi
{
    partial class Taburcu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdosyano = new System.Windows.Forms.TextBox();
            this.cmbodeme = new System.Windows.Forms.ComboBox();
            this.dtcikis = new System.Windows.Forms.DateTimePicker();
            this.txttoplamtutar = new System.Windows.Forms.TextBox();
            this.dtsevktarihi = new System.Windows.Forms.DateTimePicker();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sevk Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Çıkış Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ödeme Şekli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Toplam Tutar";
            // 
            // txtdosyano
            // 
            this.txtdosyano.Location = new System.Drawing.Point(157, 24);
            this.txtdosyano.Name = "txtdosyano";
            this.txtdosyano.Size = new System.Drawing.Size(200, 22);
            this.txtdosyano.TabIndex = 1;
            // 
            // cmbodeme
            // 
            this.cmbodeme.FormattingEnabled = true;
            this.cmbodeme.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı-Taksitli",
            "Kredi Kartı-Tek Çekim",
            "Çek",
            "Senet"});
            this.cmbodeme.Location = new System.Drawing.Point(157, 150);
            this.cmbodeme.Name = "cmbodeme";
            this.cmbodeme.Size = new System.Drawing.Size(205, 24);
            this.cmbodeme.TabIndex = 2;
            // 
            // dtcikis
            // 
            this.dtcikis.Location = new System.Drawing.Point(157, 108);
            this.dtcikis.Name = "dtcikis";
            this.dtcikis.Size = new System.Drawing.Size(200, 22);
            this.dtcikis.TabIndex = 3;
            // 
            // txttoplamtutar
            // 
            this.txttoplamtutar.Location = new System.Drawing.Point(157, 194);
            this.txttoplamtutar.Name = "txttoplamtutar";
            this.txttoplamtutar.Size = new System.Drawing.Size(205, 22);
            this.txttoplamtutar.TabIndex = 1;
            // 
            // dtsevktarihi
            // 
            this.dtsevktarihi.Location = new System.Drawing.Point(157, 66);
            this.dtsevktarihi.Name = "dtsevktarihi";
            this.dtsevktarihi.Size = new System.Drawing.Size(200, 22);
            this.dtsevktarihi.TabIndex = 3;
            this.dtsevktarihi.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(29, 249);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(108, 43);
            this.btnVazgec.TabIndex = 4;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(254, 249);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(108, 43);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.button2_Click);
            // 
            // Taburcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(387, 316);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.dtsevktarihi);
            this.Controls.Add(this.dtcikis);
            this.Controls.Add(this.cmbodeme);
            this.Controls.Add(this.txttoplamtutar);
            this.Controls.Add(this.txtdosyano);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Taburcu";
            this.Text = "SOHATS-Taburcu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdosyano;
        private System.Windows.Forms.ComboBox cmbodeme;
        private System.Windows.Forms.DateTimePicker dtcikis;
        private System.Windows.Forms.TextBox txttoplamtutar;
        private System.Windows.Forms.DateTimePicker dtsevktarihi;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnKaydet;
    }
}