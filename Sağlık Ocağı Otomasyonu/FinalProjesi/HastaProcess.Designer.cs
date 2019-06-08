namespace FinalProjesi
{
    partial class HastaProcess
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaProcess));
            this.txtdosyano = new System.Windows.Forms.TextBox();
            this.txtKurumAdi = new System.Windows.Forms.TextBox();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.txthastaSoyadi = new System.Windows.Forms.TextBox();
            this.cmbOncekislemler = new System.Windows.Forms.ComboBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnGit = new System.Windows.Forms.Button();
            this.btnHastaBilgileri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbyapilanislem = new System.Windows.Forms.ComboBox();
            this.cmbpolik = new System.Windows.Forms.ComboBox();
            this.cmbdrkodu = new System.Windows.Forms.ComboBox();
            this.txtsirano = new System.Windows.Forms.TextBox();
            this.txtbirimfiyat = new System.Windows.Forms.TextBox();
            this.numericmiktar = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSeçSil = new System.Windows.Forms.Button();
            this.btnTAburcu = new System.Windows.Forms.Button();
            this.btnyazdir = new System.Windows.Forms.Button();
            this.btnbaskionizleme = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtsevk = new System.Windows.Forms.DateTimePicker();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericmiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdosyano
            // 
            this.txtdosyano.Location = new System.Drawing.Point(119, 25);
            this.txtdosyano.Name = "txtdosyano";
            this.txtdosyano.Size = new System.Drawing.Size(113, 22);
            this.txtdosyano.TabIndex = 0;
            this.txtdosyano.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdosyano_KeyDown);
            // 
            // txtKurumAdi
            // 
            this.txtKurumAdi.Location = new System.Drawing.Point(456, 88);
            this.txtKurumAdi.Name = "txtKurumAdi";
            this.txtKurumAdi.Size = new System.Drawing.Size(100, 22);
            this.txtKurumAdi.TabIndex = 7;
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(456, 32);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(100, 22);
            this.txtHastaAdi.TabIndex = 5;
            // 
            // txthastaSoyadi
            // 
            this.txthastaSoyadi.Location = new System.Drawing.Point(456, 60);
            this.txthastaSoyadi.Name = "txthastaSoyadi";
            this.txthastaSoyadi.Size = new System.Drawing.Size(100, 22);
            this.txthastaSoyadi.TabIndex = 6;
            // 
            // cmbOncekislemler
            // 
            this.cmbOncekislemler.FormattingEnabled = true;
            this.cmbOncekislemler.Location = new System.Drawing.Point(119, 88);
            this.cmbOncekislemler.Name = "cmbOncekislemler";
            this.cmbOncekislemler.Size = new System.Drawing.Size(113, 24);
            this.cmbOncekislemler.TabIndex = 3;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(238, 24);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGit
            // 
            this.btnGit.Location = new System.Drawing.Point(238, 89);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(75, 23);
            this.btnGit.TabIndex = 4;
            this.btnGit.Text = "Git";
            this.btnGit.UseVisualStyleBackColor = true;
            this.btnGit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHastaBilgileri
            // 
            this.btnHastaBilgileri.Location = new System.Drawing.Point(562, 32);
            this.btnHastaBilgileri.Name = "btnHastaBilgileri";
            this.btnHastaBilgileri.Size = new System.Drawing.Size(197, 75);
            this.btnHastaBilgileri.TabIndex = 7;
            this.btnHastaBilgileri.Text = "Hasta Bilgileri";
            this.btnHastaBilgileri.UseVisualStyleBackColor = true;
            this.btnHastaBilgileri.Click += new System.EventHandler(this.btnHastaBilgileri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dosya No **";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sevk Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Önceki İşlemler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasta Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Soyadı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Kurum Adı";
            // 
            // cmbyapilanislem
            // 
            this.cmbyapilanislem.FormattingEnabled = true;
            this.cmbyapilanislem.Location = new System.Drawing.Point(245, 173);
            this.cmbyapilanislem.Name = "cmbyapilanislem";
            this.cmbyapilanislem.Size = new System.Drawing.Size(121, 24);
            this.cmbyapilanislem.TabIndex = 10;
            // 
            // cmbpolik
            // 
            this.cmbpolik.FormattingEnabled = true;
            this.cmbpolik.Location = new System.Drawing.Point(12, 173);
            this.cmbpolik.Name = "cmbpolik";
            this.cmbpolik.Size = new System.Drawing.Size(121, 24);
            this.cmbpolik.TabIndex = 8;
            // 
            // cmbdrkodu
            // 
            this.cmbdrkodu.FormattingEnabled = true;
            this.cmbdrkodu.Location = new System.Drawing.Point(372, 173);
            this.cmbdrkodu.Name = "cmbdrkodu";
            this.cmbdrkodu.Size = new System.Drawing.Size(85, 24);
            this.cmbdrkodu.TabIndex = 11;
            // 
            // txtsirano
            // 
            this.txtsirano.Location = new System.Drawing.Point(139, 173);
            this.txtsirano.Name = "txtsirano";
            this.txtsirano.Size = new System.Drawing.Size(100, 22);
            this.txtsirano.TabIndex = 9;
            // 
            // txtbirimfiyat
            // 
            this.txtbirimfiyat.Location = new System.Drawing.Point(551, 173);
            this.txtbirimfiyat.Name = "txtbirimfiyat";
            this.txtbirimfiyat.Size = new System.Drawing.Size(100, 22);
            this.txtbirimfiyat.TabIndex = 13;
            // 
            // numericmiktar
            // 
            this.numericmiktar.Location = new System.Drawing.Point(463, 174);
            this.numericmiktar.Name = "numericmiktar";
            this.numericmiktar.Size = new System.Drawing.Size(82, 22);
            this.numericmiktar.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Poliklinik";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "SIRA NO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(251, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Yapılan İşlem";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(369, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Dr. Kodu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(463, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Miktar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(551, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Birim Fiyat";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(657, 173);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(102, 24);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 213);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 128);
            this.dataGridView1.TabIndex = 9;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(15, 400);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(98, 42);
            this.btnYeni.TabIndex = 15;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSeçSil
            // 
            this.btnSeçSil.Location = new System.Drawing.Point(121, 400);
            this.btnSeçSil.Name = "btnSeçSil";
            this.btnSeçSil.Size = new System.Drawing.Size(98, 42);
            this.btnSeçSil.TabIndex = 16;
            this.btnSeçSil.Text = "Seç-Sil";
            this.btnSeçSil.UseVisualStyleBackColor = true;
            // 
            // btnTAburcu
            // 
            this.btnTAburcu.Location = new System.Drawing.Point(225, 400);
            this.btnTAburcu.Name = "btnTAburcu";
            this.btnTAburcu.Size = new System.Drawing.Size(98, 42);
            this.btnTAburcu.TabIndex = 17;
            this.btnTAburcu.Text = "Taburcu";
            this.btnTAburcu.UseVisualStyleBackColor = true;
            this.btnTAburcu.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnyazdir
            // 
            this.btnyazdir.Location = new System.Drawing.Point(329, 400);
            this.btnyazdir.Name = "btnyazdir";
            this.btnyazdir.Size = new System.Drawing.Size(98, 42);
            this.btnyazdir.TabIndex = 18;
            this.btnyazdir.Text = "Yazdır";
            this.btnyazdir.UseVisualStyleBackColor = true;
            this.btnyazdir.Click += new System.EventHandler(this.btnyazdir_Click);
            // 
            // btnbaskionizleme
            // 
            this.btnbaskionizleme.Location = new System.Drawing.Point(433, 400);
            this.btnbaskionizleme.Name = "btnbaskionizleme";
            this.btnbaskionizleme.Size = new System.Drawing.Size(98, 42);
            this.btnbaskionizleme.TabIndex = 19;
            this.btnbaskionizleme.Text = "Baskı Önizleme";
            this.btnbaskionizleme.UseVisualStyleBackColor = true;
            this.btnbaskionizleme.Click += new System.EventHandler(this.btnbaskionizleme_Click);
            // 
            // btncikis
            // 
            this.btncikis.Location = new System.Drawing.Point(661, 400);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(98, 42);
            this.btncikis.TabIndex = 20;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.button10_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(559, 380);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 17);
            this.label13.TabIndex = 11;
            this.label13.Text = "Toplam Tutar :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(722, 380);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 17);
            this.label14.TabIndex = 12;
            this.label14.Text = "   TL";
            // 
            // dtsevk
            // 
            this.dtsevk.Location = new System.Drawing.Point(119, 60);
            this.dtsevk.Name = "dtsevk";
            this.dtsevk.Size = new System.Drawing.Size(194, 22);
            this.dtsevk.TabIndex = 2;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // HastaProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(777, 467);
            this.Controls.Add(this.dtsevk);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnTAburcu);
            this.Controls.Add(this.btnbaskionizleme);
            this.Controls.Add(this.btnSeçSil);
            this.Controls.Add(this.btnyazdir);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericmiktar);
            this.Controls.Add(this.cmbpolik);
            this.Controls.Add(this.cmbdrkodu);
            this.Controls.Add(this.cmbyapilanislem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHastaBilgileri);
            this.Controls.Add(this.btnGit);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.cmbOncekislemler);
            this.Controls.Add(this.txthastaSoyadi);
            this.Controls.Add(this.txtKurumAdi);
            this.Controls.Add(this.txtHastaAdi);
            this.Controls.Add(this.txtbirimfiyat);
            this.Controls.Add(this.txtsirano);
            this.Controls.Add(this.txtdosyano);
            this.Name = "HastaProcess";
            this.Text = "HastaProcess";
            this.Load += new System.EventHandler(this.HastaProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericmiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdosyano;
        private System.Windows.Forms.TextBox txtKurumAdi;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.TextBox txthastaSoyadi;
        private System.Windows.Forms.ComboBox cmbOncekislemler;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnGit;
        private System.Windows.Forms.Button btnHastaBilgileri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbyapilanislem;
        private System.Windows.Forms.ComboBox cmbpolik;
        private System.Windows.Forms.ComboBox cmbdrkodu;
        private System.Windows.Forms.TextBox txtsirano;
        private System.Windows.Forms.TextBox txtbirimfiyat;
        private System.Windows.Forms.NumericUpDown numericmiktar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSeçSil;
        private System.Windows.Forms.Button btnTAburcu;
        private System.Windows.Forms.Button btnyazdir;
        private System.Windows.Forms.Button btnbaskionizleme;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtsevk;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}