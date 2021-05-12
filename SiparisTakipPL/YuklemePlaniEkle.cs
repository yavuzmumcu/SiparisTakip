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
    public partial class YuklemePlaniEkle : Form
    {
        public YuklemePlaniEkle()
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

        private void YuklemePlaniEkle_Load(object sender, EventArgs e)
        {
            cmbSevkArac.DataSource = _otherEntitiesService.SevkAracListele();
            cmbSevkArac.DisplayMember = "sevkAracAd";
            cmbSevkArac.ValueMember = "sevkAracId";

            new SiparisDetayEkle().AutoComplete(cmbSevkArac);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtYuklemePlaniAd.Text!="" && (int)cmbSevkArac.SelectedValue!=0)
            {
                Parametre._yuklemePlaniId = YuklemeEkle();

                SevkBilgiEkle();

                this.Hide();
                new YuklemePlaniDetayEkle().ShowDialog();
                this.Close();
            }
        }

        private void SevkBilgiEkle()
        {
            _sevkBilgiService.Ekle(new SevkBilgi
            {
                SiparisId = Parametre._yuklemePlaniId,
                SevkAracId = (int)cmbSevkArac.SelectedValue,
                SevkAdres = txtSevkAdres.Text
            });
        }

        private int YuklemeEkle()
        {
          return _yuklemePlaniService.Ekle(new YuklemePlani
            {
                Ad = txtYuklemePlaniAd.Text,
                KullaniciId = 1
            });
        }
    }
}
