namespace KoctasMobil
{
    partial class frm_PaketlemeToplamaDegistirKoliNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PaketlemeToplamaDegistirKoliNo));
            this.label2 = new System.Windows.Forms.Label();
            this.txtKoliNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Vazgec = new KoctasMobil.PictureButton();
            this.btn_Getir = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 62);
            this.label2.Text = "Toplanan Ürünleri Değiştir";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtKoliNo
            // 
            this.txtKoliNo.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular);
            this.txtKoliNo.ForeColor = System.Drawing.Color.Black;
            this.txtKoliNo.Location = new System.Drawing.Point(121, 99);
            this.txtKoliNo.MaxLength = 10;
            this.txtKoliNo.Name = "txtKoliNo";
            this.txtKoliNo.Size = new System.Drawing.Size(177, 31);
            this.txtKoliNo.TabIndex = 9;
            this.txtKoliNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKoliNo_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.Text = "Koli No :";
            // 
            // btn_Vazgec
            // 
            this.btn_Vazgec.BackColor = System.Drawing.Color.Tomato;
            this.btn_Vazgec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Vazgec.BackgroundImage")));
            this.btn_Vazgec.ForeColor = System.Drawing.Color.White;
            this.btn_Vazgec.Location = new System.Drawing.Point(24, 157);
            this.btn_Vazgec.Name = "btn_Vazgec";
            this.btn_Vazgec.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Vazgec.PressedImage")));
            this.btn_Vazgec.Size = new System.Drawing.Size(135, 54);
            this.btn_Vazgec.TabIndex = 11;
            this.btn_Vazgec.Text = "     Vazgeç";
            this.btn_Vazgec.Click += new System.EventHandler(this.btn_Vazgec_Click);
            // 
            // btn_Getir
            // 
            this.btn_Getir.BackColor = System.Drawing.Color.Tomato;
            this.btn_Getir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Getir.BackgroundImage")));
            this.btn_Getir.ForeColor = System.Drawing.Color.White;
            this.btn_Getir.Location = new System.Drawing.Point(165, 157);
            this.btn_Getir.Name = "btn_Getir";
            this.btn_Getir.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Getir.PressedImage")));
            this.btn_Getir.Size = new System.Drawing.Size(135, 54);
            this.btn_Getir.TabIndex = 10;
            this.btn_Getir.Text = "      Getir";
            this.btn_Getir.Click += new System.EventHandler(this.btn_Getir_Click);
            // 
            // frm_PaketlemeToplamaDegistirKoliNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 295);
            this.Controls.Add(this.btn_Vazgec);
            this.Controls.Add(this.btn_Getir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKoliNo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PaketlemeToplamaDegistirKoliNo";
            this.Text = "Toplama Değiştir";
            this.Load += new System.EventHandler(this.frm_PaketlemeToplamaDegistirKoliNo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureButton btn_Vazgec;
        private PictureButton btn_Getir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKoliNo;
        private System.Windows.Forms.Label label1;
    }
}