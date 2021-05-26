using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace OYUN
{
    public partial class oyunBasi : Form
    {
        public oyunBasi()
        {
            InitializeComponent();
        }
        public static string ad, soyad;
         
        private void basla_Click(object sender, EventArgs e)
        {
            
            if (isimBox.Text == "" && soyisimBox.Text == "" ){ lblHata.Visible = true; }

            else
            {
                 
                ad = isimBox.Text;
                soyad = soyisimBox.Text;
                OYUN oyun = new OYUN();
                this.Hide();
                oyun.Show();
            }
          
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            
        }
    }
}
