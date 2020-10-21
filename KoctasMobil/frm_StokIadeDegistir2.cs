using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace KoctasMobil
{
    public partial class frm_StokIadeDegistir2 : Form
    {
        public frm_StokIadeDegistir2()
        {
            InitializeComponent();
            dt_mal = new DataTable();
            dt_mal.Columns.Add("matnr");
            dt_mal.Columns.Add("maktx");
            dt_mal.Columns.Add("menge");
            dt_mal.Columns.Add("meins");
            dt_mal.Columns.Add("itip");
        }
        public frm_StokIadeDegistir2(DataTable dt_malzemeler)
        {
            InitializeComponent();
            if (dt_malzemeler != null)
            {
                dt_mal = dt_malzemeler;
            }
            else
            {
                dt_mal = new DataTable();
                dt_mal.Columns.Add("matnr");
                dt_mal.Columns.Add("maktx");
                dt_mal.Columns.Add("menge");
                dt_mal.Columns.Add("meins");
                dt_mal.Columns.Add("itip");
            }
            dt_undo = new DataTable();
            dt_undo.Columns.Add("matnr");
            dt_undo.Columns.Add("maktx");
            dt_undo.Columns.Add("menge");
            dt_undo.Columns.Add("meins");
            dt_undo.Columns.Add("itip");
        }

        DataTable dt_mal, dt_undo;
        string _formno;
        bool malzemeChecked = false;
        string _iadeTipi;

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FIT_Malgiris_Load(object sender, EventArgs e)
        {            
            grd_mal.DataSource = dt_mal;
            cmbIadeTipi.SelectedItem = Utility.getIadeTip(_iadeTipi);
            
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try { decimal.Parse(txt_miktar.Text.Trim()); }
            catch
            {
                MessageBox.Show("Miktar alanına yalnız sayısal değer girebilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                return;
            }

            if (!malzemeChecked) checkMalzeme();
            if (!malzemeChecked) return;
            
            bool ekle = true;
            for (int j = 0; j < dt_mal.Rows.Count; j++)
            {
                if (dt_mal.Rows[j]["MATNR"].ToString() == txt_malzemeno.Text.Trim())
                {
                    ekle = false;
                    dt_mal.Rows[j]["MENGE"] =  Convert.ToDecimal(txt_miktar.Text.Trim());

                }
            }

            if (ekle)
            {
                DataRow row = dt_mal.NewRow();
                row["matnr"] = txt_malzemeno.Text;
                row["maktx"] = txt_maktx.Text;
                row["menge"] = txt_miktar.Text;
                row["meins"] = txt_birim.Text;

                dt_mal.Rows.Add(row);
            }            

            txt_miktar.Text = txt_birim.Text = txt_maktx.Text = txt_malzemeno.Text = "";
            txt_malzemeno.Focus();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {            
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Stok.service srv = new KoctasMobil.WS_Stok.service();
                WS_Stok.ZktmobilChngIade ret = new KoctasMobil.WS_Stok.ZktmobilChngIade();
                WS_Stok.ZktmobilIade[] iade = new KoctasMobil.WS_Stok.ZktmobilIade[dt_mal.Rows.Count];
                WS_Stok.ZktmobilChngIadeResponse resp = new KoctasMobil.WS_Stok.ZktmobilChngIadeResponse();

                srv.Url = Utility.getWsUrl("zktmobil_stok");
                srv.Credentials = ProgramGlobalData.g_credential;
                int i = 0;
                foreach (DataRow row in dt_mal.Rows)
                {
                    iade[i] = new KoctasMobil.WS_Stok.ZktmobilIade();
                    iade[i].Matnr = row["matnr"].ToString();
                    iade[i].Menge = Convert.ToDecimal(row["menge"].ToString());
                    iade[i].ITip = Utility.getIadeTipReverse(cmbIadeTipi.SelectedItem.ToString());
                    i++;
                }

                ret.IFormno = _formno;
                ret.ItIadec = iade;
                
                resp = srv.ZktmobilChngIade(ret);
                
                if (resp.EReturn != null && resp.EReturn.Length > 0 && resp.EReturn[0].RcCode == "E")
                {
                    throw new Exception(resp.EReturn[0].RcText);
                }

                dt_mal.Clear();
                MessageBox.Show("İade değişikliği kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void txt_miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_Ekle_Click(txt_miktar, new EventArgs());
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (grd_mal.CurrentRowIndex < 0)
                {
                    return;
                }
                dt_undo.ImportRow(dt_mal.Rows[grd_mal.CurrentCell.RowNumber]);
                dt_mal.Rows.RemoveAt(grd_mal.CurrentCell.RowNumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);                
            }
        }

        private void txt_malzemeno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                checkMalzeme();
                if (malzemeChecked)
                {
                    txt_miktar.Focus();
                }                
            }
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

                if (String.IsNullOrEmpty(txt_malzemeno.Text))
                {
                    return;
                }
                mtnr.IMatnr = txt_malzemeno.Text;

                matresp = SRV.ZktmobilChckMtnr(mtnr);
                if (!String.IsNullOrEmpty(matresp.EMaktx.Trim()))
                {
                    txt_miktar.Focus();
                    txt_birim.Text = matresp.EMeins;
                    txt_malzemeno.Text = matresp.EMatnr;
                    txt_maktx.Text = matresp.EMaktx;
                    cmbIadeTipi.SelectedValue = Utility.getIadeTip(mtnr.ITip);
                    malzemeChecked = true;
                }
                else
                {
                    txt_malzemeno.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                txt_malzemeno.Focus();
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void txt_malzemeno_TextChanged(object sender, EventArgs e)
        {
            malzemeChecked = false;
        }

        private void GeneralKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public string Formno
        {
            get { return _formno; }
            set { _formno = value; }
        }

        public string iadeTipi
        {
            get { return _iadeTipi; }
            set { _iadeTipi = value; }
        }

        private void btn_HepsiniSil_Click(object sender, EventArgs e)
        {
            dt_undo = dt_mal.Copy();
            dt_mal.Clear();
        }

        private void btn_undo1_Click(object sender, EventArgs e)
        {            
            try
            {
                if (dt_undo.Rows.Count == 0)
                {
                    return;
                }
                foreach (DataRow row in dt_undo.Rows)
                {
                    dt_mal.ImportRow(row);
                }
                dt_undo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }
        private void grd_mal_DoubleClick(object sender, EventArgs e)
        {
            txt_malzemeno.Text = dt_mal.Rows[grd_mal.CurrentCell.RowNumber]["matnr"].ToString();
            //dt_undo.ImportRow(dt_mal.Rows[grd_mal.CurrentCell.RowNumber]);
            //dt_mal.Rows.RemoveAt(grd_mal.CurrentCell.RowNumber);
            checkMalzeme();
        }


    }
}