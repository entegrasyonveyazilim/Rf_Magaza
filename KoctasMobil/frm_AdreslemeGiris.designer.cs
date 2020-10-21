namespace KoctasMobil
{
    partial class frm_AdreslemeGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AdreslemeGiris));
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.grd_mal = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.txt_birim = new System.Windows.Forms.TextBox();
            this.txt_maktx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_malzemeNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btn_Geri = new KoctasMobil.PictureButton();
            this.btn_kaydet = new KoctasMobil.PictureButton();
            this.btn_Ekle = new KoctasMobil.PictureButton();
            this.btn_sil = new KoctasMobil.PictureButton();
            this.btn_Getir = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Birim";
            this.dataGridTextBoxColumn4.MappingName = "Meins";
            this.dataGridTextBoxColumn4.Width = 30;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.Text = "Adres";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Miktar";
            this.dataGridTextBoxColumn3.MappingName = "Menge";
            this.dataGridTextBoxColumn3.Width = 40;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Malz. Metni";
            this.dataGridTextBoxColumn2.MappingName = "Maktx";
            this.dataGridTextBoxColumn2.Width = 130;
            // 
            // dataGridTextBoxColumn7
            // 
            this.dataGridTextBoxColumn7.Format = "";
            this.dataGridTextBoxColumn7.FormatInfo = null;
            this.dataGridTextBoxColumn7.HeaderText = "Adresleme";
            this.dataGridTextBoxColumn7.MappingName = "Nlpla";
            this.dataGridTextBoxColumn7.Width = 0;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Malz no.";
            this.dataGridTextBoxColumn1.MappingName = "Matnr";
            this.dataGridTextBoxColumn1.Width = 80;
            // 
            // grd_mal
            // 
            this.grd_mal.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_mal.Location = new System.Drawing.Point(1, 112);
            this.grd_mal.Name = "grd_mal";
            this.grd_mal.Size = new System.Drawing.Size(316, 110);
            this.grd_mal.TabIndex = 181;
            this.grd_mal.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn7);
            // 
            // txt_birim
            // 
            this.txt_birim.BackColor = System.Drawing.Color.Tomato;
            this.txt_birim.Enabled = false;
            this.txt_birim.ForeColor = System.Drawing.Color.White;
            this.txt_birim.Location = new System.Drawing.Point(276, 29);
            this.txt_birim.MaxLength = 40;
            this.txt_birim.Name = "txt_birim";
            this.txt_birim.Size = new System.Drawing.Size(37, 23);
            this.txt_birim.TabIndex = 180;
            // 
            // txt_maktx
            // 
            this.txt_maktx.BackColor = System.Drawing.Color.Tomato;
            this.txt_maktx.Enabled = false;
            this.txt_maktx.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_maktx.ForeColor = System.Drawing.Color.White;
            this.txt_maktx.Location = new System.Drawing.Point(67, 54);
            this.txt_maktx.MaxLength = 18;
            this.txt_maktx.Name = "txt_maktx";
            this.txt_maktx.Size = new System.Drawing.Size(247, 22);
            this.txt_maktx.TabIndex = 179;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(0, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "Ürün Adı  :";
            // 
            // txt_miktar
            // 
            this.txt_miktar.Enabled = false;
            this.txt_miktar.Location = new System.Drawing.Point(235, 29);
            this.txt_miktar.MaxLength = 40;
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(35, 23);
            this.txt_miktar.TabIndex = 176;
            this.txt_miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_miktar_KeyPress);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(190, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.Text = "Miktar:";
            // 
            // txt_malzemeNo
            // 
            this.txt_malzemeNo.Enabled = false;
            this.txt_malzemeNo.Location = new System.Drawing.Point(67, 29);
            this.txt_malzemeNo.MaxLength = 40;
            this.txt_malzemeNo.Name = "txt_malzemeNo";
            this.txt_malzemeNo.Size = new System.Drawing.Size(121, 23);
            this.txt_malzemeNo.TabIndex = 175;
            this.txt_malzemeNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_malzemeNo_KeyPress);
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(0, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.Text = "Malzeme  :";
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.Color.White;
            this.txtAdres.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txtAdres.ForeColor = System.Drawing.Color.Black;
            this.txtAdres.Location = new System.Drawing.Point(67, 6);
            this.txtAdres.MaxLength = 18;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(122, 20);
            this.txtAdres.TabIndex = 173;
            this.txtAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdres1_KeyPress);
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.Tomato;
            this.btn_Geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.BackgroundImage")));
            this.btn_Geri.ForeColor = System.Drawing.Color.White;
            this.btn_Geri.Location = new System.Drawing.Point(215, 225);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.PressedImage")));
            this.btn_Geri.Size = new System.Drawing.Size(99, 48);
            this.btn_Geri.TabIndex = 183;
            this.btn_Geri.Text = "   Geri";
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Tomato;
            this.btn_kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.BackgroundImage")));
            this.btn_kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_kaydet.Location = new System.Drawing.Point(1, 225);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.PressedImage")));
            this.btn_kaydet.Size = new System.Drawing.Size(178, 48);
            this.btn_kaydet.TabIndex = 182;
            this.btn_kaydet.Text = "     Kaydet";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Tomato;
            this.btn_Ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.BackgroundImage")));
            this.btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.btn_Ekle.Location = new System.Drawing.Point(1, 82);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.PressedImage = null;
            this.btn_Ekle.Size = new System.Drawing.Size(91, 24);
            this.btn_Ekle.TabIndex = 177;
            this.btn_Ekle.Text = "   Ekle";
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Tomato;
            this.btn_sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sil.BackgroundImage")));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(98, 82);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_sil.PressedImage")));
            this.btn_sil.Size = new System.Drawing.Size(91, 24);
            this.btn_sil.TabIndex = 178;
            this.btn_sil.Text = "    Sil";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_Getir
            // 
            this.btn_Getir.BackColor = System.Drawing.Color.Tomato;
            this.btn_Getir.BackgroundImage = null;
            this.btn_Getir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Getir.ForeColor = System.Drawing.Color.White;
            this.btn_Getir.Location = new System.Drawing.Point(233, 5);
            this.btn_Getir.Name = "btn_Getir";
            this.btn_Getir.Size = new System.Drawing.Size(81, 21);
            this.btn_Getir.TabIndex = 174;
            this.btn_Getir.Text = "Kontrol Et";
            this.btn_Getir.Click += new System.EventHandler(this.btn_Getir_Click);
            // 
            // frm_AdreslemeGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.ControlBox = false;
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.grd_mal);
            this.Controls.Add(this.txt_birim);
            this.Controls.Add(this.txt_maktx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_malzemeNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Getir);
            this.Name = "frm_AdreslemeGiris";
            this.Text = "Adresleme Giriş";
            this.Load += new System.EventHandler(this.frm_AdreslemeGiris_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
        private PictureButton btn_Geri;
        private PictureButton btn_kaydet;
        private PictureButton btn_Ekle;
        private PictureButton btn_sil;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGrid grd_mal;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.TextBox txt_birim;
        private System.Windows.Forms.TextBox txt_maktx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_malzemeNo;
        private System.Windows.Forms.Label label7;
        private PictureButton btn_Getir;
        private System.Windows.Forms.TextBox txtAdres;
    }
}