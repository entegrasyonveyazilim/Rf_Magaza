using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_ListKontrol : Form
    {
        public frm_ListKontrol()
        {
            InitializeComponent();
        }

        private void bntVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool MlzmChck = false; 
        private void txt_Matnr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13) return;

            txtLabst.Text = txtList.Text = txtMeins.Text = "";

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Kontrol.service SRV = new WS_Kontrol.service();

                SRV.Url = Utility.getWsUrl("zktmobil_kontrol");
                SRV.Credentials = ProgramGlobalData.g_credential;

                WS_Kontrol.ZktmobilChckMtnr chcMtnr = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnr();
                chcMtnr.IMatnr = txt_Matnr.Text.Trim();
                chcMtnr.EReturn = new KoctasMobil.WS_Kontrol.ZkmobilReturn();

                WS_Kontrol.ZktmobilChckMtnrResponse Response = SRV.ZktmobilChckMtnr(chcMtnr);
                
                if (Response.EReturn.RcCode == "E")
                {
                    MessageBox.Show(Response.EReturn.RcText, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    txt_maktx.Text = "";
                    Cursor.Current = Cursors.Default;
                    return;
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    txt_maktx.Text = Response.EMaktx;
                    MlzmChck = true;
                    txtUretimYeri.Focus();
                }

                //if (txtUretimYeri.Text != "")
                //{
                //    txtUretimYeri_KeyPress(txtUretimYeri, new KeyPressEventArgs((char)13));
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                txt_maktx.Text = "";
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }  
           
        }

        private void frm_ListKontrol_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txt_Matnr.Focus();
        }

        private void txtUretimYeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13) return;

            txtLabst.Text = txtList.Text = txtMeins.Text = "";

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Kontrol.service SRV = new WS_Kontrol.service();

                SRV.Url = Utility.getWsUrl("zktmobil_kontrol");
                SRV.Credentials = ProgramGlobalData.g_credential;

                WS_Kontrol.ZktmobilChckWerks chcWerks = new KoctasMobil.WS_Kontrol.ZktmobilChckWerks();
                chcWerks.IWerks = txtUretimYeri.Text.Trim();
                chcWerks.EReturn = new KoctasMobil.WS_Kontrol.ZkmobilReturn();

                WS_Kontrol.ZktmobilChckWerksResponse Response = SRV.ZktmobilChckWerks(chcWerks);                 

                if (Response.EReturn.RcCode == "E")
                {
                    MessageBox.Show(Response.EReturn.RcText, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    Cursor.Current = Cursors.Default;
                    txtUretimYeriText.Text = ""; 
                    return;
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    txtUretimYeriText.Text = Response.EName;
                     if ( txt_Matnr.Text == "") txt_Matnr.Focus();
                }

                if (txt_Matnr.Text != "")
                {
                    txt_Matnr_KeyPress(txt_Matnr, new KeyPressEventArgs((char)13));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                txtUretimYeriText.Text = "";                
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }  
        }

        private void btn_Kontrol_Click(object sender, EventArgs e)
        {
            if (txt_Matnr.Text.Trim() == "" || txtUretimYeri.Text.Trim() == "" || !MlzmChck)
                return;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Kontrol.service SRV = new WS_Kontrol.service();

                SRV.Url = Utility.getWsUrl("zktmobil_kontrol");
                SRV.Credentials = ProgramGlobalData.g_credential;

                WS_Kontrol.ZktmobilChckList chcList = new KoctasMobil.WS_Kontrol.ZktmobilChckList();
                chcList.IMatnr = txt_Matnr.Text.Trim();
                chcList.IWerks = txtUretimYeri.Text.Trim();

                WS_Kontrol.ZktmobilChckListResponse Response = SRV.ZktmobilChckList(chcList);

                txtList.Text = Response.EList.ToUpper();
                txtMeins.Text = Response.EMeins;
                txtLabst.Text = Convert.ToInt32(Response.ELabst).ToString();
                
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

        private void txt_Matnr_TextChanged(object sender, EventArgs e)
        {
            MlzmChck = false;
        }
      
    }
}