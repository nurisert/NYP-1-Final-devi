using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace VideoKutuphanesi
{
    public partial class Form1 : Form
    {
        List<Video> tumVideolar = new List<Video>();
        string dosyaYolu = "videolarim.txt";

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

            // Tüm butonları garanti olsun diye buradan bağlıyoruz
            if (btnEkle != null) btnEkle.Click += btnEkle_Click;
            if (btnSil != null) btnSil.Click += btnSil_Click;
            if (btnKopyala != null) btnKopyala.Click += btnKopyala_Click;
            if (btnRastgele != null) btnRastgele.Click += btnRastgele_Click;

            // YENİ BUTON
            if (btnGuncelle != null) btnGuncelle.Click += btnGuncelle_Click;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (webView != null) await webView.EnsureCoreWebView2Async();
            VerileriYukle();
            ListeyiGuncelle(tumVideolar);

            txtArama.TextChanged += TxtArama_TextChanged;
            lstVideolar.SelectedIndexChanged += LstVideolar_SelectedIndexChanged;
        }

        private void VerileriYukle()
        {
            if (File.Exists(dosyaYolu))
            {
                string[] satirlar = File.ReadAllLines(dosyaYolu);
                foreach (string satir in satirlar)
                {
                    string[] parca = satir.Split('|');
                    if (parca.Length >= 3)
                    {
                        tumVideolar.Add(new Video
                        {
                            Baslik = parca[0],
                            YoutubeLink = parca[1],
                            Etiketler = parca[2],
                            Aciklama = parca[0]
                        });
                    }
                }
            }
            else
            {
                VeriEkle("Beyin Bedava", "https://www.youtube.com/watch?v=31l4fNgNuQ4", "komik,röportaj", "Efsane");
                DosyayaKaydet();
            }
        }

        private void VeriEkle(string baslik, string link, string etiketler, string aciklama)
        {
            tumVideolar.Add(new Video
            {
                Baslik = baslik,
                YoutubeLink = link,
                Etiketler = etiketler,
                Aciklama = aciklama
            });
        }

        // --- BUTONLAR ---

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYeniBaslik.Text) || string.IsNullOrWhiteSpace(txtYeniLink.Text))
            {
                MessageBox.Show("Başlık ve Link boş olamaz!", "Hata");
                return;
            }

            VeriEkle(txtYeniBaslik.Text, txtYeniLink.Text, txtYeniAnahtar.Text, txtYeniBaslik.Text);

            DosyayaKaydet();
            ListeyiGuncelle(tumVideolar);

            KutulariTemizle();
            MessageBox.Show("Video eklendi!");
        }

        // --- İŞTE İSTEDİĞİN GÜNCELLEME ÖZELLİĞİ ---
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // 1. Bir video seçili mi?
            if (lstVideolar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen önce listeden güncellenecek videoyu seç!", "Uyarı");
                return;
            }

            // 2. Seçili videoyu al
            Video secilen = (Video)lstVideolar.SelectedItem;

            // 3. Videonun bilgilerini kutulardaki yeni yazılarla değiştir
            secilen.Baslik = txtYeniBaslik.Text;
            secilen.YoutubeLink = txtYeniLink.Text;
            secilen.Etiketler = txtYeniAnahtar.Text; // Buraya yeni etiketleri yazacaksın

            // 4. Kaydet ve Listeyi Yenile
            DosyayaKaydet();
            ListeyiGuncelle(tumVideolar);

            MessageBox.Show("Video bilgileri ve etiketler güncellendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstVideolar.SelectedItem == null) return;
            if (MessageBox.Show("Sileyim mi?", "Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tumVideolar.Remove((Video)lstVideolar.SelectedItem);
                DosyayaKaydet();
                ListeyiGuncelle(tumVideolar);
                KutulariTemizle();

                if (webView != null && webView.CoreWebView2 != null) webView.CoreWebView2.Navigate("about:blank");
                lblReplik.Text = "";
            }
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            // Önce bir mesaj gösterelim ki butonun çalıştığını anlayalım
            // (Bu satırı testten sonra silebilirsin)
            // MessageBox.Show("Butona basıldı!"); 

            if (lstVideolar.SelectedItem != null)
            {
                // Seçili videoyu al
                Video secilen = (Video)lstVideolar.SelectedItem;

                // Panoya (Clipboard) kopyala
                Clipboard.SetText(secilen.YoutubeLink);

                MessageBox.Show("Link kopyalandı:\n" + secilen.YoutubeLink);
            }
            else
            {
                MessageBox.Show("Lütfen önce listeden kopyalanacak videoyu seçin!");
            }
        }

        private void btnRastgele_Click(object sender, EventArgs e)
        {
            if (lstVideolar.Items.Count > 0)
                lstVideolar.SelectedIndex = new Random().Next(0, lstVideolar.Items.Count);
        }

        private void TxtArama_TextChanged(object sender, EventArgs e)
        {
            string aranan = MetniTemizle(txtArama.Text);
            if (string.IsNullOrEmpty(aranan)) { ListeyiGuncelle(tumVideolar); return; }

            var bulunanlar = tumVideolar.Where(v =>
                MetniTemizle(v.Baslik).Contains(aranan) ||
                MetniTemizle(v.Etiketler).Contains(aranan)
            ).ToList();
            ListeyiGuncelle(bulunanlar);
        }

        // --- SEÇİNCE KUTULARI DOLDURMA ---
        private void LstVideolar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVideolar.SelectedItem == null) return;
            Video secilen = (Video)lstVideolar.SelectedItem;

            lblReplik.Text = secilen.Aciklama;

            // BURASI YENİ: Seçince aşağıdaki kutular dolsun ki düzenleyebilesin
            txtYeniBaslik.Text = secilen.Baslik;
            txtYeniLink.Text = secilen.YoutubeLink;
            txtYeniAnahtar.Text = secilen.Etiketler;

            if (webView != null && webView.CoreWebView2 != null) webView.CoreWebView2.Navigate(secilen.YoutubeLink);
            else webView.Source = new Uri(secilen.YoutubeLink);
        }

        private void ListeyiGuncelle(List<Video> liste)
        {
            liste.Sort((v1, v2) => v1.Baslik.CompareTo(v2.Baslik));
            lstVideolar.Items.Clear();
            foreach (var video in liste) lstVideolar.Items.Add(video);
            if (lblAdet != null) lblAdet.Text = "Video Sayısı: " + liste.Count;
        }

        private void DosyayaKaydet()
        {
            List<string> satirlar = new List<string>();
            foreach (var v in tumVideolar) satirlar.Add(v.Baslik + "|" + v.YoutubeLink + "|" + v.Etiketler);
            File.WriteAllLines(dosyaYolu, satirlar);
        }

        private void KutulariTemizle()
        {
            txtYeniBaslik.Clear();
            txtYeniLink.Clear();
            txtYeniAnahtar.Clear();
        }

        private string MetniTemizle(string metin)
        {
            if (string.IsNullOrEmpty(metin)) return "";
            return metin.ToLower().Replace("ç", "c").Replace("ş", "s").Replace("ı", "i").Replace("ğ", "g").Replace("ü", "u").Replace("ö", "o");
        }

        private void txtYeniBaslik_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Video
    {
        public string Baslik { get; set; }
        public string YoutubeLink { get; set; }
        public string Etiketler { get; set; }
        public string Aciklama { get; set; }

        public override string ToString()
        {
            string etiketGosterimi = "";
            if (!string.IsNullOrEmpty(Etiketler))
                etiketGosterimi = "  (#" + Etiketler.Replace(",", " #").Replace(" ", "") + ")";
            return Baslik + etiketGosterimi;
        }
    }
}