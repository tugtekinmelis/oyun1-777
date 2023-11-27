using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun1_777
{
    public partial class Form1 : Form
    {
        Oyuncu oyuncu1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Oyuncu oyuncu1 = new Oyuncu();

            oyuncu1.Id = "142555485697458548";
            oyuncu1.Ad = "Ramiz";
            oyuncu1.Soyad = "Yurdakul";
            oyuncu1.Posta = "yurdakul_ramiz_2000@gmail.com";
            oyuncu1.Puan = 100;
            oyuncu1.KayitTarih = DateTime.Now;
            oyuncu1.Aktif = false;

            MessageBox.Show("Ad:" + oyuncu1.Ad + "\nPuan:" + oyuncu1.Puan + "\nAktif:" + oyuncu1.Aktif);

    
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            oyuncu1 = new Oyuncu();
            oyuncu1.Id = random.Next(1000,10000).ToString();
            oyuncu1.Ad = txtAd.Text;
            oyuncu1.Soyad = txtSoyad.Text;
            oyuncu1.Posta = txtPosta.Text;
            oyuncu1.KayitTarih = DateTime.Now;
            oyuncu1.Puan = 100; //isterseniz random yaparız.
            oyuncu1.Aktif = false;
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ID:" + oyuncu1.Id + "\nAd:" + oyuncu1.Puan + "\nKayıt:" + oyuncu1.KayitTarih);
            //Her sınıf için bu işi yapan özel bir metot vardır. Bu metoda "kurucu metot" denir.
        }
    }
}
