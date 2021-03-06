using Business.Abstract;
using Business.DependencyResolver.Ninject;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace SiparisTakipPL
{
    public partial class SiparisEkle : Form
    {
        public SiparisEkle()
        {
            InitializeComponent();
            _siparisService = InstanceFactory.GetInstance<ISiparisService>();
            _musteriService = InstanceFactory.GetInstance<IMusteriService>();
            _kullaniciService = InstanceFactory.GetInstance<IKullaniciService>();
        }

        ISiparisService _siparisService;
        IMusteriService _musteriService;
        IKullaniciService _kullaniciService;

        public static int _siparisId;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var result =  _siparisService.Ekle(new Siparis
            {
                SiparisNo = "10001",
                MusteriId = (int)cmbMusteri.SelectedValue,
                KullaniciId = 1,
                SiparisTarih = dtpSiparisTarih.Value,
                Aciklama = txtSiparisAciklama.Text
            });

            if (result == 0)
            {
                MessageBox.Show("Müşteri Alanı Boş. Müşteri Seçin!","Sipariş Takip");
            }

            else
            {
                _siparisId = result;
                this.Hide();
                new SiparisDetayEkle().ShowDialog();
                this.Close();
            }
        }

        private void SiparisEkle_Load(object sender, EventArgs e)
        {
            Utilities.LoadComboBox(cmbMusteri, _musteriService.MusteriListele(), "MusteriAd", "MusteriId");

            Utilities.AutoComplete(cmbMusteri);
        }

        private void cmbMusteri_Leave(object sender, EventArgs e)
        {
            Utilities.CombobxControl(cmbMusteri, label1);
        }
    }
}
