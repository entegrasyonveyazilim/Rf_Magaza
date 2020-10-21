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
    public partial class frm_malgirisDepo : Form
    {

        ArrayList materials = new ArrayList();
        WS_Satis.ZkmobilMatlist[] sas_fs = new KoctasMobil.WS_Satis.ZkmobilMatlist[1000];
        int lenght = 0;
        
        public frm_malgirisDepo()
        {
            InitializeComponent();
        }

        private void frm_malgirisDepo_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dtp_belge.Format = DateTimePickerFormat.Custom;
            dtp_belge.CustomFormat = "dd-MM-yyyy";

            dtp_kayit.Format = DateTimePickerFormat.Custom;
            dtp_kayit.CustomFormat = "dd-MM-yyyy";
        }

        private void btn_SevkiyatNo_Kontrol_Click(object sender, EventArgs e)
        {
            if (txtSevkiyatNo.Text.Trim() == "")
            {
                MessageBox.Show("Sevkiyat No giriniz", "HATA");
                return;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                WS_Satis.SERVICE srv = new KoctasMobil.WS_Satis.SERVICE();
                WS_Satis.ZmbSevkiyatHrzDty[] itDetay = new KoctasMobil.WS_Satis.ZmbSevkiyatHrzDty[0];
                WS_Satis.ZmbSevkiyatHrz[] itSevkiyat = new KoctasMobil.WS_Satis.ZmbSevkiyatHrz[0];
                WS_Satis.ZktmobilSevkiyatSiparis ss = new KoctasMobil.WS_Satis.ZktmobilSevkiyatSiparis();
                WS_Satis.ZktmobilSevkiyatSiparisResponse resp = new KoctasMobil.WS_Satis.ZktmobilSevkiyatSiparisResponse();

                ss.ItDetay = itDetay;
                ss.ItSevkiyat = itSevkiyat;
                ss.ImSevkno = txtSevkiyatNo.Text.Trim().ToUpper();
                ss.ImDetay = "X";


                srv.Credentials = ProgramGlobalData.g_credential;
                srv.Url = Utility.getWsUrl("zktmobil_satis");
                resp = srv.ZktmobilSevkiyatSiparis(ss);



                // Eger kontrol sonrasýnda hiçbir sipariş dönmüyorsa 
                // uyarı veriliyor
                if (resp.ItSevkiyat.Length == 0)
                {
                    MessageBox.Show("Belirtilen sevkiyat numarasına ait sipariş listesi bulunamadı", "HATA");
                    Cursor.Current = Cursors.Default;
                    return;
                }
                else if (resp.ItSevkiyat.Length > 0)
                {
                    //lst_Siparis.Items.Clear();
                    for (int i = 0; i < resp.ItSevkiyat.Length; i++)
                    {
                        string sipNo = resp.ItSevkiyat[i].Ebeln.ToString().Trim();

                        //Herbir siparis detayi cekiliyor

                        WS_Satis.SERVICE srv2 = new KoctasMobil.WS_Satis.SERVICE();
                        WS_Satis.ZkmobilMatlist[] matlist = new KoctasMobil.WS_Satis.ZkmobilMatlist[0];
                        WS_Satis.ZkmobilReturn[] ret = new KoctasMobil.WS_Satis.ZkmobilReturn[0];
                        WS_Satis.ZktmobilMgCheckSas sas = new KoctasMobil.WS_Satis.ZktmobilMgCheckSas();
                        WS_Satis.ZktmobilMgCheckSasResponse resp2 = new KoctasMobil.WS_Satis.ZktmobilMgCheckSasResponse();


                        sas.TeMatlist = matlist;
                        sas.TeReturn = ret;
                        sas.IEbeln = sipNo;

                        //System.Net.NetworkCredential cr = new System.Net.NetworkCredential("berk", "Burak980");
                        //srv.Credentials = cr;

                        srv2.Credentials = ProgramGlobalData.g_credential;
                        srv2.Url = Utility.getWsUrl("zktmobil_satis");
                        resp2 = srv2.ZktmobilMgCheckSas(sas);




                        // Eger SAS kontrolu sonrasýnda siparis kaydi HOROZ'a ait bir 
                        // kayıt ise, checkbox ýn seçilmesi isteniyor.
                        if ((resp2.ExType1 == "1") && (!chk_horoz.Checked))
                        {
                            MessageBox.Show("Bu sipariş için 'Horoz Lojistik' kutusunu işaretleyiniz.", "HATA");
                        }
                        else if (resp2.TeReturn.Length > 0)
                        {
                            if (resp2.TeReturn[0].RcCode.ToUpper() == "S" && resp2.TeMatlist.Length > 0)
                            {
                                //lst_Siparis.Items.Add(sipNo);
                                lst_Siparis.Items.Insert(0, sipNo);
                                for (int j = 0; j < resp2.TeMatlist.Length; j++)
                                {
                                    try
                                    {
                                        materials.Add(Convert.ToInt64(resp2.TeMatlist[j].Ean11));
                                    }
                                    catch { }

                                    sas_fs[lenght] = resp2.TeMatlist[j];
                                    sas_fs[lenght].Ebeln = sipNo;


                                    //ilgili siparis ve malzeme numarasýna göre Amenge degeri bulunuyor
                                    if (resp.ItDetay.Length > 0)
                                    {
                                        for (int ii = 0; ii < resp.ItDetay.Length; ii++)
                                        {
                                            if ((resp.ItDetay[ii].Ebeln.ToString().Trim() == sipNo) && (resp.ItDetay[ii].Matnr.TrimStart('0').ToString() == sas_fs[lenght].Matnr))
                                            {
                                                //Acik siparis miktarlari Matlist tablosuna ataniyor
                                                sas_fs[lenght].Amenge = Convert.ToDecimal(resp.ItDetay[ii].Amenge.ToString());
                                                break;
                                            }
                                        }
                                    }


                                    lenght++;
                                }
                            }

                            //else
                            //{
                            //    MessageBox.Show(resp2.TeReturn[0].RcText, "HATA");
                            //}
                        }


                    }

                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                MessageBox.Show(ex.Message, "HATA");
            }

            if (lenght == 0)
            {
                MessageBox.Show("Girilen sevkiyat numarasına ait mal kabulu yapılacak sipariş listesi bulunmamaktadır.", "BİLGİ");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSevkiyatNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_SevkiyatNo_Kontrol_Click(new object(), new EventArgs());
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sipariþ_Click(object sender, EventArgs e)
        {
            if (lst_Siparis.Items.Count == 0 || txt_irsNo.Text.Trim() == "")
            {
                return;
            }
            try
            {
                frm_Malgiris2 frm = new frm_Malgiris2();
                frm.belgeTarihi = dtp_belge.Value;
                frm.kayitTarihi = dtp_kayit.Value;
                frm.materials = materials;
                frm.irsNo = txt_irsNo.Text.Trim();
                frm.sas_fs = sas_fs;
                frm.sas_lenght = lenght;
                frm.sevkiyatNo = txtSevkiyatNo.Text.Trim().ToUpper();

                //frm.siparis_sayisi = materials.Count / 2;
                frm.siparis_sayisi = lst_Siparis.Items.Count;
                frm.Horoz = chk_horoz.Checked;
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                lst_Siparis.Items.Clear();
                sas_fs = new KoctasMobil.WS_Satis.ZkmobilMatlist[1000];
                materials.Clear();
                lenght = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekran yenilenemedi: " + ex.Message, "HATA!");
                this.Close();
            }
        }


    }
}