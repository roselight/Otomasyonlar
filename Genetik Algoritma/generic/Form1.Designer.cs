namespace generic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtSonuc = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtIterasyon = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtiterasyon = new System.Windows.Forms.TextBox();
            this.txtmutkatsayi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcaprazlama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmutoran = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpop = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dtSonuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIterasyon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtSonuc
            // 
            this.dtSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSonuc.Location = new System.Drawing.Point(536, 194);
            this.dtSonuc.Margin = new System.Windows.Forms.Padding(4);
            this.dtSonuc.Name = "dtSonuc";
            this.dtSonuc.Size = new System.Drawing.Size(487, 324);
            this.dtSonuc.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(460, 127);
            this.button1.TabIndex = 14;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Toplama",
            "Çıkarma",
            "Random"});
            this.comboBox4.Location = new System.Drawing.Point(5, 100);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(153, 24);
            this.comboBox4.TabIndex = 12;
            this.comboBox4.Text = "Mutasyon Seçimi";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Beale",
            "Easom",
            "Colville",
            "Michalewicz 2",
            "Michalewicz 5",
            "Michalewicz 10",
            "Zakharov"});
            this.comboBox3.Location = new System.Drawing.Point(5, 70);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(153, 24);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.Text = "Fonksiyon Seçimi";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Tek Noktalı"});
            this.comboBox2.Location = new System.Drawing.Point(5, 39);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 24);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Caprazlama Seçimi";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Deterministik",
            "Rulet Tekerleği",
            "Rastgele",
            "Turnuva",
            "Random"});
            this.comboBox1.Location = new System.Drawing.Point(5, 10);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Birey Seçme";
            // 
            // dtIterasyon
            // 
            this.dtIterasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtIterasyon.Location = new System.Drawing.Point(38, 194);
            this.dtIterasyon.Margin = new System.Windows.Forms.Padding(4);
            this.dtIterasyon.Name = "dtIterasyon";
            this.dtIterasyon.Size = new System.Drawing.Size(487, 324);
            this.dtIterasyon.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(348, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(176, 137);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "İterasyon Sayısı : ";
            // 
            // txtiterasyon
            // 
            this.txtiterasyon.Location = new System.Drawing.Point(176, 133);
            this.txtiterasyon.Margin = new System.Windows.Forms.Padding(4);
            this.txtiterasyon.Name = "txtiterasyon";
            this.txtiterasyon.Size = new System.Drawing.Size(100, 22);
            this.txtiterasyon.TabIndex = 13;
            // 
            // txtmutkatsayi
            // 
            this.txtmutkatsayi.Location = new System.Drawing.Point(176, 102);
            this.txtmutkatsayi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmutkatsayi.Name = "txtmutkatsayi";
            this.txtmutkatsayi.Size = new System.Drawing.Size(100, 22);
            this.txtmutkatsayi.TabIndex = 8;
            this.txtmutkatsayi.Text = "0,5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mutasyon Katsayısı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popülasyon Büyüklüğü : ";
            // 
            // txtcaprazlama
            // 
            this.txtcaprazlama.Location = new System.Drawing.Point(176, 42);
            this.txtcaprazlama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcaprazlama.Name = "txtcaprazlama";
            this.txtcaprazlama.Size = new System.Drawing.Size(100, 22);
            this.txtcaprazlama.TabIndex = 6;
            this.txtcaprazlama.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Caprazlama Oranı : ";
            // 
            // txtmutoran
            // 
            this.txtmutoran.Location = new System.Drawing.Point(176, 71);
            this.txtmutoran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmutoran.Name = "txtmutoran";
            this.txtmutoran.Size = new System.Drawing.Size(100, 22);
            this.txtmutoran.TabIndex = 5;
            this.txtmutoran.Text = "0,5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mutasyon Oranı : ";
            // 
            // txtpop
            // 
            this.txtpop.Location = new System.Drawing.Point(176, 12);
            this.txtpop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpop.Name = "txtpop";
            this.txtpop.Size = new System.Drawing.Size(100, 22);
            this.txtpop.TabIndex = 4;
            this.txtpop.Text = "10";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtiterasyon);
            this.groupBox1.Controls.Add(this.txtmutkatsayi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcaprazlama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmutoran);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtpop);
            this.groupBox1.Location = new System.Drawing.Point(38, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(289, 166);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(46, 549);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(977, 300);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 875);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dtSonuc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtIterasyon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtSonuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIterasyon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtSonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dtIterasyon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtiterasyon;
        private System.Windows.Forms.TextBox txtmutkatsayi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcaprazlama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmutoran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

