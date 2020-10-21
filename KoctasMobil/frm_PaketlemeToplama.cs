using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Web.Services.Protocols;

namespace KoctasMobil
{
    public partial class frm_PaketlemeToplama : Form
    {
        public frm_PaketlemeToplama()
        {
            InitializeComponent();
        }

        DataTable drMal = new DataTable();
        DataTable koliMal = new DataTable();
        DataTable ekleMal = new DataTable();
        DataTable yukMal = new DataTable();
            
        WS_Paket.Ztoplama1[] malList = new KoctasMobil.WS_Paket.Ztoplama1[1000];
        int index = 0;

        Int32 malAdet = 0;
        string malNo = "";
        string malTanim = "";
        string malBirim = "";
        string siparisNo = "";

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_PaketlemeToplama_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            drMal = new DataTable();
            koliMal = new DataTable();
            drMal.Columns.Add("Ebeln");
            drMal.Columns.Add("Matnr");
            drMal.Columns.Add("Maktx");
            drMal.Columns.Add("Meins");
            drMal.Columns.Add("Menge");
            drMal.Columns.Add("PaketNo");
            drMal.Columns.Add("Ebelp");
            drMal.Clear();

            koliMal.Columns.Add("Ebeln");
            koliMal.Columns.Add("Matnr");
            koliMal.Columns.Add("Maktx");
            koliMal.Columns.Add("Meins");
            koliMal.Columns.Add("Menge");
            koliMal.Columns.Add("PaketNo");
            koliMal.Columns.Add("Ebelp");
            koliMal.Clear();

            ekleMal.Columns.Add("Ebeln");
            ekleMal.Columns.Add("Matnr");
            ekleMal.Columns.Add("Maktx");
            ekleMal.Columns.Add("Meins");
            ekleMal.Columns.Add("Menge");
            ekleMal.Columns.Add("PaketNo");
            ekleMal.Columns.Add("Ebelp");
            ekleMal.Clear();

            yukMal.Columns.Add("kalemNo");
            yukMal.Columns.Add("malAdet");
            yukMal.Clear();

            


        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Getir_Click_1(object sender, EventArgs e)
        {
            

            if (txt_siparisNo.Text == "") 
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                WS_Paket.SERVICE srv = new KoctasMobil.WS_Paket.SERVICE();
                WS_Paket.Ztoplama1[] sipList = new KoctasMobil.WS_Paket.Ztoplama1[0];
                WS_Paket.Ztoplama2[] toplananList = new KoctasMobil.WS_Paket.Ztoplama2[0];
                WS_Paket.ZkmobilReturn ret = new KoctasMobil.WS_Paket.ZkmobilReturn();

                WS_Paket.ZktmobilPakCheckSip sipChk = new KoctasMobil.WS_Paket.ZktmobilPakCheckSip();
                WS_Paket.ZktmobilPakCheckSipResponse sipChkResp = new KoctasMobil.WS_Paket.ZktmobilPakCheckSipResponse();


                sipChk.ItItab = sipList;
                sipChk.ItToplama = toplananList;
                sipChk.EReturn = ret;

                sipChk.ImEbeln = txt_siparisNo.Text;

                srv.Credentials = ProgramGlobalData.g_credential;
                srv.Url = Utility.getWsUrl("zktmobil_paket");
                sipChkResp = srv.ZktmobilPakCheckSip(sipChk);

                if (sipChkResp.EReturn.RcCode.ToUpper() == "E")
                {
                    //Eger siparis tanımlı değilse
                    txt_siparisNo.Text = "";
                    MessageBox.Show(sipChkResp.EReturn.RcText, "HATA");
                }
                else
                {
                    //Sipariş tanımlıysa işlemlere devam ediliyor
                    index = 0;
                    //malList temizleniyor
                    for (int i = 0; i < malList.Length; i++)
                    {
                        malList[i] = null;
                    }
                    

                    siparisNo = txt_siparisNo.Text;
                    txt_malzemeNo.Enabled = true;
                    
                    for (int i = 0; i < sipChkResp.ItItab.Length; i++)
                    {
                        malList[index] = sipChkResp.ItItab[i];
                        index++;
                    }

                    txt_malzemeNo.Focus();
                    toplananList = sipChkResp.ItToplama;



                    //Daha once eklenmis olan malzeme listesi cekiliyor
                    for (int j = 0; j < toplananList.Length; j++)
                    {
                        DataRow row = koliMal.NewRow();
                        row["Ebeln"] = toplananList[j].Ebeln.ToString();
                        row["Matnr"] = toplananList[j].Matnr.ToString();
                        row["Meins"] = toplananList[j].Meins.ToString();
                        row["Menge"] = toplananList[j].Menge.ToString();
                        row["PaketNo"] = toplananList[j].PaketNo.ToString();
                        row["Ebelp"] = toplananList[j].Ebelp.ToString();

                        koliMal.Rows.Add(row);

                    }


                }
                Cursor.Current = Cursors.Default;
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

        private void txt_siparisNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_Getir_Click_1(new object(), new EventArgs());
            }
            
        }

