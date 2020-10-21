namespace KoctasMobil
{
    partial class frm_PaketlemeMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PaketlemeMenu));
            this.btn_Degistir = new KoctasMobil.PictureButton();
            this.btn_Yukleme = new KoctasMobil.PictureButton();
            this.btn_Toplama = new KoctasMobil.PictureButton();
            this.btn_cikis = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // btn_Degistir
            // 
            this.btn_Degistir.BackColor = System.Drawing.Color.Tomato;
            this.btn_Degistir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Degistir.BackgroundImage")));
            this.btn_Degistir.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Degistir.ForeColor = System.Drawing.Color.White;
            this.btn_Degistir.Location = new System.Drawing.Point(21, 60);
            this.btn_Degistir.Name = "btn_Degistir";
            this.btn_Degistir.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Degistir.PressedImage")));
            this.btn_Degistir.Size = new System.Drawing.Size(280, 48);
            this.btn_Degistir.TabIndex = 20;
            this.btn_Degistir.Text = "Koli İçeriğini Değiştir";
            this.btn_Degistir.Click += new System.EventHandler(this.btn_Degistir_Click);
            // 
            // btn_Yukleme
            // 
            this.btn_Yukleme.BackColor = System.Drawing.Color.Tomato;
            this.btn_Yukleme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Yukleme.BackgroundImage")));
            this.btn_Yukleme.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Yukleme.ForeColor = System.Drawing.Color.White;
            this.btn_Yukleme.Location = new System.Drawing.Point(21, 114);
            this.btn_Yukleme.Name = "btn_Yukleme";
            this.btn_Yukleme.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Yukleme.PressedImage")));
            this.btn_Yukleme.Size = new System.Drawing.Size(280, 48);
            this.btn_Yukleme.TabIndex = 19;
            this.btn_Yukleme.Text = "Yükleme";
            this.btn_Yukleme.Click += new System.EventHandler(this.btn_Yukleme_Click);
            // 
            // btn_Toplama
            // 
            this.btn_Toplama.BackColor = System.Drawing.Color.Tomato;
            this.btn_Toplama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Toplama.BackgroundImage")));
            this.btn_Toplama.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Toplama.ForeColor = System.Drawing.Color.White;
            this.btn_Toplama.Location = new System.Drawing.Point(21, 6);
            this.btn_Toplama.Name = "btn_Toplama";
            this.btn_Toplama.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Toplama.PressedImage")));
            this.btn_Toplama.Size = new System.Drawing.Size(280, 48);
            this.btn_Toplama.TabIndex = 18;
            this.btn_Toplama.Text = "Ürün Toplama";
            this.btn_Toplama.Click += new System.EventHandler(this.btn_Toplama_Click_1);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Tomato;
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btn_cikis.ForeColor = System.Drawing.Color.White;
            this.btn_cikis.Location = new System.Drawing.Point(43, 206);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.PressedImage")));
            this.btn_cikis.Size = new System.Drawing.Size(230, 39);
            this.btn_cikis.TabIndex = 12;
            this.btn_cikis.Text = "Geri";
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click_1);
            // 
            // frm_PaketlemeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 295);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Degistir);
            this.Controls.Add(this.btn_Yukleme);
            this.Controls.Add(this.btn_Toplama);
            this.Controls.Add(this.btn_cikis);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PaketlemeMenu";
            this.Text = "Toplama & Paketleme";
            this.Load += new System.EventHandler(this.frm_PaketlemeMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureButton btn_cikis;
        private PictureButton btn_Toplama;
        private PictureButton btn_Yukleme;
        private PictureButton btn_Degistir;
    }
}