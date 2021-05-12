using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisTakipPL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }          

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        //void GirisKontrol()
        //{
        //    Personel personel = _personelService.PersonelGetir(new Personel
        //    {
        //        KullaniciAd = txtKullaniciAdi.Text,
        //        Sifre = txtSifre.Text
        //    });

        //    if (personel != null)
        //    {
        //        _personelAdSoyad = personel.AdSoyad;
        //        _birim = personel.BirimAd;
        //        _personelId = personel.PersonelId;
        //        _yetki = personel.Yetki;
        //        _birimId = personel.BirimId;

        //        this.Hide();

        //        new AnaForm().Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Kullanıcı Ade veya Şifre Hatalı!", "GİRİŞ");
        //    }


        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        GirisKontrol();
        //    }
        //}

        //private void btnGirisYap_Click(object sender, EventArgs e)
        //{
        //    GirisKontrol();
        //}
        //private void LoginForm_Load(object sender, EventArgs e)
        //{

        //}
    }
}
