
namespace Ogrenci_Not_Sistemi
{
    partial class FormGiris
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
            this.bgiris = new System.Windows.Forms.Button();
            this.textBoxyadi = new System.Windows.Forms.TextBox();
            this.textBoxysifre = new System.Windows.Forms.TextBox();
            this.buttoncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bgiris
            // 
            this.bgiris.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bgiris.FlatAppearance.BorderSize = 0;
            this.bgiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bgiris.Location = new System.Drawing.Point(164, 185);
            this.bgiris.Name = "bgiris";
            this.bgiris.Size = new System.Drawing.Size(80, 32);
            this.bgiris.TabIndex = 0;
            this.bgiris.Text = "Giriş";
            this.bgiris.UseVisualStyleBackColor = false;
            this.bgiris.Click += new System.EventHandler(this.bgiris_Click);
            // 
            // textBoxyadi
            // 
            this.textBoxyadi.Location = new System.Drawing.Point(112, 66);
            this.textBoxyadi.Name = "textBoxyadi";
            this.textBoxyadi.Size = new System.Drawing.Size(182, 26);
            this.textBoxyadi.TabIndex = 1;
            // 
            // textBoxysifre
            // 
            this.textBoxysifre.Location = new System.Drawing.Point(112, 117);
            this.textBoxysifre.Name = "textBoxysifre";
            this.textBoxysifre.PasswordChar = '*';
            this.textBoxysifre.Size = new System.Drawing.Size(182, 26);
            this.textBoxysifre.TabIndex = 2;
            // 
            // buttoncikis
            // 
            this.buttoncikis.FlatAppearance.BorderSize = 0;
            this.buttoncikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoncikis.Location = new System.Drawing.Point(382, 0);
            this.buttoncikis.Name = "buttoncikis";
            this.buttoncikis.Size = new System.Drawing.Size(30, 30);
            this.buttoncikis.TabIndex = 3;
            this.buttoncikis.Text = "X";
            this.buttoncikis.UseVisualStyleBackColor = true;
            this.buttoncikis.Click += new System.EventHandler(this.buttoncikis_Click);
            // 
            // FormGiris
            // 
            this.AcceptButton = this.bgiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(411, 284);
            this.Controls.Add(this.buttoncikis);
            this.Controls.Add(this.textBoxysifre);
            this.Controls.Add(this.textBoxyadi);
            this.Controls.Add(this.bgiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGiris";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bgiris;
        private System.Windows.Forms.TextBox textBoxyadi;
        private System.Windows.Forms.TextBox textBoxysifre;
        private System.Windows.Forms.Button buttoncikis;
    }
}

