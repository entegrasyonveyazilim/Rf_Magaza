using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_SiparisIade : Form
    {
        public frm_SiparisIade()
        {
            InitializeComponent();
        }
        private void btnGetir_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBelgeNo.Text)) //malzeme seçerek iade
                {
                    frm_MatIade frm = new frm_MatIade();
                    frm.ShowDialog();
                }
                else // sipariþin iadesi
                {
                    Cursor.Current = Cursors.WaitCursor;
                    WS_Satis.SERVICE SRV = new KoctasMobil.WS_Satis.SERVICE();
                    WS_Satis.ZktmobilIadeItemsGet itemsget = new KoctasMobil.WS_Satis.ZktmobilIadeItemsGet();
                    WS_Satis.ZktmobilIadeItemsGetResponse response = new KoctasMobil.WS_Satis.ZktmobilIadeItemsGetResponse();
                    itemsget.TeList = new KoctasMobil.WS_Satis.ZktmobilSIadeItems[0];
                    itemsget.IVbeln = txtBelgeNo.Text.Trim();
                    SRV.Url = Utility.getWsUrl("zktmobil_satis");
                    SRV.Credentials = ProgramGlobalData.g_credential;
                    response = SRV.ZktmobilIadeItemsGet(itemsget);
                    Cursor.Current = Cursors.Default;
                    if (response.EReturn.RcCode == "S")
                    {
                        frm_SiparisIade2 frm = new frm_SiparisIade2();
                        frm.Items = response.TeList;
                        if (DialogResult.OK == frm.ShowDialog())
                        {
                            this.Close();
                        }
                    }
                    else if (response.EReturn.RcCode == "E")
                    {
                        MessageBox.Show(response.EReturn.RcText, "HATA");
                    }
                    
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

        private void bntVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBelgeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnGetir_Click(txtBelgeNo, new EventArgs());
            }
        }

        private void frm_SiparisIade_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}