using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace OYUN
{
    public partial class OYUN : Form
    {
        public OYUN()
        {
            InitializeComponent();
           
        }
        MySqlConnection baglan = new MySqlConnection("Server=localhost;uid=root; Password=rootMysql.1234;");
        MySqlDataAdapter baglayici = new MySqlDataAdapter();
        MySqlCommand komut = new MySqlCommand();
        MySqlDataReader dr;
         
        public static int saniye = 60;
        public static int dakika = 0;
        int puan = 0;
        public static int toplam = 0;
        int saniye2 = 20;
        int syc = 1;
        string cevap;
        string yeniCevap;
        private void OYUN_Load(object sender, EventArgs e)
        {

            timer1.Start();
            dakika = 4;
           

           

            
            sonraki.Text = "Sonraki Soru";
            Random random = new Random();
            
           
            string sqlsorgusu = "Select * from sorucevap.dortlu order by rand() limit 1"; 

            


            komut.CommandText = sqlsorgusu;
            komut.Connection = baglan;

            baglayici.SelectCommand = komut;

            baglan.Open();

            dr = komut.ExecuteReader();



            dr.Read();
                soru.Text = dr.GetString("soru");
                cevap = dr.GetString("cevap");
                yeniCevap = cevap;
               
                if (cevap.Length == 4 )
                { 
                    harf1.Text = cevap.Substring(0, 1);
                    harf2.Text = cevap.Substring(1, 1);
                    harf3.Text = cevap.Substring(2, 1);
                    harf4.Text = cevap.Substring(3, 1);
                    puan = 400;
                    lblPuan.Text = Convert.ToString(puan);
                    

                }

               
            
            
           
          
        }

        private void harf4_Click(object sender, EventArgs e)
        {

        }

        private void harf2_Click(object sender, EventArgs e)
        {

        }

        private void harfAl_Click(object sender, EventArgs e)
        { 
            Random sayi = new Random();
            List<int> sayilar = new List<int>();
            lblPuan.Text = Convert.ToString(puan);
            
                 cevap = dr.GetString("cevap");
                 int harfS = cevap.Length;
                 int uret;
                while (sayilar.Count < harfS) {
         
                uret = sayi.Next(0, harfS);
                
              

                
                while(sayilar.Contains(uret))
                {
                
                    uret = sayi.Next(0, harfS);
                }
                sayilar.Add(uret);




                if (uret == 0)  
                    {
                        
                       if (harf1.Visible==true)
                    {
                        puan += 100;
                        
                    }
                    puan -= 100;
                    harf1.Visible = true; break;
                }
                    else if (uret == 1)
                    {
                    if (harf2.Visible == true)
                    {
                        puan += 100;

                    }
                    puan -= 100;
                    harf2.Visible = true; break;
                }
                    else if (uret == 2)
                    {
                    if (harf3.Visible == true)
                    {
                        puan += 100;

                    }
                    puan -= 100;
                    harf3.Visible = true; break;
                }
                    else if (uret == 3)
                    {
                    if (harf4.Visible == true)
                    {
                        puan += 100;

                    }
                    puan -= 100;
                    harf4.Visible = true; break;
                }
                    else if (uret == 4)
                    {
                    if (harf5.Visible == true)
                    {
                        puan += 100;

                    }
                    puan -= 100;
                    harf5.Visible = true; break;
                }
                    else if (uret == 5)
                    {
                    if (harf6.Visible == true)
                    {
                        puan += 100;

                    }
                    puan -= 100;
                    harf6.Visible = true; break;
                }
                    else if (uret == 6)
                    {
                    if (harf7.Visible == true)
                    {
                        puan += 100;

                    }
                    puan -= 100;
                    harf7.Visible = true; break;
                }
                    else if (uret == 7)
                    {
                    if (harf8.Visible == true)
                    {
                        puan += 100;

                    }
                    puan -= 100;
                    harf8.Visible = true; break;
                }
                    else if (uret == 8)
                    {
                    if (harf9.Visible == true)
                    {
                        puan += 100;

                    }
                    puan -= 100;
                    harf9.Visible = true; break;
                }
                    else if (uret == 9)
                    {
                    if (harf10.Visible == true)
                    {
                        puan += 100;

                    }
                    puan -= 100;
                    harf10.Visible = true; break;
                }

                
            }
            
        }

        private void harf3_Click(object sender, EventArgs e)
        {

        }

        private void harf1_Click(object sender, EventArgs e)
        {

        }
        
        private void tahmin_Click(object sender, EventArgs e)

        {
            
            saniye2 = 20;
            onay.Enabled = true;
            
            timer2.Start();
            timer1.Stop();
            lblSaniye2.Visible = true;
            if (lblSaniye2.Text== "Tahmin süreniz bitti!")
            {
                if(label1.Text == "YANLIŞ YANIT!")
                {
                    toplam = toplam - puan;
                }
            }
        }

        private void sonraki_Click(object sender, EventArgs e)
        {
           
            sonraki.Enabled = false;
            lblSaniye2.Visible = false;
            tahminBox.Enabled = true;
           
            tahmin.Enabled = true;
            tahminBox.Text = "";
           
            timer1.Start();
           
        

          
           
            label1.Text =" ";
           
            harf1.Visible = false;
            harf2.Visible = false;
            harf3.Visible = false;
            harf4.Visible = false;
            harf5.Visible = false;
            harf6.Visible = false;
            harf7.Visible = false;
            harf8.Visible = false;
            harf9.Visible = false;
            harf10.Visible = false;

            Random random = new Random();

            baglan.Close();

            


            if (syc == 2) 

            {

                string sqlsorgusu = "Select * from sorucevap.dortlu order by rand() limit 1";
                komut.CommandText = sqlsorgusu;
                komut.Connection = baglan;

                baglayici.SelectCommand = komut;

                baglan.Open();

                dr = komut.ExecuteReader();
                dr.Read();
               
                cevap = dr.GetString("cevap");
                
                while(yeniCevap==cevap)
                {
                    baglan.Close();
                    baglan.Open();
                     sqlsorgusu = "Select * from sorucevap.dortlu order by rand() limit 1";
                    komut.CommandText = sqlsorgusu;
                    komut.Connection = baglan;

                    baglayici.SelectCommand = komut;

                 

                    dr = komut.ExecuteReader();
                    dr.Read();
                    
                    cevap = dr.GetString("cevap");

                }
                soru.Text = dr.GetString("soru");
                if (cevap.Length == 4)
                {
                    harf1.Text = cevap.Substring(0, 1);
                    harf2.Text = cevap.Substring(1, 1);
                    harf3.Text = cevap.Substring(2, 1);
                    harf4.Text = cevap.Substring(3, 1);
                    puan = 400;
                    lblPuan.Text = Convert.ToString(puan);

                }
            }
            if (syc == 3)

            {
                h5.Visible = true;
                string sqlsorgusu = "Select * from sorucevap.besli order by rand() limit 1";
                komut.CommandText = sqlsorgusu;
                komut.Connection = baglan;

                baglayici.SelectCommand = komut;

                baglan.Open();

                dr = komut.ExecuteReader();
                dr.Read();
                
                 cevap = dr.GetString("cevap");

                while (yeniCevap == cevap)
                {
                    baglan.Close();
                    baglan.Open();
                    sqlsorgusu = "Select * from sorucevap.besli order by rand() limit 1";
                    komut.CommandText = sqlsorgusu;
                    komut.Connection = baglan;

                    baglayici.SelectCommand = komut;



                    dr = komut.ExecuteReader();
                    dr.Read();

                    cevap = dr.GetString("cevap");

                }
                soru.Text = dr.GetString("soru");
                if (cevap.Length == 5)
                {
                    harf1.Text = cevap.Substring(0, 1);
                    harf2.Text = cevap.Substring(1, 1);
                    harf3.Text = cevap.Substring(2, 1);
                    harf4.Text = cevap.Substring(3, 1);
                    harf5.Text = cevap.Substring(4, 1);
                    puan = 500;
                    lblPuan.Text = Convert.ToString(puan);

                }
            }
            if (syc == 4)

            {
                h5.Visible = true;
                string sqlsorgusu = "Select * from sorucevap.besli order by rand() limit 1";
                komut.CommandText = sqlsorgusu;
                komut.Connection = baglan;

                baglayici.SelectCommand = komut;

                baglan.Open();

                dr = komut.ExecuteReader();
                dr.Read();
                 
                  cevap = dr.GetString("cevap");

                while (yeniCevap == cevap)
                {
                    baglan.Close();
                    baglan.Open();
                    sqlsorgusu = "Select * from sorucevap.besli order by rand() limit 1";
                    komut.CommandText = sqlsorgusu;
                    komut.Connection = baglan;

                    baglayici.SelectCommand = komut;



                    dr = komut.ExecuteReader();
                    dr.Read();

                    cevap = dr.GetString("cevap");

                }
                soru.Text = dr.GetString("soru");
                if (cevap.Length == 5)
                {
                    harf1.Text = cevap.Substring(0, 1);
                    harf2.Text = cevap.Substring(1, 1);
                    harf3.Text = cevap.Substring(2, 1);
                    harf4.Text = cevap.Substring(3, 1);
                    harf5.Text = cevap.Substring(4, 1);
                   
                    puan = 500;
                    lblPuan.Text = Convert.ToString(puan);

                }
            }
            if (syc == 5)

            {
                h6.Visible = true;
                string sqlsorgusu = "Select * from sorucevap.altili order by rand() limit 1";
                komut.CommandText = sqlsorgusu;
                komut.Connection = baglan;

                baglayici.SelectCommand = komut;

                baglan.Open();

                dr = komut.ExecuteReader();
                dr.Read();
                
                  cevap = dr.GetString("cevap");

                while (yeniCevap == cevap)
                {
                    baglan.Close();
                    baglan.Open();
                    sqlsorgusu = "Select * from sorucevap.altili order by rand() limit 1";
                    komut.CommandText = sqlsorgusu;
                    komut.Connection = baglan;

                    baglayici.SelectCommand = komut;



                    dr = komut.ExecuteReader();
                    dr.Read();

                    cevap = dr.GetString("cevap");

                }
                soru.Text = dr.GetString("soru");
                if (cevap.Length == 6)
                {
                    harf1.Text = cevap.Substring(0, 1);
                    harf2.Text = cevap.Substring(1, 1);
                    harf3.Text = cevap.Substring(2, 1);
                    harf4.Text = cevap.Substring(3, 1);
                    harf5.Text = cevap.Substring(4, 1);
                    harf6.Text = cevap.Substring(5, 1);
                    
                    puan = 600;
                    lblPuan.Text = Convert.ToString(puan);

                }
            }
            if (syc == 6)

            {
                h6.Visible = true;
                string sqlsorgusu = "Select * from sorucevap.altili order by rand() limit 1";
                komut.CommandText = sqlsorgusu;
                komut.Connection = baglan;

                baglayici.SelectCommand = komut;

                baglan.Open();

                dr = komut.ExecuteReader();
                dr.Read();
              
                 cevap = dr.GetString("cevap");

                while (yeniCevap == cevap)
                {
                    baglan.Close();
                    baglan.Open();
                    sqlsorgusu = "Select * from sorucevap.altili order by rand() limit 1";
                    komut.CommandText = sqlsorgusu;
                    komut.Connection = baglan;

                    baglayici.SelectCommand = komut;



                    dr = komut.ExecuteReader();
                    dr.Read();

                    cevap = dr.GetString("cevap");

                }
                soru.Text = dr.GetString("soru");
                if (cevap.Length == 6)
                {
                    harf1.Text = cevap.Substring(0, 1);
                    harf2.Text = cevap.Substring(1, 1);
                    harf3.Text = cevap.Substring(2, 1);
                    harf4.Text = cevap.Substring(3, 1);
                    harf5.Text = cevap.Substring(4, 1);
                    harf6.Text = cevap.Substring(5, 1);
                    
                    puan = 600;
                    lblPuan.Text = Convert.ToString(puan);

                }
            }
            if (syc == 7)

            {
                h7.Visible = true;
                string sqlsorgusu = "Select * from sorucevap.yedili order by rand() limit 1";
                komut.CommandText = sqlsorgusu;
                komut.Connection = baglan;

                baglayici.SelectCommand = komut;

                baglan.Open();

                dr = komut.ExecuteReader();
                dr.Read();
                
                  cevap = dr.GetString("cevap");

                while (yeniCevap == cevap)
                {
                    baglan.Close();
                    baglan.Open();
                    sqlsorgusu = "Select * from sorucevap.yedili order by rand() limit 1";
                    komut.CommandText = sqlsorgusu;
                    komut.Connection = baglan;

                    baglayici.SelectCommand = komut;



                    dr = komut.ExecuteReader();
                    dr.Read();

                    cevap = dr.GetString("cevap");

                }
                soru.Text = dr.GetString("soru");
                if (cevap.Length == 7)
                {
                    harf1.Text = cevap.Substring(0, 1);
                    harf2.Text = cevap.Substring(1, 1);
                    harf3.Text = cevap.Substring(2, 1);
                    harf4.Text = cevap.Substring(3, 1);
                    harf5.Text = cevap.Substring(4, 1);
                    harf6.Text = cevap.Substring(5, 1);
                    harf7.Text = cevap.Substring(6, 1);
                   
                    
                    puan = 700;
                    lblPuan.Text = Convert.ToString(puan);

                }
            }
            if (syc == 8)

            {
                h7.Visible = true;
                string sqlsorgusu = "Select * from sorucevap.yedili order by rand() limit 1";
                komut.CommandText = sqlsorgusu;
                komut.Connection = baglan;

                baglayici.SelectCommand = komut;

                baglan.Open();

                dr = komut.ExecuteReader();
                dr.Read();
               
                  cevap = dr.GetString("cevap");

                while (yeniCevap == cevap)
                {
                    baglan.Close();
                    baglan.Open();
                    sqlsorgusu = "Select * from sorucevap.yedili order by rand() limit 1";
                    komut.CommandText = sqlsorgusu;
                    komut.Connection = baglan;

                    baglayici.SelectCommand = komut;



                    dr = komut.ExecuteReader();
                    dr.Read();

                    cevap = dr.GetString("cevap");

                }
                soru.Text = dr.GetString("soru");
                if (cevap.Length == 7)
                {
                    harf1.Text = cevap.Substring(0, 1);
                    harf2.Text = cevap.Substring(1, 1);
                    harf3.Text = cevap.Substring(2, 1);
                    harf4.Text = cevap.Substring(3, 1);
                    harf5.Text = cevap.Substring(4, 1);
                    harf6.Text = cevap.Substring(5, 1);
                    harf7.Text = cevap.Substring(6, 1);
                     
               
                    puan = 700;
                    lblPuan.Text = Convert.ToString(puan);

                }
            }
            if (syc == 9)

            {
                h8.Visible = true;
                string sqlsorgusu = "Select * from sorucevap.sekizli order by rand() limit 1";
                komut.CommandText = sqlsorgusu;
                komut.Connection = baglan;

                baglayici.SelectCommand = komut;

                baglan.Open();

                dr = komut.ExecuteReader();
                dr.Read();
                
                  cevap = dr.GetString("cevap");

                while (yeniCevap == cevap)
                {
                    baglan.Close();
                    baglan.Open();
                    sqlsorgusu = "Select * from sorucevap.sekizli order by rand() limit 1";
                    komut.CommandText = sqlsorgusu;
                    komut.Connection = baglan;

                    baglayici.SelectCommand = komut;



                    dr = komut.ExecuteReader();
                    dr.Read();

                    cevap = dr.GetString("cevap");

                }
                soru.Text = dr.GetString("soru");
                if (cevap.Length == 8)
                {
                    harf1.Text = cevap.Substring(0, 1);
                    harf2.Text = cevap.Substring(1, 1);
                    harf3.Text = cevap.Substring(2, 1);
                    harf4.Text = cevap.Substring(3, 1);
                    harf5.Text = cevap.Substring(4, 1);
                    harf6.Text = cevap.Substring(5, 1);
                    harf7.Text = cevap.Substring(6, 1);
                    harf8.Text = cevap.Substring(7, 1);

                    puan = 800;
                    lblPuan.Text = Convert.ToString(puan);

                }
            }
            if (syc == 10)

            {
                h8.Visible = true;
                string sqlsorgusu = "Select * from sorucevap.sekizli order by rand() limit 1";
                komut.CommandText = sqlsorgusu;
                komut.Connection = baglan;

                baglayici.SelectCommand = komut;

                baglan.Open();

                dr = komut.ExecuteReader();
                dr.Read();
                 
                  cevap = dr.GetString("cevap");

                while (yeniCevap == cevap)
                {
                    baglan.Close();
                    baglan.Open();
                    sqlsorgusu = "Select * from sorucevap.sekizli order by rand() limit 1";
                    komut.CommandText = sqlsorgusu;
                    komut.Connection = baglan;

                    baglayici.SelectCommand = komut;



                    dr = komut.ExecuteReader();
                    dr.Read();

                    cevap = dr.GetString("cevap");

                }
                soru.Text = dr.GetString("soru");
                if (cevap.Length == 8)
                {
                    harf1.Text = cevap.Substring(0, 1);
                    harf2.Text = cevap.Substring(1, 1);
                    harf3.Text = cevap.Substring(2, 1);
                    harf4.Text = cevap.Substring(3, 1);
                    harf5.Text = cevap.Substring(4, 1);
                    harf6.Text = cevap.Substring(5, 1);
                    harf7.Text = cevap.Substring(6, 1);
                    harf8.Text = cevap.Substring(7, 1);

                    puan = 800;
                    lblPuan.Text = Convert.ToString(puan);

                }
            }
            if (syc == 11)

            {
                h9.Visible = true;
                string sqlsorgusu = "Select * from sorucevap.dokuzlu order by rand() limit 1";
                komut.CommandText = sqlsorgusu;
                komut.Connection = baglan;

                baglayici.SelectCommand = komut;

                baglan.Open();

                dr = komut.ExecuteReader();
                dr.Read();
                
                  cevap = dr.GetString("cevap");

                while (yeniCevap == cevap)
                {
                    baglan.Close();
                    baglan.Open();
                    sqlsorgusu = "Select * from sorucevap.dokuzlu order by rand() limit 1";
                    komut.CommandText = sqlsorgusu;
                    komut.Connection = baglan;

                    baglayici.SelectCommand = komut;



                    dr = komut.ExecuteReader();
                    dr.Read();

                    cevap = dr.GetString("cevap");

                }
                soru.Text = dr.GetString("soru");
                if (cevap.Length == 9)
                {
                    harf1.Text = cevap.Substring(0, 1);
                    harf2.Text = cevap.Substring(1, 1);
                    harf3.Text = cevap.Substring(2, 1);
                    harf4.Text = cevap.Substring(3, 1);
                    harf5.Text = cevap.Substring(4, 1);
                    harf6.Text = cevap.Substring(5, 1);
                    harf7.Text = cevap.Substring(6, 1);
                    harf8.Text = cevap.Substring(7, 1);
                    harf9.Text = cevap.Substring(8, 1);

                    puan = 900;
                    lblPuan.Text = Convert.ToString(puan);

                }
            }
            if (syc == 12)

            {
                h9.Visible = true;
                string sqlsorgusu = "Select * from sorucevap.dokuzlu order by rand() limit 1";
                komut.CommandText = sqlsorgusu;
                komut.Connection = baglan;

                baglayici.SelectCommand = komut;

                baglan.Open();

                dr = komut.ExecuteReader();
                dr.Read();
                
                  cevap = dr.GetString("cevap");

                while (yeniCevap == cevap)
                {
                    baglan.Close();
                    baglan.Open();
                    sqlsorgusu = "Select * from sorucevap.dokuzlu order by rand() limit 1";
                    komut.CommandText = sqlsorgusu;
                    komut.Connection = baglan;

                    baglayici.SelectCommand = komut;



                    dr = komut.ExecuteReader();
                    dr.Read();

                    cevap = dr.GetString("cevap");

                }
                soru.Text = dr.GetString("soru");
                if (cevap.Length == 9)
                {
                    harf1.Text = cevap.Substring(0, 1);
                    harf2.Text = cevap.Substring(1, 1);
                    harf3.Text = cevap.Substring(2, 1);
                    harf4.Text = cevap.Substring(3, 1);
                    harf5.Text = cevap.Substring(4, 1);
                    harf6.Text = cevap.Substring(5, 1);
                    harf7.Text = cevap.Substring(6, 1);
                    harf8.Text = cevap.Substring(7, 1);
                    harf9.Text = cevap.Substring(8, 1);

                    puan = 900;
                    lblPuan.Text = Convert.ToString(puan);

                }
            }
            if (syc == 13)

            {
                h10.Visible = true;
                string sqlsorgusu = "Select * from sorucevap.onlu order by rand() limit 1";
                komut.CommandText = sqlsorgusu;
                komut.Connection = baglan;

                baglayici.SelectCommand = komut;

                baglan.Open();

                dr = komut.ExecuteReader();
                dr.Read();
               
                  cevap = dr.GetString("cevap");

                while (yeniCevap == cevap)
                {
                    baglan.Close();
                    baglan.Open();
                    sqlsorgusu = "Select * from sorucevap.onlu order by rand() limit 1";
                    komut.CommandText = sqlsorgusu;
                    komut.Connection = baglan;

                    baglayici.SelectCommand = komut;



                    dr = komut.ExecuteReader();
                    dr.Read();

                    cevap = dr.GetString("cevap");

                }
                soru.Text = dr.GetString("soru");
                if (cevap.Length == 10)
                {
                    harf1.Text = cevap.Substring(0, 1);
                    harf2.Text = cevap.Substring(1, 1);
                    harf3.Text = cevap.Substring(2, 1);
                    harf4.Text = cevap.Substring(3, 1);
                    harf5.Text = cevap.Substring(4, 1);
                    harf6.Text = cevap.Substring(5, 1);
                    harf7.Text = cevap.Substring(6, 1);
                    harf8.Text = cevap.Substring(7, 1);
                    harf9.Text = cevap.Substring(8, 1);
                    harf9.Text = cevap.Substring(9, 1);

                    puan = 1000;
                    lblPuan.Text = Convert.ToString(puan);

                }
            }
            if (syc == 14)

            {
                h10.Visible = true;
                string sqlsorgusu = "Select * from sorucevap.onlu order by rand() limit 1";
                komut.CommandText = sqlsorgusu;
                komut.Connection = baglan;

                baglayici.SelectCommand = komut;

                baglan.Open();

                dr = komut.ExecuteReader();
                dr.Read();
               
                  cevap = dr.GetString("cevap");

                while (yeniCevap == cevap)
                {
                    baglan.Close();
                    baglan.Open();
                    sqlsorgusu = "Select * from sorucevap.onlu order by rand() limit 1";
                    komut.CommandText = sqlsorgusu;
                    komut.Connection = baglan;

                    baglayici.SelectCommand = komut;



                    dr = komut.ExecuteReader();
                    dr.Read();

                    cevap = dr.GetString("cevap");

                }
                soru.Text = dr.GetString("soru");
                if (cevap.Length == 10)
                {
                    harf1.Text = cevap.Substring(0, 1);
                    harf2.Text = cevap.Substring(1, 1);
                    harf3.Text = cevap.Substring(2, 1);
                    harf4.Text = cevap.Substring(3, 1);
                    harf5.Text = cevap.Substring(4, 1);
                    harf6.Text = cevap.Substring(5, 1);
                    harf7.Text = cevap.Substring(6, 1);
                    harf8.Text = cevap.Substring(7, 1);
                    harf9.Text = cevap.Substring(8, 1);
                    harf9.Text = cevap.Substring(9, 1);

                    puan = 1000;
                    lblPuan.Text = Convert.ToString(puan);

                }
            }
            if (syc == 15 )
            {
                oyunSonu1 oyunsonu = new oyunSonu1();
                this.Hide();
                oyunsonu.Show();
            }







            saniye2 = 20;

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            sonraki.Enabled = true;
            syc++;

            tahminBox.Enabled = false;
            tahmin.Enabled = false;
            onay.Enabled = false;
            if (cevap == tahminBox.Text)
            {
                label1.ForeColor = Color.Lime;
                label1.Text = "DOĞRU YANIT!";
                label1.Visible = true;
                timer2.Stop();
                toplam = toplam + puan;
                lblToplam.Text = Convert.ToString(toplam);
            }

            else
            {
                label1.ForeColor = Color.Black;
                label1.Text = "YANLIŞ YANIT!";
                label1.Visible = true;
                timer2.Stop();
                toplam = toplam - puan;
                lblToplam.Text = Convert.ToString(toplam);

            }
        }

        private void tahminBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void soru_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000; //1 sn
            saniye = saniye - 1;
            lblSaniye.Text = saniye.ToString();
            lblDakika.Text = (dakika - 1).ToString();
            if (saniye == 0)
            {
                dakika = dakika - 1;
                lblDakika.Text = dakika.ToString();
                saniye = 60;
            }
            if (lblDakika.Text == "-1")
            {
                timer1.Stop();
                lblDakika.Text="0";
                lblSaniye.Text = "0";
                oyunSonu1 oyunsonu = new oyunSonu1();
                this.Hide();
                oyunsonu.Show();

            }
            if(lblDakika.Text=="0" && lblSaniye.Text == "0")
            {
                harfAl.Enabled = false;
                tahmin.Enabled = false;
                sonraki.Enabled = false;
                harf1.Visible = true;
                harf2.Visible = true;
                harf3.Visible = true;
                harf4.Visible = true;
                harf5.Visible = true;
                harf6.Visible = true;
                harf7.Visible = true;
                harf8.Visible = true;
                harf9.Visible = true;
                harf10.Visible = true;
                
            }

        }

        private void lblSaniye_Click(object sender, EventArgs e)
        {

        }

        private void lblPuan_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            timer2.Interval = 1000; //1 sn
            saniye2 = saniye2 - 1;
            lblSaniye2.Text = saniye2.ToString();
             
            if (saniye2 == 0)
            {
                lblSaniye2.Text = "Tahmin süreniz bitti!";
                timer2.Stop();
                saniye2 = 20;
               
                toplam = toplam - puan;
            }
            if(lblDakika.Text=="0" && lblSaniye.Text == "0")
            {
                oyunSonu1 oyunsonu = new oyunSonu1();
                this.Hide();
                oyunsonu.Show();
            }
           
        }

        private void lblToplam_Click(object sender, EventArgs e)
        {

        }

        private void lblSaniye2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void h1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void tahmin_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void tahmin_MouseDown(object sender, MouseEventArgs e)
        {
             
        }
    }
    }
