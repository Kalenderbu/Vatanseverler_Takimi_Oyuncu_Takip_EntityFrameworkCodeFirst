using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace VatanseverlerAnaliz
{
    public partial class FrmOyuncuekle : Form
    {
        TakimDB veritabani = new TakimDB();
        public FrmOyuncuekle()
        {
            InitializeComponent();
        }
        private void btnOyuncuekle_Click(object sender, EventArgs e)
        {
            if (txtFormanuEkle.Text == "" || txtFormanuEkle.Text == null || txtFormanuEkle.Text == " ")
            {
                MessageBox.Show("Oyuncunun Forma Numarasını giriniz!", "UYARI");
                this.ActiveControl = txtFormanuEkle;
                return;
            }
            if (txtAdEkle.Text == "" || txtAdEkle.Text == null || txtAdEkle.Text == " ")
            {
                MessageBox.Show("Oyuncunun Adını giriniz!", "UYARI");
                this.ActiveControl = txtAdEkle;
                return;
            }
            if (txtSoyadEkle.Text == "" || txtSoyadEkle.Text == null || txtSoyadEkle.Text == " ")
            {
                MessageBox.Show("Oyuncunun Soyadını giriniz!", "UYARI");
                this.ActiveControl = txtSoyadEkle;
                return;
            }
            if (txtTelefonEkle.Text == "" || txtTelefonEkle.Text == null || txtTelefonEkle.Text == " ")
            {
                MessageBox.Show("Oyuncunun Telefon numarasını giriniz!", "UYARI");
                this.ActiveControl = txtTelefonEkle;
                return;
            }
            if (txtPozisyonEkle.Text == "" || txtPozisyonEkle.Text == null || txtPozisyonEkle.Text == " ")
            {
                MessageBox.Show("Oyuncunun Pozisyonunu giriniz!", "UYARI");
                this.ActiveControl = txtPozisyonEkle;
                return;
            }
            if (txtBoyEkle.Text == "" || txtBoyEkle.Text == null || txtBoyEkle.Text == " ")
            {
                MessageBox.Show("Oyuncunun Boyunu giriniz!", "UYARI");
                this.ActiveControl = txtBoyEkle;
                return;
            }
            if (txtKiloEkle.Text == "" || txtKiloEkle.Text == null || txtKiloEkle.Text == " ")
            {
                MessageBox.Show("Oyuncunun Kilosunu giriniz!", "UYARI");
                this.ActiveControl = txtKiloEkle;
                return;
            }
            if (txtYasEkle.Text == "" || txtYasEkle.Text == null || txtYasEkle.Text == " ")
            {
                MessageBox.Show("Oyuncunun Yaşını giriniz!", "UYARI");
                this.ActiveControl = txtYasEkle;
                return;
            }
            List<Oyuncular> liste = veritabani.Oyunculars.Where(tablo => tablo.FormaNu == txtFormanuEkle.Text).ToList();
            if (liste.Count>0)
            {
                MessageBox.Show("Aynı Forma Numarasına sahip bir kayıt var.","");
            }
            else
            {
                Oyuncular OyuncuKayit = new Oyuncular();
                OyuncuKayit.FormaNu = txtFormanuEkle.Text;
                OyuncuKayit.Ad = txtAdEkle.Text;
                OyuncuKayit.Soyad = txtSoyadEkle.Text;
                OyuncuKayit.Pozisyon = txtPozisyonEkle.Text;
                OyuncuKayit.TelefonNu = txtTelefonEkle.Text;
                OyuncuKayit.Boy = txtBoyEkle.Text;
                OyuncuKayit.Kilo = txtKiloEkle.Text;
                OyuncuKayit.Yas = Convert.ToInt32(txtYasEkle.Text);
                OyuncuKayit.KatilmaTarihi = dtpKatilmaekle.Text;
                OyuncuKayit.Devamsizlik = "YOK";
                OyuncuKayit.DisiplinCezasi = "YOK";
                OyuncuKayit.Zimmet = "YOK";
                veritabani.Oyunculars.Add(OyuncuKayit);
                veritabani.SaveChanges();
                MessageBox.Show("Oyuncu kaydedildi.", "ONAY");
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            txtFormanuEkle.Focus();
        }
        private void btnOyuncuGuncelle_Click(object sender, EventArgs e)
        {
            if (txtFormanuGuncelle.Text == "" || txtFormanuGuncelle.Text == null || txtFormanuGuncelle.Text == " ")
            {
                MessageBox.Show("Oyuncunun Forma Numarasını giriniz!", "UYARI");
                this.ActiveControl = txtFormanuGuncelle;
                return;
            }
            if (txtAdGuncelle.Text == "" || txtAdGuncelle.Text == null || txtAdGuncelle.Text == " ")
            {
                MessageBox.Show("Oyuncunun Adını giriniz!", "UYARI");
                this.ActiveControl = txtAdGuncelle;
                return;
            }
            if (txtSoyadGuncelle.Text == "" || txtSoyadGuncelle.Text == null || txtSoyadGuncelle.Text == " ")
            {
                MessageBox.Show("Oyuncunun Soyadını giriniz!", "UYARI");
                this.ActiveControl = txtSoyadGuncelle;
                return;
            }
            if (txtTelefonGuncelle.Text == "" || txtTelefonGuncelle.Text == null || txtTelefonGuncelle.Text == " ")
            {
                MessageBox.Show("Oyuncunun Telefon numarasını giriniz!", "UYARI");
                this.ActiveControl = txtTelefonGuncelle;
                return;
            }
            if (txtPozisyonGuncelle.Text == "" || txtPozisyonGuncelle.Text == null || txtPozisyonGuncelle.Text == " ")
            {
                MessageBox.Show("Oyuncunun Pozisyonunu giriniz!", "UYARI");
                this.ActiveControl = txtPozisyonGuncelle;
                return;
            }
            if (txtBoyGuncelle.Text == "" || txtBoyGuncelle.Text == null || txtBoyGuncelle.Text == " ")
            {
                MessageBox.Show("Oyuncunun Boyunu giriniz!", "UYARI");
                this.ActiveControl = txtBoyGuncelle;
                return;
            }
            if (txtKiloGuncelle.Text == "" || txtKiloGuncelle.Text == null || txtKiloGuncelle.Text == " ")
            {
                MessageBox.Show("Oyuncunun Kilosunu giriniz!", "UYARI");
                this.ActiveControl = txtKiloGuncelle;
                return;
            }
            if (txtYasGuncelle.Text == "" || txtYasGuncelle.Text == null || txtYasGuncelle.Text == " ")
            {
                MessageBox.Show("Oyuncunun Yaşını giriniz!", "UYARI");
                this.ActiveControl = txtYasGuncelle;
                return;
            }
            // if (txtYasGuncelle.Text.Length <= 0)    //Bu da olur ama kullanıcı boşluk girerse lenght 1 olur çalışmaz.
            //  {
            //      MessageBox.Show("Oyuncunun Yaşını giriniz!", "UYARI");
            //     this.ActiveControl = txtYasGuncelle;
            //     return;
            // }
            else
            {
            bool degerVarMi = veritabani.Oyunculars.Where(w => w.FormaNu == txtFormanuGuncelle.Text).Any();
            if (degerVarMi)
            {
                var guncellenecek = veritabani.Oyunculars.Where(w => w.FormaNu == txtFormanuGuncelle.Text).FirstOrDefault();
                guncellenecek.Ad = txtAdGuncelle.Text;
                guncellenecek.Soyad = txtSoyadGuncelle.Text;
                guncellenecek.Pozisyon = txtPozisyonGuncelle.Text;
                guncellenecek.TelefonNu = txtTelefonGuncelle.Text;
                guncellenecek.Boy = txtBoyGuncelle.Text;
                guncellenecek.Kilo = txtKiloGuncelle.Text;
                guncellenecek.Yas = Convert.ToInt32(txtYasGuncelle.Text);
                guncellenecek.KatilmaTarihi = dtpKatilmaGuncelle.Value.ToString();
                veritabani.SaveChanges();
                MessageBox.Show("Oyuncu bilgileri güncellendi.", "ONAY");
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }
            txtFormanuGuncelle.Focus();
    }
        private void txtFormanuGuncelle_TextChanged(object sender, EventArgs e)
        {
            List<Oyuncular> liste = veritabani.Oyunculars.Where(tablo => tablo.FormaNu == txtFormanuGuncelle.Text).ToList();
            if (liste.Count > 0)
            {
                var guncellenecek = veritabani.Oyunculars.Where(w => w.FormaNu == txtFormanuGuncelle.Text).FirstOrDefault();
                txtAdGuncelle.Text = guncellenecek.Ad;
                txtSoyadGuncelle.Text = guncellenecek.Soyad;
                txtPozisyonGuncelle.Text = guncellenecek.Pozisyon;
                txtTelefonGuncelle.Text = guncellenecek.TelefonNu.ToString();
                txtBoyGuncelle.Text = guncellenecek.Boy;
                txtKiloGuncelle.Text = guncellenecek.Kilo;
                txtYasGuncelle.Text = guncellenecek.Yas.ToString();
                dtpKatilmaGuncelle.Text = guncellenecek.KatilmaTarihi;
                veritabani.SaveChanges();
            }
            if (txtFormanuGuncelle.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                dtpKatilmaGuncelle.Text = DateTime.Now.ToString();
            }
        }
        private void groupBox2_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "Güncellenecek oyuncunun forma numarasını giriniz.";
        }
        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "Oyuncu bilgileri boş bırakılamaz.";
        }
        private void FrmOyuncuekle_MouseHover(object sender, EventArgs e)
        {
            label19.Text = "";
        }

        private void txtFormanuEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtYasEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFormanuGuncelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtYasGuncelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}