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
    public partial class frm_Malgiris2 : Form
    {
        public frm_Malgiris2()
        {
            InitializeComponent();
        }

        DataTable dt_mal = new DataTable();
        public ArrayList materials = new ArrayList();

        public WS_Satis.ZkmobilMatlist[] sas_fs = new KoctasMobil.WS_Satis.ZkmobilMatlist[1000];
        public DateTime belgeTarihi, kayitTarihi;
        public string irsNo;
        public int siparis_sayisi;
        public int sas_lenght;
        public bool Horoz = false;
        const decimal YÜZDEONBEŞ = 1.15M;
        public string sevkiyatNo = "";

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FIT_Malgiris_Load(object sender, EventArgs e)
        {
            dt_mal = new DataTable();
            dt_mal.Columns.Add("matnr");
            dt_mal.Columns.Add("maktx");
            dt_mal.Columns.Add("S");
            dt_mal.Columns.Add("menge", typeof(decimal));
            dt_mal.Columns.Add("meins");
            dt_mal.Columns.Add("ebeln");
            dt_mal.Columns.Add("werks");
            dt_mal.Columns.Add("ebelp");
            dt_mal.Columns.Add("lgort");
            dt_mal.Columns.Add("Amenge");
            //dt_mal.Columns.Add("frbnr");
            this.WindowState = FormWindowState.Maximized;
            lbl_horoz.Visible = Horoz;
            txt_Horoz.Visible = Horoz;
            txt_Horoz.Text = sevkiyatNo;
            txt_Horoz.ReadOnly = Horoz;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txt_malzemeno.Text) || String.IsNullOrEmpty(txt_miktar.Text))
                {
                    return;
                }


                if ((Horoz == true) && (String.IsNullOrEmpty(txt_Horoz.Text)))
                {
                    MessageBox.Show("Sevkiyat No Alanını Giriniz", "HATA");
                    return;
                }

                /*
                if ((Horoz == true) && (txt_Horoz.Text != ""))
                {
                    Cursor.Current = Cursors.WaitCursor;
                    // Horoz sevkiyat numarasi sistemde var mi kontrol
                    // ediliyor. - 26.12.2010 - Added by BrkSnmz
                    WS_Satis.SERVICE srv = new KoctasMobil.WS_Satis.SERVICE();
                    WS_Satis.ZktmobilHrzSevkiyat hrzChk = new KoctasMobil.WS_Satis.ZktmobilHrzSevkiyat();
                    WS_Satis.ZktmobilHrzSevkiyatResponse hrzChkRes = new KoctasMobil.WS_Satis.ZktmobilHrzSevkiyatResponse();
                                        
                    srv.Url = Utility.getWsUrl("zktmobil_satis");
                    srv.Credentials = ProgramGlobalData.g_credential;

                    hrzChk.ImSevkno = txt_Horoz.Text.Trim();
                    hrzChkRes = srv.ZktmobilHrzSevkiyat(hrzChk);

                    if (hrzChkRes.ExReturn == "0")
                    {
                        MessageBox.Show("Sevkiyat Numarası Bulunmamaktadır.", "HATA");
                        Cursor.Current = Cursors.Default;
                        return;
                    }
                }*/

                bool miktar_aşımı = false;
                Int64 matnr = Convert.ToInt64(txt_malzemeno.Text.Trim()); //140509
                //malzeme kontrol yap.
                if (materials.Contains(matnr))
                {
                    decimal miktar = decimal.Parse(txt_miktar.Text.Trim());
                    decimal kalan_miktar = miktar;
                    decimal eklenen_miktar = 0;
                    string siparisNo = "";
                    decimal kontrolMiktar = 0;

                    //barkod no ile gelen malzemenin 'malzeme no' su bulunuyor
                    for (int i = 0; i < sas_lenght; i++)
                    {
                        if ((Convert.ToInt64(sas_fs[i].Ean11.Trim()) == matnr && Convert.ToInt64(sas_fs[i].Matnr.Trim()) != matnr))
                        {
                            matnr = Convert.ToInt64(sas_fs[i].Matnr.Trim());
                            break;
                        }
                    }

                    //malzemenin bütün siparişlerdeki toplam miktarı:
                    decimal max_menge = 0;
                    for (int i = 0; i < sas_lenght; i++)
                    {
                        //Eger horoz siparişi ise Amenge miktarı kontrol ediliyor
                        if (Horoz == true)
                        {
                            kontrolMiktar = sas_fs[i].Amenge;
                        }
                        else
                        {
                            kontrolMiktar = sas_fs[i].Menge;
                        }


                        if ((Convert.ToInt64(sas_fs[i].Ean11.Trim()) == matnr || Convert.ToInt64(sas_fs[i].Matnr.Trim()) == matnr) && (siparisNo != sas_fs[i].Ebeln.ToString().Trim()))
                        {
                            max_menge += kontrolMiktar;
                            siparisNo = sas_fs[i].Ebeln.ToString().Trim();

                        }
                    }

                    //Malzeme daha önce eklenmişse eklenen miktarları devral
                    for (int i = 0; i < dt_mal.Rows.Count; i++)
                    {
                        if ((Convert.ToInt64(dt_mal.Rows[i]["matnr"].ToString()) == matnr))
                        {
                            miktar += Convert.ToDecimal(dt_mal.Rows[i]["menge"].ToString());
                        }
                    }

                    if (Horoz == true)
                    {
                        if (miktar > max_menge)
                        {
                            MessageBox.Show("Girmek istediğiniz miktar açık sipariş miktarından fazla olamaz", "HATA");
                            return;
                        }
                    }

                    if (miktar > max_menge)
                    {
                        if (MessageBox.Show("Girmek istediğiniz miktar açık sipariş miktarından fazla. Yine de eklemek istiyor musunuz?", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) == DialogResult.No)
                        {
                            return;
                        }
                    }

                    kalan_miktar = miktar;

                    #region ÇIKARILAN %15 KONTROLÜ
                    //miktar max miktarı aşıyor mu?:
                    //if (miktar > max_menge)
                    //{
                    //    //miktar, max miktarı en fazla yüzde 15 aşabilir :
                    //    if (miktar > max_menge * YÜZDEONBEŞ)
                    //    {
                    //        MessageBox.Show("Miktar " + max_menge.ToString() + "'i yüzde 15den fazla aşamaz.");
                    //        return;
                    //    }
                    //    miktar_aşımı = true;
                    //}

                    ////eklemeden önce, aynı malzeme daha önce eklenmişse sil:
                    //for (int i = 0; i < dt_mal.Rows.Count; i++)
                    //{
                    //    if (Convert.ToInt64(dt_mal.Rows[i]["matnr"].ToString()) == matnr)
                    //    {
                    //        dt_mal.Rows.RemoveAt(i);
                    //        i--;
                    //    }
                    //}

                    ////ekle                    
                    //for (int i = 0; i < sas_lenght; i++)
                    //{
                    //    if (Convert.ToInt64(sas_fs[i].Ean11.Trim()) == matnr || Convert.ToInt64(sas_fs[i].Matnr) == matnr)
                    //    {
                    //        if (kalan_miktar > (sas_fs[i].Menge * YÜZDEONBEŞ))
                    //        {
                    //            if (miktar_aşımı) //miktar aşımı varsa siparişlerdeki miktarların %15 fazlaları kullanılır, yoksa sipparişteki miktar kullanılır.
                    //            {
                    //                miktar = sas_fs[i].Menge * YÜZDEONBEŞ;
                    //            }
                    //            else
                    //            {
                    //                miktar = sas_fs[i].Menge;
                    //            }
                    //        }
                    //        else
                    //        {
                    //            miktar = kalan_miktar;
                    //        }
                    //        kalan_miktar = kalan_miktar - miktar;
                    //        DataRow row = dt_mal.NewRow();
                    //        row["matnr"] = sas_fs[i].Matnr;
                    //        row["maktx"] = sas_fs[i].Maktx;
                    //        row["menge"] = miktar;
                    //        row["meins"] = sas_fs[i].Meins;
                    //        row["ebeln"] = sas_fs[i].Ebeln;
                    //        row["ebelp"] = sas_fs[i].Ebelp;
                    //        row["werks"] = sas_fs[i].Werks;
                    //        row["lgort"] = sas_fs[i].Lgort;
                    //        if (chk_Son.Checked || miktar >= sas_fs[i].Menge)
                    //        {
                    //            row["S"] = "X";
                    //        }
                    //        dt_mal.Rows.Add(row);
                    //        grd_mal.DataSource = null;
                    //        grd_mal.DataSource = dt_mal;

                    //        if (kalan_miktar == 0)
                    //        {
                    //            break;
                    //        }
                    //    }
                    //}
                    //txt_malzemeno.Text = "";
                    //txt_miktar.Text = "";
                    //txt_malzemeno.Focus();
                    //chk_Son.Checked = false;
                    #endregion

                    //eklemeden önce, aynı malzeme daha önce eklenmişse sil:
                    for (int i = 0; i < dt_mal.Rows.Count; i++)
                    {
                        if ((Convert.ToInt64(dt_mal.Rows[i]["matnr"].ToString()) == matnr))
                        {
                            dt_mal.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                    //bu malzemeye ait olan siparişlerin alınması
                    WS_Satis.ZkmobilMatlist[] sas_mat = new KoctasMobil.WS_Satis.ZkmobilMatlist[1000];

                    
                    int inx = 0;
                    siparisNo = "";
                    for (int i = 0; i < sas_lenght; i++)
                    {
                        if (ConvertInt64(sas_fs[i].Ean11.Trim()) == matnr || ConvertInt64(sas_fs[i].Ean112.Trim()) == matnr || ConvertInt64(sas_fs[i].Matnr) == matnr)
                        {
                            if (siparisNo != sas_fs[i].Ebeln.ToString().Trim())
                            {
                                sas_mat[inx] = sas_fs[i];
                                inx++;
                                siparisNo = sas_fs[i].Ebeln.ToString().Trim();
                            }
                        }
                    }
                    for (int i = 0; i < inx; i++)
                    {

                        //Eger horoz siparişi ise Amenge miktarı kontrol ediliyor
                        if (Horoz == true)
                        {
                            kontrolMiktar = sas_mat[i].Amenge;
                        }
                        else
                        {
                            kontrolMiktar = sas_mat[i].Menge;
                        }

                        if (kalan_miktar > (kontrolMiktar)) //Son siparişe kadar, sipariş miktarlarını kapatarak git
                        {
                            miktar = kontrolMiktar;
                        }
                        else
                        {
                            miktar = kalan_miktar;
                        }
                        kalan_miktar = kalan_miktar - miktar;
                        DataRow row = dt_mal.NewRow();
                        row["matnr"] = sas_mat[i].Matnr;
                        row["maktx"] = sas_mat[i].Maktx;
                        row["menge"] = miktar;
                        eklenen_miktar += miktar;
                        row["meins"] = sas_mat[i].Meins;
                        row["ebeln"] = sas_mat[i].Ebeln;
                        row["ebelp"] = sas_mat[i].Ebelp;
                        row["werks"] = sas_mat[i].Werks;
                        row["lgort"] = sas_mat[i].Lgort;

                        //row["frbnr"] = txt_Horoz.Text.Trim() ;
                        if (chk_Son.Checked || miktar >= kontrolMiktar)
                        {
                            row["S"] = "X";
                            //dt_mal.Rows.Add(row);
                            dt_mal.Rows.InsertAt(row, 0);
                        }
                        //Sipariş miktarındaki miktardan fazla miktar eklenmiş ise
                        else if ((Horoz == false) && (eklenen_miktar >= kontrolMiktar))
                        {
                            //row["S"] = "X";
                            dt_mal.Rows[dt_mal.Rows.Count - 1]["menge"] = (Convert.ToDecimal(dt_mal.Rows[dt_mal.Rows.Count - 1]["menge"].ToString()) + miktar).ToString();

                        }
                        else
                        {
                            //dt_mal.Rows.Add(row);
                            dt_mal.Rows.InsertAt(row, 0);
                        }


                        //dt_mal.Rows.Add(row);
                        grd_mal.DataSource = null;
                        grd_mal.DataSource = dt_mal;

                        if (kalan_miktar == 0)
                        {
                            break;
                        }
                    }
                    if (kalan_miktar > 0) //Kalan miktarın tamamını son siparişe ekle.
                    {

                        //decimal sonMiktar = Convert.ToDecimal(dt_mal.Rows[dt_mal.Rows.Count - 1]["menge"].ToString()) + kalan_miktar;
                        //dt_mal.Rows[dt_mal.Rows.Count - 1]["menge"] = sonMiktar.ToString();
                        decimal sonMiktar = Convert.ToDecimal(dt_mal.Rows[0]["menge"].ToString()) + kalan_miktar;
                        dt_mal.Rows[0]["menge"] = sonMiktar.ToString();

                        //DataRow row = dt_mal.NewRow();
                        //row["matnr"] = sas_mat[inx - 1].Matnr;
                        //row["maktx"] = sas_mat[inx - 1].Maktx;
                        //row["menge"] = kalan_miktar;
                        //row["meins"] = sas_mat[inx - 1].Meins;
                        //row["ebeln"] = sas_mat[inx - 1].Ebeln;
                        //row["ebelp"] = sas_mat[inx - 1].Ebelp;
                        //row["werks"] = sas_mat[inx - 1].Werks;
                        //row["lgort"] = sas_mat[inx - 1].Lgort;
                        //if (chk_Son.Checked || miktar >= sas_mat[inx - 1].Menge)
                        //{
                        //   row["S"] = "X";
                        //}
                        //dt_mal.Rows.Add(row);
                        grd_mal.DataSource = null;
                        grd_mal.DataSource = dt_mal;
                    }
                    txt_malzemeno.Text = txt_miktar.Text = "";
                    txt_malzemeno.Focus();

                    Cursor.Current = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Bu malzeme girilen siparişlerde bulunmuyor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Satis.SERVICE srv = new KoctasMobil.WS_Satis.SERVICE();
                WS_Satis.ZkmobilMgH mgh = new KoctasMobil.WS_Satis.ZkmobilMgH();
                WS_Satis.ZkmobilMgI[] mgi = new KoctasMobil.WS_Satis.ZkmobilMgI[dt_mal.Rows.Count];
                WS_Satis.ZkmobilReturn[] ret = new KoctasMobil.WS_Satis.ZkmobilReturn[0];
                WS_Satis.ZktmobilMgCreate2 cre = new KoctasMobil.WS_Satis.ZktmobilMgCreate2();
                WS_Satis.ZktmobilMgCreate2Response resp = new KoctasMobil.WS_Satis.ZktmobilMgCreate2Response();

                mgh.RefDocNo = irsNo;
                //mgh.PrUname = Program.username ;
                if (Horoz)
                {
                    mgh.Frbnr = txt_Horoz.Text.Trim();
                }

                

                for (int i = 0; i < dt_mal.Rows.Count; i++)
                {
                    mgi[i] = new KoctasMobil.WS_Satis.ZkmobilMgI();
                    mgi[i].Plant = dt_mal.Rows[i]["werks"].ToString();
                    mgi[i].StgeLoc = dt_mal.Rows[i]["lgort"].ToString();
                    mgi[i].EntryQnt = decimal.Parse(dt_mal.Rows[i]["menge"].ToString());
                    mgi[i].PoNumber = dt_mal.Rows[i]["ebeln"].ToString();
                    mgi[i].PoItem = dt_mal.Rows[i]["ebelp"].ToString();
                    if (dt_mal.Rows[i]["S"].ToString() == "X")
                    {
                        mgi[i].Elikz = "X";
                    }
                }

                

                cre.IHeader = mgh;
                cre.TeReturn = ret;
                cre.TiItems = mgi;

                cre.IDocDate = belgeTarihi.ToString("yyyy-MM-dd");
                cre.IPstngDate = kayitTarihi.ToString("yyyy-MM-dd");

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

        private void txt_miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (Horoz == true)
                {
                    txt_Horoz.Focus();
                }
                else
                {
                    btn_Ekle_Click(txt_miktar, new EventArgs());
                }

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
                txt_miktar.Focus();
            }
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

        private void txt_Horoz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_Ekle_Click(txt_Horoz, new EventArgs());
            }
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


    }
}