        private void txt_malzemeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_malzemeNo.Text == "")
            {
                return;
            }


            int malKontrol = 0;
            malAdet = 0;
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
                    txt_malzemeNo.Text = chkMtnrResp.EMatnr.ToString();
                }
                
                
                
                
                // Girilen artikel no siparise ait malzeme
                // listesinde kontrol ediliyor
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
                }
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


            if (Convert.ToInt32(txt_miktar.Text) > malAdet)
            {
                MessageBox.Show("Siparişteki toplam miktarı aşamazsınız (Malzeme Adedi:" + malAdet + ")", "HATA");
                txt_miktar.Text = "";
                txt_miktar.Focus();
                return;
            }

            bool eklemeYap = true;
            decimal yuklenmisMiktar = 0;


            yukMal.Clear();
            //Daha once olusturulan koli icindeki malzeme adetleri kontrol ediliyor
            for (int j = 0; j < koliMal.Rows.Count; j++)
            {
                if (koliMal.Rows[j]["Matnr"].ToString() == txt_malzemeNo.Text.Trim().ToString())
                {
                    DataRow yukRow = yukMal.NewRow();
                    yukRow["kalemNo"] = koliMal.Rows[j]["Ebelp"].ToString();
                    yukRow["malAdet"] = Convert.ToDecimal(koliMal.Rows[j]["Menge"].ToString());
                    yukMal.Rows.Add(yukRow);

                    yuklenmisMiktar += Convert.ToDecimal(koliMal.Rows[j]["Menge"].ToString());

                }
            }

            
            decimal kalanMiktar = 0;
            // Daha onceden yuklenen malzeme miktarlari siparişteki eklenecek malzeme miktarlarından düşürülüyor
            for (int j = 0; j < ekleMal.Rows.Count; j++)
            {
                for (int i = 0; i < yukMal.Rows.Count; i++)
                {
                    kalanMiktar = Convert.ToDecimal(yukMal.Rows[i]["malAdet"].ToString());
                    if (yukMal.Rows[i]["kalemNo"].ToString() == ekleMal.Rows[j]["Ebelp"].ToString())
                    {
                        if (kalanMiktar < Convert.ToDecimal(ekleMal.Rows[j]["Menge"].ToString()))
                        {
                            ekleMal.Rows[j]["Menge"] = Convert.ToDecimal(ekleMal.Rows[j]["Menge"].ToString()) - kalanMiktar;
                            kalanMiktar = 0;
                        }
                        else
                        {
                            kalanMiktar = kalanMiktar - Convert.ToDecimal(ekleMal.Rows[j]["Menge"].ToString());
                            ekleMal.Rows[j]["Menge"] = 0;
                        }
                    }
                }
                
                
            }
           

            // Eger form tablosuna kayit eklenmemis ise onceki koli icerigini kontrol et
            decimal eklenecekMiktar = Convert.ToDecimal(txt_miktar.Text.Trim());
            decimal eklenmekIstenen = yuklenmisMiktar + eklenecekMiktar;
            if (eklenmekIstenen > malAdet)
            {
                MessageBox.Show("Eklenen miktar toplamı, siparişteki ve önceki kolilerdeki toplam miktardan fazla olamaz", "HATA");
                eklemeYap = false;
            }

            decimal toplamEklenen = 0;
            if (eklemeYap)
            {
                for (int j = 0; j < drMal.Rows.Count; j++)
                {
                    if ((drMal.Rows[j]["Matnr"].ToString() == txt_malzemeNo.Text.Trim().ToString()) && (drMal.Rows[j]["Ebeln"].ToString() == txt_siparisNo.Text.Trim()))
                    {
                        // Daha once eklenmis olan miktar ile yeni eklenen miktar
                        // toplam malzeme miktarından buyuk mu?

                        toplamEklenen += Convert.ToDecimal(drMal.Rows[j]["Menge"].ToString());
                    }
                }

                if ((toplamEklenen + yuklenmisMiktar + eklenecekMiktar) > malAdet)
                {
                    if (yuklenmisMiktar == 0)
                    {
                        MessageBox.Show("Eklenen miktar toplamı siparişteki toplam miktardan fazla olamaz", "HATA");
                    }
                    else
                    {
                        MessageBox.Show("Daha önce paketlenen kolilerdeki toplam ürün miktarı ile doldurulan koli içindeki toplam malzeme miktarı, sipariş miktarından büyük olamaz", "HATA");
                    }

                    eklemeYap = false;

                }
                else
                {
                    // Tabloya eklenmiş miktarlar yeniden eklenmek için
                    // tablodan siliniyor
                    for (int j = 0; j < drMal.Rows.Count; j++)
                    {
                        if ((drMal.Rows[j]["Matnr"].ToString() == txt_malzemeNo.Text.Trim().ToString()) && (drMal.Rows[j]["Ebeln"].ToString() == txt_siparisNo.Text.Trim()))
                        {
                            drMal.Rows.RemoveAt(j);
                            j--;
                        }
                    }

                    eklenecekMiktar = (toplamEklenen + eklenecekMiktar);
                }
            }

            string sipKalemNo = "";
            decimal miktar = 0;
            if (eklemeYap)
            {

                for (int j = 0; j < ekleMal.Rows.Count; j++)
                {
                    sipKalemNo = ekleMal.Rows[j]["Ebelp"].ToString();

                    if (eklenecekMiktar > Convert.ToDecimal(ekleMal.Rows[j]["Menge"].ToString()))
                    {
                        miktar = Convert.ToDecimal(ekleMal.Rows[j]["Menge"].ToString());
                    }
                    else
                    {
                        miktar = eklenecekMiktar;
                    }

                    eklenecekMiktar = eklenecekMiktar - miktar;
                    if (miktar > 0)
                    {
                        DataRow row = drMal.NewRow();
                        row["Ebeln"] = siparisNo;
                        row["Maktx"] = malTanim;
                        row["Matnr"] = malNo;
                        row["Meins"] = malBirim;
                        row["Ebelp"] = sipKalemNo;
                        row["Menge"] = miktar;
                        drMal.Rows.Add(row);
                    }

                }
            }
            grd_mal.DataSource = null;
            grd_mal.DataSource = drMal;

            txt_malzemeNo.Text = "";
            txt_maktx.Text = "";
            txt_miktar.Text = "";
            txt_birim.Text = "";
            malTanim = "";
            malNo = "";
            malBirim = "";
            malAdet = 0;

            txt_miktar.Enabled = false;
            txt_birim.Enabled = false;
            txt_maktx.Enabled = false;

            txt_malzemeNo.Focus();

        }

        private void txt_miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_Ekle_Click(new object(), new EventArgs());
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
                drMal.Rows.RemoveAt(grd_mal.CurrentCell.RowNumber);
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (drMal.Rows.Count == 0)
            {
                MessageBox.Show("Kaydetmeden önce malzeme ekleyin", "HATA");
                return;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                WS_Paket.SERVICE srv = new KoctasMobil.WS_Paket.SERVICE();
                WS_Paket.Ztoplama2[] topMal = new KoctasMobil.WS_Paket.Ztoplama2[drMal.Rows.Count];
                WS_Paket.ZkmobilReturn ret = new KoctasMobil.WS_Paket.ZkmobilReturn();

                WS_Paket.ZktmobilPakSave saveSip = new KoctasMobil.WS_Paket.ZktmobilPakSave();
                WS_Paket.ZktmobilPakSaveResponse saveSipResp = new KoctasMobil.WS_Paket.ZktmobilPakSaveResponse();

                srv.Credentials = ProgramGlobalData.g_credential;
                srv.Url = Utility.getWsUrl("zktmobil_paket");

                int j = 0;
                foreach (DataRow row in drMal.Rows)
                {
                    topMal[j] = new KoctasMobil.WS_Paket.Ztoplama2();
                    topMal[j].Ebeln = row["Ebeln"].ToString();
                    topMal[j].Matnr = row["Matnr"].ToString();
                    topMal[j].Meins = row["Meins"].ToString();
                    topMal[j].Menge = Convert.ToDecimal(row["Menge"]);
                    topMal[j].Ebelp = row["Ebelp"].ToString();

                    j++;
                }

                saveSip.ItData = topMal;
                saveSip.EReturn = ret;

                saveSipResp = srv.ZktmobilPakSave(saveSip);

                if (saveSipResp.EReturn.RcCode.ToUpper() == "E")
                {
                    //Eger kayit sirasinda bir hata olmussa
                    MessageBox.Show(saveSipResp.EReturn.RcText, "HATA");
                }
                else
                {
                    drMal.Clear();
                    MessageBox.Show(saveSipResp.ExKolino.ToString() + " nolu koli kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
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