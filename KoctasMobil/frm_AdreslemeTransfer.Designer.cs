namespace KoctasMobil
{
    partial class frm_AdreslemeTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AdreslemeTransfer));
            this.txt_birim = new System.Windows.Forms.TextBox();
            this.txt_maktx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_malzemeNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHedefAdres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKaynakAdres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grd_mal = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.cmbDepoYeri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkSatisAlani = new System.Windows.Forms.CheckBox();
            this.btn_Getir = new KoctasMobil.PictureButton();
            this.btn_Ekle = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // txt_birim
            // 
            this.txt_birim.BackColor = System.Drawing.Color.Tomato;
            this.txt_birim.Enabled = false;
            this.txt_birim.ForeColor = System.Drawing.Color.White;
            this.txt_birim.Location = new System.Drawing.Point(278, 164);
            this.txt_birim.MaxLength = 40;
            this.txt_birim.Name = "txt_birim";
            this.txt_birim.Size = new System.Drawing.Size(37, 23);
            this.txt_birim.TabIndex = 190;
            // 
            // txt_maktx
            // 
            this.txt_maktx.BackColor = System.Drawing.Color.Tomato;
            this.txt_maktx.Enabled = false;
            this.txt_maktx.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txt_maktx.ForeColor = System.Drawing.Color.White;
            this.txt_maktx.Location = new System.Drawing.Point(70, 193);
            this.txt_maktx.MaxLength = 18;
            this.txt_maktx.Name = "txt_maktx";
            this.txt_maktx.Size = new System.Drawing.Size(245, 22);
            this.txt_maktx.TabIndex = 189;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(4, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "Ürün Adı  :";
            // 
            // txt_miktar
            // 
            this.txt_miktar.Enabled = false;
            this.txt_miktar.Location = new System.Drawing.Point(237, 164);
            this.txt_miktar.MaxLength = 40;
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(35, 23);
            this.txt_miktar.TabIndex = 188;
            this.txt_miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_miktar_KeyPress);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(192, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.Text = "Miktar:";
            // 
            // txt_malzemeNo
            // 
            this.txt_malzemeNo.Enabled = false;
            this.txt_malzemeNo.Location = new System.Drawing.Point(70, 165);
            this.txt_malzemeNo.MaxLength = 40;
            this.txt_malzemeNo.Name = "txt_malzemeNo";
            this.txt_malzemeNo.Size = new System.Drawing.Size(121, 23);
            this.txt_malzemeNo.TabIndex = 187;
            this.txt_malzemeNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_malzemeNo_KeyPress);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.Text = "Malz. No:";
            // 
            // txtHedefAdres
            // 
            this.txtHedefAdres.BackColor = System.Drawing.Color.White;
            this.txtHedefAdres.Enabled = false;
            this.txtHedefAdres.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txtHedefAdres.ForeColor = System.Drawing.Color.Black;
            this.txtHedefAdres.Location = new System.Drawing.Point(109, 244);
            this.txtHedefAdres.MaxLength = 18;
            this.txtHedefAdres.Name = "txtHedefAdres";
            this.txtHedefAdres.Size = new System.Drawing.Size(122, 20);
            this.txtHedefAdres.TabIndex = 207;
            this.txtHedefAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHedefAdres_KeyPress);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Hedef Adres  :";
            // 
            // txtKaynakAdres
            // 
            this.txtKaynakAdres.BackColor = System.Drawing.Color.White;
            this.txtKaynakAdres.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txtKaynakAdres.ForeColor = System.Drawing.Color.Black;
            this.txtKaynakAdres.Location = new System.Drawing.Point(109, 3);
            this.txtKaynakAdres.MaxLength = 18;
            this.txtKaynakAdres.Name = "txtKaynakAdres";
            this.txtKaynakAdres.Size = new System.Drawing.Size(122, 20);
            this.txtKaynakAdres.TabIndex = 215;
            this.txtKaynakAdres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdres1_KeyPress);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.Text = "Kaynak Adres:";
            // 
            // grd_mal
            // 
            this.grd_mal.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_mal.Location = new System.Drawing.Point(2, 55);
            this.grd_mal.Name = "grd_mal";
            this.grd_mal.Size = new System.Drawing.Size(316, 107);
            this.grd_mal.TabIndex = 218;
            this.grd_mal.TableStyles.Add(this.dataGridTableStyle1);
            this.grd_mal.DoubleClick += new System.EventHandler(this.grd_mal_DoubleClick);
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
            this.dataGridTextBoxColumn1.HeaderText = "Malzeme No";
            this.dataGridTextBoxColumn1.MappingName = "Matnr";
            this.dataGridTextBoxColumn1.Width = 150;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Adet";
            this.dataGridTextBoxColumn2.MappingName = "Menge";
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Birim";
            this.dataGridTextBoxColumn3.MappingName = "Meins";
            this.dataGridTextBoxColumn3.Width = 30;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Kaynak Adres";
            this.dataGridTextBoxColumn4.MappingName = "Nlpla";
            this.dataGridTextBoxColumn4.Width = 75;
            // 
            // cmbDepoYeri
            // 
            this.cmbDepoYeri.Location = new System.Drawing.Point(234, 30);
            this.cmbDepoYeri.Name = "cmbDepoYeri";
            this.cmbDepoYeri.Size = new System.Drawing.Size(81, 23);
            this.cmbDepoYeri.TabIndex = 224;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(158, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.Text = "Depo Yeri:";
            // 
            // checkSatisAlani
            // 
            this.checkSatisAlani.Location = new System.Drawing.Point(70, 220);
            this.checkSatisAlani.Name = "checkSatisAlani";
            this.checkSatisAlani.Size = new System.Drawing.Size(214, 20);
            this.checkSatisAlani.TabIndex = 230;
            this.checkSatisAlani.Text = "Satış Alanı Transfer";
            this.checkSatisAlani.CheckStateChanged += new System.EventHandler(this.checkSatisAlani_CheckStateChanged);
            // 
            // btn_Getir
            // 
            this.btn_Getir.BackColor = System.Drawing.Color.Tomato;
            this.btn_Getir.BackgroundImage = null;
            this.btn_Getir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Getir.ForeColor = System.Drawing.Color.White;
            this.btn_Getir.Location = new System.Drawing.Point(234, 3);
            this.btn_Getir.Name = "btn_Getir";
            this.btn_Getir.Size = new System.Drawing.Size(81, 21);
            this.btn_Getir.TabIndex = 216;
            this.btn_Getir.Text = "Kontrol Et";
            this.btn_Getir.Click += new System.EventHandler(this.btn_Getir_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Tomato;
            this.btn_Ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.BackgroundImage")));
            this.btn_Ekle.Enabled = false;
            this.btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.btn_Ekle.Location = new System.Drawing.Point(237, 240);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.PressedImage")));
            this.btn_Ekle.Size = new System.Drawing.Size(78, 24);
            this.btn_Ekle.TabIndex = 197;
            this.btn_Ekle.Text = "   Trans. Et";
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click_1);
            // 
            // frm_AdreslemeTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.checkSatisAlani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDepoYeri);
            this.Controls.Add(this.grd_mal);
            this.Controls.Add(this.txtKaynakAdres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Getir);
            this.Controls.Add(this.txtHedefAdres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txt_birim);
            this.Controls.Add(this.txt_maktx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_malzemeNo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AdreslemeTransfer";
            this.Text = "Adresleme Transfer";
            this.Load += new System.EventHandler(this.frm_AdreslemeTransfer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_birim;
        private System.Windows.Forms.TextBox txt_maktx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_malzemeNo;
        private PictureButton btn_Ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHedefAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKaynakAdres;
        private System.Windows.Forms.Label label4;
        private PictureButton btn_Getir;
        private System.Windows.Forms.DataGrid grd_mal;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.ComboBox cmbDepoYeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkSatisAlani;
    }
}