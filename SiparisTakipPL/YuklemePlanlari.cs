using Business.Abstract;
using Business.DependencyResolver.Ninject;
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
    public partial class YuklemePlanlari : Form
    {
        public YuklemePlanlari()
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

        private void YuklemePlanlari_Load(object sender, EventArgs e)
        {
            dgvYuklemePlanlari.DataSource = _yuklemePlaniService.YuklemePlanlariListele();
        }

        private void btnPlanOlustur_Click(object sender, EventArgs e)
        {
            new YuklemePlaniEkle().Show();
        }

        private void dgvYuklemePlanlari_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Parametre._yuklemePlaniId = Convert.ToInt32(dgvYuklemePlanlari.CurrentRow.Cells[0].Value);
            dgvYuklemePlaniDetaylari.DataSource = _yuklemePlaniDetayService.YuklemePlaniDetayListele(Parametre._yuklemePlaniId);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            new YuklemePlaniDetayEkle().Show();
        }
    }
}
