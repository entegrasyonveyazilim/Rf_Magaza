namespace KoctasMobil
{
    partial class frm_FixMalGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FixMalGiris));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.registerDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTransportUnit = new System.Windows.Forms.TextBox();
            this.btn_fix_close = new KoctasMobil.PictureButton();
            this.fixProductSearchButton = new KoctasMobil.PictureButton();
            this.SuspendLayout();
            // 
            // registerDate
            // 
            this.registerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.registerDate.Location = new System.Drawing.Point(101, 9);
            this.registerDate.Name = "registerDate";
            this.registerDate.Size = new System.Drawing.Size(200, 24);
            this.registerDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.Text = "Kayıt Tarihi";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.Text = "Taşıma Birimi";
            // 
            // txtTransportUnit
            // 
            this.txtTransportUnit.Location = new System.Drawing.Point(102, 40);
            this.txtTransportUnit.MaxLength = 10;
            this.txtTransportUnit.Multiline = true;
            this.txtTransportUnit.Name = "txtTransportUnit";
            this.txtTransportUnit.Size = new System.Drawing.Size(199, 23);
            this.txtTransportUnit.TabIndex = 4;
            this.txtTransportUnit.TextChanged += new System.EventHandler(this.txtTransportUnit_TextChanged);
            // 
            // btn_fix_close
            // 
            this.btn_fix_close.BackColor = System.Drawing.Color.Tomato;
            this.btn_fix_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_fix_close.BackgroundImage")));
            this.btn_fix_close.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btn_fix_close.ForeColor = System.Drawing.Color.White;
            this.btn_fix_close.Location = new System.Drawing.Point(142, 229);
            this.btn_fix_close.Name = "btn_fix_close";
            this.btn_fix_close.PressedImage = ((System.Drawing.Image)(resources.GetObject("btn_fix_close.PressedImage")));
            this.btn_fix_close.Size = new System.Drawing.Size(159, 48);
            this.btn_fix_close.TabIndex = 12;
            this.btn_fix_close.Text = "Geri";
            this.btn_fix_close.Click += new System.EventHandler(this.btn_fix_close_Click);
            // 
            // fixProductSearchButton
            // 
            this.fixProductSearchButton.BackColor = System.Drawing.Color.Tomato;
            this.fixProductSearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fixProductSearchButton.BackgroundImage")));
            this.fixProductSearchButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.fixProductSearchButton.ForeColor = System.Drawing.Color.White;
            this.fixProductSearchButton.Location = new System.Drawing.Point(67, 86);
            this.fixProductSearchButton.Name = "fixProductSearchButton";
            this.fixProductSearchButton.PressedImage = ((System.Drawing.Image)(resources.GetObject("fixProductSearchButton.PressedImage")));
            this.fixProductSearchButton.Size = new System.Drawing.Size(159, 48);
            this.fixProductSearchButton.TabIndex = 13;
            this.fixProductSearchButton.Text = "ARA";
            this.fixProductSearchButton.Click += new System.EventHandler(this.fixProductSearchButton_Click);
            // 
            // frm_FixMalGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 295);
            this.ControlBox = false;
            this.Controls.Add(this.fixProductSearchButton);
            this.Controls.Add(this.btn_fix_close);
            this.Controls.Add(this.txtTransportUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerDate);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "frm_FixMalGiris";
            this.Text = "frm_FixMalGiris";
            this.Load += new System.EventHandler(this.frm_FixMalGiris_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker registerDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTransportUnit;
        private PictureButton btn_fix_close;
        private PictureButton fixProductSearchButton;
    }
}