using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_AdreslemeUrunKontrol : Form
    {
        public frm_AdreslemeUrunKontrol()
        {
            InitializeComponent();
        }


        string malzemeNo = "";
        string malzemeTanim = "";
        string depoYeri = "";
        DataTable drMal = new DataTable();


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

        private void btn_Getir_Click(object sender, EventArgs e)
        {
            
            if (txt_malzemeNo.Text == "")
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            try
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
                    depoYeri = cmbDepoYeri.SelectedItem.ToString();

                    //Malzemenin adresleme bilgileri cekiliyor...
                    WS_Kontrol.ZmbMalzemeAdres[] zmbAdres =  new KoctasMobil.WS_Kontrol.ZmbMalzemeAdres[1];

                    WS_Kontrol.ZktmobilMalzemeAdrsMiktar malAdresMiktar = new KoctasMobil.WS_Kontrol.ZktmobilMalzemeAdrsMiktar();
                    WS_Kontrol.ZktmobilMalzemeAdrsMiktarResponse resp = new KoctasMobil.WS_Kontrol.ZktmobilMalzemeAdrsMiktarResponse();

                    malAdresMiktar.Itab = zmbAdres;
                    malAdresMiktar.ImMatnr = malzemeNo;
                    malAdresMiktar.ImLgort = depoYeri;

                    srv.Credentials = ProgramGlobalData.g_credential;
                    srv.Url = Utility.getWsUrl("zktmobil_kontrol");
                    resp = srv.ZktmobilMalzemeAdrsMiktar(malAdresMiktar);

                    if (resp.Itab.Length <= 0)
                    {
                        //Eger adres listesi boş ise
                        grd_mal.DataSource = null;
                        MessageBox.Show("Belirtilen ürüne ait adresleme bulunamadı", "HATA");
                    }
                    else
                    {
                        //grd_mal listesi dolduruluyor
                        drMal.Clear();
                        for (int i = 0; i < resp.Itab.Length; i++)
                        {
                            DataRow row = drMal.NewRow();
                            row["Matnr"] = malzemeNo;
                            row["Lgort"] = depoYeri;
                            row["Menge"] = resp.Itab[i].Menge.ToString();
                            row["Meins"] = resp.Itab[i].Meins.ToString();
                            row["Nlpla"] = resp.Itab[i].Lgpla.ToString();
                            drMal.Rows.Add(row);
                        }

                        grd_mal.DataSource = null;
                        grd_mal.DataSource = drMal;
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

        private void frm_AdreslemeUrunKontrol_Load(object sender, EventArgs e)
        {

            drMal = new DataTable();
            drMal.Columns.Add("Matnr");
            drMal.Columns.Add("Lgort");
            drMal.Columns.Add("Menge");
            drMal.Columns.Add("Meins");
            drMal.Columns.Add("Nlpla");

            depoYeriDoldur();
        }

        private void txt_malzemeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)13))
            {
                btn_Getir_Click(new object(), new EventArgs());
            }
        }


    }
}