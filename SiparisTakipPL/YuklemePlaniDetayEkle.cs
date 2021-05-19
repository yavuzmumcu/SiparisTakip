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
    public partial class YuklemePlaniDetayEkle : Form
    {
        public YuklemePlaniDetayEkle()
        {
            InitializeComponent();
            _urunService = InstanceFactory.GetInstance<IUrunService>();
            _renkService = InstanceFactory.GetInstance<IRenkService>();
            _kaliteService = InstanceFactory.GetInstance<IKaliteService>();
            _siparisDetayService = InstanceFactory.GetInstance<ISiparisDetayService>();
            _otherEntitiesService = InstanceFactory.GetInstance<IOtherEntitiesService>();
            _sevkBilgiService = InstanceFactory.GetInstance<ISevkBilgiService>();
            _siparisService = InstanceFactory.GetInstance<ISiparisService>();
            _yuklemePlaniService = InstanceFactory.GetInstance<IYuklemePlaniService>();
            _yuklemePlaniDetayService = InstanceFactory.GetInstance<IYuklemePlaniDetayService>();
        }
        IUrunService _urunService;
        IRenkService _renkService;
        IKaliteService _kaliteService;
        ISiparisDetayService _siparisDetayService;
        IOtherEntitiesService _otherEntitiesService;
        ISevkBilgiService _sevkBilgiService;
        ISiparisService _siparisService;
        IYuklemePlaniService _yuklemePlaniService;
        IYuklemePlaniDetayService _yuklemePlaniDetayService;

        public static int _siparisId = 0;
        public static int _siparisDetayId = 0;
        public static int _kalanAdet = 0;

        private void SiparisDetaylariListele()
        {
            dgvSiparisDetaylari.DataSource = _siparisDetayService.SiparisDetayDegerleriListele(_siparisId);
        }

        private void YuklemePlaniDetayEkle_Load(object sender, EventArgs e)
        {
            dgvSiparisler.DataSource = _siparisService.SiparisleriListele();
            lblYuklemePlaniId.Text = Parametre._yuklemePlaniId.ToString();

            var yuklemePlaniDeger= _yuklemePlaniService.yuklemePlaniDegerleri(Parametre._yuklemePlaniId);
            lblSevkAdres.Text = yuklemePlaniDeger.SevkAdres;
            lblSevkArac.Text = yuklemePlaniDeger.SevkArac;
            lblYuklemePlaniAd.Text = yuklemePlaniDeger.YuklemePlaniAd;

            YuklemePlaniDetaylariListele();

        }

        private void dgvSiparisler_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            _siparisId = Convert.ToInt32(dgvSiparisler.CurrentRow.Cells[0].Value);
            SiparisDetaylariListele();
        }

        private void dgvSiparisDetaylari_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            _siparisDetayId = Convert.ToInt32(dgvSiparisDetaylari.CurrentRow.Cells[0].Value);
            _kalanAdet= Convert.ToInt32(dgvSiparisDetaylari.CurrentRow.Cells["kalanAdet"].Value);

            Parametre.SiparisAdet = Convert.ToInt32(dgvSiparisDetaylari.CurrentRow.Cells["Adet"].Value);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (_siparisDetayId != 0)
            {
                if (numAdet.Value > _kalanAdet)
                {
                    MessageBox.Show("Kalan Adetten Fazla ürün Eklenemez!", "Sipariş Takip");
                }
                else
                {

                    _yuklemePlaniDetayService.Ekle(new YuklemePlaniDetay
                    {
                        YuklemePlaniId = Parametre._yuklemePlaniId,
                        SiparisDetayId = _siparisDetayId,
                        Adet = (int)numAdet.Value
                    });

                    YuklemePlaniDetaylariListele();
                    SiparisDetaylariListele();

                    _siparisDetayId = 0;

                }
            }
            else
            {
                MessageBox.Show("Sipariş Seçilmedi!", "Sipariş Takip");
            }
        }

        private void YuklemePlaniDetaylariListele()
        {
            dgvYuklemePlani.DataSource = _yuklemePlaniDetayService.YuklemePlaniDetayListele(Parametre._yuklemePlaniId);
        }

        private void dgvYuklemePlani_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Parametre._yuklemePlaniDetayId = Convert.ToInt32(dgvYuklemePlani.CurrentRow.Cells[0].Value);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _yuklemePlaniDetayService.Sil(new YuklemePlaniDetay
            {
                Id = Parametre._yuklemePlaniDetayId
            });

            YuklemePlaniDetaylariListele();
            SiparisDetaylariListele();
        }
    }
}
