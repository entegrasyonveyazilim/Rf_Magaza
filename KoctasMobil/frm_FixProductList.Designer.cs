namespace KoctasMobil
{
    partial class FixProductList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //private System.Windows.Forms.MainMenu mainMenu1;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixProductList));
            this.lbl_MalzemeNo = new System.Windows.Forms.Label();
            this.txtSevkNo = new System.Windows.Forms.TextBox();
            this.dtp_kayit = new System.Windows.Forms.DateTimePicker();
            this.lbl_KayitTarihi = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grd_mal = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.btn_Geri = new KoctasMobil.PictureButton();
            this.btn_Kaydet = new KoctasMobil.PictureButton();
            this.pictureButton1 = new KoctasMobil.PictureButton();
            this.btn_Ekle = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // lbl_MalzemeNo
            // 
            this.lbl_MalzemeNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_MalzemeNo.Location = new System.Drawing.Point(3, 9);
            this.lbl_MalzemeNo.Name = "lbl_MalzemeNo";
            this.lbl_MalzemeNo.Size = new System.Drawing.Size(122, 18);
            this.lbl_MalzemeNo.Text = "Taşıma Birimi";
            // 
            // txtSevkNo
            // 
            this.txtSevkNo.BackColor = System.Drawing.Color.White;
            this.txtSevkNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.txtSevkNo.Location = new System.Drawing.Point(131, 6);
            this.txtSevkNo.Name = "txtSevkNo";
            this.txtSevkNo.Size = new System.Drawing.Size(178, 21);
            this.txtSevkNo.TabIndex = 5;
            // 
            // dtp_kayit
            // 
            this.dtp_kayit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.dtp_kayit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_kayit.Location = new System.Drawing.Point(131, 36);
            this.dtp_kayit.Name = "dtp_kayit";
            this.dtp_kayit.Size = new System.Drawing.Size(178, 22);
            this.dtp_kayit.TabIndex = 66;
            // 
            // lbl_KayitTarihi
            // 
            this.lbl_KayitTarihi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_KayitTarihi.Location = new System.Drawing.Point(3, 38);
            this.lbl_KayitTarihi.Name = "lbl_KayitTarihi";
            this.lbl_KayitTarihi.Size = new System.Drawing.Size(122, 20);
            this.lbl_KayitTarihi.Text = "Kayıt Tarihi:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.textBox2.Location = new System.Drawing.Point(157, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 21);
            this.textBox2.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(97, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.Text = "Miktar:";
            // 
            // grd_mal
            // 
            this.grd_mal.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_mal.Location = new System.Drawing.Point(3, 91);
            this.grd_mal.Name = "grd_mal";
            this.grd_mal.Size = new System.Drawing.Size(312, 121);
            this.grd_mal.TabIndex = 164;
            this.grd_mal.TableStyles.Add(this.dataGridTableStyle1);
            this.grd_mal.Click += new System.EventHandler(this.grd_mal_Click);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn7);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "SA Belge No";
            this.dataGridTextBoxColumn1.MappingName = "SA_Belge_No";
            this.dataGridTextBoxColumn1.Width = 65;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Klm";
            this.dataGridTextBoxColumn2.MappingName = "Klm";
            this.dataGridTextBoxColumn2.Width = 33;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Malzeme";
            this.dataGridTextBoxColumn3.MappingName = "Malzeme";
            this.dataGridTextBoxColumn3.Width = 65;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Malzeme Tanımı";
            this.dataGridTextBoxColumn4.MappingName = "Malzeme_Tanimi";
            this.dataGridTextBoxColumn4.Width = 250;
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "Teslimat Miktarı";
            this.dataGridTextBoxColumn5.MappingName = "Teslimat_Miktari";
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "Brm";
            this.dataGridTextBoxColumn6.MappingName = "Birim";
            this.dataGridTextBoxColumn6.Width = 25;
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.HeaderText = "Giris Miktar";
            this.dataGridTextBoxColumn7.MappingName = "Giris_Miktari";
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.Tomato;
            this.btn_Geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.BackgroundImage")));
            this.btn_Geri.ForeColor = System.Drawing.Color.White;
            this.btn_Geri.Location = new System.Drawing.Point(3, 212);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.PressedImage")));
            this.btn_Geri.Size = new System.Drawing.Size(135, 54);
            this.btn_Geri.TabIndex = 101;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.Tomato;
            this.btn_Kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.BackgroundImage")));
            this.btn_Kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_Kaydet.Location = new System.Drawing.Point(180, 212);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.PressedImage")));
            this.btn_Kaydet.Size = new System.Drawing.Size(135, 54);
            this.btn_Kaydet.TabIndex = 102;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // pictureButton1
            // 
            this.pictureButton1.BackColor = System.Drawing.Color.Tomato;
            this.pictureButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureButton1.BackgroundImage")));
            this.pictureButton1.ForeColor = System.Drawing.Color.White;
            this.pictureButton1.Location = new System.Drawing.Point(219, 64);
            this.pictureButton1.Name = "pictureButton1";
            this.pictureButton1.PressedImage = ((System.Drawing.Image)(resources.GetObject("pictureButton1.PressedImage")));
            this.pictureButton1.Size = new System.Drawing.Size(88, 24);
            this.pictureButton1.TabIndex = 100;
            this.pictureButton1.Text = "Güncelle";
            this.pictureButton1.Click += new System.EventHandler(this.pictureButton1_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Tomato;
            this.btn_Ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.BackgroundImage")));
            this.btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.btn_Ekle.Location = new System.Drawing.Point(3, 64);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.PressedImage")));
            this.btn_Ekle.Size = new System.Drawing.Size(88, 24);
            this.btn_Ekle.TabIndex = 99;
            this.btn_Ekle.Text = "Listele";
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // FixProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.ControlBox = false;
            this.Controls.Add(this.grd_mal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.pictureButton1);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dtp_kayit);
            this.Controls.Add(this.lbl_KayitTarihi);
            this.Controls.Add(this.lbl_MalzemeNo);
            this.Controls.Add(this.txtSevkNo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FixProductList";
            this.Text = "Fix Mal İşlemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_MalzemeNo;
        private System.Windows.Forms.TextBox txtSevkNo;
        private System.Windows.Forms.DateTimePicker dtp_kayit;
        private System.Windows.Forms.Label lbl_KayitTarihi;
        private System.Windows.Forms.TextBox textBox2;
        private PictureButton btn_Ekle;
        private PictureButton pictureButton1;
        private PictureButton btn_Geri;
        private PictureButton btn_Kaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGrid grd_mal;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;

    }
}