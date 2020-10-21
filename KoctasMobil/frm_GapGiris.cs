using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_GapGiris : Form
    {
        public frm_GapGiris()
        {
            InitializeComponent();            
        }

        DataTable dtGAP = new DataTable();
        bool matChecked;
        public string Nlpla;

        private void frm_UrunKontrol3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
           
            try
            {
                dtGAP.Columns.Add("matnr");
                dtGAP.Columns.Add("maktx");
                dtGAP.Columns.Add("ean11");
                dtGAP.PrimaryKey = new DataColumn[] { dtGAP.Columns["matnr"] };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }            
        }

        private void GeneralKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_getir_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            WS_Kontrol.service srv = new KoctasMobil.WS_Kontrol.service();
            WS_Kontrol.ZktmobilChckMtnr mtnr = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnr();
            WS_Kontrol.ZktmobilChckMtnrResponse matresp = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnrResponse();

            try
            {
                if (sender == txt_matnr) 
                {
                    mtnr.IMatnr = txt_matnr.Text.Trim();
                }
                else if (sender == txt_Barkod)
                {
                    mtnr.IMatnr = txt_Barkod.Text.Trim();
                }
                else
                {
                    if (!String.IsNullOrEmpty(txt_Barkod.Text))
                    {
                        mtnr.IMatnr = txt_Barkod.Text.Trim();
                    }
                    else if (!String.IsNullOrEmpty(txt_matnr.Text))
                    {
                        mtnr.IMatnr = txt_matnr.Text.Trim();
                    }
                    else
                    {
                        return;
                    }
                }
                srv.Url = Utility.getWsUrl("zktmobil_kontrol");
                srv.Credentials = ProgramGlobalData.g_credential;
                
                matresp = srv.ZktmobilChckMtnr(mtnr);

                if (matresp.EReturn.RcCode == "E")
                {
                    throw new Exception(matresp.EReturn.RcText);
                }

                txt_Barkod.Text = matresp.EEan11;
                txt_maktx.Text = matresp.EMaktx;
                txt_matnr.Text = matresp.EMatnr.TrimStart('0');
                matChecked = true;
            }
            catch (Exception ex)
            {
                txt_Barkod.Text = "";
                txt_maktx.Text = "";
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void malzChanged(object sender, EventArgs e)
        {
            matChecked = false;
        }

        private void txt_matnr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (matChecked) btn_Ekle_Click(txt_matnr, EventArgs.Empty);
                else
                    btn_getir_Click(txt_matnr, new EventArgs());
            }
        }

        private void txt_Barkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (matChecked) btn_Ekle_Click(txt_Barkod, EventArgs.Empty);
                else
                btn_getir_Click(txt_Barkod, new EventArgs());
            }
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            WS_Kontrol.service srv = new KoctasMobil.WS_Kontrol.service();
            WS_Kontrol.ZktmobilSaveGap GAP = new KoctasMobil.WS_Kontrol.ZktmobilSaveGap();
            WS_Kontrol.ZktmobilSaveGapResponse Response = new WS_Kontrol.ZktmobilSaveGapResponse();

            try
            {              
                srv.Url = Utility.getWsUrl("zktmobil_kontrol");
                srv.Credentials = ProgramGlobalData.g_credential;

                WS_Kontrol.ZitGap[] items = new WS_Kontrol.ZitGap[dtGAP.Rows.Count];
                for (int i = 0; i < dtGAP.Rows.Count; i++)
                {
                    WS_Kontrol.ZitGap item = new WS_Kontrol.ZitGap();

                    item.Matnr = dtGAP.Rows[i]["matnr"].ToString();
                    item.Nlpla = this.Nlpla;  //RAf Adresi
                    
                    items[i] = item;
                }
                GAP.ItGap = items;
                
                
                Response = srv.ZktmobilSaveGap(GAP);

                //if (matresp.EReturn.RcCode == "E")
                //{
                //    throw new Exception(matresp.EReturn.RcText);
                //}

                this.Close();               
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (!matChecked) btn_getir_Click(btn_Ekle, EventArgs.Empty);
            if (!matChecked) return;

            if (txt_matnr.Text == "") return;
            DataRow fRow = dtGAP.Rows.Find(txt_matnr.Text.Trim());
            if (fRow == null)
                dtGAP.Rows.Add(txt_matnr.Text.Trim(),
                                     txt_maktx.Text.Trim(),
                                     txt_Barkod.Text.Trim());

            grd_GAP.DataSource = dtGAP;
            txt_Barkod.Text = txt_maktx.Text = txt_matnr.Text = "";
            txt_Barkod.Focus();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            for (int i = dtGAP.Rows.Count - 1; i >= 0; i--)
                if (grd_GAP.IsSelected(i))
                    dtGAP.Rows.RemoveAt(i);
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            for (int i = dtGAP.Rows.Count - 1; i >= 0; i--)
                    dtGAP.Rows.RemoveAt(i);
        }
        
        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
    }
}

