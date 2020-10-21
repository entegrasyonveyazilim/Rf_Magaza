namespace KoctasMobil
{
    partial class frm_Malgiris2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Malgiris2));
            this.txt_malzemeno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_miktar = new System.Windows.Forms.TextBox();
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
            this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.chk_Son = new System.Windows.Forms.CheckBox();
            this.txt_Horoz = new System.Windows.Forms.TextBox();
            this.lbl_horoz = new System.Windows.Forms.Label();
            this.btn_sil = new KoctasMobil.PictureButton();
            this.btn_SiparişEkle = new KoctasMobil.PictureButton();
            this.btn_Geri = new KoctasMobil.PictureButton();
            this.btn_siparis = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // txt_malzemeno
            // 
            this.txt_malzemeno.Location = new System.Drawing.Point(93, 1);
            this.txt_malzemeno.MaxLength = 40;
            this.txt_malzemeno.Name = "txt_malzemeno";
            this.txt_malzemeno.Size = new System.Drawing.Size(222, 23);
            this.txt_malzemeno.TabIndex = 1;
            this.txt_malzemeno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_malzemeno_KeyPress);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.Text = "Malzeme no   :";
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(93, 25);
            this.txt_miktar.MaxLength = 40;
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(222, 23);
            this.txt_miktar.TabIndex = 2;
            this.txt_miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_miktar_KeyPress);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.Text = "Miktar           :";
            // 
            // grd_mal
            // 
            this.grd_mal.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_mal.Location = new System.Drawing.Point(1, 100);
            this.grd_mal.Name = "grd_mal";
            this.grd_mal.Size = new System.Drawing.Size(316, 112);
            this.grd_mal.TabIndex = 132;
            this.grd_mal.TableStyles.Add(this.dataGridTableStyle1);
            this.grd_mal.CurrentCellChanged += new System.EventHandler(this.grd_mal_CurrentCellChanged);
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
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Malz no.";
            this.dataGridTextBoxColumn1.MappingName = "matnr";
            this.dataGridTextBoxColumn1.NullText = "";
            this.dataGridTextBoxColumn1.Width = 70;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Malz. Metni";
            this.dataGridTextBoxColumn2.MappingName = "maktx";
            this.dataGridTextBoxColumn2.NullText = "";
            this.dataGridTextBoxColumn2.Width = 105;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "S";
            this.dataGridTextBoxColumn3.MappingName = "S";
            this.dataGridTextBoxColumn3.NullText = "";
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
            // chk_Son
            // 
            this.chk_Son.ForeColor = System.Drawing.Color.Black;
            this.chk_Son.Location = new System.Drawing.Point(204, 74);
            this.chk_Son.Name = "chk_Son";
            this.chk_Son.Size = new System.Drawing.Size(111, 20);
            this.chk_Son.TabIndex = 3;
            this.chk_Son.Text = "Son Teslimat";
            this.chk_Son.Visible = false;
            // 
            // txt_Horoz
            // 
            this.txt_Horoz.Location = new System.Drawing.Point(93, 49);
            this.txt_Horoz.MaxLength = 40;
            this.txt_Horoz.Name = "txt_Horoz";
            this.txt_Horoz.Size = new System.Drawing.Size(222, 23);
            this.txt_Horoz.TabIndex = 151;
            this.txt_Horoz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Horoz_KeyPress);
            // 
            // lbl_horoz
            // 
            this.lbl_horoz.ForeColor = System.Drawing.Color.Black;
            this.lbl_horoz.Location = new System.Drawing.Point(3, 52);
            this.lbl_horoz.Name = "lbl_horoz";
            this.lbl_horoz.Size = new System.Drawing.Size(114, 20);
            this.lbl_horoz.Text = "Sevkiyat no   :";
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Tomato;
            this.btn_sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sil.BackgroundImage")));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(100, 74);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_sil.PressedImage")));
            this.btn_sil.Size = new System.Drawing.Size(91, 24);
            this.btn_sil.TabIndex = 147;
            this.btn_sil.Text = "    Sil";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_SiparişEkle
            // 
            this.btn_SiparişEkle.BackColor = System.Drawing.Color.Tomato;
            this.btn_SiparişEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SiparişEkle.BackgroundImage")));
            this.btn_SiparişEkle.ForeColor = System.Drawing.Color.White;
            this.btn_SiparişEkle.Location = new System.Drawing.Point(3, 74);
            this.btn_SiparişEkle.Name = "btn_SiparişEkle";
            this.btn_SiparişEkle.PressedImage = null;
            this.btn_SiparişEkle.Size = new System.Drawing.Size(91, 24);
            this.btn_SiparişEkle.TabIndex = 144;
            this.btn_SiparişEkle.Text = "   Ekle";
            this.btn_SiparişEkle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.Tomato;
            this.btn_Geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.BackgroundImage")));
            this.btn_Geri.ForeColor = System.Drawing.Color.White;
            this.btn_Geri.Location = new System.Drawing.Point(216, 214);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.PressedImage")));
            this.btn_Geri.Size = new System.Drawing.Size(99, 48);
            this.btn_Geri.TabIndex = 143;
            this.btn_Geri.Text = "   Geri";
            this.btn_Geri.Click += new System.EventHandler(this.btn_Exit_Click_1);
            // 
            // btn_siparis
            // 
            this.btn_siparis.BackColor = System.Drawing.Color.Tomato;
            this.btn_siparis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_siparis.BackgroundImage")));
            this.btn_siparis.ForeColor = System.Drawing.Color.White;
            this.btn_siparis.Location = new System.Drawing.Point(3, 214);
            this.btn_siparis.Name = "btn_siparis";
            this.btn_siparis.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_siparis.PressedImage")));
            this.btn_siparis.Size = new System.Drawing.Size(178, 48);
            this.btn_siparis.TabIndex = 142;
            this.btn_siparis.Text = "       Kaydet";
            this.btn_siparis.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // frm_Malgiris2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.txt_Horoz);
            this.Controls.Add(this.lbl_horoz);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Malgiris2";
            this.Text = "Mal Girişi";
            this.Load += new System.EventHandler(this.FIT_Malgiris_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_malzemeno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGrid grd_mal;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
        private System.Windows.Forms.CheckBox chk_Son;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
        private PictureButton btn_Geri;
        private PictureButton btn_siparis;
        private PictureButton btn_SiparişEkle;
        private PictureButton btn_sil;
        private System.Windows.Forms.TextBox txt_Horoz;
        private System.Windows.Forms.Label lbl_horoz;
    }
}