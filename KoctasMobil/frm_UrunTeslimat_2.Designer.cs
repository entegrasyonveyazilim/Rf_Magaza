namespace KoctasMobil
{
    partial class frm_UrunTeslimat_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UrunTeslimat_2));
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.grdUrunTeslimat = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.txtMatnrEan11 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFormNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMenge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRedNeden = new System.Windows.Forms.ComboBox();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEMenge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new KoctasMobil.PictureButton();
            this.btn_Temizle = new KoctasMobil.PictureButton();
            this.btn_Sil = new KoctasMobil.PictureButton();
            this.btn_Ekle = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Top.";
            this.dataGridTextBoxColumn2.MappingName = "MENGE";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Malzeme No";
            this.dataGridTextBoxColumn1.MappingName = "MATNR";
            this.dataGridTextBoxColumn1.Width = 100;
            // 
            // grdUrunTeslimat
            // 
            this.grdUrunTeslimat.BackColor = System.Drawing.Color.White;
            this.grdUrunTeslimat.BackgroundColor = System.Drawing.Color.Tomato;
            this.grdUrunTeslimat.Location = new System.Drawing.Point(3, 141);
            this.grdUrunTeslimat.Name = "grdUrunTeslimat";
            this.grdUrunTeslimat.Size = new System.Drawing.Size(309, 89);
            this.grdUrunTeslimat.TabIndex = 190;
            this.grdUrunTeslimat.TableStyles.Add(this.dataGridTableStyle1);
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
            this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Set Ürün";
            this.dataGridTextBoxColumn3.MappingName = "ISET";
            this.dataGridTextBoxColumn3.Width = 30;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Malzeme Adı";
            this.dataGridTextBoxColumn4.MappingName = "MAKTX";
            this.dataGridTextBoxColumn4.Width = 200;
            // 
            // dataGridTextBoxColumn5
            // 
            this.dataGridTextBoxColumn5.Format = "";
            this.dataGridTextBoxColumn5.FormatInfo = null;
            this.dataGridTextBoxColumn5.HeaderText = "Eksik";
            this.dataGridTextBoxColumn5.MappingName = "EMENGE";
            // 
            // dataGridTextBoxColumn6
            // 
            this.dataGridTextBoxColumn6.Format = "";
            this.dataGridTextBoxColumn6.FormatInfo = null;
            this.dataGridTextBoxColumn6.HeaderText = "Red Nedeni";
            this.dataGridTextBoxColumn6.MappingName = "NEDEN_CODE";
            // 
            // txtMatnrEan11
            // 
            this.txtMatnrEan11.BackColor = System.Drawing.Color.White;
            this.txtMatnrEan11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txtMatnrEan11.ForeColor = System.Drawing.Color.Black;
            this.txtMatnrEan11.Location = new System.Drawing.Point(92, 28);
            this.txtMatnrEan11.MaxLength = 18;
            this.txtMatnrEan11.Name = "txtMatnrEan11";
            this.txtMatnrEan11.Size = new System.Drawing.Size(121, 20);
            this.txtMatnrEan11.TabIndex = 61;
            this.txtMatnrEan11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatnrEan11_KeyPress);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.Text = "Malzeme No :";
            // 
            // txtFormNo
            // 
            this.txtFormNo.BackColor = System.Drawing.Color.White;
            this.txtFormNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txtFormNo.ForeColor = System.Drawing.Color.Black;
            this.txtFormNo.Location = new System.Drawing.Point(92, 2);
            this.txtFormNo.MaxLength = 18;
            this.txtFormNo.Name = "txtFormNo";
            this.txtFormNo.Size = new System.Drawing.Size(121, 20);
            this.txtFormNo.TabIndex = 50;
            this.txtFormNo.TextChanged += new System.EventHandler(this.txtFormNo_TextChanged);
            this.txtFormNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFormNo_KeyPress);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.Text = "Form No :";
            // 
            // txtMenge
            // 
            this.txtMenge.BackColor = System.Drawing.Color.White;
            this.txtMenge.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txtMenge.ForeColor = System.Drawing.Color.Black;
            this.txtMenge.Location = new System.Drawing.Point(216, 28);
            this.txtMenge.MaxLength = 18;
            this.txtMenge.Name = "txtMenge";
            this.txtMenge.Size = new System.Drawing.Size(46, 20);
            this.txtMenge.TabIndex = 62;
            this.txtMenge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMenge_KeyPress);
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(2, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.Text = "Red Nedeni:";
            // 
            // cmbRedNeden
            // 
            this.cmbRedNeden.Location = new System.Drawing.Point(92, 77);
            this.cmbRedNeden.Name = "cmbRedNeden";
            this.cmbRedNeden.Size = new System.Drawing.Size(220, 23);
            this.cmbRedNeden.TabIndex = 65;
            this.cmbRedNeden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbRedNeden_KeyPress);
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.BackColor = System.Drawing.Color.White;
            this.txtMalzemeAdi.Enabled = false;
            this.txtMalzemeAdi.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold);
            this.txtMalzemeAdi.ForeColor = System.Drawing.Color.Black;
            this.txtMalzemeAdi.Location = new System.Drawing.Point(92, 51);
            this.txtMalzemeAdi.MaxLength = 18;
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(220, 20);
            this.txtMalzemeAdi.TabIndex = 150;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.Text = "Malzeme Adı :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(270, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.Text = "Eksik";
            // 
            // txtEMenge
            // 
            this.txtEMenge.BackColor = System.Drawing.Color.White;
            this.txtEMenge.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
            this.txtEMenge.ForeColor = System.Drawing.Color.Black;
            this.txtEMenge.Location = new System.Drawing.Point(265, 28);
            this.txtEMenge.MaxLength = 18;
            this.txtEMenge.Name = "txtEMenge";
            this.txtEMenge.ReadOnly = true;
            this.txtEMenge.Size = new System.Drawing.Size(50, 20);
            this.txtEMenge.TabIndex = 63;
            this.txtEMenge.Text = "0";
            this.txtEMenge.TextChanged += new System.EventHandler(this.txtEMenge_TextChanged);
            this.txtEMenge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEMenge_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(214, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.Text = "Toplanan";
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.Color.Tomato;
            this.btn_Kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.BackgroundImage")));
            this.btn_Kaydet.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_Kaydet.Location = new System.Drawing.Point(215, 233);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Kaydet.PressedImage")));
            this.btn_Kaydet.Size = new System.Drawing.Size(97, 25);
            this.btn_Kaydet.TabIndex = 103;
            this.btn_Kaydet.Text = "     Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.BackColor = System.Drawing.Color.Tomato;
            this.btn_Temizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Temizle.BackgroundImage")));
            this.btn_Temizle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Temizle.ForeColor = System.Drawing.Color.White;
            this.btn_Temizle.Location = new System.Drawing.Point(163, 113);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Temizle.PressedImage")));
            this.btn_Temizle.Size = new System.Drawing.Size(76, 25);
            this.btn_Temizle.TabIndex = 100;
            this.btn_Temizle.Text = "    Temizle";
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Tomato;
            this.btn_Sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sil.BackgroundImage")));
            this.btn_Sil.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Sil.ForeColor = System.Drawing.Color.White;
            this.btn_Sil.Location = new System.Drawing.Point(84, 113);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Sil.PressedImage")));
            this.btn_Sil.Size = new System.Drawing.Size(76, 25);
            this.btn_Sil.TabIndex = 99;
            this.btn_Sil.Text = "   Sil";
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Tomato;
            this.btn_Ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.BackgroundImage")));
            this.btn_Ekle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Ekle.ForeColor = System.Drawing.Color.White;
            this.btn_Ekle.Location = new System.Drawing.Point(4, 113);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.PressedImage")));
            this.btn_Ekle.Size = new System.Drawing.Size(76, 25);
            this.btn_Ekle.TabIndex = 98;
            this.btn_Ekle.Text = "   Ekle";
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // frm_UrunTeslimat_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEMenge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbRedNeden);
            this.Controls.Add(this.txtMalzemeAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txtMenge);
            this.Controls.Add(this.txtFormNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grdUrunTeslimat);
            this.Controls.Add(this.txtMatnrEan11);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_UrunTeslimat_2";
            this.Text = "Ürün Teslimat";
            this.Load += new System.EventHandler(this.frm_Etiket_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGrid grdUrunTeslimat;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.TextBox txtMatnrEan11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFormNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMenge;
        private PictureButton btn_Temizle;
        private PictureButton btn_Sil;
        private PictureButton btn_Ekle;
        private PictureButton btn_Kaydet;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRedNeden;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEMenge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;

    }
}