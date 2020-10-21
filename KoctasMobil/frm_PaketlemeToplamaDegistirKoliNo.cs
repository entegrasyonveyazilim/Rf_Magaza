using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_PaketlemeToplamaDegistirKoliNo : Form
    {
        public frm_PaketlemeToplamaDegistirKoliNo()
        {
            InitializeComponent();
        }

        private void frm_PaketlemeToplamaDegistirKoliNo_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bntVazgec_Click(object sender, EventArgs e)
        {

        }

        private void btnGetir_Click(object sender, EventArgs e)
        {

        }

        private void btn_Getir_Click(object sender, EventArgs e)
        {
            if (txtKoliNo.Text.Trim() == "")
            {
                return;
            }

            try { decimal.Parse(txtKoliNo.Text.Trim()); }
            catch
            {
                MessageBox.Show("Koli No alanına yalnız sayısal değer girebilirsiniz.", "HATA");
                return;
            }


            try
            {
                Cursor.Current = Cursors.WaitCursor;

                WS_Paket.SERVICE srv = new KoctasMobil.WS_Paket.SERVICE();
                WS_Paket.ZkmobilReturn ret = new KoctasMobil.WS_Paket.ZkmobilReturn();
                WS_Paket.Ztoplama2[] koliList = new KoctasMobil.WS_Paket.Ztoplama2[0];

                WS_Paket.ZktmobilPakCheckKoli chkKoli = new KoctasMobil.WS_Paket.ZktmobilPakCheckKoli();
                WS_Paket.ZktmobilPakCheckKoliResponse chkKoliResp = new KoctasMobil.WS_Paket.ZktmobilPakCheckKoliResponse();

                chkKoli.EReturn = ret;
                chkKoli.ItData = koliList;

                string koliNo = txtKoliNo.Text.Trim().PadLeft(10, '0');
                chkKoli.ImPaketno = koliNo;
                srv.Credentials = ProgramGlobalData.g_credential;
                srv.Url = Utility.getWsUrl("zktmobil_paket");

                chkKoliResp = srv.ZktmobilPakCheckKoli(chkKoli);

                if (chkKoliResp.EReturn.RcCode.ToUpper() == "E")
                {
                    txtKoliNo.Text = "";
                    MessageBox.Show(chkKoliResp.EReturn.RcText, "HATA");
                }
                else
                {
                    frm_PaketlemeToplamaDegistir frm = new frm_PaketlemeToplamaDegistir();
                    frm.gecerliKoliMal = chkKoliResp.ItData;
                    frm.paketNo = koliNo;
                    Cursor.Current = Cursors.Default;
                    frm.ShowDialog();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

            
            
        }

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKoliNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_Getir_Click(new object(), new EventArgs());
            }
        }


    }
}