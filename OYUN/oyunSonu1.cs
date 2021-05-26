using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OYUN
{
    public partial class oyunSonu1 : Form
    {
        public oyunSonu1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void basla_Click(object sender, EventArgs e)
        {
            oyunBasi form1 = new oyunBasi();
            this.Hide();
            form1.Show();
        }

        private void oyunSonu1_Load(object sender, EventArgs e)
        {
            adSon.Text = oyunBasi.ad;
            soyadSon.Text = oyunBasi.soyad;
            sonPuan.Text = Convert.ToString(OYUN.toplam);
            DateTime tarih = DateTime.Now;
            lblTarih.Text = Convert.ToString(tarih);
            kalanSure.Text = Convert.ToString(OYUN.dakika + ":" + OYUN.saniye);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
