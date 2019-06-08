namespace FinalProjesi
{
    partial class PoliTanit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoliTanit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPoliklinikad = new System.Windows.Forms.ComboBox();
            this.checkGecerli_siz = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 52);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOHATS-Poliklinik Tanıtma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(110, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poliklinik Adı";
            // 
            // cmbPoliklinikad
            // 
            this.cmbPoliklinikad.FormattingEnabled = true;
            this.cmbPoliklinikad.Location = new System.Drawing.Point(246, 144);
            this.cmbPoliklinikad.Name = "cmbPoliklinikad";
            this.cmbPoliklinikad.Size = new System.Drawing.Size(159, 24);
            this.cmbPoliklinikad.TabIndex = 2;
            this.cmbPoliklinikad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPoliklinikad_KeyDown);
            // 
            // checkGecerli_siz
            // 
            this.checkGecerli_siz.AutoSize = true;
            this.checkGecerli_siz.BackColor = System.Drawing.Color.Transparent;
            this.checkGecerli_siz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkGecerli_siz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkGecerli_siz.Location = new System.Drawing.Point(247, 184);
            this.checkGecerli_siz.Name = "checkGecerli_siz";
            this.checkGecerli_siz.Size = new System.Drawing.Size(158, 24);
            this.checkGecerli_siz.TabIndex = 3;
            this.checkGecerli_siz.Text = "Geçerli/Geçersiz";
            this.checkGecerli_siz.UseVisualStyleBackColor = false;
            // 
            // PoliTanit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 339);
            this.Controls.Add(this.checkGecerli_siz);
            this.Controls.Add(this.cmbPoliklinikad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PoliTanit";
            this.Text = "PoliTanit";
            this.Load += new System.EventHandler(this.PoliTanit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPoliklinikad;
        private System.Windows.Forms.CheckBox checkGecerli_siz;
    }
}