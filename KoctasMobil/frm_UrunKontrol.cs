using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{

    public partial class frm_UrunKontrol : Form
    {
        public char SayimTipi;
        public string malzemeNo;

        public frm_UrunKontrol()
        {
            InitializeComponent();

        }

        private void bntVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_Sayim_Click(new object(), new EventArgs());
            }
        }

        private void btn_Sayim_Click(object sender, EventArgs e)
        {
            WS_Kontrol.ZktmobilCheckProductResponse resp = null;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Kontrol.service srv = new KoctasMobil.WS_Kontrol.service();
                srv.Url = Utility.getWsUrl("zktmobil_kontrol");
                srv.Credentials = ProgramGlobalData.g_credential;
                WS_Kontrol.ZktmobilCheckProduct product = new KoctasMobil.WS_Kontrol.ZktmobilCheckProduct();
                resp = new KoctasMobil.WS_Kontrol.ZktmobilCheckProductResponse();
                resp.EReturn = new KoctasMobil.WS_Kontrol.ZkmobilReturn();
                product.IMatnr = txt_Matnr.Text.Trim();
                product.ItDepostk = new KoctasMobil.WS_Kontrol.ZktmobilDepostk[0];
                resp = srv.ZktmobilCheckProduct(product);
                if (String.IsNullOrEmpty(resp.EMatnr)) return;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                return;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            frm_UrunKontrol2 frm = new frm_UrunKontrol2();
            frm.resp = resp;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.malzemeNo = txt_Matnr.Text;

                txt_Matnr.Text = "";
                txt_Matnr.Focus();

                this.Close();
            }
            else
            {
                txt_Matnr.Text = "";
                txt_Matnr.Focus();
            }
        }

        private void frm_UrunKontrol_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (malzemeNo != "")
            {
                txt_Matnr.Text = malzemeNo;
            }
        }


        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.malzemeNo = txt_Matnr.Text;
            
            this.Close();

        }
    }
}