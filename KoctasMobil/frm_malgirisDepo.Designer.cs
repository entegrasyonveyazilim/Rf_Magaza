namespace KoctasMobil
{
    partial class frm_malgirisDepo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_malgirisDepo));
            this.txtSevkiyatNo = new System.Windows.Forms.TextBox();
            this.lbSevkiyatNo = new System.Windows.Forms.Label();
            this.chk_horoz = new System.Windows.Forms.CheckBox();
            this.dtp_kayit = new System.Windows.Forms.DateTimePicker();
            this.dtp_belge = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lst_Siparis = new System.Windows.Forms.ListBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt_irsNo = new System.Windows.Forms.TextBox();
            this.btn_Geri = new KoctasMobil.PictureButton();
            this.btn_siparis = new KoctasMobil.PictureButton();
            this.btn_SevkiyatNo_Kontrol = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // txtSevkiyatNo
            // 
            this.txtSevkiyatNo.Location = new System.Drawing.Point(94, 77);
            this.txtSevkiyatNo.MaxLength = 40;
            this.txtSevkiyatNo.Name = "txtSevkiyatNo";
            this.txtSevkiyatNo.Size = new System.Drawing.Size(130, 23);
            this.txtSevkiyatNo.TabIndex = 161;
            this.txtSevkiyatNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSevkiyatNo_KeyPress);
            // 
            // lbSevkiyatNo
            // 
            this.lbSevkiyatNo.BackColor = System.Drawing.Color.White;
            this.lbSevkiyatNo.ForeColor = System.Drawing.Color.Black;
            this.lbSevkiyatNo.Location = new System.Drawing.Point(3, 81);
            this.lbSevkiyatNo.Name = "lbSevkiyatNo";
            this.lbSevkiyatNo.Size = new System.Drawing.Size(96, 20);
            this.lbSevkiyatNo.Text = "Sevkiyat No   :";
            // 
            // chk_horoz
            // 
            this.chk_horoz.Checked = true;
            this.chk_horoz.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_horoz.Enabled = false;
            this.chk_horoz.Location = new System.Drawing.Point(92, 55);
            this.chk_horoz.Name = "chk_horoz";
            this.chk_horoz.Size = new System.Drawing.Size(120, 20);
            this.chk_horoz.TabIndex = 160;
            this.chk_horoz.Text = "Depo Lojistik";
            // 
            // dtp_kayit
            // 
            this.dtp_kayit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_kayit.Location = new System.Drawing.Point(94, 29);
            this.dtp_kayit.Name = "dtp_kayit";
            this.dtp_kayit.Size = new System.Drawing.Size(222, 24);
            this.dtp_kayit.TabIndex = 159;
            // 
            // dtp_belge
            // 
            this.dtp_belge.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_belge.Location = new System.Drawing.Point(94, 3);
            this.dtp_belge.Name = "dtp_belge";
            this.dtp_belge.Size = new System.Drawing.Size(222, 24);
            this.dtp_belge.TabIndex = 158;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.Text = "Kayıt Tarihi    :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.Text = "Belge Tarihi   :";
            // 
            // lst_Siparis
            // 
            this.lst_Siparis.Location = new System.Drawing.Point(92, 144);
            this.lst_Siparis.Name = "lst_Siparis";
            this.lst_Siparis.Size = new System.Drawing.Size(224, 82);
            this.lst_Siparis.TabIndex = 166;
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.ForeColor = System.Drawing.Color.Black;
            this.lbl3.Location = new System.Drawing.Point(4, 112);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(132, 20);
            this.lbl3.Text = "İrsaliye no     :";
            // 
            // txt_irsNo
            // 
            this.txt_irsNo.Location = new System.Drawing.Point(94, 109);
            this.txt_irsNo.MaxLength = 40;
            this.txt_irsNo.Name = "txt_irsNo";
            this.txt_irsNo.Size = new System.Drawing.Size(130, 23);
            this.txt_irsNo.TabIndex = 171;
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.Tomato;
            this.btn_Geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.BackgroundImage")));
            this.btn_Geri.ForeColor = System.Drawing.Color.White;
            this.btn_Geri.Location = new System.Drawing.Point(217, 235);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.PressedImage")));
            this.btn_Geri.Size = new System.Drawing.Size(99, 48);
            this.btn_Geri.TabIndex = 168;
            this.btn_Geri.Text = "   Geri";
            this.btn_Geri.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_siparis
            // 
            this.btn_siparis.BackColor = System.Drawing.Color.Tomato;
            this.btn_siparis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_siparis.BackgroundImage")));
            this.btn_siparis.ForeColor = System.Drawing.Color.White;
            this.btn_siparis.Location = new System.Drawing.Point(4, 235);
            this.btn_siparis.Name = "btn_siparis";
            this.btn_siparis.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_siparis.PressedImage")));
            this.btn_siparis.Size = new System.Drawing.Size(178, 48);
            this.btn_siparis.TabIndex = 167;
            this.btn_siparis.Text = "   Malzeme Giriş";
            this.btn_siparis.Click += new System.EventHandler(this.btn_Sipariþ_Click);
            // 
            // btn_SevkiyatNo_Kontrol
            // 
            this.btn_SevkiyatNo_Kontrol.BackColor = System.Drawing.Color.Tomato;
            this.btn_SevkiyatNo_Kontrol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SevkiyatNo_Kontrol.BackgroundImage")));
            this.btn_SevkiyatNo_Kontrol.ForeColor = System.Drawing.Color.White;
            this.btn_SevkiyatNo_Kontrol.Location = new System.Drawing.Point(225, 77);
            this.btn_SevkiyatNo_Kontrol.Name = "btn_SevkiyatNo_Kontrol";
            this.btn_SevkiyatNo_Kontrol.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_SevkiyatNo_Kontrol.PressedImage")));
            this.btn_SevkiyatNo_Kontrol.Size = new System.Drawing.Size(91, 24);
            this.btn_SevkiyatNo_Kontrol.TabIndex = 162;
            this.btn_SevkiyatNo_Kontrol.Text = "     Kontrol Et";
            this.btn_SevkiyatNo_Kontrol.Click += new System.EventHandler(this.btn_SevkiyatNo_Kontrol_Click);
            // 
            // frm_malgirisDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 295);
            this.ControlBox = false;
            this.Controls.Add(this.txt_irsNo);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_siparis);
            this.Controls.Add(this.lst_Siparis);
            this.Controls.Add(this.btn_SevkiyatNo_Kontrol);
            this.Controls.Add(this.txtSevkiyatNo);
            this.Controls.Add(this.lbSevkiyatNo);
            this.Controls.Add(this.chk_horoz);
            this.Controls.Add(this.dtp_kayit);
            this.Controls.Add(this.dtp_belge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_malgirisDepo";
            this.Text = "Mal Girişi - Depo";
            this.Load += new System.EventHandler(this.frm_malgirisDepo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureButton btn_SevkiyatNo_Kontrol;
        private System.Windows.Forms.TextBox txtSevkiyatNo;
        private System.Windows.Forms.Label lbSevkiyatNo;
        private System.Windows.Forms.CheckBox chk_horoz;
        private System.Windows.Forms.DateTimePicker dtp_kayit;
        private System.Windows.Forms.DateTimePicker dtp_belge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PictureButton btn_Geri;
        private PictureButton btn_siparis;
        private System.Windows.Forms.ListBox lst_Siparis;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt_irsNo;
    }
}