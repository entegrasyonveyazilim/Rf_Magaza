namespace KoctasMobil
{
    partial class frm_SiparisBirlestir1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SiparisBirlestir1));
            this.grd_Siparisler = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.txt_siparisNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Vazgec = new KoctasMobil.PictureButton();
            this.btn_SiparisBirlestir = new KoctasMobil.PictureButton();
            this.btn_Sil = new KoctasMobil.PictureButton();
            this.btn_ekle = new KoctasMobil.PictureButton();
            this.rdb_Normal = new System.Windows.Forms.RadioButton();
            this.rdb_Transferli = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // grd_Siparisler
            // 
            this.grd_Siparisler.BackgroundColor = System.Drawing.Color.Tomato;
            this.grd_Siparisler.Location = new System.Drawing.Point(3, 64);
            this.grd_Siparisler.Name = "grd_Siparisler";
            this.grd_Siparisler.Size = new System.Drawing.Size(315, 113);
            this.grd_Siparisler.TabIndex = 37;
            this.grd_Siparisler.TableStyles.Add(this.dataGridTableStyle2);
            // 
            // dataGridTableStyle2
            // 
            this.dataGridTableStyle2.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Sipariþ No";
            this.dataGridTextBoxColumn1.MappingName = "SIPARISNO";
            this.dataGridTextBoxColumn1.NullText = "";
            this.dataGridTextBoxColumn1.Width = 111;
            // 
            // txt_siparisNo
            // 
            this.txt_siparisNo.Location = new System.Drawing.Point(76, 6);
            this.txt_siparisNo.MaxLength = 18;
            this.txt_siparisNo.Name = "txt_siparisNo";
            this.txt_siparisNo.Size = new System.Drawing.Size(240, 23);
            this.txt_siparisNo.TabIndex = 32;
            this.txt_siparisNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_siparisNo_KeyPress);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "Sipariş No :";
            // 
            // btn_Vazgec
            // 
            this.btn_Vazgec.BackColor = System.Drawing.Color.Tomato;
            this.btn_Vazgec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Vazgec.BackgroundImage")));
            this.btn_Vazgec.ForeColor = System.Drawing.Color.White;
            this.btn_Vazgec.Location = new System.Drawing.Point(204, 214);
            this.btn_Vazgec.Name = "btn_Vazgec";
            this.btn_Vazgec.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Vazgec.PressedImage")));
            this.btn_Vazgec.Size = new System.Drawing.Size(113, 54);
            this.btn_Vazgec.TabIndex = 44;
            this.btn_Vazgec.Text = "       Vazgeç";
            this.btn_Vazgec.Click += new System.EventHandler(this.btn_Vazgec_Click);
            // 
            // btn_SiparisBirlestir
            // 
            this.btn_SiparisBirlestir.BackColor = System.Drawing.Color.Tomato;
            this.btn_SiparisBirlestir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SiparisBirlestir.BackgroundImage")));
            this.btn_SiparisBirlestir.ForeColor = System.Drawing.Color.White;
            this.btn_SiparisBirlestir.Location = new System.Drawing.Point(3, 214);
            this.btn_SiparisBirlestir.Name = "btn_SiparisBirlestir";
            this.btn_SiparisBirlestir.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_SiparisBirlestir.PressedImage")));
            this.btn_SiparisBirlestir.Size = new System.Drawing.Size(176, 54);
            this.btn_SiparisBirlestir.TabIndex = 42;
            this.btn_SiparisBirlestir.Text = "        Siparişleri Birleştir";
            this.btn_SiparisBirlestir.Click += new System.EventHandler(this.btn_SiparisBirlestir_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Tomato;
            this.btn_Sil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sil.BackgroundImage")));
            this.btn_Sil.ForeColor = System.Drawing.Color.White;
            this.btn_Sil.Location = new System.Drawing.Point(94, 36);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Sil.PressedImage")));
            this.btn_Sil.Size = new System.Drawing.Size(85, 24);
            this.btn_Sil.TabIndex = 41;
            this.btn_Sil.Text = "Vazgeç";
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Tomato;
            this.btn_ekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ekle.BackgroundImage")));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(3, 36);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_ekle.PressedImage")));
            this.btn_ekle.Size = new System.Drawing.Size(85, 24);
            this.btn_ekle.TabIndex = 39;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // rdb_Normal
            // 
            this.rdb_Normal.Checked = true;
            this.rdb_Normal.Location = new System.Drawing.Point(4, 184);
            this.rdb_Normal.Name = "rdb_Normal";
            this.rdb_Normal.Size = new System.Drawing.Size(100, 20);
            this.rdb_Normal.TabIndex = 46;
            this.rdb_Normal.Text = "Normal Satış";
            // 
            // rdb_Transferli
            // 
            this.rdb_Transferli.Location = new System.Drawing.Point(110, 183);
            this.rdb_Transferli.Name = "rdb_Transferli";
            this.rdb_Transferli.Size = new System.Drawing.Size(120, 20);
            this.rdb_Transferli.TabIndex = 47;
            this.rdb_Transferli.TabStop = false;
            this.rdb_Transferli.Text = "Transferli Satış";
            // 
            // frm_SiparisBirlestir1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.rdb_Transferli);
            this.Controls.Add(this.rdb_Normal);
            this.Controls.Add(this.btn_Vazgec);
            this.Controls.Add(this.grd_Siparisler);
            this.Controls.Add(this.btn_SiparisBirlestir);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_siparisNo);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_SiparisBirlestir1";
            this.Text = "Sipariş Birleştir";
            this.Load += new System.EventHandler(this.frm_SiparisBirlestir1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid grd_Siparisler;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.TextBox txt_siparisNo;
        private System.Windows.Forms.Label label5;
        private PictureButton btn_ekle;
        private PictureButton btn_Sil;
        private PictureButton btn_SiparisBirlestir;
        private PictureButton btn_Vazgec;
        private System.Windows.Forms.RadioButton rdb_Normal;
        private System.Windows.Forms.RadioButton rdb_Transferli;
    }
}