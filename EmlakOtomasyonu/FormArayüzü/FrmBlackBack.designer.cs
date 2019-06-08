using System.Drawing;
using System.Windows.Forms;
using System;
using DevExpress.XtraEditors;

namespace FormArayüzü
{
    partial class FrmBlackBack
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

        private Color bColor;
        private XtraForm Ftemp2;
        private int opastiy;
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FrmBlackBack
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 378);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBlackBack";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBlackBack";
            this.Shown += new System.EventHandler(this.FrmBlackBack_Shown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}