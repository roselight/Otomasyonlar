namespace FinalProjesi
{
    partial class Rapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rapor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btncikis = new System.Windows.Forms.Button();
            this.btnyazdir = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnsorgula = new System.Windows.Forms.Button();
            this.radioHepsi = new System.Windows.Forms.RadioButton();
            this.radiotaburcuolmamis = new System.Windows.Forms.RadioButton();
            this.radiotaburcuolmus = new System.Windows.Forms.RadioButton();
            this.dtsevkbitis = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtsevbaslangic = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 121);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1139, 399);
            this.dataGridView1.TabIndex = 36;
            // 
            // btncikis
            // 
            this.btncikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncikis.Location = new System.Drawing.Point(1045, 14);
            this.btncikis.Margin = new System.Windows.Forms.Padding(4);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(93, 89);
            this.btncikis.TabIndex = 8;
            this.btncikis.Text = "Çıkış";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // btnyazdir
            // 
            this.btnyazdir.Location = new System.Drawing.Point(850, 14);
            this.btnyazdir.Margin = new System.Windows.Forms.Padding(4);
            this.btnyazdir.Name = "btnyazdir";
            this.btnyazdir.Size = new System.Drawing.Size(123, 89);
            this.btnyazdir.TabIndex = 7;
            this.btnyazdir.Text = "Yazdır";
            this.btnyazdir.UseVisualStyleBackColor = true;
            this.btnyazdir.Click += new System.EventHandler(this.btnyazdir_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(719, 14);
            this.btntemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(123, 89);
            this.btntemizle.TabIndex = 6;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnsorgula
            // 
            this.btnsorgula.Location = new System.Drawing.Point(588, 14);
            this.btnsorgula.Margin = new System.Windows.Forms.Padding(4);
            this.btnsorgula.Name = "btnsorgula";
            this.btnsorgula.Size = new System.Drawing.Size(123, 89);
            this.btnsorgula.TabIndex = 5;
            this.btnsorgula.Text = "Sorgula";
            this.btnsorgula.UseVisualStyleBackColor = true;
            this.btnsorgula.Click += new System.EventHandler(this.btnsorgula_Click);
            // 
            // radioHepsi
            // 
            this.radioHepsi.AutoSize = true;
            this.radioHepsi.Font = new System.Drawing.Font("Arial", 9.75F);
            this.radioHepsi.Location = new System.Drawing.Point(415, 78);
            this.radioHepsi.Margin = new System.Windows.Forms.Padding(4);
            this.radioHepsi.Name = "radioHepsi";
            this.radioHepsi.Size = new System.Drawing.Size(71, 23);
            this.radioHepsi.TabIndex = 4;
            this.radioHepsi.Text = "Hepsi";
            this.radioHepsi.UseVisualStyleBackColor = true;
            // 
            // radiotaburcuolmamis
            // 
            this.radiotaburcuolmamis.AutoSize = true;
            this.radiotaburcuolmamis.Font = new System.Drawing.Font("Arial", 9.75F);
            this.radiotaburcuolmamis.Location = new System.Drawing.Point(415, 46);
            this.radiotaburcuolmamis.Margin = new System.Windows.Forms.Padding(4);
            this.radiotaburcuolmamis.Name = "radiotaburcuolmamis";
            this.radiotaburcuolmamis.Size = new System.Drawing.Size(153, 23);
            this.radiotaburcuolmamis.TabIndex = 3;
            this.radiotaburcuolmamis.Text = "Taburcu olmamış";
            this.radiotaburcuolmamis.UseVisualStyleBackColor = true;
            // 
            // radiotaburcuolmus
            // 
            this.radiotaburcuolmus.AutoSize = true;
            this.radiotaburcuolmus.Checked = true;
            this.radiotaburcuolmus.Font = new System.Drawing.Font("Arial", 9.75F);
            this.radiotaburcuolmus.Location = new System.Drawing.Point(415, 14);
            this.radiotaburcuolmus.Margin = new System.Windows.Forms.Padding(4);
            this.radiotaburcuolmus.Name = "radiotaburcuolmus";
            this.radiotaburcuolmus.Size = new System.Drawing.Size(135, 23);
            this.radiotaburcuolmus.TabIndex = 2;
            this.radiotaburcuolmus.TabStop = true;
            this.radiotaburcuolmus.Text = "Taburcu olmuş";
            this.radiotaburcuolmus.UseVisualStyleBackColor = true;
            // 
            // dtsevkbitis
            // 
            this.dtsevkbitis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtsevkbitis.Location = new System.Drawing.Point(152, 61);
            this.dtsevkbitis.Margin = new System.Windows.Forms.Padding(4);
            this.dtsevkbitis.Name = "dtsevkbitis";
            this.dtsevkbitis.Size = new System.Drawing.Size(253, 26);
            this.dtsevkbitis.TabIndex = 1;
            this.dtsevkbitis.Tag = "12";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "Bitiş Tarihi:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtsevbaslangic
            // 
            this.dtsevbaslangic.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtsevbaslangic.Location = new System.Drawing.Point(152, 26);
            this.dtsevbaslangic.Margin = new System.Windows.Forms.Padding(4);
            this.dtsevbaslangic.Name = "dtsevbaslangic";
            this.dtsevbaslangic.Size = new System.Drawing.Size(253, 26);
            this.dtsevbaslangic.TabIndex = 0;
            this.dtsevbaslangic.Tag = "12";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(7, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Başlangıç Tarihi:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1139, 520);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnyazdir);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnsorgula);
            this.Controls.Add(this.radioHepsi);
            this.Controls.Add(this.radiotaburcuolmamis);
            this.Controls.Add(this.radiotaburcuolmus);
            this.Controls.Add(this.dtsevkbitis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtsevbaslangic);
            this.Controls.Add(this.label8);
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btncikis;
        private System.Windows.Forms.Button btnyazdir;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btnsorgula;
        private System.Windows.Forms.RadioButton radioHepsi;
        private System.Windows.Forms.RadioButton radiotaburcuolmamis;
        private System.Windows.Forms.RadioButton radiotaburcuolmus;
        private System.Windows.Forms.DateTimePicker dtsevkbitis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtsevbaslangic;
        private System.Windows.Forms.Label label8;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}