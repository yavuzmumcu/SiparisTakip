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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnYeniSiparis_Click(object sender, EventArgs e)
        {
            new SiparisEkle().Show();
        }

        private void btnSiparislerim_Click(object sender, EventArgs e)
        {
            new Siparislerim().Show();
        }

        private void btnYuklemePlani_Click(object sender, EventArgs e)
        {
            new YuklemePlanlari().Show();
        }
    }
}
