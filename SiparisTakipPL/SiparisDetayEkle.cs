using Business.Abstract;
using Business.DependencyResolver.Ninject;
using Entities.ComplexTypes;
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
    public partial class SiparisDetayEkle : Form
    {
        public SiparisDetayEkle()
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

        int _siparisDetayId = 0;

        private void SiparisDetayEkle_Load(object sender, EventArgs e)
        {
            lblSiparisId.Text = SiparisEkle._siparisId.ToString();
            cbLogo.Checked = false;

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

            cmbKalite.SelectedValue = 2;
            cmbRenk.SelectedValue = 1;
            cmbPalet.SelectedValue = 3;
            cmbYuklemeTip.SelectedValue = 3;
            


            AutoComplete(cmbUrun);

            SiparisDeger siparisDeger = _siparisService.siparisDegerleriniGetir(SiparisEkle._siparisId);
            lblMusteriAd.Text = siparisDeger.MusteriAd;
            lblSiparisTarih.Text = siparisDeger.SiparisTarih.ToShortDateString();

            SiparisDetaylariniListele();

            if (dgvSiparisDetaylari.RowCount>0)
            {
               SevkBilgi sevkBilgi= _sevkBilgiService.SevkBilgileriGetir(SiparisEkle._siparisId);
                
            }
            
        }

        public void AutoComplete(ComboBox comboBox)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                collection.Add(comboBox.GetItemText(comboBox.Items[i]));
            }
            comboBox.AutoCompleteCustomSource = collection;
        }

        private void SiparisDetayEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dgvSiparisDetaylari.RowCount==0)
            {
                _siparisService.Sil(new Siparis { SiparisId = SiparisEkle._siparisId });
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            int result = Ekle();

            SiparisDetaylariniListele();

            if (result == 0)
            {
                MessageBox.Show("Boş Alan Bırakmayın!", "SİPARİŞ EKLE");
            }

            //if (_sevkBilgiService.SevkVarMi(SiparisEkle._siparisId) == 0 && result != 0)
            //{
               
            //}

            
        }

        private int Ekle()
        {
            return _siparisDetayService.Ekle(new SiparisDetay
            {
                SiparisId = SiparisEkle._siparisId,
                UrunId = (int)cmbUrun.SelectedValue,
                KaliteId = (int)cmbKalite.SelectedValue,
                RenkId = (int)cmbRenk.SelectedValue,
                YuklemeTipId = (int)cmbYuklemeTip.SelectedValue,
                PaletId = (int)cmbPalet.SelectedValue,
                Adet = (int)numAdet.Value,
                Aciklama = txtSiparisDetayAciklama.Text,
                Logo = txtLogo.Text,
                Kutu=txtKutu.Text
                
            });
        }

        private void SiparisDetaylariniListele()
        {
            dgvSiparisDetaylari.DataSource = _siparisDetayService.SiparisDetayDegerleriListele(SiparisEkle._siparisId);
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

        string Logo()
        {
            return txtLogo.Text;
        }

        private void cmbUrun_Leave(object sender, EventArgs e)
        {
            CombobxControl(cmbUrun, label3);
        }

        public void CombobxControl(ComboBox comboBox, Label label)
        {
            if (comboBox.FindStringExact(comboBox.Text) != -1)
            {
                label.ForeColor = Color.Black;
                comboBox.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Geçersiz Değer.");
                comboBox.SelectedIndex = 0;
                label.ForeColor = Color.Red;
                comboBox.ForeColor = Color.Red;
            }
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
                    cmbPalet.SelectedValue = 0;
                }
                else
                {
                    txtKutu.Visible = true;
                    cmbPalet.Enabled = false;
                    cmbPalet.SelectedValue = 5;
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _siparisDetayService.Sil(new SiparisDetay { SiparisDetayId = _siparisDetayId });

            SiparisDetaylariniListele();
        }

        private void dgvSiparisDetaylari_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _siparisDetayId =Convert.ToInt32(dgvSiparisDetaylari.CurrentRow.Cells[0].Value);
        }
    }
}
