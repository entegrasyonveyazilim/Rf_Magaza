namespace KoctasMobil
{
    partial class frm_UrunKontrol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UrunKontrol));
            this.txt_Matnr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Vazgec = new KoctasMobil.PictureButton();
            this.btn_Sayim = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // txt_Matnr
            // 
            this.txt_Matnr.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular);
            this.txt_Matnr.ForeColor = System.Drawing.Color.Black;
            this.txt_Matnr.Location = new System.Drawing.Point(26, 71);
            this.txt_Matnr.MaxLength = 0;
            this.txt_Matnr.Name = "txt_Matnr";
            this.txt_Matnr.Size = new System.Drawing.Size(271, 31);
            this.txt_Matnr.TabIndex = 1;
            this.txt_Matnr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 28);
            this.label2.Text = "Malzeme no :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Vazgec
            // 
            this.btn_Vazgec.BackColor = System.Drawing.Color.Tomato;
            this.btn_Vazgec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Vazgec.BackgroundImage")));
            this.btn_Vazgec.ForeColor = System.Drawing.Color.White;
            this.btn_Vazgec.Location = new System.Drawing.Point(21, 128);
            this.btn_Vazgec.Name = "btn_Vazgec";
            this.btn_Vazgec.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Vazgec.PressedImage")));
            this.btn_Vazgec.Size = new System.Drawing.Size(135, 54);
            this.btn_Vazgec.TabIndex = 2;
            this.btn_Vazgec.Text = "     Vazgeç";
            this.btn_Vazgec.Click += new System.EventHandler(this.bntVazgec_Click);
            // 
            // btn_Sayim
            // 
            this.btn_Sayim.BackColor = System.Drawing.Color.Tomato;
            this.btn_Sayim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sayim.BackgroundImage")));
            this.btn_Sayim.ForeColor = System.Drawing.Color.White;
            this.btn_Sayim.Location = new System.Drawing.Point(162, 128);
            this.btn_Sayim.Name = "btn_Sayim";
            this.btn_Sayim.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Sayim.PressedImage")));
            this.btn_Sayim.Size = new System.Drawing.Size(135, 54);
            this.btn_Sayim.TabIndex = 3;
            this.btn_Sayim.Text = "      Devam";
            this.btn_Sayim.Click += new System.EventHandler(this.btn_Sayim_Click);
            // 
            // frm_UrunKontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.ControlBox = false;
            this.Controls.Add(this.txt_Matnr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Vazgec);
            this.Controls.Add(this.btn_Sayim);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_UrunKontrol";
            this.Text = "Ürün Kontrol";
            this.Load += new System.EventHandler(this.frm_UrunKontrol_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureButton btn_Sayim;
        private PictureButton btn_Vazgec;
        private System.Windows.Forms.TextBox txt_Matnr;
        private System.Windows.Forms.Label label2;
    }
}