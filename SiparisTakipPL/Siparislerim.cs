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
    public partial class Siparislerim : Form
    {
        public Siparislerim()
        {
            InitializeComponent();
            _siparisService = InstanceFactory.GetInstance<ISiparisService>();
            _siparisDetayService = InstanceFactory.GetInstance<ISiparisDetayService>();
            _yuklemePlaniDetayService = InstanceFactory.GetInstance<IYuklemePlaniDetayService>();
        }
        
        ISiparisService _siparisService;
        ISiparisDetayService _siparisDetayService;
        IYuklemePlaniDetayService _yuklemePlaniDetayService;

        public static int _siparisId = 0;
        public static int _siparisDetayId = 0;

        private void Siparislerim_Load(object sender, EventArgs e)
        {
            dgvSiparisler.DataSource = _siparisService.SiparisleriListele();
        }

        private void dgvSiparisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _siparisId = Convert.ToInt32(dgvSiparisler.CurrentRow.Cells[0].Value);
            SiparisDetaylariListele();
        }

        private void SiparisDetaylariListele()
        {
            dgvSiparisDetaylari.DataSource = _siparisDetayService.SiparisDetayDegerleriListele(_siparisId);
        }

        private void dgvSiparisDetaylari_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _siparisDetayId = Convert.ToInt32(dgvSiparisDetaylari.CurrentRow.Cells[0].Value);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            
                new SiparisDetayDuzenle().ShowDialog();
            
            
        }

        private void btnSiparisDetaySil_Click(object sender, EventArgs e)
        {
            DialogResult sil = MessageBox.Show("Siparişi Silmek İstiyor musunuz?", "Sipariş Takip", MessageBoxButtons.YesNoCancel);
            if (sil==DialogResult.Yes)
            {
                var result = _siparisDetayService.Sil(new SiparisDetay { SiparisDetayId = _siparisDetayId });

                if (result==0)
                {
                    MessageBox.Show("Siparişe ait Yükleme Planı oluşturulduğu için Sipariş Silinemiyor!","Sipariş Takip");
                }
                else
                {
                    SiparisDetaylariListele();
                }

                
            }
            else
            {

            }
            
        }

        private void btnSipariseEkle_Click(object sender, EventArgs e)
        {
            SiparisEkle._siparisId = _siparisId;
            new SiparisDetayEkle().Show();
        }
    }
}
