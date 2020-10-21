namespace KoctasMobil
{
    partial class frm_MusteridenIadeBilgiFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MusteridenIadeBilgiFormu));
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusteriTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFisNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIadeNedeni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFisTarih = new System.Windows.Forms.DateTimePicker();
            this.btn_Geri = new KoctasMobil.PictureButton();
            this.btn_kaydet = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(130, 5);
            this.txtMusteriAd.MaxLength = 40;
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(185, 23);
            this.txtMusteriAd.TabIndex = 147;
            this.txtMusteriAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriAd_KeyPress);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.Tag = "";
            this.label1.Text = "Müşteri Adı Soyadı :";
            // 
            // txtMusteriTelefon
            // 
            this.txtMusteriTelefon.Location = new System.Drawing.Point(130, 34);
            this.txtMusteriTelefon.MaxLength = 40;
            this.txtMusteriTelefon.Name = "txtMusteriTelefon";
            this.txtMusteriTelefon.Size = new System.Drawing.Size(185, 23);
            this.txtMusteriTelefon.TabIndex = 150;
            this.txtMusteriTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriTelefon_KeyPress);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.Text = "Müşteri Telefonu :";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.Text = "Fiş-Fatura Tarihi :";
            // 
            // txtFisNo
            // 
            this.txtFisNo.Location = new System.Drawing.Point(130, 92);
            this.txtFisNo.MaxLength = 40;
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(185, 23);
            this.txtFisNo.TabIndex = 156;
            this.txtFisNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFisNo_KeyPress);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.Text = "Fiş-Fatura No :";
            // 
            // txtIadeNedeni
            // 
            this.txtIadeNedeni.Location = new System.Drawing.Point(3, 146);
            this.txtIadeNedeni.MaxLength = 40;
            this.txtIadeNedeni.Multiline = true;
            this.txtIadeNedeni.Name = "txtIadeNedeni";
            this.txtIadeNedeni.Size = new System.Drawing.Size(312, 58);
            this.txtIadeNedeni.TabIndex = 159;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.Text = "İade Nedeni :";
            // 
            // txtFisTarih
            // 
            this.txtFisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFisTarih.Location = new System.Drawing.Point(130, 62);
            this.txtFisTarih.Name = "txtFisTarih";
            this.txtFisTarih.Size = new System.Drawing.Size(185, 24);
            this.txtFisTarih.TabIndex = 161;
            this.txtFisTarih.Value = new System.DateTime(2011, 8, 18, 15, 57, 24, 0);
            this.txtFisTarih.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFisTarih_KeyPress);
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.Tomato;
            this.btn_Geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.BackgroundImage")));
            this.btn_Geri.ForeColor = System.Drawing.Color.White;
            this.btn_Geri.Location = new System.Drawing.Point(216, 216);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.PressedImage")));
            this.btn_Geri.Size = new System.Drawing.Size(99, 48);
            this.btn_Geri.TabIndex = 145;
            this.btn_Geri.Text = "   Geri";
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.BackColor = System.Drawing.Color.Tomato;
            this.btn_kaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.BackgroundImage")));
            this.btn_kaydet.ForeColor = System.Drawing.Color.White;
            this.btn_kaydet.Location = new System.Drawing.Point(3, 216);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.PressedImage")));
            this.btn_kaydet.Size = new System.Drawing.Size(178, 48);
            this.btn_kaydet.TabIndex = 144;
            this.btn_kaydet.Text = "     İade  Kaydet";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // frm_MusteridenIadeBilgiFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.ControlBox = false;
            this.Controls.Add(this.txtFisTarih);
            this.Controls.Add(this.txtIadeNedeni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFisNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMusteriTelefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_kaydet);
            this.Name = "frm_MusteridenIadeBilgiFormu";
            this.Text = "Müşteriden İade Bilgi Formu";
            this.Load += new System.EventHandler(this.frm_MusteridenIadeBilgiFormu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureButton btn_Geri;
        private PictureButton btn_kaydet;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFisNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIadeNedeni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtFisTarih;
    }
}