namespace KoctasMobil
{
    partial class frm_Malgiris1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Malgiris1));
            this.chk_Son = new System.Windows.Forms.CheckBox();
            this.grd_mal = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn12 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn13 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn14 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_malzemeno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBirim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.irsaliyeMiktar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hasarMiktar = new System.Windows.Forms.TextBox();
            this.btn_Check2 = new KoctasMobil.PictureButton();
            this.btn_sil = new KoctasMobil.PictureButton();
            this.btn_SiparişEkle = new KoctasMobil.PictureButton();
            this.btn_Geri = new KoctasMobil.PictureButton();
            this.btn_siparis = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // chk_Son
            // 
            this.chk_Son.ForeColor = System.Drawing.Color.Black;
            this.chk_Son.Location = new System.Drawing.Point(187, 78);
            this.chk_Son.Name = "chk_Son";
            this.chk_Son.Size = new System.Drawing.Size(65, 20);
            this.chk_Son.TabIndex = 162;
            this.chk_Son.Text = "Son T";
            // 
            // grd_mal
            // 
            this.grd_mal.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_mal.Location = new System.Drawing.Point(-1, 108);
            this.grd_mal.Name = "grd_mal";
            this.grd_mal.Size = new System.Drawing.Size(316, 130);
            this.grd_mal.TabIndex = 163;
            this.grd_mal.TableStyles.Add(this.dataGridTableStyle1);
            this.grd_mal.CurrentCellChanged += new System.EventHandler(this.grd_mal_CurrentCellChanged_1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn7);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn8);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn9);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn10);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn11);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn12);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn13);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn14);
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Malz no.";
            this.dataGridTextBoxColumn1.MappingName = "matnr";
            this.dataGridTextBoxColumn1.Width = 70;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Malz. Metni";
            this.dataGridTextBoxColumn2.MappingName = "maktx";
            this.dataGridTextBoxColumn2.Width = 105;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "S";
            this.dataGridTextBoxColumn3.MappingName = "S";
            this.dataGridTextBoxColumn3.Width = 15;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Miktar";
            this.dataGridTextBoxColumn4.MappingName = "menge";
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "TÖB";
            this.dataGridTextBoxColumn5.MappingName = "meins";
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "Sas";
            this.dataGridTextBoxColumn6.MappingName = "ebeln";
            this.dataGridTextBoxColumn6.Width = 75;
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.HeaderText = "PO";
            this.dataGridTextBoxColumn7.MappingName = "ebelp";
            this.dataGridTextBoxColumn7.Width = 0;
            // 
            // dataGridTextBoxColumn8
            // 
            this.dataGridTextBoxColumn8.Format = "";
            this.dataGridTextBoxColumn8.FormatInfo = null;
            this.dataGridTextBoxColumn8.HeaderText = "Üretim Yeri";
            this.dataGridTextBoxColumn8.MappingName = "werks";
            this.dataGridTextBoxColumn8.Width = 0;
            // 
            // dataGridTextBoxColumn9
            // 
            this.dataGridTextBoxColumn9.Format = "";
            this.dataGridTextBoxColumn9.FormatInfo = null;
            this.dataGridTextBoxColumn9.HeaderText = "Depo";
            this.dataGridTextBoxColumn9.MappingName = "lgort";
            this.dataGridTextBoxColumn9.Width = 0;
            // 
            // dataGridTextBoxColumn10
            // 
            this.dataGridTextBoxColumn10.Format = "";
            this.dataGridTextBoxColumn10.FormatInfo = null;
            this.dataGridTextBoxColumn10.HeaderText = "A. Sip.";
            this.dataGridTextBoxColumn10.MappingName = "Amenge";
            this.dataGridTextBoxColumn10.Width = 0;
            // 
            // dataGridTextBoxColumn11
            // 
            this.dataGridTextBoxColumn11.Format = "";
            this.dataGridTextBoxColumn11.FormatInfo = null;
            this.dataGridTextBoxColumn11.HeaderText = "İrs. No";
            this.dataGridTextBoxColumn11.MappingName = "irsaliyeNo";
            // 
            // dataGridTextBoxColumn12
            // 
            this.dataGridTextBoxColumn12.Format = "";
            this.dataGridTextBoxColumn12.FormatInfo = null;
            this.dataGridTextBoxColumn12.HeaderText = "İrsaliye Miktar";
            this.dataGridTextBoxColumn12.MappingName = "irsaliyeMiktar";
            // 
            // dataGridTextBoxColumn13
            // 
            this.dataGridTextBoxColumn13.Format = "";
            this.dataGridTextBoxColumn13.FormatInfo = null;
            this.dataGridTextBoxColumn13.HeaderText = "Hasar Miktar";
            this.dataGridTextBoxColumn13.MappingName = "hasarMiktar";
            // 
            // dataGridTextBoxColumn14
            // 
            this.dataGridTextBoxColumn14.Format = "";
            this.dataGridTextBoxColumn14.FormatInfo = null;
            this.dataGridTextBoxColumn14.HeaderText = "Eksik Miktar";
            this.dataGridTextBoxColumn14.MappingName = "eksikMiktar";
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(93, 26);
            this.txt_miktar.MaxLength = 40;
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(117, 23);
            this.txt_miktar.TabIndex = 161;
            this.txt_miktar.GotFocus += new System.EventHandler(this.txt_miktar_GotFocus);
            this.txt_miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_miktar_KeyPress);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.Text = "Miktar           :";
            // 
            // txt_malzemeno
            // 
            this.txt_malzemeno.Location = new System.Drawing.Point(93, 2);
            this.txt_malzemeno.MaxLength = 40;
            this.txt_malzemeno.Name = "txt_malzemeno";
            this.txt_malzemeno.Size = new System.Drawing.Size(188, 23);
            this.txt_malzemeno.TabIndex = 160;
            this.txt_malzemeno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_malzemeno_KeyPress);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.Text = "Malzeme no   :";
            // 
            // cmbBirim
            // 
            this.cmbBirim.Location = new System.Drawing.Point(216, 26);
            this.cmbBirim.Name = "cmbBirim";
            this.cmbBirim.Size = new System.Drawing.Size(65, 23);
            this.cmbBirim.TabIndex = 172;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.Text = "İrsaliye Miktarı:";
            // 
            // irsaliyeMiktar
            // 
            this.irsaliyeMiktar.Location = new System.Drawing.Point(93, 49);
            this.irsaliyeMiktar.Name = "irsaliyeMiktar";
            this.irsaliyeMiktar.Size = new System.Drawing.Size(59, 23);
            this.irsaliyeMiktar.TabIndex = 176;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(158, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "Hasar Miktarı";
            // 
            // hasarMiktar
            // 
            this.hasarMiktar.Location = new System.Drawing.Point(248, 49);
            this.hasarMiktar.Name = "hasarMiktar";
            this.hasarMiktar.Size = new System.Drawing.Size(45, 23);
            this.hasarMiktar.TabIndex = 178;
            // 
            // btn_Check2
            // 
            this.btn_Check2.BackColor = System.Drawing.Color.Tomato;
            this.btn_Check2.BackgroundImage = null;
            this.btn_Check2.ForeColor = System.Drawing.Color.White;
            this.btn_Check2.Location = new System.Drawing.Point(285, 1);
            this.btn_Check2.Name = "btn_Check2";
            this.btn_Check2.Size = new System.Drawing.Size(30, 24);
            this.btn_Check2.TabIndex = 169;
            this.btn_Check2.Text = " ? ";
            this.btn_Check2.Click += new System.EventHandler(this.btn_Check2_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Tomato;
            this.btn_sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sil.BackgroundImage")));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(100, 78);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_sil.PressedImage")));
            this.btn_sil.Size = new System.Drawing.Size(81, 24);
            this.btn_sil.TabIndex = 167;
            this.btn_sil.Text = "    Sil";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_SiparişEkle
            // 
            this.btn_SiparişEkle.BackColor = System.Drawing.Color.Tomato;
            this.btn_SiparişEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SiparişEkle.BackgroundImage")));
            this.btn_SiparişEkle.ForeColor = System.Drawing.Color.White;
            this.btn_SiparişEkle.Location = new System.Drawing.Point(3, 78);
            this.btn_SiparişEkle.Name = "btn_SiparişEkle";
            this.btn_SiparişEkle.PressedImage = null;
            this.btn_SiparişEkle.Size = new System.Drawing.Size(91, 24);
            this.btn_SiparişEkle.TabIndex = 166;
            this.btn_SiparişEkle.Text = "   Ekle";
            this.btn_SiparişEkle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.Tomato;
            this.btn_Geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.BackgroundImage")));
            this.btn_Geri.ForeColor = System.Drawing.Color.White;
            this.btn_Geri.Location = new System.Drawing.Point(216, 244);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.PressedImage")));
            this.btn_Geri.Size = new System.Drawing.Size(99, 48);
            this.btn_Geri.TabIndex = 165;
            this.btn_Geri.Text = "   Geri";
            this.btn_Geri.Click += new System.EventHandler(this.btn_Exit_Click_1);
            // 
            // btn_siparis
            // 
            this.btn_siparis.BackColor = System.Drawing.Color.Tomato;
            this.btn_siparis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_siparis.BackgroundImage")));
            this.btn_siparis.ForeColor = System.Drawing.Color.White;
            this.btn_siparis.Location = new System.Drawing.Point(3, 244);
            this.btn_siparis.Name = "btn_siparis";
            this.btn_siparis.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_siparis.PressedImage")));
            this.btn_siparis.Size = new System.Drawing.Size(178, 48);
            this.btn_siparis.TabIndex = 164;
            this.btn_siparis.Text = "       Kaydet";
            this.btn_siparis.Click += new System.EventHandler(this.btn_siparis_Click);
            // 
            // frm_Malgiris1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.ControlBox = false;
            this.Controls.Add(this.hasarMiktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.irsaliyeMiktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBirim);
            this.Controls.Add(this.btn_Check2);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_SiparişEkle);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_siparis);
            this.Controls.Add(this.chk_Son);
            this.Controls.Add(this.grd_mal);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_malzemeno);
            this.Controls.Add(this.label1);
            this.Name = "frm_Malgiris1";
            this.Text = "Mal Girişi";
            this.Load += new System.EventHandler(this.frm_Malgiris1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureButton btn_Check2;
        private PictureButton btn_sil;
        private PictureButton btn_SiparişEkle;
        private PictureButton btn_Geri;
        private PictureButton btn_siparis;
        private System.Windows.Forms.CheckBox chk_Son;
        private System.Windows.Forms.DataGrid grd_mal;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_malzemeno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn10;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn11;
        private System.Windows.Forms.ComboBox cmbBirim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox irsaliyeMiktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hasarMiktar;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn12;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn13;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn14;
    }
}