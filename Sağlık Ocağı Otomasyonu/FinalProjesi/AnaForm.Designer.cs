namespace FinalProjesi
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menustripItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıTanıtmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaİşlemleriF2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menustripItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlargeçiciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustripItem1,
            this.menustripItem2,
            this.menustripItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menustripItem1
            // 
            this.menustripItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.polToolStripMenuItem,
            this.kullanıcıTanıtmaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menustripItem1.Name = "menustripItem1";
            this.menustripItem1.Size = new System.Drawing.Size(117, 24);
            this.menustripItem1.Text = "REFERANSLAR";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // polToolStripMenuItem
            // 
            this.polToolStripMenuItem.Name = "polToolStripMenuItem";
            this.polToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.polToolStripMenuItem.Text = "Poliklinik Tanıtma";
            this.polToolStripMenuItem.Click += new System.EventHandler(this.polToolStripMenuItem_Click);
            // 
            // kullanıcıTanıtmaToolStripMenuItem
            // 
            this.kullanıcıTanıtmaToolStripMenuItem.Name = "kullanıcıTanıtmaToolStripMenuItem";
            this.kullanıcıTanıtmaToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.kullanıcıTanıtmaToolStripMenuItem.Text = "Kullanıcı Tanıtma";
            this.kullanıcıTanıtmaToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıTanıtmaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // menustripItem2
            // 
            this.menustripItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hastaİşlemleriF2ToolStripMenuItem});
            this.menustripItem2.Name = "menustripItem2";
            this.menustripItem2.Size = new System.Drawing.Size(116, 24);
            this.menustripItem2.Text = "HASTA KABUL";
            // 
            // hastaİşlemleriF2ToolStripMenuItem
            // 
            this.hastaİşlemleriF2ToolStripMenuItem.Name = "hastaİşlemleriF2ToolStripMenuItem";
            this.hastaİşlemleriF2ToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.hastaİşlemleriF2ToolStripMenuItem.Text = "Hasta İşlemleri F2";
            this.hastaİşlemleriF2ToolStripMenuItem.Click += new System.EventHandler(this.hastaİşlemleriF2ToolStripMenuItem_Click);
            // 
            // menustripItem3
            // 
            this.menustripItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporlargeçiciToolStripMenuItem});
            this.menustripItem3.Name = "menustripItem3";
            this.menustripItem3.Size = new System.Drawing.Size(94, 24);
            this.menustripItem3.Text = "RAPORLAR";
            // 
            // raporlargeçiciToolStripMenuItem
            // 
            this.raporlargeçiciToolStripMenuItem.Name = "raporlargeçiciToolStripMenuItem";
            this.raporlargeçiciToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.raporlargeçiciToolStripMenuItem.Text = "Raporlar(geçici)";
            this.raporlargeçiciToolStripMenuItem.Click += new System.EventHandler(this.raporlargeçiciToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 608);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menustripItem1;
        private System.Windows.Forms.ToolStripMenuItem menustripItem2;
        private System.Windows.Forms.ToolStripMenuItem menustripItem3;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıTanıtmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaİşlemleriF2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlargeçiciToolStripMenuItem;



    }
}

