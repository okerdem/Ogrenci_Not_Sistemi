using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessLogicLayer;

namespace Ogrenci_Not_Sistemi
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        public void Gecis()
        {
            this.Show();
        }

        private void bgiris_Click(object sender, EventArgs e)
        {
            BLLYonetici by = new BLLYonetici();
            EntityYonetici ey = new EntityYonetici();
            ey.Kullaniciadi = textBoxyadi.Text.ToString();
            ey.Sifre = textBoxysifre.Text.ToString();

            if (by.Kontrol(ey))
            {
                Formislemler fi = new Formislemler();
                fi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş.");
            }
        }

        private void buttoncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
