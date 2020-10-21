namespace KoctasMobil
{
    partial class frm_PaketlemeYukleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PaketlemeYukleme));
            this.lst_Koli = new System.Windows.Forms.ListBox();
            this.txt_formNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_YuklemeCikart = new KoctasMobil.PictureButton();
            this.btn_Geri = new KoctasMobil.PictureButton();
            this.btn_yukleme = new KoctasMobil.PictureButton();
            this.btn_YuklemeEkle = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // lst_Koli
            // 
            this.lst_Koli.Location = new System.Drawing.Point(92, 40);
            this.lst_Koli.Name = "lst_Koli";
            this.lst_Koli.Size = new System.Drawing.Size(224, 130);
            this.lst_Koli.TabIndex = 144;
            // 
            // txt_formNo
            // 
            this.txt_formNo.Location = new System.Drawing.Point(92, 11);
            this.txt_formNo.MaxLength = 40;
            this.txt_formNo.Name = "txt_formNo";
            this.txt_formNo.Size = new System.Drawing.Size(130, 23);
            this.txt_formNo.TabIndex = 143;
            this.txt_formNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_formNo_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.Text = "Koli No      :";
            // 
            // btn_YuklemeCikart
            // 
            this.btn_YuklemeCikart.BackColor = System.Drawing.Color.Tomato;
            this.btn_YuklemeCikart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_YuklemeCikart.BackgroundImage")));
            this.btn_YuklemeCikart.ForeColor = System.Drawing.Color.White;
            this.btn_YuklemeCikart.Location = new System.Drawing.Point(92, 176);
            this.btn_YuklemeCikart.Name = "btn_YuklemeCikart";
            this.btn_YuklemeCikart.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_YuklemeCikart.PressedImage")));
            this.btn_YuklemeCikart.Size = new System.Drawing.Size(224, 24);
            this.btn_YuklemeCikart.TabIndex = 149;
            this.btn_YuklemeCikart.Text = "  Seçili Koliyi Çıkart";
            this.btn_YuklemeCikart.Click += new System.EventHandler(this.btn_YuklemeCikart_Click);
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.Tomato;
            this.btn_Geri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.BackgroundImage")));
            this.btn_Geri.ForeColor = System.Drawing.Color.White;
            this.btn_Geri.Location = new System.Drawing.Point(217, 209);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Geri.PressedImage")));
            this.btn_Geri.Size = new System.Drawing.Size(99, 48);
            this.btn_Geri.TabIndex = 147;
            this.btn_Geri.Text = "   Geri";
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // btn_yukleme
            // 
            this.btn_yukleme.BackColor = System.Drawing.Color.Tomato;
            this.btn_yukleme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_yukleme.BackgroundImage")));
            this.btn_yukleme.ForeColor = System.Drawing.Color.White;
            this.btn_yukleme.Location = new System.Drawing.Point(4, 209);
            this.btn_yukleme.Name = "btn_yukleme";
            this.btn_yukleme.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_yukleme.PressedImage")));
            this.btn_yukleme.Size = new System.Drawing.Size(178, 48);
            this.btn_yukleme.TabIndex = 146;
            this.btn_yukleme.Text = "   Yüklemeyi Tamamla";
            this.btn_yukleme.Click += new System.EventHandler(this.btn_yukleme_Click);
            // 
            // btn_YuklemeEkle
            // 
            this.btn_YuklemeEkle.BackColor = System.Drawing.Color.Tomato;
            this.btn_YuklemeEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_YuklemeEkle.BackgroundImage")));
            this.btn_YuklemeEkle.ForeColor = System.Drawing.Color.White;
            this.btn_YuklemeEkle.Location = new System.Drawing.Point(225, 10);
            this.btn_YuklemeEkle.Name = "btn_YuklemeEkle";
            this.btn_YuklemeEkle.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_YuklemeEkle.PressedImage")));
            this.btn_YuklemeEkle.Size = new System.Drawing.Size(91, 24);
            this.btn_YuklemeEkle.TabIndex = 145;
            this.btn_YuklemeEkle.Text = "  Ekle";
            this.btn_YuklemeEkle.Click += new System.EventHandler(this.btn_YuklemeEkle_Click);
            // 
            // frm_PaketlemeYukleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 295);
            this.ControlBox = false;
            this.Controls.Add(this.btn_YuklemeCikart);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_yukleme);
            this.Controls.Add(this.btn_YuklemeEkle);
            this.Controls.Add(this.lst_Koli);
            this.Controls.Add(this.txt_formNo);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PaketlemeYukleme";
            this.Text = "Yükleme";
            this.Load += new System.EventHandler(this.frm_PaketlemeYukleme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureButton btn_Geri;
        private PictureButton btn_yukleme;
        private PictureButton btn_YuklemeEkle;
        private System.Windows.Forms.ListBox lst_Koli;
        private System.Windows.Forms.TextBox txt_formNo;
        private System.Windows.Forms.Label label3;
        private PictureButton btn_YuklemeCikart;
    }
}