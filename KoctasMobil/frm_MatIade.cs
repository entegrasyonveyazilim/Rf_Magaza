using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{

    public partial class frm_MatIade : Form
    {        
        public frm_MatIade()
        {
            InitializeComponent();
            _dt_urun = new DataTable();
            _dt_urun.Columns.Add("MATNR");
            _dt_urun.Columns.Add("MAKTX");
            _dt_urun.Columns.Add("MENGE");
            _dt_urun.Columns.Add("MEINS");
            _dt_urun.Columns.Add("IADE");
        }

        //Members:             
        DataTable _dt_urun;

                

        string matkl, mtart;
        //public frm_MatIade(WS_Satis.ZktmobilSItemslist[] list, string pvbeln, Title title)
        //{
        //    InitializeComponent();
        //    this._title = title;
        //    SetTitle();
        //    _VBELN = pvbeln;

        //    _dt_urun = new DataTable(); 
        //    _dt_urun.Columns.Add("MATNR");
        //    _dt_urun.Columns.Add("MAKTX");
        //    _dt_urun.Columns.Add("MENGE");
        //    _dt_urun.Columns.Add("MEINS");

        //    foreach (WS_Satis.ZktmobilSItemslist var in list)
        //    {
        //        DataRow row = _dt_urun.NewRow();
        //        row["MATNR"] = var.Matnr;
        //        row["MAKTX"] = var.Maktx;
        //        row["MENGE"] = var.Menge;
        //        row["MEINS"] = var.Meins;
        //        _dt_urun.Rows.Add(row);
        //    }

        //    grd_Urun.DataSource = null;
        //    grd_Urun.DataSource = _dt_urun;

        //    WS_Satis.SERVICE SRV = new KoctasMobil.WS_Satis.SERVICE();
        //    WS_Satis.ZktmobilCalcTotalAmount amount = new KoctasMobil.WS_Satis.ZktmobilCalcTotalAmount();
        //    WS_Satis.ZktmobilCalcTotalAmountResponse response = new KoctasMobil.WS_Satis.ZktmobilCalcTotalAmountResponse();
        //    SRV.Url = Utility.getWsUrl("zktmobil_satis");
        //    SRV.Credentials = ProgramGlobalData.g_credential;

        //    amount.TiList = new KoctasMobil.WS_Satis.ZktmobilItemsToCalculate[_dt_urun.Rows.Count];
        //    for (int i = 0; i < _dt_urun.Rows.Count; i++)
        //    {
        //        amount.TiList[i] = new KoctasMobil.WS_Satis.ZktmobilItemsToCalculate();
        //        amount.TiList[i].Matnr = _dt_urun.Rows[i]["MATNR"].ToString();
        //        amount.TiList[i].Meins = _dt_urun.Rows[i]["MEINS"].ToString();
        //        amount.TiList[i].Menge = Convert.ToDecimal(_dt_urun.Rows[i]["MENGE"].ToString());
        //    }
        //    response = SRV.ZktmobilCalcTotalAmount(amount);
        //    txt_toplamTutar.Text = response.ETotal.ToString() + " TL";
        //}        
       
       
        private void frm_NormalSiparisYarat_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void txt_Barkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)  
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Satis.SERVICE SRV = new KoctasMobil.WS_Satis.SERVICE();
                WS_Satis.ZktmobilGetMaterialInfo Matinfo = new KoctasMobil.WS_Satis.ZktmobilGetMaterialInfo();
                WS_Satis.ZktmobilGetMaterialInfoResponse response = new KoctasMobil.WS_Satis.ZktmobilGetMaterialInfoResponse();
                try
                {
                    SRV.Url = Utility.getWsUrl("zktmobil_satis");
                    SRV.Credentials = ProgramGlobalData.g_credential;
                    Matinfo.IBarkod = txt_Barkod.Text.Trim();
                    response = SRV.ZktmobilGetMaterialInfo(Matinfo);
                    txt_matnr.Text = response.EMatnr;
                    txt_maktx.Text = response.EMaktx;
                    txt_birim.Text = response.EMeins;
                    matkl = response.EMatkl;
                    mtart = response.EMtart;
                    txt_miktar.Focus();
                    if (string.IsNullOrEmpty(response.EMatnr))
                    {
                        txt_Barkod.Focus();
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

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(txt_maktx.Text))
            {
                if (!string.IsNullOrEmpty(txt_Barkod.Text))
                {
                    txt_Barkod_KeyPress(btn_Ekle, new KeyPressEventArgs((char)13));
                }
                else if (!string.IsNullOrEmpty(txt_matnr.Text))
                {
                    txt_matnr_KeyPress(btn_Ekle, new KeyPressEventArgs((char)13));
                }
            }
            if (String.IsNullOrEmpty(txt_maktx.Text))
            {
                return;
            }

            try
            {
                decimal.Parse(txt_miktar.Text.Trim());
            }
            catch 
            {
                MessageBox.Show("Miktar alanına yalnız sayısal değer girebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            WS_Satis.SERVICE SRV = new KoctasMobil.WS_Satis.SERVICE();
            WS_Satis.ZktmobilCalcTotalAmount amount = new KoctasMobil.WS_Satis.ZktmobilCalcTotalAmount();
            WS_Satis.ZktmobilCalcTotalAmountResponse response = new KoctasMobil.WS_Satis.ZktmobilCalcTotalAmountResponse();
            SRV.Url = Utility.getWsUrl("zktmobil_satis");
            SRV.Credentials = ProgramGlobalData.g_credential;
            try
            {               
                bool ekle = true;
                decimal toplam = 0m;
                for (int j = 0; j < _dt_urun.Rows.Count; j++)
                {
                    if (_dt_urun.Rows[j]["MATNR"].ToString() == txt_matnr.Text.Trim())
                    {
                        ekle = false;
                        toplam += Convert.ToDecimal(_dt_urun.Rows[j]["MENGE"].ToString());
                    }
                }
                toplam += Convert.ToDecimal(txt_miktar.Text.Trim());

                for (int j = 0; j < _dt_urun.Rows.Count; j++)
                {
                    if (_dt_urun.Rows[j]["MATNR"].ToString() == txt_matnr.Text.Trim())
                    {
                        _dt_urun.Rows[j]["MENGE"] = Convert.ToDecimal(_dt_urun.Rows[j]["MENGE"].ToString()) + Convert.ToDecimal(txt_miktar.Text.Trim());
                    }
                }
                if (ekle)
                {
                    DataRow row = _dt_urun.NewRow();
                    row["MATNR"] = txt_matnr.Text.Trim();
                    row["MAKTX"] = txt_maktx.Text.Trim();
                    row["MENGE"] = txt_miktar.Text.Trim();
                    row["MEINS"] = txt_birim.Text.Trim();
                    if (rdb_Raf.Checked)
                    {
                        row["IADE"] = "R";
                    }
                    if (rdb_Sarf.Checked)
                    {
                        row["IADE"] = "S";
                    }
                    if (rdb_Tedarikci.Checked)
                    {
                        row["IADE"] = "T";
                    }
                    _dt_urun.Rows.Add(row);
                }
                grd_Urun.DataSource = null;
                grd_Urun.DataSource = _dt_urun;


                amount.TiList = new KoctasMobil.WS_Satis.ZktmobilItemsToCalculate[_dt_urun.Rows.Count];
                for (int i = 0; i < _dt_urun.Rows.Count; i++)
                {
                    amount.TiList[i] = new KoctasMobil.WS_Satis.ZktmobilItemsToCalculate();
                    amount.TiList[i].Matnr = _dt_urun.Rows[i]["MATNR"].ToString();
                    amount.TiList[i].Meins = _dt_urun.Rows[i]["MEINS"].ToString();
                    amount.TiList[i].Menge = Convert.ToDecimal(_dt_urun.Rows[i]["MENGE"].ToString());                    
                }
                response = SRV.ZktmobilCalcTotalAmount(amount);
                txt_toplamTutar.Text = response.ETotal.ToString() + " TL";
                txt_birim.Text = string.Empty;
                txt_maktx.Text = string.Empty;
                txt_matnr.Text = string.Empty;
                txt_Barkod.Text = string.Empty;
                txt_miktar.Text = string.Empty;
                txt_Barkod.Focus();
            }            
            catch (Exception ex)
            {
                txt_miktar.Focus();
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (grd_Urun.CurrentRowIndex >= 0)
                {
                    _dt_urun.Rows.RemoveAt(grd_Urun.CurrentRowIndex);
                    grd_Urun.DataSource = null;
                    grd_Urun.DataSource = _dt_urun;
                }

                Cursor.Current = Cursors.WaitCursor;
                WS_Satis.SERVICE SRV = new KoctasMobil.WS_Satis.SERVICE();
                SRV.Url = Utility.getWsUrl("zktmobil_satis");
                SRV.Credentials = ProgramGlobalData.g_credential;
                WS_Satis.ZktmobilCalcTotalAmount amount = new KoctasMobil.WS_Satis.ZktmobilCalcTotalAmount();
                WS_Satis.ZktmobilCalcTotalAmountResponse response = new KoctasMobil.WS_Satis.ZktmobilCalcTotalAmountResponse();
                amount.TiList = new KoctasMobil.WS_Satis.ZktmobilItemsToCalculate[_dt_urun.Rows.Count];
                for (int i = 0; i < _dt_urun.Rows.Count; i++)
                {
                    amount.TiList[i] = new KoctasMobil.WS_Satis.ZktmobilItemsToCalculate();
                    amount.TiList[i].Matnr = _dt_urun.Rows[i]["MATNR"].ToString();
                    amount.TiList[i].Meins = _dt_urun.Rows[i]["MEINS"].ToString();
                    amount.TiList[i].Menge = Convert.ToDecimal(_dt_urun.Rows[i]["MENGE"].ToString());
                }
                response = SRV.ZktmobilCalcTotalAmount(amount);
                txt_toplamTutar.Text = response.ETotal.ToString() + " TL";

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

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (_dt_urun.Rows.Count == 0)
            {
                return;
            }
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Satis.SERVICE SRV = new KoctasMobil.WS_Satis.SERVICE();
                WS_Satis.ZktmobilIade iade = new KoctasMobil.WS_Satis.ZktmobilIade();
                WS_Satis.ZktmobilIadeResponse response = new KoctasMobil.WS_Satis.ZktmobilIadeResponse();
                SRV.Url = Utility.getWsUrl("zktmobil_satis");
                SRV.Credentials = ProgramGlobalData.g_credential;
                iade.TeList = new KoctasMobil.WS_Satis.ZktmobilSIadeItems[_dt_urun.Rows.Count];
                int i = 0;

                foreach (DataRow  row in _dt_urun.Rows)
                {
                    iade.TeList[i] = new KoctasMobil.WS_Satis.ZktmobilSIadeItems();
                    iade.TeList[i].Matnr = row["MATNR"].ToString();
                    iade.TeList[i].Meins = row["MEINS"].ToString();
                    iade.TeList[i].Sel = "X";
                    iade.TeList[i].Menge = Convert.ToDecimal(row["MENGE"].ToString());
                    iade.TeList[i].CancelDate = DateTime.Now.ToString("yyyy-MM-dd");
                    switch (row["IADE"].ToString())
                    {
                        case "S":
                            iade.TeList[i].S = "X";
                            break;
                        case "R":
                            iade.TeList[i].R = "X";
                            break;
                        case "T":
                            iade.TeList[i].T = "X";
                            break;
                    }
                    i++;
                }
                response = SRV.ZktmobilIade(iade);
                Cursor.Current = Cursors.Default;
                if (response.EReturn.RcCode == "S")
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    throw new Exception(response.EReturn.RcText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void txt_matnr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Satis.SERVICE SRV = new KoctasMobil.WS_Satis.SERVICE();
                WS_Satis.ZktmobilGetMaterialInfo Matinfo = new KoctasMobil.WS_Satis.ZktmobilGetMaterialInfo();
                WS_Satis.ZktmobilGetMaterialInfoResponse response = new KoctasMobil.WS_Satis.ZktmobilGetMaterialInfoResponse();
                try
                {
                    SRV.Url = Utility.getWsUrl("zktmobil_satis");
                    SRV.Credentials = ProgramGlobalData.g_credential;
                    Matinfo.IMatnr = txt_matnr.Text.Trim();
                    response = SRV.ZktmobilGetMaterialInfo(Matinfo);
                    txt_Barkod.Text = response.EEan11;
                    txt_maktx.Text = response.EMaktx;
                    txt_birim.Text = response.EMeins;
                    matkl = response.EMatkl;
                    mtart = response.EMtart;
                    txt_miktar.Focus();
                    if (string.IsNullOrEmpty(response.EEan11))
                    {
                        txt_matnr.Focus();
                    }
                }
                catch (Exception ex)
                {
                    txt_matnr.Focus();
                    MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void grd_Urun_DoubleClick(object sender, EventArgs e)
        {
            txt_matnr.Text = _dt_urun.Rows[grd_Urun.CurrentCell.RowNumber]["MATNR"].ToString();
            //txt_miktar.Text = _dt_urun.Rows[grd_Urun.CurrentCell.RowNumber]["MENGE"].ToString();
            txt_matnr_KeyPress(grd_Urun, new KeyPressEventArgs((char)13));
        } 

        private void txt_miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_ekle_Click(txt_miktar, new EventArgs());
            }
        }

        private void ClearScrean()
        {
            foreach (Control var in this.Controls)
            {
                if (var is TextBox && var.Name != "txt_toplamTutar")
                {
                    var.Text = "";
                }
            }
        }

        private void txt_toplamTutar_KeyDown(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_birim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_maktx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            ClearScrean(); 
        }
        

        //Properties :
        public DataTable Dt_urun
        {
            get { return _dt_urun; }
            set { _dt_urun = value; }
        }                  
    }
}

