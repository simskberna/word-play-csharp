
namespace OYUN
{
    partial class oyunBasi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oyunBasi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.basla = new System.Windows.Forms.Button();
            this.soyisimBox = new System.Windows.Forms.TextBox();
            this.isimBox = new System.Windows.Forms.TextBox();
            this.lblHata = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 98);
            this.label1.TabIndex = 1;
            this.label1.Text = "KELIME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(51, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 79);
            this.label2.TabIndex = 2;
            this.label2.Text = "OYUNU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(455, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "AD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(429, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "SOYAD";
            // 
            // basla
            // 
            this.basla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.basla.BackColor = System.Drawing.Color.Transparent;
            this.basla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("basla.BackgroundImage")));
            this.basla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.basla.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basla.ForeColor = System.Drawing.Color.White;
            this.basla.Location = new System.Drawing.Point(55, 263);
            this.basla.Margin = new System.Windows.Forms.Padding(0);
            this.basla.Name = "basla";
            this.basla.Size = new System.Drawing.Size(255, 111);
            this.basla.TabIndex = 0;
            this.basla.Text = "BASLA";
            this.basla.UseVisualStyleBackColor = false;
            this.basla.Click += new System.EventHandler(this.basla_Click);
            // 
            // soyisimBox
            // 
            this.soyisimBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.soyisimBox.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soyisimBox.ForeColor = System.Drawing.Color.Black;
            this.soyisimBox.Location = new System.Drawing.Point(551, 255);
            this.soyisimBox.Name = "soyisimBox";
            this.soyisimBox.Size = new System.Drawing.Size(163, 47);
            this.soyisimBox.TabIndex = 4;
            // 
            // isimBox
            // 
            this.isimBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.isimBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.isimBox.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isimBox.ForeColor = System.Drawing.Color.Black;
            this.isimBox.Location = new System.Drawing.Point(551, 172);
            this.isimBox.Name = "isimBox";
            this.isimBox.Size = new System.Drawing.Size(163, 47);
            this.isimBox.TabIndex = 3;
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.BackColor = System.Drawing.Color.Transparent;
            this.lblHata.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHata.ForeColor = System.Drawing.Color.Red;
            this.lblHata.Location = new System.Drawing.Point(470, 102);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(294, 23);
            this.lblHata.TabIndex = 7;
            this.lblHata.Text = "Lutfen Alanlari Doldurun ! ";
            this.lblHata.Visible = false;
            // 
            // oyunBasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soyisimBox);
            this.Controls.Add(this.isimBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.basla);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "oyunBasi";
            this.Text = "KELİME OYUNU";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button basla;
        private System.Windows.Forms.TextBox soyisimBox;
        private System.Windows.Forms.TextBox isimBox;
        private System.Windows.Forms.Label lblHata;
    }
}

