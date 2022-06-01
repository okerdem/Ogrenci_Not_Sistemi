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
    public partial class Formislemler : Form
    {
        BLLOgrenci bo = new BLLOgrenci();
        BLLNotlar bn = new BLLNotlar();
        EntityNotlar en = new EntityNotlar();
        EntityOgrenci eo = new EntityOgrenci();

        public Formislemler()
        {
            InitializeComponent();
        }

        private void buttoncikis_Click(object sender, EventArgs e)
        {
            FormGiris fg = new FormGiris();
            fg.Gecis();
            this.Close();
        }

        private void buttonalt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void OgrenciListele()
        {
            List<EntityOgrenci> lo = bo.Listele();
            dataGridViewogrenci.DataSource = lo;
        }

        public void NotListele()
        {
            List<EntityNotlar> ln = bn.Listele();
            dataGridViewnot.DataSource = ln;
        }

        private void buttonogrenci_Click(object sender, EventArgs e)
        {
            panelogrenci.Show();
        }

        private void buttonnot_Click(object sender, EventArgs e)
        {
            panelnot.Show();
        }

        private void panelogrenci_Paint(object sender, PaintEventArgs e)
        {
            OgrenciListele();
        }

        private void panelnot_Paint(object sender, PaintEventArgs e)
        {
            NotListele();
        }

        private void dataGridViewogrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxid.Text = dataGridViewogrenci.CurrentRow.Cells[0].Value.ToString();
            textBoxad.Text = dataGridViewogrenci.CurrentRow.Cells[1].Value.ToString();
            textBoxsoyad.Text = dataGridViewogrenci.CurrentRow.Cells[2].Value.ToString();
            textBoxfotograf.Text = dataGridViewogrenci.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridViewnot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxnotid.Text = dataGridViewnot.CurrentRow.Cells[2].Value.ToString();
            textBoxsinav1.Text = dataGridViewnot.CurrentRow.Cells[3].Value.ToString();
            textBoxsinav2.Text = dataGridViewnot.CurrentRow.Cells[4].Value.ToString();
            textBoxproje.Text = dataGridViewnot.CurrentRow.Cells[5].Value.ToString();
        }

        private void buttongeri_Click(object sender, EventArgs e)
        {
            panelogrenci.Hide();
        }

        private void buttonnotgeri_Click(object sender, EventArgs e)
        {
            panelnot.Hide();
        }
        
        private void buttonekle_Click(object sender, EventArgs e)
        {
            eo.Ad = textBoxad.Text;
            eo.Soyad = textBoxsoyad.Text;
            eo.Fotograf = textBoxfotograf.Text;

            bo.Ekle(eo);

            OgrenciListele();
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            eo.Id = Convert.ToInt16(textBoxid.Text);
            bo.Sil(eo);

            OgrenciListele();
        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            eo.Id = Convert.ToInt16(textBoxid.Text);
            eo.Ad = textBoxad.Text;
            eo.Soyad = textBoxsoyad.Text;
            eo.Fotograf = textBoxfotograf.Text;

            bo.Guncelle(eo);
            OgrenciListele();
        }

        private void buttonnotguncelle_Click(object sender, EventArgs e)
        {
            en.Ogrenciid = Convert.ToInt16(textBoxnotid.Text);
            en.Sinav1 = Convert.ToInt16(textBoxsinav1.Text);
            en.Sinav2 = Convert.ToInt16(textBoxsinav2.Text);
            en.Proje = Convert.ToInt16(textBoxproje.Text);

            bn.Guncelle(en);
            NotListele();
        }
    }
}
