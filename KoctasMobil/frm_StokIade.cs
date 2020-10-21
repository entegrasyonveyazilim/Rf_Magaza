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
    public partial class frm_StokIade : Form
    {
        public frm_StokIade()
        {
            InitializeComponent();
        }
        DataTable dt_mal;
        bool malzemeChecked = false;
        static string saticiKodu = "";
        static string _saticiKodu = "";
        static string _tanim = "";

        private string _iadeTuru = "";

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FIT_Malgiris_Load(object sender, EventArgs e)
        {
            dt_mal = new DataTable();
            dt_mal.Columns.Add("matnr");
            dt_mal.Columns.Add("maktx");
            dt_mal.Columns.Add("menge");
            dt_mal.Columns.Add("meins");
            grd_mal.DataSource = dt_mal;
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
                    dt_mal.Rows[j]["MENGE"] = Convert.ToDecimal(dt_mal.Rows[j]["MENGE"].ToString()) + Convert.ToDecimal(txt_miktar.Text.Trim());
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

            if (dt_mal.Rows.Count == 1)
            {
                saticiKodu = _saticiKodu;
            }

            txt_miktar.Text = txt_birim.Text = txt_maktx.Text = txt_malzemeno.Text = "";
            txt_malzemeno.Focus();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (dt_mal.Rows.Count == 0)
            {
                MessageBox.Show("Formu göndermeden önce malzeme ekleyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                return;
            }

            if (iadeTuru.ToString() == "M")
            {
                frm_MusteridenIadeBilgiFormu frm = new frm_MusteridenIadeBilgiFormu();
                frm._dt_mal = dt_mal;
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.Abort)
                {
                    dt_mal.Clear();
                    this.Close();
                }
            }
            else
            {

                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    WS_Stok.service srv = new KoctasMobil.WS_Stok.service();
                    WS_Stok.ZktmobilReturnFormCrt ret = new KoctasMobil.WS_Stok.ZktmobilReturnFormCrt();
                    WS_Stok.ZktmobilIade[] iade = new KoctasMobil.WS_Stok.ZktmobilIade[dt_mal.Rows.Count];
                    WS_Stok.ZktmobilReturnFormCrtResponse resp = new KoctasMobil.WS_Stok.ZktmobilReturnFormCrtResponse();

                    srv.Url = Utility.getWsUrl("zktmobil_stok");
                    srv.Credentials = ProgramGlobalData.g_credential;
                    int i = 0;
                    foreach (DataRow row in dt_mal.Rows)
                    {
                        iade[i] = new KoctasMobil.WS_Stok.ZktmobilIade();
                        iade[i].Matnr = row["matnr"].ToString();
                        iade[i].Menge = Convert.ToDecimal(row["menge"].ToString());
                        i++;
                    }

                    
                    
                    ret.ItIade = iade;
                    ret.ITip = iadeTuru.ToString();

                    resp = srv.ZktmobilReturnFormCrt(ret);//    •	İade formu çıktısı kaldırılacak,

                    
                    if (String.IsNullOrEmpty(resp.EFormno) && resp.EReturn[0].RcCode == "E")
                    {
                        throw new Exception(resp.EReturn[0].RcText);
                    }
                    dt_mal.Clear();
                    MessageBox.Show(resp.EFormno + " nolu iade kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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
                dt_mal.Rows.RemoveAt(grd_mal.CurrentCell.RowNumber);
            }
            catch (Exception ex)
            {
                
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
                
                mtnr.ITip = this.iadeTuru.ToString();

                matresp = SRV.ZktmobilChckMtnr(mtnr);
                if (!String.IsNullOrEmpty(matresp.EMaktx.Trim()))
                {
                    if (matresp.EDurum.ToString() == "X")
                    {

                        /*
                         * 27.03.2012 - farklı satıcı kontrolü çıkartıldı, by brksnmz...
                         * 18.07.2012 - Sadece Mal Kabulden İade seçeneği ile geldiğinde bu kontrol aktif olacak şekilde yeniden revize edildi., by brksnmz via ulass.
                         * 
                         * 
                        */

                        //  14.01.2019 Mehmet Keskin via Ümit Buzol
                        //if (this.iadeTuru.ToString() == "M")
                        //{
                        //    if (((dt_mal.Rows.Count >= 1)) && (saticiKodu != matresp.ELifnr.ToString()))
                        //    {
                        //        MessageBox.Show("Farklı bir satıcıya ait ürün ekleyemezsiniz.", "HATA");
                        //        malzemeChecked = false;
                        //        return;
                        //    }
                        //}

                        txt_miktar.Focus();
                        txt_birim.Text = matresp.EMeins;
                        txt_malzemeno.Text = matresp.EMatnr;
                        txt_maktx.Text = matresp.EMaktx;
                        _saticiKodu = matresp.ELifnr.ToString();
                        _tanim = matresp.ETanim.ToString();


                        //Iade turu ayıplı iade ise tanım bilgisi ekrana basiliyor
                        if (this.iadeTuru.ToString() == "B")
                        {
                            if (_tanim.Trim() != "")
                            {
                                MessageBox.Show(_tanim.ToString(), "İADE STATÜSÜ");
                            }
                        }
                        malzemeChecked = true;
                    }
                    else
                    {
                        MessageBox.Show("İade statü bilgisi yoktur.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        txt_malzemeno.Text = "";
                        txt_malzemeno.Focus();
                    }
                    
                    
                }
                else
                {
                    txt_malzemeno.Text = "";
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

        //Properties :
        public string iadeTuru
        {
            get { return _iadeTuru; }
            set { _iadeTuru = value; }
        }


    }
}