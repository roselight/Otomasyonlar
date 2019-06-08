namespace pso
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ngmin = new System.Windows.Forms.NumericUpDown();
            this.nc2 = new System.Windows.Forms.NumericUpDown();
            this.nc1 = new System.Windows.Forms.NumericUpDown();
            this.njen = new System.Windows.Forms.NumericUpDown();
            this.nparcacik = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.njen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nparcacik)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ngmin);
            this.panel1.Controls.Add(this.nc2);
            this.panel1.Controls.Add(this.nc1);
            this.panel1.Controls.Add(this.njen);
            this.panel1.Controls.Add(this.nparcacik);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 170);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Global Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "gBest için Öğr. Fakt.(c1)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "pBest için Öğr.Fakt.(c2)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenerasyon Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parçacık Sayısı";
            // 
            // ngmin
            // 
            this.ngmin.Location = new System.Drawing.Point(224, 125);
            this.ngmin.Name = "ngmin";
            this.ngmin.Size = new System.Drawing.Size(120, 22);
            this.ngmin.TabIndex = 0;
            // 
            // nc2
            // 
            this.nc2.Location = new System.Drawing.Point(224, 97);
            this.nc2.Name = "nc2";
            this.nc2.Size = new System.Drawing.Size(120, 22);
            this.nc2.TabIndex = 0;
            this.nc2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nc1
            // 
            this.nc1.Location = new System.Drawing.Point(224, 69);
            this.nc1.Name = "nc1";
            this.nc1.Size = new System.Drawing.Size(120, 22);
            this.nc1.TabIndex = 0;
            this.nc1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // njen
            // 
            this.njen.Location = new System.Drawing.Point(224, 41);
            this.njen.Name = "njen";
            this.njen.Size = new System.Drawing.Size(120, 22);
            this.njen.TabIndex = 0;
            this.njen.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nparcacik
            // 
            this.nparcacik.Location = new System.Drawing.Point(224, 13);
            this.nparcacik.Name = "nparcacik";
            this.nparcacik.Size = new System.Drawing.Size(120, 22);
            this.nparcacik.TabIndex = 0;
            this.nparcacik.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "label6";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "label6";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(379, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(573, 548);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 577);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.njen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nparcacik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown ngmin;
        private System.Windows.Forms.NumericUpDown nc2;
        private System.Windows.Forms.NumericUpDown nc1;
        private System.Windows.Forms.NumericUpDown njen;
        private System.Windows.Forms.NumericUpDown nparcacik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
    }
}

