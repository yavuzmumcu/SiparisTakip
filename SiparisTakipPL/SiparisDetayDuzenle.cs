using Business.Abstract;
using Business.DependencyResolver.Ninject;
using Entities.Concrete;
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
    public partial class SiparisDetayDuzenle : Form
    {
        public SiparisDetayDuzenle()
        {
            InitializeComponent();
            _urunService = InstanceFactory.GetInstance<IUrunService>();
            _renkService = InstanceFactory.GetInstance<IRenkService>();
            _kaliteService = InstanceFactory.GetInstance<IKaliteService>();
            _siparisDetayService = InstanceFactory.GetInstance<ISiparisDetayService>();
            _otherEntitiesService = InstanceFactory.GetInstance<IOtherEntitiesService>();
            _sevkBilgiService = InstanceFactory.GetInstance<ISevkBilgiService>();
            _siparisService = InstanceFactory.GetInstance<ISiparisService>();
        }
        IUrunService _urunService;
        IRenkService _renkService;
        IKaliteService _kaliteService;
        ISiparisDetayService _siparisDetayService;
        IOtherEntitiesService _otherEntitiesService;
        ISevkBilgiService _sevkBilgiService;
        ISiparisService _siparisService;

        
        private void SiparisDetayDuzenle_Load(object sender, EventArgs e)
        {
            cbLogo.Checked = false;

            ComboboxDoldur();

            Utilities.AutoComplete(cmbUrun);

            SiparisDetaylariniGetir();

        }

        private void ComboboxDoldur()
        {
            Utilities.LoadComboBox(cmbRenk, _renkService.RenkListele(), "renkad", "renkId");

            Utilities.LoadComboBox(cmbUrun, _urunService.UrunListele(), "stokkod", "UrunId");

            Utilities.LoadComboBox(cmbKalite, _kaliteService.KaliteListele(), "kaliteAd", "kaliteId");

            Utilities.LoadComboBox(cmbYuklemeTip, _otherEntitiesService.YuklemeTipListele(), "YuklemeTipAd", "YuklemeTipId");

            Utilities.LoadComboBox(cmbPalet, _otherEntitiesService.PaletListele(), "PaletAd", "PaletId");


        }

        private void SiparisDetaylariniGetir()
        {
            var siparisDetay = _siparisDetayService.SiparisDetay(Siparislerim._siparisDetayId);

            cmbKalite.SelectedValue = siparisDetay.KaliteId;
            cmbUrun.SelectedValue = siparisDetay.UrunId;
            cmbRenk.SelectedValue = siparisDetay.RenkId;
            cmbYuklemeTip.SelectedValue = siparisDetay.YuklemeTipId;
            cmbPalet.SelectedValue = siparisDetay.PaletId;

            numAdet.Value = siparisDetay.Adet;
            txtSiparisDetayAciklama.Text = siparisDetay.Aciklama;
            txtLogo.Text = siparisDetay.Logo;
            txtKutu.Text = siparisDetay.Kutu;

            if (siparisDetay.Logo=="")
            {
                cbLogo.Checked = false;
            }
            else
            {
                cbLogo.Checked = true;
            }
        }

        private void cmbUrun_Leave(object sender, EventArgs e)
        {
            Utilities.CombobxControl(cmbUrun, label3);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var reuslt = _siparisDetayService.Guncelle(new SiparisDetay
            {
                UrunId = (int)cmbUrun.SelectedValue,
                KaliteId = (int)cmbKalite.SelectedValue,
                RenkId = (int)cmbRenk.SelectedValue,
                YuklemeTipId = (int)cmbYuklemeTip.SelectedValue,
                PaletId = (int)cmbPalet.SelectedValue,
                Logo = txtLogo.Text,
                Aciklama = txtSiparisDetayAciklama.Text,
                Adet = (int)numAdet.Value,
                Kutu = txtKutu.Text,

                SiparisDetayId = Siparislerim._siparisDetayId

            });
            if (reuslt == 0)
            {
                MessageBox.Show("Siparişe ait Yükleme Planı oluşturulduğu için Sipariş Güncellenemyior!");
            }
            else
            {
                MessageBox.Show("Kayıt Başarıyla Güncellendi!");
            }
        }

        private void cmbYuklemeTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            var yuklemeTip = _otherEntitiesService.Kutu((int)cmbYuklemeTip.SelectedIndex);

            if (yuklemeTip != null)
            {
                if (yuklemeTip.Kutu == 0)
                {
                    txtKutu.Visible = false;
                    cmbPalet.Enabled = true;
                    txtKutu.Text = "";
                    cmbPalet.SelectedValue = 0;
                }
                else if (yuklemeTip.Kutu == 1)
                {
                    txtKutu.Visible = true;
                    cmbPalet.Enabled = false;
                    cmbPalet.SelectedValue = 5;
                }
                else if (yuklemeTip.Kutu == 2)
                {
                    txtKutu.Visible = true;
                    cmbPalet.Enabled = true;
                    cmbPalet.SelectedValue = 0;
                }
            }
        }

        private void cbLogo_CheckedChanged(object sender, EventArgs e)
        {      
                if (cbLogo.Checked)
                {
                    txtLogo.Visible = true;
                }
                else
                {
                    txtLogo.Visible = false;
                }
            }       
    }
}


