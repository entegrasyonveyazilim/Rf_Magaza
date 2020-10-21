using System;

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
    public partial class frm_Malgiris1 : Form
    {

        public DataTable tbl_Irsaliye;
        public DataTable tbl_Siparisler;
        public DataTable tbl_Malzeme;
        public DataTable tbl_Topla;
        public string gecerliIrsaliyeNo;
        public DateTime gecerliBelgeTarihi;
        public DateTime gecerliKayitTarihi;
        
        public frm_Malgiris1()
        {
            InitializeComponent();
        }


       
        private void frm_Malgiris1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DataTableGoster();
        }

        private void btn_Check2_Click(object sender, EventArgs e)
        {
            frm_UrunKontrol frm = new frm_UrunKontrol();
            frm.malzemeNo = txt_malzemeno.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txt_malzemeno.Text = frm.malzemeNo.Trim();
                txt_malzemeno.Focus();
            }

            
            
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Girdiğiniz malzeme kaydını silmek istediğinizden emin misiniz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    if (grd_mal.CurrentRowIndex < 0)
                    {
                        return;
                    }
                    

                    string matnr = grd_mal[grd_mal.CurrentCell.RowNumber, 0].ToString();
                    string siparisNo = grd_mal[grd_mal.CurrentCell.RowNumber, 5].ToString();
                    string irsaliyeNo = grd_mal[grd_mal.CurrentCell.RowNumber, 10].ToString();

                    for (int i = 0; i < tbl_Topla.Rows.Count; i++)
                    {
                        if ((tbl_Topla.Rows[i]["matnr"].ToString() == matnr) && (tbl_Topla.Rows[i]["ebeln"].ToString() == siparisNo) && (tbl_Topla.Rows[i]["irsaliyeNo"].ToString() == irsaliyeNo))
                        {
                            tbl_Topla.Rows.RemoveAt(i);
                        }
                    }

                    DataTableGoster();

                }
                catch (Exception ex)
                {

                } 
            }

            


        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            /*
            DataRow row = tbl_Topla.NewRow();
            row["matnr"] = "1";
            row["maktx"] = "2";
            tbl_Topla.Rows.Add(row);*/

            try
            {
                //|| String.IsNullOrEmpty(hasarMiktar.Text) || String.IsNullOrEmpty(irsaliyeMiktar.Text)
                if (String.IsNullOrEmpty(txt_malzemeno.Text) || String.IsNullOrEmpty(txt_miktar.Text) || String.IsNullOrEmpty(hasarMiktar.Text) || String.IsNullOrEmpty(irsaliyeMiktar.Text))
                {
                    return;
                }


                Int64 matnr = Convert.ToInt64(txt_malzemeno.Text.Trim());

                //Malzeme tbl_Malzeme tablosunda var mı?
                if (dt_MalzemeVarMi(gecerliIrsaliyeNo, matnr) == true)
                {

                    Cursor.Current = Cursors.WaitCursor;

                    decimal miktar;
                    decimal hasarliMiktar;
                    decimal irsaliyeMiktari;

                    try
                    {
                        miktar = decimal.Parse(txt_miktar.Text.Trim());
                    }
                    catch
                    {
                        MessageBox.Show("Miktar alanına sayısal bir değer giriniz");
                        Cursor.Current = Cursors.Default;
                        return;
                    }

                    try
                    {
                        hasarliMiktar = decimal.Parse(hasarMiktar.Text.Trim());
                    }
                    catch
                    {
                        MessageBox.Show("Hasar Miktar alanına sayısal bir değer giriniz");
                        Cursor.Current = Cursors.Default;
                        return;
                    }

                    try
                    {
                        irsaliyeMiktari = decimal.Parse(irsaliyeMiktar.Text.Trim());
                    }
                    catch
                    {
                        MessageBox.Show("İrsaliye Miktar alanına sayısal bir değer giriniz");
                        Cursor.Current = Cursors.Default;
                        return;
                    }

                    if (irsaliyeMiktari < miktar || irsaliyeMiktari<miktar+hasarliMiktar)
                    {
                        MessageBox.Show("Fazla ürün girişi yapılamaz. Girişlerinizi düzeltin");
                        Cursor.Current = Cursors.Default;
                       return;
                    }

                    
                    //Miktar çarpan ile çarpılıyor
                    decimal carpan = malzemeBirimCarpaniBul(cmbBirim.Text, matnr.ToString());
                    miktar = Math.Round((miktar / carpan),3);
                    
                    
                    decimal kalan_miktar = miktar;
                    decimal eklenen_miktar = 0;
                    string siparisNo = "";
                    decimal kontrolMiktar = 0;

                    DataRow[] rowsTopla = tbl_Topla.Select("irsaliyeNo = '" + gecerliIrsaliyeNo + "'");
                    DataRow[] rowsToplaDiger = tbl_Topla.Select("irsaliyeNo <> '" + gecerliIrsaliyeNo + "'");

                    //barkod no ile gelen malzemenin 'malzeme no' su bulunuyor
                    foreach (DataRow row in tbl_Malzeme.Rows)
                    {
                        if ((Convert.ToInt64(row["Ean11"].ToString().Trim()) == matnr && Convert.ToInt64(row["Matnr"].ToString().Trim()) != matnr))
                        {
                            matnr = Convert.ToInt64(row["Matnr"].ToString().Trim());
                            break;
                        }
                    }


                    


                    //İlgili irsaliyedeki malzeme numarasının geçtiği sipariş numaralarına göre tekil listenin oluşturulması
                    DataRow[] rowsMalzeme = tbl_Malzeme.Select("irsaliyeNo = '" + gecerliIrsaliyeNo + "' AND (  Matnr = '" + matnr + "')");

                    DataTable tbl_Temp = tbl_Malzeme.Clone();
                    siparisNo = "";

                    for (int i = 0; i < rowsMalzeme.Length; i++)
                    {
                        if (ConvertInt64(rowsMalzeme[i]["Ean11"].ToString().Trim()) == matnr || ConvertInt64(rowsMalzeme[i]["Ean112"].ToString().Trim()) == matnr || ConvertInt64(rowsMalzeme[i]["Matnr"].ToString()) == matnr)
                        {
                            if (siparisNo != rowsMalzeme[i]["Ebeln"].ToString().Trim())
                            {
                                tbl_Temp.NewRow();
                                tbl_Temp.Rows.Add(rowsMalzeme[i].ItemArray);
                                siparisNo = rowsMalzeme[i]["Ebeln"].ToString().Trim();
                            }
                        }
                    }

                    siparisNo = "";
                    //malzemenin ilgili irsaliyedeki bütün siparişlerin içindeki toplam miktarı:
                    decimal max_menge = 0;
                    for (int i = 0; i < tbl_Temp.Rows.Count; i++)
                    {

                        kontrolMiktar = Convert.ToDecimal(tbl_Temp.Rows[i]["Menge"]);

                        if ((Convert.ToInt64(tbl_Temp.Rows[i]["Ean11"].ToString().Trim()) == matnr || Convert.ToInt64(tbl_Temp.Rows[i]["Matnr"].ToString().Trim()) == matnr) && (gecerliIrsaliyeNo == tbl_Temp.Rows[i]["irsaliyeNo"].ToString().Trim()) && (siparisNo != tbl_Temp.Rows[i]["Ebeln"].ToString().Trim()))
                        //if ((Convert.ToInt64(tbl_Malzeme.Rows[i]["Ean11"].ToString().Trim()) == matnr || Convert.ToInt64(tbl_Malzeme.Rows[i]["Matnr"].ToString().Trim()) == matnr) && (siparisNo != tbl_Malzeme.Rows[i]["Ebeln"].ToString().Trim()))
                        {
                            max_menge += kontrolMiktar;
                            siparisNo = tbl_Temp.Rows[i]["Ebeln"].ToString().Trim();

                        }
                    }

                    //Malzemenin tüm siparişlerde daha önce eklenmişse eklenen miktarları devral

                    //foreach (DataRow row in rowsTopla)
                    foreach (DataRow row in tbl_Topla.Rows)
                    {
                        if ((Convert.ToInt64(row["matnr"].ToString()) == matnr))
                        {
                            miktar += Convert.ToDecimal(row["menge"].ToString());
                        }
                    }

                    if (miktar > max_menge)
                    {
                        MessageBox.Show("Fazla ürün girişi yapılamaz. Girişlerinizi düzeltin");
                        Cursor.Current = Cursors.Default;
                        return;
                    }

                    kalan_miktar = miktar;


                    //eklemeden önce, aynı malzemenin geçerli irsaliyeye eklenen kayıtlarını sil
                    for (int i = 0; i < tbl_Topla.Rows.Count; i++)
                    {
                        if ((Convert.ToInt64(tbl_Topla.Rows[i]["matnr"].ToString()) == matnr) && (tbl_Topla.Rows[i]["irsaliyeNo"].ToString() == gecerliIrsaliyeNo))
                        {
                            tbl_Topla.Rows.RemoveAt(i);
                            i--;
                        }
                    }


                    //İlgili malzemenin ilgili irsaliyedeki siparişlere göre dağıtılarak tbl_topla tablosuna eklenmesi

                    

                    //Kalan miktardan önceki irsaliyelere eklenen toplam miktar çıkartılıyor
                    decimal digerMiktar = 0;
                    foreach (DataRow row in rowsToplaDiger)
                    {
                        if ((Convert.ToInt64(row["matnr"].ToString()) == matnr))
                        {
                            digerMiktar += Convert.ToDecimal(row["menge"].ToString());
                        }
                    }


                    kalan_miktar = kalan_miktar - digerMiktar;

                    int tempSay = 0;
                    foreach (DataRow row in tbl_Temp.Rows)
                    {
                        kontrolMiktar = Convert.ToDecimal(row["Menge"].ToString());
                        tempSay++;

                        if (kalan_miktar > (kontrolMiktar)) //Son siparişe kadar, sipariş miktarlarını kapatarak git
                        {
                            miktar = kontrolMiktar;
                        }
                        else
                        {
                            miktar = kalan_miktar;
                        }


                        //Döngüden gelen siparişNo için eklenecek müsait miktar var mı?
                        //Eğer son kayıttan farklı ise
                        if (tempSay < tbl_Temp.Rows.Count)
                        {
                            decimal siparisEklemeMiktari = dt_SipariseEklenenMiktar(row["Ebeln"].ToString(), matnr);
                            if (siparisEklemeMiktari >= kontrolMiktar) continue;
                        }

                        kalan_miktar = kalan_miktar - miktar;
                        DataRow rowAdd = tbl_Topla.NewRow();
                        rowAdd["matnr"] = row["Matnr"].ToString();
                        rowAdd["maktx"] = row["Maktx"].ToString();
                        rowAdd["menge"] = miktar;
                        eklenen_miktar += miktar;
                        rowAdd["meins"] = row["Meins"].ToString();
                        rowAdd["ebeln"] = row["Ebeln"].ToString();
                        rowAdd["ebelp"] = row["Ebelp"].ToString();
                        rowAdd["werks"] = row["Werks"].ToString();
                        rowAdd["lgort"] = row["Lgort"].ToString();
                        rowAdd["irsaliyeNo"] = gecerliIrsaliyeNo;
                        rowAdd["S"] = "";
                        rowAdd["irsaliyeMiktar"] = irsaliyeMiktar.Text.ToString();
                        rowAdd["hasarMiktar"] = hasarMiktar.Text.ToString();
                        rowAdd["eksikMiktar"] = irsaliyeMiktari-miktar-hasarliMiktar;
                        // Son değişiklik

                        if (miktar >= kontrolMiktar)
                        {
                            rowAdd["S"] = "X";
                            tbl_Topla.Rows.InsertAt(rowAdd, 0);
                            
                        }
                        //Sipariş miktarındaki miktardan fazla miktar eklenmiş ise
                        /*else if (eklenen_miktar >= kontrolMiktar)
                        {
                            //Fazla miktarı ilgili siparişin son kaydına eklenir
                            //İlgili siparişin son tablonun 0. satırı oluyor
                            tbl_Topla.Rows[0]["menge"] = Convert.ToDecimal(tbl_Topla.Rows[0]["menge"].ToString()) + miktar;

                        }*/
                        else
                        {
                            tbl_Topla.Rows.InsertAt(rowAdd, 0);
                        }

                        DataTableGoster();


                        if (kalan_miktar == 0)
                        {
                            break;
                        }
                        
                    } //foreach end


                    if (kalan_miktar > 0) //Kalan miktarın tamamını son siparişe ekle.
                    {

                        //decimal sonMiktar = Convert.ToDecimal(dt_mal.Rows[0]["menge"].ToString()) + kalan_miktar;
                        decimal sonMiktar = Convert.ToDecimal(tbl_Topla.Rows[0]["menge"].ToString()) + kalan_miktar;
                        tbl_Topla.Rows[0]["menge"] = sonMiktar;

                        DataTableGoster();
                    }

                    txt_malzemeno.Text = txt_miktar.Text = "";
                    txt_malzemeno.Focus();

                    //Kursoru en son satırı götür
                    Cursor.Current = Cursors.Default;

                }
                else
                {
                    MessageBox.Show("Bu malzeme girilen siparişlerde bulunmuyor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA");
            }

        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txt_miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_Ekle_Click(txt_miktar, new EventArgs());

            }
        }

        private void malzemeBirimiDoldur()
        {
            cmbBirim.Items.Clear();
            if (txt_malzemeno.Text != "")
            {
                //Lmein
                try
                {
                    Int64 matnr = Convert.ToInt64(txt_malzemeno.Text.ToString());
                    if (tbl_Malzeme.Rows.Count > 0)
                    {
                        for (int i = 0; i < tbl_Malzeme.Rows.Count; i++)
                        {
                            if ((Convert.ToInt64(tbl_Malzeme.Rows[i]["Ean11"].ToString().Trim()) == matnr) || (Convert.ToInt64(tbl_Malzeme.Rows[i]["Matnr"].ToString().Trim()) == matnr))
                            {
                                string lmein = tbl_Malzeme.Rows[i]["Lmein"].ToString();
                                string meins = tbl_Malzeme.Rows[i]["Meins"].ToString();
                                //decimal ckats = Convert.ToDecimal(tbl_Malzeme.Rows[i]["Ckats"].ToString());

                                if (cmbBirim.Items.Contains(meins) == false)
                                {
                                    cmbBirim.Items.Add(meins);
                                }
                                if (meins != lmein)
                                {
                                    if (cmbBirim.Items.Contains(lmein) == false)
                                    {
                                        cmbBirim.Items.Add(lmein);
                                    }
                                
                                }

                                cmbBirim.SelectedValue = meins;
                                cmbBirim.SelectedItem = meins;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Malzeme birimi kontrol hatası.");
                }


            }
        }


        private decimal malzemeBirimCarpaniBul(string birim, string matnr)
        {

            decimal ckats = 1;
            decimal umrez;
            decimal umren;

            if (birim != "")
            {
                
                try
                {

                    if (tbl_Malzeme.Rows.Count > 0)
                    {
                        for (int i = 0; i < tbl_Malzeme.Rows.Count; i++)
                        {
                            if ((tbl_Malzeme.Rows[i]["Matnr"].ToString().Trim() == matnr) && (tbl_Malzeme.Rows[i]["Lmein"].ToString().Trim() == birim))
                            {
                                umrez = Convert.ToDecimal(tbl_Malzeme.Rows[i]["Umrez"].ToString());
                                umren = Convert.ToDecimal(tbl_Malzeme.Rows[i]["Umren"].ToString());

                                ckats = umrez / umren;
                            }
                        }
                    }
                }
                catch 
                {
                    MessageBox.Show("Malzeme birimi çarpan kontrol hatası.");
                }
            }

            return ckats;
        }

        private void txt_malzemeno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                malzemeBirimiDoldur();
                txt_miktar.Focus();
            }
        }

        private void grd_mal_CurrentCellChanged(object sender, EventArgs e)
        {

        }



        //Malzeme siparişten dönen malzeme listesinde ilgili irsaliye de var mı?
        private bool dt_MalzemeVarMi(string irsaliyeNo, Int64 malzemeNo)
        {
            bool ret = false;

            try
            {

                if (tbl_Malzeme.Rows.Count > 0)
                {
                    for (int i = 0; i < tbl_Malzeme.Rows.Count; i++)
                    {
                        if ((tbl_Malzeme.Rows[i]["irsaliyeNo"].ToString() == irsaliyeNo) && (tbl_Malzeme.Rows[i]["Ean11"].ToString() == malzemeNo.ToString()))
                        {
                            ret = true;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ret;
        }

        private Int64 ConvertInt64(string s)
        {
            try
            {
                if (string.IsNullOrEmpty(s))
                {
                    return 0;
                }
                else
                {
                    return Convert.ToInt64(s);
                }
            }
            catch (Exception)
            {
                return 0;
            }

        }

        private void DataTableGoster()
        {
            grd_mal.DataSource = null;
            //grd_mal.DataSource = tbl_Topla.Select("irsaliyeNo = '" + gecerliIrsaliyeNo + "'");

            DataRow[] goster = tbl_Topla.Select("irsaliyeNo = '" + gecerliIrsaliyeNo + "'", "ID DESC");
            if (goster.Length > 0)
            {
                DataTable aktar = tbl_Topla.Clone();
                foreach (DataRow rowAktar in goster)
                {
                    aktar.Rows.Add(rowAktar.ItemArray);
                }

                grd_mal.DataSource = aktar;
                if (aktar.Rows.Count > 0) 
                    grd_mal.CurrentRowIndex = aktar.Rows.Count - 1;
            }
        }


        private decimal dt_SipariseEklenenMiktar(string siparisNo, Int64 malzemeNo)
        {
            decimal miktar = 0;

            try
            {

                if (tbl_Topla.Rows.Count > 0)
                {
                    for (int i = 0; i < tbl_Topla.Rows.Count; i++)
                    {
                        if ((tbl_Topla.Rows[i]["ebeln"].ToString() == siparisNo) && (tbl_Topla.Rows[i]["matnr"].ToString() == malzemeNo.ToString()) && (tbl_Topla.Rows[i]["irsaliyeNo"] != gecerliIrsaliyeNo))
                        {
                            miktar += Convert.ToDecimal(tbl_Topla.Rows[i]["menge"].ToString());
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return miktar;
        }

        private void btn_siparis_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] rowsTopla = tbl_Topla.Select("irsaliyeNo = '" + gecerliIrsaliyeNo + "'");

                if (rowsTopla.Length == 0)
                {
                    MessageBox.Show("Bu irsaliye için SAP'ye aktarılacak bir malzeme girişi yok", "HATA");
                    return;
                }
                
                Cursor.Current = Cursors.WaitCursor;
                WS_Satis.SERVICE srv = new KoctasMobil.WS_Satis.SERVICE();
                WS_Satis.ZkmobilMgH mgh = new KoctasMobil.WS_Satis.ZkmobilMgH();
                WS_Satis.ZkmobilMgI[] mgi = new KoctasMobil.WS_Satis.ZkmobilMgI[rowsTopla.Length];
                WS_Satis.ZkmobilSMgCreate[] mgc = new KoctasMobil.WS_Satis.ZkmobilSMgCreate[rowsTopla.Length];
                WS_Satis.ZkmobilReturn[] ret = new KoctasMobil.WS_Satis.ZkmobilReturn[0];
                WS_Satis.ZktmobilMgCreate2 cre = new KoctasMobil.WS_Satis.ZktmobilMgCreate2();
                WS_Satis.ZktmobilMgCreate2Response resp = new KoctasMobil.WS_Satis.ZktmobilMgCreate2Response();

                mgh.RefDocNo = gecerliIrsaliyeNo;

                
                int i = 0;
                foreach (DataRow row in rowsTopla)
                {
                    
                    mgi[i] = new KoctasMobil.WS_Satis.ZkmobilMgI();
                    mgi[i].Plant = row["werks"].ToString();
                    mgi[i].StgeLoc = row["lgort"].ToString();
                    mgi[i].EntryQnt = decimal.Parse(row["menge"].ToString());
                    mgi[i].PoNumber = row["ebeln"].ToString();
                    mgi[i].PoItem = row["ebelp"].ToString();
                    
                    if (row["S"].ToString() == "X")
                    {
                        mgi[i].Elikz = "X";
                    }
                    i++;
                }

                int j = 0;
                foreach (DataRow row in rowsTopla)
                {

                    mgc[j] = new KoctasMobil.WS_Satis.ZkmobilSMgCreate();
                    mgc[j].Plant = row["werks"].ToString();
                    mgc[j].StgeLoc = row["lgort"].ToString();
                    mgc[j].EntryQnt = decimal.Parse(row["menge"].ToString());
                    mgc[j].PoNumber = row["ebeln"].ToString();
                    mgc[j].PoItem = row["ebelp"].ToString();
                    mgc[j].DmgdQnt = decimal.Parse(row["hasarMiktar"].ToString());
                    mgc[j].MinusQnt = decimal.Parse(row["eksikMiktar"].ToString());

                    if (row["S"].ToString() == "X")
                    {
                        mgc[j].Elikz = "X";
                    }
                    j++;
                }


                
                cre.IHeader = mgh;
                cre.TeReturn = ret;
                cre.TiItems = mgi;
                cre.ItItems = mgc;
                cre.IFiori = "X";
                
                cre.IDocDate = gecerliBelgeTarihi.ToString("yyyy-MM-dd");
                cre.IPstngDate = gecerliKayitTarihi.ToString("yyyy-MM-dd");

                resp.TeReturn = ret;
                resp.TiItems = mgi;

                srv.Credentials = ProgramGlobalData.g_credential;
                srv.Url = Utility.getWsUrl("zktmobil_satis");
                resp = srv.ZktmobilMgCreate2(cre);

                Cursor.Current = Cursors.Default;

                if (resp.TeReturn.Length > 0)
                {
                    if (resp.TeReturn[0].RcCode.ToUpper() == "S")
                    {
                        MessageBox.Show(resp.TeReturn[0].RcText);
                        this.DialogResult = DialogResult.OK;
                        
                        //İrsaliye tablosu SAPye aktarıldı olarak işaretlenecek
                        irsaliyeAktarildi(gecerliIrsaliyeNo);
                        
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(resp.TeReturn[0].RcText);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }


        public void irsaliyeAktarildi(string irssaliyeNo)
        {
            if (tbl_Irsaliye.Rows.Count > 0)
            {
                for (int i = 0; i < tbl_Irsaliye.Rows.Count; i++)
                {
                    if (tbl_Irsaliye.Rows[i]["irsaliyeNo"].ToString() == irssaliyeNo)
                    {
                        tbl_Irsaliye.Rows[i]["sapAktar"] = "1";
                    }
                }
            }
        }

        private void txt_miktar_GotFocus(object sender, EventArgs e)
        {
            
        }

        private void grd_mal_CurrentCellChanged_1(object sender, EventArgs e)
        {

        }

    }
}