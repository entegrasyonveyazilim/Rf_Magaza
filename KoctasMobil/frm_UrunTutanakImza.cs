using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace KoctasMobil
{
    public partial class frm_UrunTutanakImza : Form
    {
        public frm_UrunTutanakImza() 
        {
            InitializeComponent();
        }

        SignatureControl _signature1 = new SignatureControl();
        SignatureControl _signature2 = new SignatureControl();
        SignatureControl _signature3 = new SignatureControl();

        public Bitmap bmp1, bmp2, bmp3;
        public string UnvanTE, IsimTE, IsimMY, PlakaTE;
        
        private void frm_UrunTutanakImza_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            try
            {
                //areaSignature.Size = new Size(310, 190);
                _signature1.Location = areaSignature1.Location;
                _signature1.Size = areaSignature1.Size;
                tabPage1.Controls.Add(_signature1);

                _signature2.Location = areaSignature2.Location;
                _signature2.Size = areaSignature2.Size;
                tabPage2.Controls.Add(_signature2);

                _signature3.Location = areaSignature3.Location;
                _signature3.Size = areaSignature3.Size;
                tabPage3.Controls.Add(_signature3);

                if (bmp1 != null)
                {
                    _signature1.Bmp = bmp1;
                }
                if (bmp2 != null)
                {
                    _signature2.Bmp = bmp2;
                }
                if (bmp3 != null)
                {
                    _signature3.Bmp = bmp3;
                }
                txt_IsimMY.Text = IsimMY;
                txt_IsimTE.Text = IsimTE;
                txt_UnvanTE.Text = UnvanTE;
                txt_Plaka.Text = PlakaTE;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btn_Tamam_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                bmp1 = _signature1.Bmp;
                bmp2 = _signature2.Bmp;
                bmp3 = _signature3.Bmp;
                IsimMY = txt_IsimMY.Text.Trim();
                IsimTE = txt_IsimTE.Text.Trim();
                UnvanTE = txt_UnvanTE.Text.Trim();
                PlakaTE = txt_Plaka.Text.Trim();
                //bmp1.Save("\\program files\\koctasmobil\\b.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "İmzalar işlenemedi!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);               
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }            
            this.Close();
        }

        private void btn_Iptal_Click(object sender, EventArgs e)
        {
            
        }
    }
}