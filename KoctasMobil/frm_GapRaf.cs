using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{

    public partial class frm_GapRaf : Form
    {
        public char SayimTipi;

        public frm_GapRaf()
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
            if (txtRafAdresi.Text == "")
            {
                return;
            }
            
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Kontrol.service SRV = new WS_Kontrol.service();

                SRV.Url = Utility.getWsUrl("zktmobil_kontrol");
                SRV.Credentials = ProgramGlobalData.g_credential;

                WS_Kontrol.ZktmobilChckAdr Adr = new KoctasMobil.WS_Kontrol.ZktmobilChckAdr();
                Adr.IAddress = txtRafAdresi.Text.ToUpper().Trim();
                Adr.EReturn = new KoctasMobil.WS_Kontrol.ZkmobilReturn();

                WS_Kontrol.ZktmobilChckAdrResponse Response = new KoctasMobil.WS_Kontrol.ZktmobilChckAdrResponse();
                Response = SRV.ZktmobilChckAdr(Adr);

                if (Response.EReturn.RcCode == "E")
                {
                    MessageBox.Show(Response.EReturn.RcText, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    Cursor.Current = Cursors.Default;
                    return;
                }
                frm_GapGiris frm = new frm_GapGiris();
                Cursor.Current = Cursors.Default;
                frm.Nlpla = Adr.IAddress;
                frm.ShowDialog();
                txtRafAdresi.Text = "";
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