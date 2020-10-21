namespace KoctasMobil
{
    partial class frm_InputBox
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
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.picBtn_OK = new KoctasMobil.PictureButton();
            this.picBtn_Iptal = new KoctasMobil.PictureButton();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.lbl_Msg.Location = new System.Drawing.Point(5, 6);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(281, 40);
            this.lbl_Msg.Text = "..";
            this.lbl_Msg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picBtn_OK
            // 
            this.picBtn_OK.BackColor = System.Drawing.Color.Tomato;
            this.picBtn_OK.BackgroundImage = null;
            this.picBtn_OK.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.picBtn_OK.ForeColor = System.Drawing.Color.White;
            this.picBtn_OK.Location = new System.Drawing.Point(12, 79);
            this.picBtn_OK.Name = "picBtn_OK";
            this.picBtn_OK.Size = new System.Drawing.Size(112, 29);
            this.picBtn_OK.TabIndex = 1;
            this.picBtn_OK.Text = "Tamam";
            this.picBtn_OK.Click += new System.EventHandler(this.picBtn_OK_Click);
            // 
            // picBtn_Iptal
            // 
            this.picBtn_Iptal.BackColor = System.Drawing.Color.Tomato;
            this.picBtn_Iptal.BackgroundImage = null;
            this.picBtn_Iptal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.picBtn_Iptal.ForeColor = System.Drawing.Color.White;
            this.picBtn_Iptal.Location = new System.Drawing.Point(163, 79);
            this.picBtn_Iptal.Name = "picBtn_Iptal";
            this.picBtn_Iptal.Size = new System.Drawing.Size(112, 29);
            this.picBtn_Iptal.TabIndex = 2;
            this.picBtn_Iptal.Text = "İptal";
            this.picBtn_Iptal.Click += new System.EventHandler(this.picBtn_Iptal_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 49);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(263, 23);
            this.txtInput.TabIndex = 3;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // frm_InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(291, 120);
            this.ControlBox = false;
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.picBtn_Iptal);
            this.Controls.Add(this.picBtn_OK);
            this.Controls.Add(this.lbl_Msg);
            this.Name = "frm_InputBox";
            this.Text = "...";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.formInputBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Msg;
        private PictureButton picBtn_OK;
        private PictureButton picBtn_Iptal;
        private System.Windows.Forms.TextBox txtInput;
    }
}