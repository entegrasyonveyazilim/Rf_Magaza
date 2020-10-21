namespace KoctasMobil
{
    partial class FixMalMiktarDegistirmeDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Yeni Miktar";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(4, 34);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(172, 23);
            this.quantity.TabIndex = 1;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Tomato;
            this.save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(4, 64);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(172, 20);
            this.save.TabIndex = 2;
            this.save.Text = "Kaydet";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Tomato;
            this.close.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(4, 90);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(172, 20);
            this.close.TabIndex = 3;
            this.close.Text = "Kapat";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // FixMalMiktarDegistirmeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(179, 135);
            this.ControlBox = false;
            this.Controls.Add(this.close);
            this.Controls.Add(this.save);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "FixMalMiktarDegistirmeDialog";
            this.Text = "Miktar Değiştirme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button close;
    }
}