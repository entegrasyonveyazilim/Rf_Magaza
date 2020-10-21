using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_AdreslemeTransfer : Form
    {

        string kaynakAdres = "";
        string malzemeNo = "";
        string malzemeTanim = "";
        decimal malzemeAdet = 0;
        string malzemeBirim = "";

        DataTable drMal = new DataTable();
        


        public frm_AdreslemeTransfer()
        {
            InitializeComponent();
        }

        private void depoYeriDoldur()
        {
            WS_Kontrol.service srv = new KoctasMobil.WS_Kontrol.service();
            WS_Kontrol.ZktStore[] itab = new KoctasMobil.WS_Kontrol.ZktStore[10];

            WS_Kontrol.ZktmobilChkStorageLocation chkStore = new KoctasMobil.WS_Kontrol.ZktmobilChkStorageLocation();
            WS_Kontrol.ZktmobilChkStorageLocationResponse resp = new KoctasMobil.WS_Kontrol.ZktmobilChkStorageLocationResponse();

            chkStore.Itab = itab;
            srv.Credentials = ProgramGlobalData.g_credential;
            srv.Url = Utility.getWsUrl("zktmobil_kontrol");
            resp = srv.ZktmobilChkStorageLocation(chkStore);

            if (resp.Itab.Length > 0)
            {
                for (int i = 0; i < resp.Itab.Length; i++)
                {
                    cmbDepoYeri.Items.Add(resp.Itab[i].Lgort.ToString());
                }

            }
            else
            {
                cmbDepoYeri.Items.Add("0001");
            }

            cmbDepoYeri.SelectedIndex = 0;

        }

        private string depoYerindenUretimYeriBul(string depoYeri)
        {
            string uretimYeri = "";

            WS_Kontrol.service srv = new KoctasMobil.WS_Kontrol.service();
            WS_Kontrol.ZktStore[] itab = new KoctasMobil.WS_Kontrol.ZktStore[10];

            WS_Kontrol.ZktmobilChkStorageLocation chkStore = new KoctasMobil.WS_Kontrol.ZktmobilChkStorageLocation();
            WS_Kontrol.ZktmobilChkStorageLocationResponse resp = new KoctasMobil.WS_Kontrol.ZktmobilChkStorageLocationResponse();

            chkStore.Itab = itab;
            srv.Credentials = ProgramGlobalData.g_credential;
            srv.Url = Utility.getWsUrl("zktmobil_kontrol");
            resp = srv.ZktmobilChkStorageLocation(chkStore);

            if (resp.Itab.Length > 0)
            {
                for (int i = 0; i < resp.Itab.Length; i++)
                {
                    if (depoYeri == resp.Itab[i].Lgort.ToString())
                    {
                        uretimYeri = resp.Itab[i].Werks.ToString();
                        break;
                    }
                }

            }

            return uretimYeri;

        }

        private void txtAdres1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)13))
            {
                btn_Getir_Click(new object(), new EventArgs());
            }
        }

        private void txt_malzemeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_malzemeNo.Text == "")
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (e.KeyChar == (char)13)
                {

                    // Malzeme alanına girilen kod barkod yada malzeme no olmasına
                    // göre webservice inden malzeme numarası çekiliyor.
                    WS_Kontrol.service srv = new KoctasMobil.WS_Kontrol.service();
                    WS_Kontrol.ZkmobilReturn ret = new KoctasMobil.WS_Kontrol.ZkmobilReturn();

                    WS_Kontrol.ZktmobilChckMtnr chkMtnr = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnr();
                    WS_Kontrol.ZktmobilChckMtnrResponse chkMtnrResp = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnrResponse();

                    chkMtnr.EReturn = ret;
                    chkMtnr.IMatnr = txt_malzemeNo.Text.Trim();

                    srv.Credentials = ProgramGlobalData.g_credential;
                    srv.Url = Utility.getWsUrl("zktmobil_kontrol");
                    chkMtnrResp = srv.ZktmobilChckMtnr(chkMtnr);

                    if (chkMtnrResp.EReturn.RcCode.ToUpper() == "E")
                    {
                        //Eger siparis tanımlı değilse
                        txt_malzemeNo.Text = "";
                        MessageBox.Show(chkMtnrResp.EReturn.RcText, "HATA");
                        return;
                    }
                    else
                    {
                        //Malzemenin adreslemedeki adedi bulunuyor
                        for(int i=0; i < drMal.Rows.Count; i++){
                            if (drMal.Rows[i]["Matnr"].ToString() == chkMtnrResp.EMatnr.ToString()) {
                                malzemeAdet = Convert.ToDecimal(drMal.Rows[i]["Menge"].ToString());
                            }
                        }
                        
                        
                        txt_malzemeNo.Text = malzemeNo = chkMtnrResp.EMatnr.ToString();
                        txt_maktx.Text = malzemeTanim = chkMtnrResp.EMaktx.ToString();
                        txt_birim.Text = malzemeBirim = chkMtnrResp.EMeins.ToString();
                        txt_miktar.Enabled = true;
                        txt_miktar.Text = malzemeAdet.ToString();
                        txt_miktar.Focus();
                        txt_miktar.SelectAll();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "HATA");
                return;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btn_Getir_Click(object sender, EventArgs e)
        {
            if (txtKaynakAdres.Text.Trim() == "")
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            try
            {

                WS_Kontrol.service srv = new KoctasMobil.WS_Kontrol.service();
                WS_Kontrol.ZmbSendToAdrs[] zmbAddres = new KoctasMobil.WS_Kontrol.ZmbSendToAdrs[1];

                WS_Kontrol.ZktmobilGetAdressContent chkAddres = new KoctasMobil.WS_Kontrol.ZktmobilGetAdressContent();
                WS_Kontrol.ZktmobilGetAdressContentResponse resp = new KoctasMobil.WS_Kontrol.ZktmobilGetAdressContentResponse();

                chkAddres.ZmbSendToAdrs = zmbAddres;

                kaynakAdres = txtKaynakAdres.Text.Trim().ToUpper();
                chkAddres.ImNlpla = kaynakAdres;


                srv.Credentials = ProgramGlobalData.g_credential;
                srv.Url = Utility.getWsUrl("zktmobil_kontrol");
                resp = srv.ZktmobilGetAdressContent(chkAddres);



                if (resp.ZmbSendToAdrs.Length <= 0)
                {
                    //Eger adres listesi boş ise
                    txtKaynakAdres.Text = "";
                    grd_mal.DataSource = null;
                    MessageBox.Show("Kaynak adres içeriğinde malzeme bulunamadı", "HATA");
                }
                else
                {
                    //grd_mal listesi dolduruluyor
                    drMal.Clear();
                    for (int i = 0; i < resp.ZmbSendToAdrs.Length; i++)
                    {
                        DataRow row = drMal.NewRow();
                        row["Matnr"] = resp.ZmbSendToAdrs[i].Matnr.ToString().TrimStart('0');
                        row["Menge"] = resp.ZmbSendToAdrs[i].Menge.ToString();
                        row["Meins"] = resp.ZmbSendToAdrs[i].Meins.ToString();
                        row["Nlpla"] = resp.ZmbSendToAdrs[i].Nlpla.ToString();
                        drMal.Rows.Add(row);
                    }

                    grd_mal.DataSource = null;
                    grd_mal.DataSource = drMal;
                    
                    txt_malzemeNo.Enabled = true;
                    txt_miktar.Enabled = true;
                    txt_malzemeNo.Focus();


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

        private void btn_Ekle_Click(object sender, EventArgs e)
        {

        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_AdreslemeTransfer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            drMal = new DataTable();
            drMal.Columns.Add("Matnr");
            drMal.Columns.Add("Meins");
            drMal.Columns.Add("Menge");
            drMal.Columns.Add("Nlpla");

            depoYeriDoldur();
            
        }

 
        private void grd_mal_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (grd_mal.CurrentRowIndex < 0)
                {
                    return;
                }


                malzemeNo = drMal.Rows[grd_mal.CurrentCell.RowNumber]["Matnr"].ToString();
                //malzemeAdet = Convert.ToDecimal(drMal.Rows[grd_mal.CurrentCell.RowNumber]["Menge"].ToString());

                txt_malzemeNo.Text = malzemeNo;
                txt_malzemeNo.Focus();

            }
            catch (Exception ex)
            {

            }
        }

        private void txt_miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)13))
            {
                
                try { decimal.Parse(txt_miktar.Text.Trim()); }
                catch
                {
                    MessageBox.Show("Miktar alanına yalnız sayısal değer girebilirsiniz.", "HATA");
                    return;
                }
                
                if (Convert.ToDecimal(txt_miktar.Text.ToString()) > 0)
                {
                    malzemeAdet = Convert.ToDecimal(txt_miktar.Text.ToString());

                    //Girilen malzeme adedi, adresleme listesindeli adet ile kontrol ediliyor.
                    for (int i = 0; i < drMal.Rows.Count; i++)
                    {
                        if (drMal.Rows[i]["Matnr"].ToString() == malzemeNo.ToString())
                        {
                            decimal mevcutAdet = Convert.ToDecimal(drMal.Rows[i]["Menge"].ToString());
                            if (malzemeAdet > mevcutAdet)
                            {
                                MessageBox.Show("Adresleme alanında bulunan miktardan daha fazla adet transfer edemezsiniz.", "HATA");
                                txt_miktar.Focus();
                                txt_miktar.SelectAll();
                                return;
                            }
                        }
                    }

                    txtHedefAdres.Enabled = true;
                    btn_Ekle.Enabled = true;
                    txtHedefAdres.Focus();
                    
                }
            }
        }

        private void btn_Ekle_Click_1(object sender, EventArgs e)
        {
            if (txtHedefAdres.Text.Trim() == "")
            {
                return;
            }
            else if (cmbDepoYeri.SelectedIndex == -1)
            {
                MessageBox.Show("Depo Yeri Seçiniz.", "HATA");
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                WS_Stok.service srv = new KoctasMobil.WS_Stok.service();
                WS_Stok.ZkmobilReturn ret = new KoctasMobil.WS_Stok.ZkmobilReturn();
                WS_Stok.ZmbTransBtwAdrs[] transData = new KoctasMobil.WS_Stok.ZmbTransBtwAdrs[1];


                WS_Stok.ZktmobilTransBtwAdrs trans = new KoctasMobil.WS_Stok.ZktmobilTransBtwAdrs();
                WS_Stok.ZktmobilTransBtwAdrsResponse resp = new KoctasMobil.WS_Stok.ZktmobilTransBtwAdrsResponse();

                trans.EReturn = ret;

                transData[0] = new KoctasMobil.WS_Stok.ZmbTransBtwAdrs();

                transData[0].DNlpla = txtHedefAdres.Text.Trim().ToUpper();
                transData[0].Lgort = cmbDepoYeri.SelectedItem.ToString();
                transData[0].Matnr = malzemeNo;
                transData[0].Menge = malzemeAdet;
                transData[0].SNlpla = kaynakAdres;
                transData[0].Werks = depoYerindenUretimYeriBul(cmbDepoYeri.SelectedItem.ToString());

                trans.ItData = transData;
                
                srv.Credentials = ProgramGlobalData.g_credential;
                srv.Url = Utility.getWsUrl("zktmobil_stok");
                resp = srv.ZktmobilTransBtwAdrs(trans);


                if (resp.EReturn.RcCode.ToUpper() == "E")
                {
                    //Eger kayit sirasinda bir hata olmussa
                    MessageBox.Show(resp.EReturn.RcText, "HATA");
                } else {
                    


                    //Transfer edilen adet kaynak listeden düşülüyor...
                    for (int i = 0; i < drMal.Rows.Count; i++)
                    {
                        if (drMal.Rows[i]["Matnr"].ToString() == malzemeNo.ToString())
                        {
                            decimal mevcutAdet = Convert.ToDecimal(drMal.Rows[i]["Menge"].ToString());
                            drMal.Rows[i]["Menge"] = (mevcutAdet - malzemeAdet);
                        }
                    }

                    malzemeAdet = 0;
                    txt_malzemeNo.Text = "";
                    txt_miktar.Text = "";
                    txt_miktar.Enabled = false;

                    txt_birim.Text = "";
                    txt_maktx.Text = "";
                    txtHedefAdres.Text = "";
                    txtHedefAdres.Enabled = false;
                    btn_Ekle.Enabled = false;
                    checkSatisAlani.Checked = false;

                    txt_malzemeNo.Focus();

                    grd_mal.DataSource = drMal;
                    MessageBox.Show("Transfer yapıldı.", "BİLGİ");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA");

            } finally {
                Cursor.Current = Cursors.Default;
            }
        }

        private void txtHedefAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)13))
            {
                btn_Ekle_Click_1(new object(), new EventArgs());
            }
        }

        private void checkSatisAlani_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkSatisAlani.Checked == true)
            {
                txtHedefAdres.Text = "A99-9999";
                txtHedefAdres.ReadOnly = true;
            }
            else
            {
                txtHedefAdres.Text = "";
                txtHedefAdres.ReadOnly = false;
            }
        }


    }
}