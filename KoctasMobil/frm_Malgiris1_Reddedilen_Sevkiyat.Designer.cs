namespace KoctasMobil
{
    partial class frm_Malgiris1_Reddedilen_Sevkiyat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.irsaliye = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.satici = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.siparis = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.redSiparisEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // irsaliye
            // 
            this.irsaliye.Location = new System.Drawing.Point(3, 4);
            this.irsaliye.Name = "irsaliye";
            this.irsaliye.Size = new System.Drawing.Size(312, 20);
            this.irsaliye.Text = "İrsaliye";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 23);
            this.textBox1.TabIndex = 1;
            // 
            // satici
            // 
            this.satici.Location = new System.Drawing.Point(4, 58);
            this.satici.Name = "satici";
            this.satici.Size = new System.Drawing.Size(311, 20);
            this.satici.Text = "Satıcı";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(4, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(311, 23);
            this.textBox2.TabIndex = 3;
            // 
            // siparis
            // 
            this.siparis.Location = new System.Drawing.Point(4, 112);
            this.siparis.Name = "siparis";
            this.siparis.Size = new System.Drawing.Size(311, 20);
            this.siparis.Text = "Sipariş";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(4, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(311, 23);
            this.textBox3.TabIndex = 5;
            // 
            // redSiparisEkle
            // 
            this.redSiparisEkle.Location = new System.Drawing.Point(119, 180);
            this.redSiparisEkle.Name = "redSiparisEkle";
            this.redSiparisEkle.Size = new System.Drawing.Size(72, 20);
            this.redSiparisEkle.TabIndex = 6;
            this.redSiparisEkle.Text = "Ekle";
            // 
            // frm_Malgiris1_Reddedilen_Sevkiyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.Controls.Add(this.redSiparisEkle);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.siparis);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.satici);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.irsaliye);
            this.Menu = this.mainMenu1;
            this.Name = "frm_Malgiris1_Reddedilen_Sevkiyat";
            this.Text = "Reddedilen Sipariş";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label irsaliye;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label satici;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label siparis;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button redSiparisEkle;
    }
}