using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{

    public partial class frm_SayimRaf : Form
    {
        public string SayimTipi = "";

        public frm_SayimRaf()
        {
            InitializeComponent();

        }

        private void bntVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRafAdresi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_Sayim_Click(txtRafAdresi, new EventArgs());
            }
        }

        private void btn_Sayim_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Sayim.service SRV = new WS_Sayim.service();

                SRV.Url = Utility.getWsUrl("zktmobil_sayim");
                SRV.Credentials = ProgramGlobalData.g_credential;

                WS_Sayim.ZktmobilCheckAdr Adr = new KoctasMobil.WS_Sayim.ZktmobilCheckAdr();
                Adr.IType = SayimTipi.ToString();
                Adr.IAddress = txtRafAdresi.Text.ToUpper().Trim();
                Adr.TeReturn = new KoctasMobil.WS_Sayim.ZkmobilReturn[1];

               WS_Sayim.ZktmobilCheckAdrResponse Response = new KoctasMobil.WS_Sayim.ZktmobilCheckAdrResponse();
               Response = SRV.ZktmobilCheckAdr(Adr);

                if (Response.TeReturn.Length > 0)
                {
                    if (Response.TeReturn[0].RcCode == "E")
                    {
                        MessageBox.Show(Response.TeReturn[0].RcText, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        Cursor.Current = Cursors.Default;
                        return;
                    }
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    frm_SayimRaf2 raf2 = new frm_SayimRaf2();
                    raf2.RafNo = Adr.IAddress;
                    raf2.SayimNo = Response.EDocument;
                    raf2.ShowDialog();
                }
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

        private void frm_SayimRaf_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}