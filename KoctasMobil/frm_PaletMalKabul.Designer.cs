namespace KoctasMobil
{
    partial class frm_PaletMalKabul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PaletMalKabul));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PaletNumarasi = new System.Windows.Forms.TextBox();
            this.txt_TUNumarasi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grd_Palet = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.txt_KayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Miktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_PaletNumarasi2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MalzemeNo = new System.Windows.Forms.TextBox();
            this.grd_Malzeme = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_GirisGuncelleme = new System.Windows.Forms.TextBox();
            this.grd_Total = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle3 = new System.Windows.Forms.DataGridTableStyle();
            this.btn_GirisGuncelle = new KoctasMobil.PictureButton();
            this.btn_MalGirisiPaletKapat = new KoctasMobil.PictureButton();
            this.btn_Geri3 = new KoctasMobil.PictureButton();
            this.btn_MalGirisiTUKapat = new KoctasMobil.PictureButton();
            this.btn_Geri2 = new KoctasMobil.PictureButton();
            this.btn_Devam2 = new KoctasMobil.PictureButton();
            this.btn_Ekle = new KoctasMobil.PictureButton();
            this.btn_Geri = new KoctasMobil.PictureButton();
            this.btn_Devam = new KoctasMobil.PictureButton();
            this.btn_Listele = new KoctasMobil.PictureButton();
            this.btn_MalzemeSil = new KoctasMobil.PictureButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.Text = "Kayıt Tarihi";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.Text = "Palet No";
            // 
            // txt_PaletNumarasi
            // 
            this.txt_PaletNumarasi.Location = new System.Drawing.Point(106, 236);
            this.txt_PaletNumarasi.Name = "txt_PaletNumarasi";
            this.txt_PaletNumarasi.Size = new System.Drawing.Size(192, 23);
            this.txt_PaletNumarasi.TabIndex = 4;
            this.txt_PaletNumarasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PaletNumarasi_KeyPress);
            // 
            // txt_TUNumarasi
            // 
            this.txt_TUNumarasi.Location = new System.Drawing.Point(106, 30);
            this.txt_TUNumarasi.Name = "txt_TUNumarasi";
            this.txt_TUNumarasi.Size = new System.Drawing.Size(192, 23);
            this.txt_TUNumarasi.TabIndex = 8;
            this.txt_TUNumarasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TUNumarasi_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.Text = "TU Numarası";
            // 
            // grd_Palet
            // 
            this.grd_Palet.BackColor = System.Drawing.Color.White;
            this.grd_Palet.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_Palet.Location = new System.Drawing.Point(3, 87);
            this.grd_Palet.Name = "grd_Palet";
            this.grd_Palet.Size = new System.Drawing.Size(295, 143);
            this.grd_Palet.TabIndex = 30;
            this.grd_Palet.TableStyles.Add(this.dataGridTableStyle1);
            this.grd_Palet.DoubleClick += new System.EventHandler(this.grd_Palet_DoubleClick);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Ürün Kodu";
            this.dataGridTextBoxColumn1.MappingName = "MATNR";
            this.dataGridTextBoxColumn1.NullText = "";
            this.dataGridTextBoxColumn1.Width = 64;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Ürün Adý";
            this.dataGridTextBoxColumn2.MappingName = "MAKTX";
            this.dataGridTextBoxColumn2.NullText = "";
            this.dataGridTextBoxColumn2.Width = 140;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Miktar";
            this.dataGridTextBoxColumn3.MappingName = "MENGE";
            this.dataGridTextBoxColumn3.NullText = "";
            this.dataGridTextBoxColumn3.Width = 44;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Tip";
            this.dataGridTextBoxColumn4.MappingName = "TIP";
            this.dataGridTextBoxColumn4.NullText = "";
            this.dataGridTextBoxColumn4.Width = 33;
            // 
            // txt_KayitTarihi
            // 
            this.txt_KayitTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_KayitTarihi.Location = new System.Drawing.Point(106, 3);
            this.txt_KayitTarihi.Name = "txt_KayitTarihi";
            this.txt_KayitTarihi.Size = new System.Drawing.Size(192, 24);
            this.txt_KayitTarihi.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_KayitTarihi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Geri);
            this.panel1.Controls.Add(this.txt_PaletNumarasi);
            this.panel1.Controls.Add(this.btn_Devam);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_Listele);
            this.panel1.Controls.Add(this.txt_TUNumarasi);
            this.panel1.Controls.Add(this.grd_Palet);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 290);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_MalzemeSil);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_Miktar);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_Geri2);
            this.panel2.Controls.Add(this.txt_PaletNumarasi2);
            this.panel2.Controls.Add(this.btn_Devam2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btn_Ekle);
            this.panel2.Controls.Add(this.txt_MalzemeNo);
            this.panel2.Controls.Add(this.grd_Malzeme);
            this.panel2.Location = new System.Drawing.Point(325, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 290);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.Text = "Miktar";
            // 
            // txt_Miktar
            // 
            this.txt_Miktar.Location = new System.Drawing.Point(105, 59);
            this.txt_Miktar.Name = "txt_Miktar";
            this.txt_Miktar.Size = new System.Drawing.Size(192, 23);
            this.txt_Miktar.TabIndex = 58;
            this.txt_Miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Miktar_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.Text = "Palet No";
            // 
            // txt_PaletNumarasi2
            // 
            this.txt_PaletNumarasi2.Enabled = false;
            this.txt_PaletNumarasi2.Location = new System.Drawing.Point(105, 3);
            this.txt_PaletNumarasi2.Name = "txt_PaletNumarasi2";
            this.txt_PaletNumarasi2.Size = new System.Drawing.Size(192, 23);
            this.txt_PaletNumarasi2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.Text = "Malzeme";
            // 
            // txt_MalzemeNo
            // 
            this.txt_MalzemeNo.Location = new System.Drawing.Point(105, 32);
            this.txt_MalzemeNo.MaxLength = 10;
            this.txt_MalzemeNo.Name = "txt_MalzemeNo";
            this.txt_MalzemeNo.Size = new System.Drawing.Size(192, 23);
            this.txt_MalzemeNo.TabIndex = 8;
            this.txt_MalzemeNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MalzemeNo_KeyPress);
            // 
            // grd_Malzeme
            // 
            this.grd_Malzeme.BackColor = System.Drawing.Color.White;
            this.grd_Malzeme.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_Malzeme.Location = new System.Drawing.Point(3, 118);
            this.grd_Malzeme.Name = "grd_Malzeme";
            this.grd_Malzeme.Size = new System.Drawing.Size(294, 141);
            this.grd_Malzeme.TabIndex = 30;
            this.grd_Malzeme.TableStyles.Add(this.dataGridTableStyle2);
            // 
            // dataGridTableStyle2
            // 
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_GirisGuncelle);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btn_MalGirisiPaletKapat);
            this.panel3.Controls.Add(this.txt_GirisGuncelleme);
            this.panel3.Controls.Add(this.btn_Geri3);
            this.panel3.Controls.Add(this.btn_MalGirisiTUKapat);
            this.panel3.Controls.Add(this.grd_Total);
            this.panel3.Location = new System.Drawing.Point(645, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 290);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.Text = "Giriş Miktarı";
            // 
            // txt_GirisGuncelleme
            // 
            this.txt_GirisGuncelleme.Location = new System.Drawing.Point(103, 3);
            this.txt_GirisGuncelleme.Name = "txt_GirisGuncelleme";
            this.txt_GirisGuncelleme.Size = new System.Drawing.Size(46, 23);
            this.txt_GirisGuncelleme.TabIndex = 62;
            this.txt_GirisGuncelleme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GirisGuncelleme_KeyPress);
            // 
            // grd_Total
            // 
            this.grd_Total.BackColor = System.Drawing.Color.White;
            this.grd_Total.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_Total.Location = new System.Drawing.Point(3, 33);
            this.grd_Total.Name = "grd_Total";
            this.grd_Total.Size = new System.Drawing.Size(294, 164);
            this.grd_Total.TabIndex = 30;
            this.grd_Total.TableStyles.Add(this.dataGridTableStyle3);
            this.grd_Total.CurrentCellChanged += new System.EventHandler(this.grd_Total_CurrentCellChanged);
            this.grd_Total.Click += new System.EventHandler(this.grd_Total_Click);
            // 
            // dataGridTableStyle3
            // 
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle3.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            // 
            // btn_GirisGuncelle
            // 
            this.btn_GirisGuncelle.BackColor = System.Drawing.Color.Tomato;
            this.btn_GirisGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_GirisGuncelle.BackgroundImage")));
            this.btn_GirisGuncelle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_GirisGuncelle.ForeColor = System.Drawing.Color.White;
            this.btn_GirisGuncelle.Location = new System.Drawing.Point(155, 3);
            this.btn_GirisGuncelle.Name = "btn_GirisGuncelle";
            this.btn_GirisGuncelle.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_GirisGuncelle.PressedImage")));
            this.btn_GirisGuncelle.Size = new System.Drawing.Size(142, 24);
            this.btn_GirisGuncelle.TabIndex = 61;
            this.btn_GirisGuncelle.Text = "Güncelle";
            this.btn_GirisGuncelle.Click += new System.EventHandler(this.btn_GirisGuncelle_Click);
            // 
            // btn_MalGirisiPaletKapat
            // 
            this.btn_MalGirisiPaletKapat.BackColor = System.Drawing.Color.Tomato;
            this.btn_MalGirisiPaletKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_MalGirisiPaletKapat.BackgroundImage")));
            this.btn_MalGirisiPaletKapat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_MalGirisiPaletKapat.ForeColor = System.Drawing.Color.White;
            this.btn_MalGirisiPaletKapat.Location = new System.Drawing.Point(125, 200);
            this.btn_MalGirisiPaletKapat.Name = "btn_MalGirisiPaletKapat";
            this.btn_MalGirisiPaletKapat.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_MalGirisiPaletKapat.PressedImage")));
            this.btn_MalGirisiPaletKapat.Size = new System.Drawing.Size(172, 25);
            this.btn_MalGirisiPaletKapat.TabIndex = 52;
            this.btn_MalGirisiPaletKapat.Text = "     Mal Girişi/Palet kapat";
            this.btn_MalGirisiPaletKapat.Click += new System.EventHandler(this.btn_MalGirisiPaletKapat_Click);
            // 
            // btn_Geri3
            // 
            this.btn_Geri3.BackColor = System.Drawing.Color.Tomato;
            this.btn_Geri3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri3.BackgroundImage")));
            this.btn_Geri3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Geri3.ForeColor = System.Drawing.Color.White;
            this.btn_Geri3.Location = new System.Drawing.Point(3, 262);
            this.btn_Geri3.Name = "btn_Geri3";
            this.btn_Geri3.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri3.PressedImage")));
            this.btn_Geri3.Size = new System.Drawing.Size(111, 25);
            this.btn_Geri3.TabIndex = 45;
            this.btn_Geri3.Text = "     Geri";
            this.btn_Geri3.Click += new System.EventHandler(this.btn_Geri3_Click);
            // 
            // btn_MalGirisiTUKapat
            // 
            this.btn_MalGirisiTUKapat.BackColor = System.Drawing.Color.Tomato;
            this.btn_MalGirisiTUKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_MalGirisiTUKapat.BackgroundImage")));
            this.btn_MalGirisiTUKapat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_MalGirisiTUKapat.ForeColor = System.Drawing.Color.White;
            this.btn_MalGirisiTUKapat.Location = new System.Drawing.Point(125, 231);
            this.btn_MalGirisiTUKapat.Name = "btn_MalGirisiTUKapat";
            this.btn_MalGirisiTUKapat.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_MalGirisiTUKapat.PressedImage")));
            this.btn_MalGirisiTUKapat.Size = new System.Drawing.Size(172, 25);
            this.btn_MalGirisiTUKapat.TabIndex = 51;
            this.btn_MalGirisiTUKapat.Text = "     Mal girişi/TU kapat";
            this.btn_MalGirisiTUKapat.Visible = false;
            this.btn_MalGirisiTUKapat.Click += new System.EventHandler(this.btn_MalGirisiTUKapat_Click);
            // 
            // btn_Geri2
            // 
            this.btn_Geri2.BackColor = System.Drawing.Color.Tomato;
            this.btn_Geri2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri2.BackgroundImage")));
            this.btn_Geri2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Geri2.ForeColor = System.Drawing.Color.White;
            this.btn_Geri2.Location = new System.Drawing.Point(3, 262);
            this.btn_Geri2.Name = "btn_Geri2";
            this.btn_Geri2.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri2.PressedImage")));
            this.btn_Geri2.Size = new System.Drawing.Size(93, 25);
            this.btn_Geri2.TabIndex = 45;
            this.btn_Geri2.Text = "     Geri";
            this.btn_Geri2.Click += new System.EventHandler(this.btn_Geri2_Click);
            // 
            // btn_Devam2
            // 
            this.btn_Devam2.BackColor = System.Drawing.Color.Tomato;
            this.btn_Devam2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Devam2.BackgroundImage")));
            this.btn_Devam2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Devam2.ForeColor = System.Drawing.Color.White;
            this.btn_Devam2.Location = new System.Drawing.Point(105, 262);
            this.btn_Devam2.Name = "btn_Devam2";
            this.btn_Devam2.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Devam2.PressedImage")));
            this.btn_Devam2.Size = new System.Drawing.Size(192, 25);
            this.btn_Devam2.TabIndex = 51;
            this.btn_Devam2.Text = "     Devam";
            this.btn_Devam2.Click += new System.EventHandler(this.btn_Devam2_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Tomato;
            this.btn_Ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.BackgroundImage")));
            this.btn_Ekle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.btn_Ekle.Location = new System.Drawing.Point(105, 87);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.PressedImage")));
            this.btn_Ekle.Size = new System.Drawing.Size(81, 25);
            this.btn_Ekle.TabIndex = 42;
            this.btn_Ekle.Text = "   Ekle";
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.Tomato;
            this.btn_Geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.BackgroundImage")));
            this.btn_Geri.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Geri.ForeColor = System.Drawing.Color.White;
            this.btn_Geri.Location = new System.Drawing.Point(3, 262);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.PressedImage")));
            this.btn_Geri.Size = new System.Drawing.Size(97, 25);
            this.btn_Geri.TabIndex = 45;
            this.btn_Geri.Text = "     Geri";
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_Devam
            // 
            this.btn_Devam.BackColor = System.Drawing.Color.Tomato;
            this.btn_Devam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Devam.BackgroundImage")));
            this.btn_Devam.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Devam.ForeColor = System.Drawing.Color.White;
            this.btn_Devam.Location = new System.Drawing.Point(106, 262);
            this.btn_Devam.Name = "btn_Devam";
            this.btn_Devam.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Devam.PressedImage")));
            this.btn_Devam.Size = new System.Drawing.Size(192, 25);
            this.btn_Devam.TabIndex = 51;
            this.btn_Devam.Text = "     Devam";
            this.btn_Devam.Click += new System.EventHandler(this.btn_Devam_Click);
            // 
            // btn_Listele
            // 
            this.btn_Listele.BackColor = System.Drawing.Color.Tomato;
            this.btn_Listele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Listele.BackgroundImage")));
            this.btn_Listele.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Listele.ForeColor = System.Drawing.Color.White;
            this.btn_Listele.Location = new System.Drawing.Point(106, 56);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Listele.PressedImage")));
            this.btn_Listele.Size = new System.Drawing.Size(192, 25);
            this.btn_Listele.TabIndex = 42;
            this.btn_Listele.Text = "   Listele";
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click_1);
            // 
            // btn_MalzemeSil
            // 
            this.btn_MalzemeSil.BackColor = System.Drawing.Color.Tomato;
            this.btn_MalzemeSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_MalzemeSil.BackgroundImage")));
            this.btn_MalzemeSil.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_MalzemeSil.ForeColor = System.Drawing.Color.White;
            this.btn_MalzemeSil.Location = new System.Drawing.Point(215, 87);
            this.btn_MalzemeSil.Name = "btn_MalzemeSil";
            this.btn_MalzemeSil.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_MalzemeSil.PressedImage")));
            this.btn_MalzemeSil.Size = new System.Drawing.Size(82, 25);
            this.btn_MalzemeSil.TabIndex = 61;
            this.btn_MalzemeSil.Text = "     Sil";
            this.btn_MalzemeSil.Click += new System.EventHandler(this.btn_MalzemeSil_Click);
            // 
            // frm_PaletMalKabul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 295);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PaletMalKabul";
            this.Text = "FİX Mal Kabul";
            this.Load += new System.EventHandler(this.frm_PaletMalKabul_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PaletNumarasi;
        private System.Windows.Forms.TextBox txt_TUNumarasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGrid grd_Palet;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private PictureButton btn_Listele;
        private PictureButton btn_Devam;
        private PictureButton btn_Geri;
        private System.Windows.Forms.DateTimePicker txt_KayitTarihi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private PictureButton btn_Geri2;
        private System.Windows.Forms.TextBox txt_PaletNumarasi2;
        private PictureButton btn_Devam2;
        private System.Windows.Forms.Label label6;
        private PictureButton btn_Ekle;
        private System.Windows.Forms.TextBox txt_MalzemeNo;
        private System.Windows.Forms.DataGrid grd_Malzeme;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
        private System.Windows.Forms.Panel panel3;
        private PictureButton btn_Geri3;
        private PictureButton btn_MalGirisiTUKapat;
        private System.Windows.Forms.DataGrid grd_Total;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Miktar;
        private PictureButton btn_MalGirisiPaletKapat;
        private PictureButton btn_GirisGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_GirisGuncelleme;
        private PictureButton btn_MalzemeSil;
    }
}