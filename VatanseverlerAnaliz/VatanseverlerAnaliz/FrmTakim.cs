using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VatanseverlerAnaliz
{
    public partial class FrmTakim : Form
    {
        TakimDB veritabani = new TakimDB();
        public FrmTakim()
        {
            InitializeComponent();
        }
        void Yenile()
        {
            dataGridView1.DataSource = veritabani.Oyunculars.ToList();
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["FormaNu"].HeaderText = "Forma Numarası";
            dataGridView1.Columns["Ad"].HeaderText = "Ad";
            dataGridView1.Columns["Soyad"].HeaderText = "Soyad";
            dataGridView1.Columns["TelefonNU"].HeaderText = "Telefon Numarası";
            dataGridView1.Columns["Pozisyon"].HeaderText = "Pozisyon";
            dataGridView1.Columns["Boy"].HeaderText = "Boy";
            dataGridView1.Columns["Kilo"].HeaderText = "Kilo";
            dataGridView1.Columns["Yas"].HeaderText = "Yaş";
            dataGridView1.Columns["KatilmaTarihi"].HeaderText = "Katılma Tarihi";
            dataGridView1.Columns["Devamsizlik"].Visible = false;
            dataGridView1.Columns["DisiplinCezasi"].Visible = false;
            dataGridView1.Columns["Zimmet"].Visible = false;
            lblToplamOyuncu.Text = "";
            if (dataGridView1.Rows.Count > 0)
            {
                lblToplamOyuncu.Text = dataGridView1.Rows.Count.ToString() + " Oyuncu Listelendi.";
            }
        }
        private void FrmTakim_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void btnOyuncusli_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Oyuncu Silinsin mı?", "UYARI", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var bul = veritabani.Oyunculars.Find(dataGridView1.CurrentRow.Cells["ID"].Value);
                veritabani.Oyunculars.Remove(bul);
                veritabani.SaveChanges();
                MessageBox.Show("Oyuncu Silindi.", "ONAY");
                Yenile();
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = veritabani.Oyunculars.Where(tablo => tablo.Ad.Contains(txtArama.Text) || 
                                                                            tablo.Soyad.Contains(txtArama.Text)|| 
                                                                            tablo.Pozisyon.Contains(txtArama.Text)|| 
                                                                            tablo.FormaNu.ToString() == txtArama.Text).ToList();
            lblToplamOyuncu.Text = "";
            if (dataGridView1.Rows.Count > 0)
            {
                lblToplamOyuncu.Text = dataGridView1.Rows.Count.ToString() + " Oyuncu Listelendi.";
            }
        }
    }
}