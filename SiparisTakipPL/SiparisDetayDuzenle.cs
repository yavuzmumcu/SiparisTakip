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

            new SiparisDetayEkle().AutoComplete(cmbUrun);

            SiparisDetaylariniGetir();

        }

        private void ComboboxDoldur()
        {
            cmbRenk.DataSource = _renkService.RenkListele();
            cmbRenk.DisplayMember = "renkad";
            cmbRenk.ValueMember = "renkId";

            cmbUrun.DataSource = _urunService.UrunListele();
            cmbUrun.DisplayMember = "stokkod";
            cmbUrun.ValueMember = "UrunId";

            cmbKalite.DataSource = _kaliteService.KaliteListele();
            cmbKalite.DisplayMember = "kaliteAd";
            cmbKalite.ValueMember = "kaliteId";

            cmbPalet.DataSource = _otherEntitiesService.PaletListele();
            cmbPalet.DisplayMember = "PaletAd";
            cmbPalet.ValueMember = "PaletId";

            cmbYuklemeTip.DataSource = _otherEntitiesService.YuklemeTipListele();
            cmbYuklemeTip.DisplayMember = "YuklemeTipAd";
            cmbYuklemeTip.ValueMember = "YuklemeTipId";
        }

        private void SiparisDetaylariniGetir()
        {
            SiparisDetay siparisDetay = _siparisDetayService.SiparisDetay(Siparislerim._siparisDetayId);
            cmbKalite.SelectedValue = siparisDetay.KaliteId;
            cmbUrun.SelectedValue = siparisDetay.UrunId;
            cmbRenk.SelectedValue = siparisDetay.RenkId;
            cmbPalet.SelectedValue = siparisDetay.PaletId;
            cmbYuklemeTip.SelectedValue = siparisDetay.YuklemeTipId;
            numAdet.Value = siparisDetay.Adet;
            txtSiparisDetayAciklama.Text = siparisDetay.Aciklama;
            txtLogo.Text = siparisDetay.Logo;
            txtKutu.Text = siparisDetay.Kutu;
        }

        private void cmbUrun_Leave(object sender, EventArgs e)
        {
            new SiparisDetayEkle().CombobxControl(cmbUrun, label3);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _siparisDetayService.Guncelle(new SiparisDetay
            {
                UrunId=(int)cmbUrun.SelectedValue,
                KaliteId = (int)cmbKalite.SelectedValue,
                RenkId = (int)cmbRenk.SelectedValue,
                PaletId = (int)cmbPalet.SelectedValue,
                YuklemeTipId = (int)cmbYuklemeTip.SelectedValue,
                Logo = txtLogo.Text,
                Aciklama = txtSiparisDetayAciklama.Text,
                Adet=(int)numAdet.Value,
                Kutu=txtKutu.Text,

                SiparisDetayId = Siparislerim._siparisDetayId

            });
        }

        private void cmbYuklemeTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            YuklemeTip yuklemeTip = _otherEntitiesService.Kutu((int)cmbYuklemeTip.SelectedIndex);

            if (yuklemeTip != null)
            {
                if (yuklemeTip.Kutu == 0)
                {
                    txtKutu.Visible = false;
                    cmbPalet.Enabled = true;
                    txtKutu.Text = "";
                    //cmbPalet.SelectedValue = 0;
                }
                else
                {
                    txtKutu.Visible = true;
                    cmbPalet.Enabled = false;
                    cmbPalet.SelectedValue = 5;
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
