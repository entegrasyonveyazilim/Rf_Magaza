namespace KoctasMobil
{
    partial class AK_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AK_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.lbl_Canli = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblVer = new System.Windows.Forms.Label();
            this.cmbSunucu = new System.Windows.Forms.ComboBox();
            this.btn_Giris = new KoctasMobil.PictureButton();
            this.btnCikis = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txt_UserName.ForeColor = System.Drawing.Color.Black;
            this.txt_UserName.Location = new System.Drawing.Point(79, 27);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(236, 26);
            this.txt_UserName.TabIndex = 18;
            this.txt_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_UserName_KeyDown);
            // 
            // Txt_Password
            // 
            this.Txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Txt_Password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Password.ForeColor = System.Drawing.Color.Black;
            this.Txt_Password.Location = new System.Drawing.Point(79, 75);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(236, 26);
            this.Txt_Password.TabIndex = 20;
            this.Txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Password_KeyDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(79, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(2, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 10);
            this.label3.Text = "Offline";
            this.label3.Visible = false;
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAyarlar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnAyarlar.ForeColor = System.Drawing.Color.Black;
            this.btnAyarlar.Location = new System.Drawing.Point(2, 282);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(11, 10);
            this.btnAyarlar.TabIndex = 29;
            this.btnAyarlar.Visible = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // lbl_Canli
            // 
            this.lbl_Canli.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_Canli.ForeColor = System.Drawing.Color.Red;
            this.lbl_Canli.Location = new System.Drawing.Point(125, 207);
            this.lbl_Canli.Name = "lbl_Canli";
            this.lbl_Canli.Size = new System.Drawing.Size(189, 21);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 83);
            // 
            // lblVer
            // 
            this.lblVer.ForeColor = System.Drawing.Color.Black;
            this.lblVer.Location = new System.Drawing.Point(3, 239);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(312, 20);
            this.lblVer.Text = "Versiyon :";
            this.lblVer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblVer.ParentChanged += new System.EventHandler(this.lblVer_ParentChanged);
            // 
            // cmbSunucu
            // 
            this.cmbSunucu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(239)))), ((int)(((byte)(250)))));
            this.cmbSunucu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.cmbSunucu.Items.Add("DEV Test");
            this.cmbSunucu.Items.Add("DEV Test - 2");
            this.cmbSunucu.Items.Add("QA Test");
            this.cmbSunucu.Items.Add("PROD");
            this.cmbSunucu.Location = new System.Drawing.Point(4, 207);
            this.cmbSunucu.Name = "cmbSunucu";
            this.cmbSunucu.Size = new System.Drawing.Size(115, 21);
            this.cmbSunucu.TabIndex = 50;
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.Color.Tomato;
            this.btn_Giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Giris.BackgroundImage")));
            this.btn_Giris.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.btn_Giris.ForeColor = System.Drawing.Color.White;
            this.btn_Giris.Location = new System.Drawing.Point(3, 107);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_Giris.PressedImage")));
            this.btn_Giris.Size = new System.Drawing.Size(312, 48);
            this.btn_Giris.TabIndex = 43;
            this.btn_Giris.Text = "GİRİŞ";
            this.btn_Giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Tomato;
            this.btnCikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.BackgroundImage")));
            this.btnCikis.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(2, 157);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.PressedImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.PressedImage")));
            this.btnCikis.Size = new System.Drawing.Size(312, 48);
            this.btnCikis.TabIndex = 42;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // AK_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.ControlBox = false;
            this.Controls.Add(this.cmbSunucu);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_Canli);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AK_Login";
            this.Text = "Koçtaş Mobil";
            this.Load += new System.EventHandler(this.AK_Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Label lbl_Canli;
        private System.Windows.Forms.PictureBox pictureBox2;
        private PictureButton btnCikis;
        private PictureButton btn_Giris;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.ComboBox cmbSunucu;
    }
}