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
    public partial class FrmDevamsizlik : Form
    {
        TakimDB veritabani = new TakimDB();
        public FrmDevamsizlik()
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
            dataGridView1.Columns["TelefonNU"].Visible = false;
            dataGridView1.Columns["Pozisyon"].Visible = false;
            dataGridView1.Columns["Boy"].Visible = false;
            dataGridView1.Columns["Kilo"].Visible = false;
            dataGridView1.Columns["Yas"].Visible = false;
            dataGridView1.Columns["KatilmaTarihi"].Visible = false;
            dataGridView1.Columns["Devamsizlik"].HeaderText = "Devamsızlık";
            dataGridView1.Columns["DisiplinCezasi"].HeaderText = "Disiplin Cezası";
            dataGridView1.Columns["Zimmet"].HeaderText = "Ekipman Bilgisi";
            lblToplamOyuncu.Text = "";
            if (dataGridView1.Rows.Count > 0)
            {
                lblToplamOyuncu.Text = dataGridView1.Rows.Count.ToString() + " Oyuncu Listelendi.";
            }
        }
        private void FrmDevamsizlik_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string tMetin = txtArama.Text.Trim();

            var liste = veritabani.Oyunculars
                                        .Where(tablo => tablo.Ad.Contains(tMetin) || 
                                                        tablo.Soyad.Contains(tMetin) || 
                                                        tablo.Pozisyon.Contains(tMetin) || 
                                                        tablo.FormaNu == tMetin)
                                        .ToList();

            dataGridView1.DataSource = liste;
            if (dataGridView1.Rows.Count > 0)
            {
                lblToplamOyuncu.Text = dataGridView1.Rows.Count.ToString() + " Oyuncu Listelendi.";
            }

            //dataGridView1.DataSource = veritabani.Oyunculars.Where(tablo => tablo.Ad.Contains(txtArama.Text) || tablo.Soyad.Contains(txtArama.Text) || tablo.Pozisyon.Contains(txtArama.Text) || tablo.FormaNu.ToString() == txtArama.Text).ToList();
            //if (dataGridView1.Rows.Count > 0)
            //{
            //    lblToplamOyuncu.Text = dataGridView1.Rows.Count.ToString() + " Oyuncu Listelendi.";
            //}
        }

        private void btnEkipmanekle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var tOyuncuNesne = veritabani.Oyunculars.Find(dataGridView1.CurrentRow.Cells["ID"].Value);
                    var guncellenecek = veritabani.Oyunculars.Where(tablo => tablo.ID == tOyuncuNesne.ID);
                    if (tOyuncuNesne.Zimmet == txtmultiEkipman.Text.Trim())
                    {
                        MessageBox.Show("Ekipman bilgileri sistemdeki ile aynı!", "HATA");
                    }
                    else
                    {
                        tOyuncuNesne.Zimmet = txtmultiEkipman.Text;
                        veritabani.SaveChanges();
                        MessageBox.Show("Ekipman bilgileri güncellendi", "ONAY");
                        Yenile();
                    }
                }
            }
        }

        private void btnDevamsizlikEkle_Click(object sender, EventArgs e)
        {
            var bul = veritabani.Oyunculars.Find(dataGridView1.CurrentRow.Cells["ID"].Value);
            var guncellenecek = veritabani.Oyunculars.Where(tablo => tablo.ID == bul.ID);
            if (bul.Devamsizlik==txtmultiDevamsizlik.Text)
            {
                MessageBox.Show("Devamsızlık bilgileri sistemdeki ile aynı!", "HATA");
            }
            else
            {
                bul.Devamsizlik = txtmultiDevamsizlik.Text;
                veritabani.SaveChanges();
                Yenile();
                MessageBox.Show("Devamsızlık güncellendi", "ONAY");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var bul2 = veritabani.Oyunculars.Find(dataGridView1.CurrentRow.Cells["ID"].Value);
            List<Oyuncular> liste = veritabani.Oyunculars.Where(tablo => tablo.ID == bul2.ID).ToList();
            if (liste.Count > 0)
            {
                txtmultiDevamsizlik.Clear();
                txtmultiDevamsizlik.Text=bul2.Devamsizlik;
                txtmultiDisiplin.Clear();
                txtmultiDisiplin.Text = bul2.DisiplinCezasi;
                txtmultiEkipman.Clear();
                txtmultiEkipman.Text = bul2.Zimmet;
            }
            if (txtmultiDisiplin.Lines.Length==2)
            {
                lblDisiplin.Text = "Disiplin sınırda!";
            }
            else if (txtmultiDisiplin.Lines.Length >2)
            {
                
                lblDisiplin.Text = "Disiplin sınırını\naşmış!";
            }
            else
            {
                lblDisiplin.Text = "";
            }
            if (txtmultiEkipman.Text=="YOK")
            {
                lblEkipman.Text = "0 Ekipman";
            }
            else
            {
                lblEkipman.Text = txtmultiEkipman.Lines.Length.ToString() + " Ekipman";
            }
            if (txtmultiDevamsizlik.Text == "YOK")
            {
                label1.Text = "Devamsızlık: 0 Gün";
            }
            else 
            {
                label1.Text = "Devamsızlık: " + (txtmultiDevamsizlik.Lines.Length - 1).ToString() + " Gün";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtmultiDevamsizlik.AppendText(dateTimePicker1.Text+"\n");
            label1.Text = "Devamsızlık: " + (txtmultiDevamsizlik.Lines.Length-1).ToString() + " Gün";
        }

        private void btnDevamsizlikSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Devamsızlık silinsin mı?", "UYARI", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var bul3 = veritabani.Oyunculars.Find(dataGridView1.CurrentRow.Cells["ID"].Value);
                var guncellenecek = veritabani.Oyunculars.Where(tablo => tablo.ID == bul3.ID ).FirstOrDefault();
                guncellenecek.Devamsizlik = "YOK";
                veritabani.SaveChanges();
                MessageBox.Show("Devamsızlık bilgileri silindi.", "ONAY");
                txtmultiDevamsizlik.Clear();
                Yenile();
            }
        }

        private void btnEkipmanSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ekipman bilgisi silinsin mı?", "UYARI", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var bul4 = veritabani.Oyunculars.Find(dataGridView1.CurrentRow.Cells["ID"].Value);
                var guncellenecek = veritabani.Oyunculars.Where(tablo => tablo.ID == bul4.ID).FirstOrDefault();
                guncellenecek.Zimmet = "YOK";
                veritabani.SaveChanges();
                MessageBox.Show("Ekipman bilgileri silindi.", "ONAY");
                txtmultiEkipman.Clear();
                Yenile();
            }
        }

        private void btnDisiplinEkle_Click(object sender, EventArgs e)
        {
            var bul5 = veritabani.Oyunculars.Find(dataGridView1.CurrentRow.Cells["ID"].Value);
            var guncellenecek = veritabani.Oyunculars.Where(tablo => tablo.ID == bul5.ID);
            if (bul5.DisiplinCezasi == txtmultiDisiplin.Text)
            {
                MessageBox.Show("Disiplin ceza bilgileri sistemdeki ile aynı!", "HATA");
            }
            else
            {
                bul5.DisiplinCezasi = txtmultiDisiplin.Text;
                veritabani.SaveChanges();
                Yenile();
                MessageBox.Show("Disiplin cezası güncellendi", "ONAY");
            }
        }

        private void btnDisiplinSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ekipman bilgisi silinsin mı?", "UYARI", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var bul6 = veritabani.Oyunculars.Find(dataGridView1.CurrentRow.Cells["ID"].Value);
                var guncellenecek = veritabani.Oyunculars.Where(tablo => tablo.ID == bul6.ID).FirstOrDefault();
                guncellenecek.DisiplinCezasi = "YOK";
                veritabani.SaveChanges();
                MessageBox.Show("Disiplin cezası silindi.", "ONAY");
                txtmultiDisiplin.Clear();
                Yenile();
            }
        }
    }
}