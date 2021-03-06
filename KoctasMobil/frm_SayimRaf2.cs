using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{

    public partial class frm_SayimRaf2 : Form
    {        
        public frm_SayimRaf2()
        {
            InitializeComponent();           
        }

        bool malzemeChecked = false;
        public string SayimNo;
        public string RafNo;
        private DataTable dtgrd_Sayim;

        private void frm_SayimRaf2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            txtRafNo.Text = RafNo;
            txtSayimNo.Text = SayimNo.TrimStart('0');

            dtgrd_Sayim = new DataTable();
            dtgrd_Sayim.Columns.Add("MATNR");
            dtgrd_Sayim.Columns.Add("MAKTX");
            dtgrd_Sayim.Columns.Add("MENGE");
            dtgrd_Sayim.Columns.Add("EAN11");
            dtgrd_Sayim.Columns.Add("MEINS");
            dtgrd_Sayim.PrimaryKey = new DataColumn[] { dtgrd_Sayim.Columns["MATNR"] };
        }
        
        private void txt_Barkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)  
            {
                checkMalzeme();
            }
        }
        
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Sayim.service SRV = new WS_Sayim.service();

                SRV.Url = Utility.getWsUrl("zktmobil_sayim");
                SRV.Credentials = ProgramGlobalData.g_credential;

                WS_Sayim.ZktmobilSayimSave SaVe = new WS_Sayim.ZktmobilSayimSave();

                WS_Sayim.ZkmobilItems[] items = new WS_Sayim.ZkmobilItems[dtgrd_Sayim.Rows.Count];
                for (int i = 0; i < dtgrd_Sayim.Rows.Count ; i++)
                {
                    WS_Sayim.ZkmobilItems item = new WS_Sayim.ZkmobilItems();

                    item.Ean11 = dtgrd_Sayim.Rows[i]["EAN11"].ToString();
                    item.Iblnr = txtSayimNo.Text.Trim();
                    item.Matnr = dtgrd_Sayim.Rows[i]["MATNR"].ToString();
                    item.Meins = dtgrd_Sayim.Rows[i]["MEINS"].ToString();
                    item.Miktar = Convert.ToDecimal(dtgrd_Sayim.Rows[i]["MENGE"]);
                    item.Personel = ProgramGlobalData.username;
                    item.Raf = txtRafNo.Text.Trim();
                    item.Saat = DateTime.Now.ToString("HH:mm:ss");
                    item.Tarih = DateTime.Now.ToString("yyyy-MM-dd");

                    items[i] = item;
                }
                SaVe.ItItems = items;
                SaVe.TeReturn = new KoctasMobil.WS_Sayim.ZkmobilReturn[1];

                WS_Sayim.ZktmobilSayimSaveResponse //Response = new WS_Sayim.ZktmobilSayimSaveResponse();
                Response = SRV.ZktmobilSayimSave(SaVe);

                if (Response.TeReturn.Length > 0)
                {
                    if (Response.TeReturn[0].RcCode == "S")
                    {
                        MessageBox.Show(Response.TeReturn[0].RcText, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        Cursor.Current = Cursors.Default;
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("İşlem Tamamlanamadı.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        Cursor.Current = Cursors.Default;
                        return;
                    }
                }
                else
                {
                    Cursor.Current = Cursors.Default;                    
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

        private void txt_matnr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                checkMalzeme();
            }
        }
              
        private void txt_miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;

            if (e.KeyChar == (char)13)
            {
                ListeyeEkle();
            }
        }

        private void GeneralKeyPressHandle(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }          

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            for (int i = dtgrd_Sayim.Rows.Count - 1; i >= 0; i--)
                if (grd_Sayim.IsSelected(i))
                    dtgrd_Sayim.Rows.RemoveAt(i);
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btn_Ekle_Click_1(object sender, EventArgs e)
        {
            ListeyeEkle();
        }

        private void ListeyeEkle()
        {
            if (string.IsNullOrEmpty(txt_miktar.Text))
            {
                txt_miktar.Text = "0";
            }
            if (!malzemeChecked) checkMalzeme();
            if (!malzemeChecked) return;
            DataRow fRow = dtgrd_Sayim.Rows.Find(txt_matnr.Text.Trim());
            if (fRow != null)
                fRow["MENGE"] = int.Parse(fRow["MENGE"].ToString()) +
                                int.Parse(txt_miktar.Text.Trim());
            else
            {               
                dtgrd_Sayim.Rows.Add(
                    txt_matnr.Text.Trim(),
                    txt_maktx.Text.Trim(),
                    txt_miktar.Text.Trim(),
                    txt_Barkod.Text.Trim(),
                    txt_birim.Text.Trim());
            }

            grd_Sayim.DataSource = dtgrd_Sayim;
            txt_Barkod.Text = txt_maktx.Text = txt_matnr.Text = txt_miktar.Text = txt_birim.Text = "";
            txt_Barkod.Focus();
        }

        private void btn_SifirSay_Click(object sender, EventArgs e)
        {           
            if (!malzemeChecked) checkMalzeme();
            if (!malzemeChecked) return;
            txt_miktar.Text = "0";
            DataRow fRow = dtgrd_Sayim.Rows.Find(txt_matnr.Text.Trim());
            if (fRow != null)
                fRow["MENGE"] = 0;
            else
                dtgrd_Sayim.Rows.Add(txt_matnr.Text.Trim(),
                                     txt_maktx.Text.Trim(),
                                     txt_miktar.Text.Trim(),
                                     txt_Barkod.Text.Trim(),
                                     txt_birim.Text.Trim());

            grd_Sayim.DataSource = dtgrd_Sayim;
            txt_Barkod.Text = txt_maktx.Text = txt_matnr.Text = txt_miktar.Text = "";
            txt_Barkod.Focus();
        }

        private void malzChanged(object sender, EventArgs e)
        {
            malzemeChecked = false;
        }
        private void checkMalzeme()
        {
            Cursor.Current = Cursors.WaitCursor;
            WS_Kontrol.service SRV = new KoctasMobil.WS_Kontrol.service();
            WS_Kontrol.ZktmobilChckMtnr mtnr = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnr();
            WS_Kontrol.ZktmobilChckMtnrResponse matresp = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnrResponse();
            try
            {
                SRV.Url = Utility.getWsUrl("zktmobil_kontrol");
                SRV.Credentials = ProgramGlobalData.g_credential;

                if (String.IsNullOrEmpty(txt_Barkod.Text))
                {
                    return;
                }
                mtnr.IMatnr = txt_Barkod.Text;

                matresp = SRV.ZktmobilChckMtnr(mtnr);
                if (!String.IsNullOrEmpty(matresp.EMaktx.Trim()))
                {               
                    txt_miktar.Focus();
                    txt_maktx.Text = matresp.EMaktx;
                    txt_birim.Text = matresp.EMeins;
                    txt_matnr.Text = matresp.EMatnr;
                    txt_Barkod.Text = matresp.EEan11;
                    malzemeChecked = true;
                }
                else
                {
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                txt_Barkod.Focus();
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        
    }
}

