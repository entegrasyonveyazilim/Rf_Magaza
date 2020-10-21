namespace KoctasMobil
{
    partial class frm_StokIadeDegistir2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StokIadeDegistir2));
            this.txt_malzemeno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grd_mal = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.txt_maktx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_birim = new System.Windows.Forms.TextBox();
            this.btn_undo = new KoctasMobil.PictureButton();
            this.btn_HepsiniSil = new KoctasMobil.PictureButton();
            this.btn_sil = new KoctasMobil.PictureButton();
            this.btn_Ekle = new KoctasMobil.PictureButton();
            this.btn_Geri = new KoctasMobil.PictureButton();
            this.btn_kaydet = new KoctasMobil.PictureButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIadeTipi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_malzemeno
            // 
            this.txt_malzemeno.Location = new System.Drawing.Point(69, 5);
            this.txt_malzemeno.MaxLength = 40;
            this.txt_malzemeno.Name = "txt_malzemeno";
            this.txt_malzemeno.Size = new System.Drawing.Size(121, 23);
            this.txt_malzemeno.TabIndex = 1;
            this.txt_malzemeno.TextChanged += new System.EventHandler(this.txt_malzemeno_TextChanged);
            this.txt_malzemeno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_malzemeno_KeyPress);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.Text = "Malzeme  :";
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(245, 5);
            this.txt_miktar.MaxLength = 40;
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(40, 23);
            this.txt_miktar.TabIndex = 2;
            this.txt_miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_miktar_KeyPress);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(196, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.Text = "Miktar :";
            // 
            // grd_mal
            // 
            this.grd_mal.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_mal.Location = new System.Drawing.Point(1, 104);
            this.grd_mal.Name = "grd_mal";
            this.grd_mal.Size = new System.Drawing.Size(316, 108);
            this.grd_mal.TabIndex = 132;
            this.grd_mal.TableStyles.Add(this.dataGridTableStyle1);
            this.grd_mal.DoubleClick += new System.EventHandler(this.grd_mal_DoubleClick);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
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
            this.dataGridTextBoxColumn2.Width = 135;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "0.#";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Miktar";
            this.dataGridTextBoxColumn4.MappingName = "menge";
            this.dataGridTextBoxColumn4.Width = 42;
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "TÖB";
            this.dataGridTextBoxColumn5.MappingName = "meins";
            this.dataGridTextBoxColumn5.Width = 33;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "İade Tipi";
            this.dataGridTextBoxColumn3.MappingName = "itip";
            this.dataGridTextBoxColumn3.Width = 100;
            // 
            // txt_maktx
            // 
            this.txt_maktx.BackColor = System.Drawing.Color.Tomato;
            this.txt_maktx.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_maktx.ForeColor = System.Drawing.Color.White;
            this.txt_maktx.Location = new System.Drawing.Point(69, 30);
            this.txt_maktx.MaxLength = 18;
            this.txt_maktx.Name = "txt_maktx";
            this.txt_maktx.Size = new System.Drawing.Size(247, 22);
            this.txt_maktx.TabIndex = 151;
            this.txt_maktx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(2, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "Ürün Adı  :";
            // 
            // txt_birim
            // 
            this.txt_birim.BackColor = System.Drawing.Color.Tomato;
            this.txt_birim.ForeColor = System.Drawing.Color.White;
            this.txt_birim.Location = new System.Drawing.Point(286, 5);
            this.txt_birim.MaxLength = 40;
            this.txt_birim.Name = "txt_birim";
            this.txt_birim.Size = new System.Drawing.Size(29, 23);
            this.txt_birim.TabIndex = 153;
            this.txt_birim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GeneralKeyPress);
            // 
            // btn_undo
            // 
            this.btn_undo.BackColor = System.Drawing.Color.Tomato;
            this.btn_undo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_undo.BackgroundImage")));
            this.btn_undo.ForeColor = System.Drawing.Color.White;
            this.btn_undo.Location = new System.Drawing.Point(237, 79);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_undo.PressedImage")));
            this.btn_undo.Size = new System.Drawing.Size(80, 24);
            this.btn_undo.TabIndex = 158;
            this.btn_undo.Text = "     Geri Al";
            this.btn_undo.Click += new System.EventHandler(this.btn_undo1_Click);
            // 
            // btn_HepsiniSil
            // 
            this.btn_HepsiniSil.BackColor = System.Drawing.Color.Tomato;
            this.btn_HepsiniSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_HepsiniSil.BackgroundImage")));
            this.btn_HepsiniSil.ForeColor = System.Drawing.Color.White;
            this.btn_HepsiniSil.Location = new System.Drawing.Point(159, 79);
            this.btn_HepsiniSil.Name = "btn_HepsiniSil";
            this.btn_HepsiniSil.PressedImage = null;
            this.btn_HepsiniSil.Size = new System.Drawing.Size(80, 24);
            this.btn_HepsiniSil.TabIndex = 157;
            this.btn_HepsiniSil.Text = "     Temizle";
            this.btn_HepsiniSil.Click += new System.EventHandler(this.btn_HepsiniSil_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Tomato;
            this.btn_sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sil.BackgroundImage")));
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(80, 79);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_sil.PressedImage")));
            this.btn_sil.Size = new System.Drawing.Size(80, 24);
            this.btn_sil.TabIndex = 147;
            this.btn_sil.Text = "    Sil";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Tomato;
            this.btn_Ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.BackgroundImage")));
            this.btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.btn_Ekle.Location = new System.Drawing.Point(1, 79);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.PressedImage = null;
            this.btn_Ekle.Size = new System.Drawing.Size(80, 24);
            this.btn_Ekle.TabIndex = 144;
            this.btn_Ekle.Text = "   Ekle";
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
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
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Tomato;
            this.btn_kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.BackgroundImage")));
            this.btn_kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_kaydet.Location = new System.Drawing.Point(3, 214);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.PressedImage")));
            this.btn_kaydet.Size = new System.Drawing.Size(178, 48);
            this.btn_kaydet.TabIndex = 142;
            this.btn_kaydet.Text = "     İade  Kaydet";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.Text = "İade Tipi  :";
            // 
            // cmbIadeTipi
            // 
            this.cmbIadeTipi.Items.Add("Normal İade");
            this.cmbIadeTipi.Items.Add("Ayıplı İade");
            this.cmbIadeTipi.Items.Add("Stok Fazlası");
            this.cmbIadeTipi.Location = new System.Drawing.Point(69, 54);
            this.cmbIadeTipi.Name = "cmbIadeTipi";
            this.cmbIadeTipi.Size = new System.Drawing.Size(246, 23);
            this.cmbIadeTipi.TabIndex = 162;
            // 
            // frm_StokIadeDegistir2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.cmbIadeTipi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_undo);
            this.Controls.Add(this.btn_HepsiniSil);
            this.Controls.Add(this.txt_birim);
            this.Controls.Add(this.txt_maktx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.grd_mal);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_malzemeno);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_StokIadeDegistir2";
            this.Text = "Stok İade Değiştir";
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
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private PictureButton btn_Geri;
        private PictureButton btn_kaydet;
        private PictureButton btn_Ekle;
        private PictureButton btn_sil;
        private System.Windows.Forms.TextBox txt_maktx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_birim;
        private PictureButton btn_undo;
        private PictureButton btn_HepsiniSil;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIadeTipi;
    }
}