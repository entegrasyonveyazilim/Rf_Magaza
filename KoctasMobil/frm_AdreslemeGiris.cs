using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_AdreslemeGiris : Form
    {

        string adres = "";
        DataTable drMal = new DataTable();
        string malzemeNo = "";
        string malzemeTanim = "";
        decimal malzemeAdet = 0;
        string malzemeBirim = "";
        
        
        public frm_AdreslemeGiris()
        {
            InitializeComponent();
        }

        private void frm_AdreslemeGiris_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            drMal = new DataTable();
            drMal.Columns.Add("Matnr");
            drMal.Columns.Add("Maktx");
            drMal.Columns.Add("Menge");
            drMal.Columns.Add("Meins");
            drMal.Columns.Add("Nlpla");

        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Getir_Click(object sender, EventArgs e)
        {
            if (txtAdres.Text.Trim() == "")
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                WS_Kontrol.service srv = new KoctasMobil.WS_Kontrol.service();
                WS_Kontrol.ZkmobilReturn ret = new KoctasMobil.WS_Kontrol.ZkmobilReturn();

                WS_Kontrol.ZktmobilChckAdr chkAddres = new KoctasMobil.WS_Kontrol.ZktmobilChckAdr();
                WS_Kontrol.ZktmobilChckAdrResponse resp = new KoctasMobil.WS_Kontrol.ZktmobilChckAdrResponse();

                chkAddres.EReturn = ret;

                adres = txtAdres.Text.Trim().ToUpper();
                chkAddres.IAddress = adres;
                
                
                srv.Credentials = ProgramGlobalData.g_credential;
                srv.Url = Utility.getWsUrl("zktmobil_kontrol");
                resp = srv.ZktmobilChckAdr(chkAddres);

                

                if (resp.EReturn.RcCode.ToUpper() == "E")
                {
                    //Eger adres tanımlı değil ise
                    txtAdres.Text = "";
                    MessageBox.Show(resp.EReturn.RcText, "HATA");
                }
                else
                {
                    txt_malzemeNo.Enabled = true;
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
                        txt_malzemeNo.Text = malzemeNo = chkMtnrResp.EMatnr.ToString();
                        txt_maktx.Text = malzemeTanim = chkMtnrResp.EMaktx.ToString();
                        txt_birim.Text = malzemeBirim = chkMtnrResp.EMeins.ToString();
                        txt_miktar.Enabled = true;
                        txt_miktar.Focus();
                    }




                    // Girilen artikel no siparise ait malzeme
                    // listesinde kontrol ediliyor
                    #region
                    /*
                    try
                    {
                        ekleMal.Clear();
                        for (int i = 0; i < index; i++)
                        {
                            if ((malList[i].Matnr == txt_malzemeNo.Text.PadLeft(18, '0')) && (malList[i].Ebeln == txt_siparisNo.Text.Trim()))
                            {

                                txt_miktar.Enabled = true;
                                txt_birim.Enabled = true;
                                txt_maktx.Enabled = true;

                                txt_maktx.Text = malTanim = malList[i].Maktx.ToString();
                                txt_birim.Text = malBirim = malList[i].Meins.ToString();

                                string[] strMal = malList[i].Menge.Split('.');
                                malAdet += Convert.ToInt32(strMal[0].ToString());
                                malNo = txt_malzemeNo.Text;


                                txt_miktar.Focus();

                                //Eklenmek istenen malzeme tabloya aktarılıyor
                                DataRow row = ekleMal.NewRow();
                                row["Ebeln"] = malList[i].Ebeln.ToString();
                                row["Matnr"] = malList[i].Matnr.ToString();
                                row["Meins"] = malList[i].Meins.ToString();
                                row["Menge"] = Convert.ToInt32(strMal[0].ToString());
                                row["Ebelp"] = malList[i].Ebelp.ToString();
                                ekleMal.Rows.Add(row);

                                malKontrol = 1;
                            }
                        }

                        //MessageBox.Show(malAdet.ToString(), "TEST");

                        if (malKontrol == 0)
                        {
                            MessageBox.Show("Girilen Ürün Sipariş Listesinde Bulunamadı", "HATA");
                            txt_malzemeNo.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "HATA");
                        txt_malzemeNo.Text = "";
                    }*/
                    #endregion

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "HATA");
                return;
            } finally {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            
            try { decimal.Parse(txt_miktar.Text.Trim()); }
            catch
            {
                MessageBox.Show("Miktar alanına yalnız sayısal değer girebilirsiniz.", "HATA");
                return;
            }

            if ((txt_miktar.Text == "") || (Convert.ToInt32(txt_miktar.Text) <= 0))
            {
                return;
            }

            malzemeAdet = Convert.ToDecimal(txt_miktar.Text.ToString());


            bool eklemeYap = true;

            //Malzeme daha once listeye eklenmiş ise, eklenen miktar devir alınıyor.
            for (int i = 0; i < drMal.Rows.Count; i++)
            {
                if (drMal.Rows[i]["Matnr"].ToString() == malzemeNo.ToString())
                {
                    decimal mevcutAdet = Convert.ToDecimal(drMal.Rows[i]["Menge"].ToString());
                    drMal.Rows[i]["Menge"] = (mevcutAdet + malzemeAdet);
                    eklemeYap = false;
                }
            }
            
            if (eklemeYap)
            {
                DataRow row = drMal.NewRow();
                row["Matnr"] = malzemeNo;
                row["Maktx"] = malzemeTanim;
                row["Menge"] = malzemeAdet;
                row["Meins"] = malzemeBirim;
                row["Nlpla"] = adres;
                drMal.Rows.Add(row);
            }

            grd_mal.DataSource = null;
            grd_mal.DataSource = drMal;

            txt_malzemeNo.Text = "";
            txt_miktar.Text = "";
            txt_birim.Text = "";
            txt_maktx.Text = "";
            txt_malzemeNo.Focus();

            
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (grd_mal.CurrentRowIndex < 0)
                {
                    return;
                }
                if (MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    drMal.Rows.RemoveAt(grd_mal.CurrentCell.RowNumber);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txt_miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)13))
            {
                btn_Ekle_Click(new object(), new EventArgs());
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (drMal.Rows.Count == 0)
            {
                MessageBox.Show("Kaydetmeden önce malzeme ekleyin", "HATA");
                return;
            }

            if (MessageBox.Show("Malzemeleri kaydetmek istediğinizden emin misiniz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try {
                    Cursor.Current = Cursors.WaitCursor;

                    WS_Stok.service srv = new KoctasMobil.WS_Stok.service();
                    WS_Stok.ZkmobilReturn ret = new KoctasMobil.WS_Stok.ZkmobilReturn();
                    WS_Stok.ZmbSendToAdrs[] topMal = new KoctasMobil.WS_Stok.ZmbSendToAdrs[drMal.Rows.Count];

                    WS_Stok.ZktmobilSendToAdress sendAdress = new KoctasMobil.WS_Stok.ZktmobilSendToAdress();
                    WS_Stok.ZktmobilSendToAdressResponse respSendAdress = new KoctasMobil.WS_Stok.ZktmobilSendToAdressResponse();

                    srv.Credentials = ProgramGlobalData.g_credential;
                    srv.Url = Utility.getWsUrl("zktmobil_stok");

                    int j = 0;
                    foreach (DataRow row in drMal.Rows)
                    {
                        topMal[j] = new KoctasMobil.WS_Stok.ZmbSendToAdrs();
                        topMal[j].Matnr = row["Matnr"].ToString();
                        topMal[j].Meins = row["Meins"].ToString();
                        topMal[j].Menge = Convert.ToDecimal(row["Menge"]);
                        topMal[j].Nlpla = row["Nlpla"].ToString();

                        j++;
                    }

                    sendAdress.EReturn = ret;
                    sendAdress.ZmbSendToAdrs = topMal;
                    sendAdress.ImNlpla = adres;

                    respSendAdress = srv.ZktmobilSendToAdress(sendAdress);
                    if (respSendAdress.EReturn.RcCode.ToUpper() == "E")
                    {
                        //Eger kayit sirasinda bir hata olmussa
                        MessageBox.Show(respSendAdress.EReturn.RcText, "HATA");
                    }
                    else
                    {
                        drMal.Clear();
                        malzemeNo = "";
                        malzemeTanim = "";
                        malzemeAdet = 0;
                        malzemeBirim = "";
                        MessageBox.Show("Malzemeler kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        this.Close();
                    }

                    
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


        

        
    }
}