namespace FinalProjesi
{
    partial class DosyaBul
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
            this.cmbkriter = new System.Windows.Forms.ComboBox();
            this.btnbul = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkand = new System.Windows.Forms.CheckBox();
            this.txtveri2 = new System.Windows.Forms.TextBox();
            this.txtveri1 = new System.Windows.Forms.TextBox();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama Kriteri";
            // 
            // cmbkriter
            // 
            this.cmbkriter.FormattingEnabled = true;
            this.cmbkriter.Items.AddRange(new object[] {
            "Hasta Adı Soyadı",
            "Kimlik No ",
            "Kurum Sicil No",
            "Dosya No"});
            this.cmbkriter.Location = new System.Drawing.Point(130, 19);
            this.cmbkriter.Name = "cmbkriter";
            this.cmbkriter.Size = new System.Drawing.Size(121, 24);
            this.cmbkriter.TabIndex = 0;
            this.cmbkriter.SelectedIndexChanged += new System.EventHandler(this.cmbkriter_SelectedIndexChanged);
            // 
            // btnbul
            // 
            this.btnbul.Location = new System.Drawing.Point(774, 19);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(75, 23);
            this.btnbul.TabIndex = 2;
            this.btnbul.Text = "Bul";
            this.btnbul.UseVisualStyleBackColor = true;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.checkand);
            this.panel1.Controls.Add(this.txtveri2);
            this.panel1.Controls.Add(this.txtveri1);
            this.panel1.Controls.Add(this.cmbkriter);
            this.panel1.Controls.Add(this.btnbul);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 54);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkand
            // 
            this.checkand.AutoSize = true;
            this.checkand.Location = new System.Drawing.Point(485, 23);
            this.checkand.Name = "checkand";
            this.checkand.Size = new System.Drawing.Size(45, 21);
            this.checkand.TabIndex = 2;
            this.checkand.Text = "ve";
            this.checkand.UseVisualStyleBackColor = true;
            // 
            // txtveri2
            // 
            this.txtveri2.Location = new System.Drawing.Point(550, 21);
            this.txtveri2.Name = "txtveri2";
            this.txtveri2.Size = new System.Drawing.Size(207, 22);
            this.txtveri2.TabIndex = 4;
            // 
            // txtveri1
            // 
            this.txtveri1.Location = new System.Drawing.Point(272, 20);
            this.txtveri1.Name = "txtveri1";
            this.txtveri1.Size = new System.Drawing.Size(207, 22);
            this.txtveri1.TabIndex = 1;
            // 
            // datagrid
            // 
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid.Location = new System.Drawing.Point(0, 54);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(870, 329);
            this.datagrid.TabIndex = 4;
            // 
            // DosyaBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 383);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.panel1);
            this.Name = "DosyaBul";
            this.Text = "DosyaBul";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbkriter;
        private System.Windows.Forms.Button btnbul;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.CheckBox checkand;
        private System.Windows.Forms.TextBox txtveri2;
        private System.Windows.Forms.TextBox txtveri1;

    }
}