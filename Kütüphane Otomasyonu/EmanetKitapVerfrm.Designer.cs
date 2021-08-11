namespace Kütüphane_Otomasyonu
{
    partial class EmanetKitapVerfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmanetKitapVerfrm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpUyeBilgi = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.grpKitapBilgi = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtKitapSayisi = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtYazari = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnTeslimEt = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblKayitliKitapSayi = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblKitapSayi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpUyeBilgi.SuspendLayout();
            this.grpKitapBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(769, 395);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpUyeBilgi
            // 
            this.grpUyeBilgi.Controls.Add(this.label4);
            this.grpUyeBilgi.Controls.Add(this.label3);
            this.grpUyeBilgi.Controls.Add(this.label2);
            this.grpUyeBilgi.Controls.Add(this.label1);
            this.grpUyeBilgi.Controls.Add(this.txtTelefon);
            this.grpUyeBilgi.Controls.Add(this.txtYas);
            this.grpUyeBilgi.Controls.Add(this.txtAdSoyad);
            this.grpUyeBilgi.Controls.Add(this.txtTcAra);
            this.grpUyeBilgi.Location = new System.Drawing.Point(10, 2);
            this.grpUyeBilgi.Name = "grpUyeBilgi";
            this.grpUyeBilgi.Size = new System.Drawing.Size(200, 134);
            this.grpUyeBilgi.TabIndex = 1;
            this.grpUyeBilgi.TabStop = false;
            this.grpUyeBilgi.Text = "Üye Bilgileri";
            this.grpUyeBilgi.Enter += new System.EventHandler(this.grpUyeBilgi_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yaş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC Ara";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(82, 100);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 3;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(82, 72);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 20);
            this.txtYas.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(82, 44);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtTcAra
            // 
            this.txtTcAra.Location = new System.Drawing.Point(82, 16);
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(100, 20);
            this.txtTcAra.TabIndex = 0;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // grpKitapBilgi
            // 
            this.grpKitapBilgi.Controls.Add(this.label12);
            this.grpKitapBilgi.Controls.Add(this.label11);
            this.grpKitapBilgi.Controls.Add(this.label10);
            this.grpKitapBilgi.Controls.Add(this.label9);
            this.grpKitapBilgi.Controls.Add(this.label8);
            this.grpKitapBilgi.Controls.Add(this.label7);
            this.grpKitapBilgi.Controls.Add(this.label6);
            this.grpKitapBilgi.Controls.Add(this.label5);
            this.grpKitapBilgi.Controls.Add(this.dateTimePicker2);
            this.grpKitapBilgi.Controls.Add(this.dateTimePicker1);
            this.grpKitapBilgi.Controls.Add(this.txtKitapSayisi);
            this.grpKitapBilgi.Controls.Add(this.txtSayfaSayisi);
            this.grpKitapBilgi.Controls.Add(this.txtYayinevi);
            this.grpKitapBilgi.Controls.Add(this.txtYazari);
            this.grpKitapBilgi.Controls.Add(this.txtKitapAdi);
            this.grpKitapBilgi.Controls.Add(this.txtBarkodNo);
            this.grpKitapBilgi.Location = new System.Drawing.Point(10, 142);
            this.grpKitapBilgi.Name = "grpKitapBilgi";
            this.grpKitapBilgi.Size = new System.Drawing.Size(200, 255);
            this.grpKitapBilgi.TabIndex = 2;
            this.grpKitapBilgi.TabStop = false;
            this.grpKitapBilgi.Text = "Kitap Bilgileri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "İade Tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Teslim Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Kitap Sayısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Sayfa Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Yayınevi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Yazarı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kitap Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Barkod No";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(81, 220);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // txtKitapSayisi
            // 
            this.txtKitapSayisi.Location = new System.Drawing.Point(81, 163);
            this.txtKitapSayisi.Name = "txtKitapSayisi";
            this.txtKitapSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtKitapSayisi.TabIndex = 5;
            this.txtKitapSayisi.Text = "1";
            this.txtKitapSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(81, 135);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtSayfaSayisi.TabIndex = 4;
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(81, 107);
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(100, 20);
            this.txtYayinevi.TabIndex = 3;
            // 
            // txtYazari
            // 
            this.txtYazari.Location = new System.Drawing.Point(81, 79);
            this.txtYazari.Name = "txtYazari";
            this.txtYazari.Size = new System.Drawing.Size(100, 20);
            this.txtYazari.TabIndex = 2;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(81, 51);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKitapAdi.TabIndex = 1;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(81, 23);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 20);
            this.txtBarkodNo.TabIndex = 0;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.ImageIndex = 6;
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(143, 420);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(67, 55);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add3.jpg");
            this.ımageList1.Images.SetKeyName(1, "delete book.jpg");
            this.ımageList1.Images.SetKeyName(2, "cancel6.jpg");
            this.ımageList1.Images.SetKeyName(3, "teslim2.jpg");
            this.ımageList1.Images.SetKeyName(4, "teslim1.jpg");
            this.ımageList1.Images.SetKeyName(5, "cancel4.jpg");
            this.ımageList1.Images.SetKeyName(6, "book add3.png");
            // 
            // btnTeslimEt
            // 
            this.btnTeslimEt.FlatAppearance.BorderSize = 0;
            this.btnTeslimEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeslimEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslimEt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTeslimEt.ImageIndex = 4;
            this.btnTeslimEt.ImageList = this.ımageList1;
            this.btnTeslimEt.Location = new System.Drawing.Point(764, 420);
            this.btnTeslimEt.Name = "btnTeslimEt";
            this.btnTeslimEt.Size = new System.Drawing.Size(97, 58);
            this.btnTeslimEt.TabIndex = 4;
            this.btnTeslimEt.Text = "Teslim Et";
            this.btnTeslimEt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeslimEt.UseVisualStyleBackColor = true;
            this.btnTeslimEt.Click += new System.EventHandler(this.btnTeslimEt_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.FlatAppearance.BorderSize = 0;
            this.btnİptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİptal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnİptal.ImageIndex = 5;
            this.btnİptal.ImageList = this.ımageList1;
            this.btnİptal.Location = new System.Drawing.Point(867, 420);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(72, 58);
            this.btnİptal.TabIndex = 5;
            this.btnİptal.Text = "İptal";
            this.btnİptal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.ImageIndex = 1;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(945, 420);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(63, 58);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(347, 426);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Kayıtlı Kitap Sayısı";
            // 
            // lblKayitliKitapSayi
            // 
            this.lblKayitliKitapSayi.AutoSize = true;
            this.lblKayitliKitapSayi.Location = new System.Drawing.Point(444, 426);
            this.lblKayitliKitapSayi.Name = "lblKayitliKitapSayi";
            this.lblKayitliKitapSayi.Size = new System.Drawing.Size(0, 13);
            this.lblKayitliKitapSayi.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(511, 426);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Kitap Sayısı:";
            // 
            // lblKitapSayi
            // 
            this.lblKitapSayi.AutoSize = true;
            this.lblKitapSayi.Location = new System.Drawing.Point(578, 426);
            this.lblKitapSayi.Name = "lblKitapSayi";
            this.lblKitapSayi.Size = new System.Drawing.Size(13, 13);
            this.lblKitapSayi.TabIndex = 10;
            this.lblKitapSayi.Text = "0";
            // 
            // EmanetKitapVerfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 490);
            this.Controls.Add(this.lblKitapSayi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblKayitliKitapSayi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnTeslimEt);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.grpKitapBilgi);
            this.Controls.Add(this.grpUyeBilgi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmanetKitapVerfrm";
            this.Text = "Emanet Kitap Verme Sayfası";
            this.Load += new System.EventHandler(this.EmanetKitapVerfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpUyeBilgi.ResumeLayout(false);
            this.grpUyeBilgi.PerformLayout();
            this.grpKitapBilgi.ResumeLayout(false);
            this.grpKitapBilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpUyeBilgi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTcAra;
        private System.Windows.Forms.GroupBox grpKitapBilgi;
        private System.Windows.Forms.TextBox txtKitapSayisi;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtYazari;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTeslimEt;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblKayitliKitapSayi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblKitapSayi;
        private System.Windows.Forms.ImageList ımageList1;
    }
}