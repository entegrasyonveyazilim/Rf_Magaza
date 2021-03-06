using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{

    public partial class frm_UrunTeslimat : Form
    {
        public frm_UrunTeslimat()
        {
            InitializeComponent();
        }

        DataTable dtTeslimat = new DataTable();
        private void frm_Etiket_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            dtTeslimat.Columns.Add("VBELN");
            dtTeslimat.Columns.Add("POSNR");
            dtTeslimat.Columns.Add("MATNR");
            dtTeslimat.Columns.Add("MENGE");
            dtTeslimat.Columns.Add("ISET");
            dtTeslimat.PrimaryKey = new DataColumn[] { dtTeslimat.Columns["MATNR"] };
        }

        private bool isINT(string value)
        {
            try
            {
                //int.Parse(value);
                decimal.Parse(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        WS_Satis.ZodendiBlg[] ZodendiBlg;
        WS_Satis.Zset[] ZodendiSet;
        string formNo = "";
        private void txtFormNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {   
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    WS_Satis.SERVICE srv = new KoctasMobil.WS_Satis.SERVICE();
                    srv.Url = Utility.getWsUrl("zktmobil_satis");
                    srv.Credentials = ProgramGlobalData.g_credential;                    

                    WS_Satis.ZktmobilOdendi odendi = new KoctasMobil.WS_Satis.ZktmobilOdendi();
                    odendi.ImVbeln = txtFormNo.Text.Trim();
                    odendi.ItOdendi = new KoctasMobil.WS_Satis.ZodendiBlg[0];
                    odendi.ItSet = new KoctasMobil.WS_Satis.Zset[0];
                    odendi.TeReturn = new KoctasMobil.WS_Satis.ZkmobilReturn[0];

                    WS_Satis.ZktmobilOdendiResponse rsp = srv.ZktmobilOdendi(odendi);

                    if (rsp.ItOdendi != null)
                    {
                        ZodendiBlg = rsp.ItOdendi;
                        ZodendiSet = rsp.ItSet;
                        formNo = txtFormNo.Text.Trim();
                        txtMatnrEan11.Focus();
                    }
                    if (rsp.TeReturn.Length > 0)
                    {
                        if (rsp.TeReturn[0].RcCode == "E")
                        {
                            MessageBox.Show(rsp.TeReturn[0].RcText, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                        }
                    }
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
        }

        private void txtMenge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (txtFormNo.Text.Trim() == string.Empty && ZodendiBlg == null)
                {
                    MessageBox.Show("Form No alanı boş geçilemez.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtFormNo.Focus();
                    return;
                }

                if (txtMatnrEan11.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Malzeme No alanı boş geçilemez.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtMatnrEan11.Focus();
                    return;
                }

                if (!isINT(txtMenge.Text.Trim()))
                {
                    MessageBox.Show("Miktar alanına sayısal bir değer giriniz.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtMenge.Text = "";
                    txtMenge.Focus();
                    return;
                }

                string Matnr = getMatnr(txtMatnrEan11.Text.Trim());
                if (Matnr == string.Empty)
                {
                    MessageBox.Show("Malzeme No bulunamadı.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtMatnrEan11.Text = txtMenge.Text = ""; txtMatnrEan11.Focus();
                    return;
                }

                //normal sipariþ tablosu kontrol edilyor
                if (ZodendiBlg != null)
                {
                    bool isExists = false;
                    bool isSet = false;
                    string setMatnr = "";
                    
                    //Normal ürünler içerisinde aranýyor
                    for (int i = 0; i < ZodendiBlg.Length; i++)
                    {
                        if (ZodendiBlg[i].Matnr.TrimStart('0') == Matnr)
                        {
                            isExists = true;
                        }
                            
                    }

                    //Eðer normal sipariþ listesinde yok ise, set ürünler listesinde aranýyor
                    if (!isExists)
                    {
                        for (int i = 0; i < ZodendiSet.Length; i++)
                        {
                            if (ZodendiSet[i].Idnrk.TrimStart('0') == Matnr)
                            {
                                isSet = true;
                                setMatnr = ZodendiSet[i].Matnr.TrimStart('0');
                            }

                        }
                    }

                    if (isExists)
                    {                        
                        //int txtMengeCount = Convert.ToInt32(txtMenge.Text.Trim());
                        decimal txtMengeCount = Convert.ToDecimal(txtMenge.Text.Trim());
                        decimal TotalCount = getMatnrCount(Matnr);

                        if (txtMengeCount > TotalCount)
                        {
                            MessageBox.Show("Fazla ürün girişi yapılamaz !", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                            txtMenge.Text = "";
                            txtMenge.Focus();
                            return;
                        }

                        for (int i = 0; i < dtTeslimat.Rows.Count; i++)
                        {
                            if (dtTeslimat.Rows[i]["MATNR"].ToString() == Matnr)
                            {
                                decimal dtTeslimatCount = Convert.ToDecimal(dtTeslimat.Rows[i]["MENGE"]);                              

                                if (dtTeslimatCount + txtMengeCount > TotalCount)
                                {
                                    MessageBox.Show("Fazla ürün girişi yapılamaz !", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                                }
                                else
                                {
                                    dtTeslimat.Rows[i]["MENGE"] = dtTeslimatCount + txtMengeCount;
                                }

                                txtMatnrEan11.Text = txtMenge.Text = ""; txtMatnrEan11.Focus();
                                return;
                            }
                        }

                        DataRow dr = dtTeslimat.NewRow();
                        dr["VBELN"] = formNo.ToString();
                        dr["POSNR"] = getMatnrPosNr(Matnr);
                        dr["MATNR"] = Matnr;
                        dr["MENGE"] = txtMenge.Text.Trim();
                        dr["ISET"] = "";
                        dtTeslimat.Rows.Add(dr);

                        grdUrunTeslimat.DataSource = dtTeslimat;
                        txtMatnrEan11.Text = txtMenge.Text = ""; txtMatnrEan11.Focus();
                    }
                    //Eger urun set urun ise
                    else if (isSet)
                    {

                        bool setMasterOk = false;

                        //Urun set olarak gelmiþ ve set master urunu listeye eklenmiþ mi kontrol ediliyor
                        //setMatnr
                        for (int i = 0; i < dtTeslimat.Rows.Count; i++)
                        {
                            if (dtTeslimat.Rows[i]["MATNR"].ToString() == setMatnr)
                            {
                                setMasterOk = true;
                            }
                        }
                        if (!setMasterOk)
                        {
                            MessageBox.Show("Set ürüne ait bir kalem eklemeden önce set ürünün kendisini eklemelisiniz!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                            txtMatnrEan11.Text = txtMenge.Text = ""; txtMatnrEan11.Focus();
                            return;
                        }
                        
                        decimal txtMengeCount = Convert.ToDecimal(txtMenge.Text.Trim());
                        //set içindeki malzemenin birim miktarý
                        decimal TotalCount = getSetMatnrCount(Matnr);

                        if (txtMengeCount > TotalCount)
                        {
                            MessageBox.Show("Fazla ürün giriþi yapılamaz !", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                            txtMenge.Text = "";
                            txtMenge.Focus();
                            return;
                        }

                        

                        for (int i = 0; i < dtTeslimat.Rows.Count; i++)
                        {
                            if (dtTeslimat.Rows[i]["MATNR"].ToString() == Matnr)
                            {
                                decimal dtTeslimatCount = Convert.ToDecimal(dtTeslimat.Rows[i]["MENGE"]);

                                if (dtTeslimatCount + txtMengeCount > TotalCount)
                                {
                                    MessageBox.Show("Fazla ürün girişi yapılamaz !", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                                }
                                else
                                {
                                    dtTeslimat.Rows[i]["MENGE"] = dtTeslimatCount + txtMengeCount;
                                }

                                txtMatnrEan11.Text = txtMenge.Text = ""; txtMatnrEan11.Focus();
                                return;
                            }
                        }

                        DataRow dr = dtTeslimat.NewRow();
                        dr["VBELN"] = formNo.ToString();
                        dr["MATNR"] = Matnr;
                        dr["MENGE"] = txtMenge.Text.Trim();
                        dr["ISET"] = "X";
                        string setMaster = getMatnrFromSet(Matnr);
                        dr["POSNR"] = getMatnrPosNr(setMaster);
                        
                        dtTeslimat.Rows.Add(dr);

                        grdUrunTeslimat.DataSource = dtTeslimat;
                        txtMatnrEan11.Text = txtMenge.Text = ""; txtMatnrEan11.Focus();
                    } 
                    else
                    {
                        MessageBox.Show("Ürün listede mevcut değil!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        txtMatnrEan11.Text = txtMenge.Text = ""; txtMatnrEan11.Focus();
                    }
                }
            }
        }

        private decimal getMatnrCount(string Matnr)
        {
            for (int i = 0; i < ZodendiBlg.Length; i++)
            {
                if (ZodendiBlg[i].Matnr.TrimStart('0') == Matnr)
                    return (decimal)ZodendiBlg[i].Menge;
            }
            return 0;
        }

        private string getMatnrPosNr(string Matnr)
        {
            for (int i = 0; i < ZodendiBlg.Length; i++)
            {
                if (ZodendiBlg[i].Matnr.TrimStart('0') == Matnr)
                    return (string)ZodendiBlg[i].Posnr.ToString();
            }
            return "";
        }

        private string getMatnrFromSet(string Matnr)
        {
            for (int i = 0; i < ZodendiSet.Length; i++)
            {
                if (ZodendiSet[i].Idnrk.TrimStart('0') == Matnr)
                    return (string)ZodendiSet[i].Matnr.ToString().TrimStart('0');
            }
            return "";
        }

        private decimal getSetMatnrCount(string Matnr)
        {
            for (int i = 0; i < ZodendiSet.Length; i++)
            {
                if (ZodendiSet[i].Idnrk.TrimStart('0') == Matnr)
                    return (decimal)ZodendiSet[i].Menge;
            }
            return 0;
        }

        private string getMatnr(string MatnrEan11)
        {
            Cursor.Current = Cursors.WaitCursor;
            WS_Kontrol.service srv = new KoctasMobil.WS_Kontrol.service();
            srv.Url = Utility.getWsUrl("zktmobil_kontrol");
            srv.Credentials = ProgramGlobalData.g_credential;
            
            WS_Kontrol.ZktmobilChckMtnr mtnr = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnr();
            mtnr.IMatnr = MatnrEan11;
            WS_Kontrol.ZktmobilChckMtnrResponse matresp = new KoctasMobil.WS_Kontrol.ZktmobilChckMtnrResponse();

            try
            {   
                matresp = srv.ZktmobilChckMtnr(mtnr);

                if (matresp.EReturn.RcCode == "E")
                {
                    throw new Exception(matresp.EReturn.RcText);
                }

                return matresp.EMatnr;
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                return "";
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            txtMenge_KeyPress(btn_Ekle, new KeyPressEventArgs((char)13));
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            for (int i = dtTeslimat.Rows.Count - 1; i >= 0; i--)
                if (grdUrunTeslimat.IsSelected(i))
                    dtTeslimat.Rows.RemoveAt(i);
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            for (int i = dtTeslimat.Rows.Count - 1; i >= 0; i--)
                dtTeslimat.Rows.RemoveAt(i);
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            
            //Eklenen urunler kontrol ediliyor
            if (dtTeslimat.Rows.Count > 0)
            {
                try
                {

                    Cursor.Current = Cursors.WaitCursor;
                    WS_Satis.ZodendiBlg[] dtUrunler = new KoctasMobil.WS_Satis.ZodendiBlg[dtTeslimat.Rows.Count];
                    
                    for (int j = 0; j < dtTeslimat.Rows.Count; j++)
                    {
                        if (dtTeslimat.Rows[j]["MATNR"].ToString() != "") {
                            dtUrunler[j] = new KoctasMobil.WS_Satis.ZodendiBlg();
                            dtUrunler[j].Matnr = dtTeslimat.Rows[j]["MATNR"].ToString();
                            dtUrunler[j].Menge = Convert.ToDecimal(dtTeslimat.Rows[j]["MENGE"].ToString());
                            dtUrunler[j].Posnr = dtTeslimat.Rows[j]["POSNR"].ToString();
                            dtUrunler[j].Vbeln = dtTeslimat.Rows[j]["VBELN"].ToString();
                            dtUrunler[j].ISet = dtTeslimat.Rows[j]["ISET"].ToString();

                            
                        }
                    }

                    WS_Satis.SERVICE srv = new KoctasMobil.WS_Satis.SERVICE();
                    srv.Url = Utility.getWsUrl("zktmobil_satis");
                    srv.Credentials = ProgramGlobalData.g_credential;

                    WS_Satis.ZktmobilOdendiKayit odendiKayit = new KoctasMobil.WS_Satis.ZktmobilOdendiKayit();
                    odendiKayit.Itab = dtUrunler;
                    odendiKayit.TeReturn = new KoctasMobil.WS_Satis.ZkmobilReturn[0];

                    WS_Satis.ZktmobilOdendiKayitResponse rsp = srv.ZktmobilOdendiKayit(odendiKayit);

                    MessageBox.Show("İşlem tamamlandı.", "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);

                    txtFormNo.Text = txtMatnrEan11.Text = txtMenge.Text = "";
                    dtTeslimat.Rows.Clear();
                    ZodendiBlg = null;
                    txtFormNo.Focus();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                MessageBox.Show("Formu kaydetmeden önce malzemeleri ekleyiniz.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                return;
            }
            
            
            /*
            for (int i = 0; i < ZodendiBlg.Length; i++)
            {
                bool FindIt = false;
                for (int j = 0; j < dtTeslimat.Rows.Count; j++)
                {
                    if (dtTeslimat.Rows[j]["MATNR"].ToString() == ZodendiBlg[i].Matnr.TrimStart('0') &&
                        dtTeslimat.Rows[j]["MENGE"].ToString() == Convert.ToInt32(ZodendiBlg[i].Menge).ToString()
                        )
                        FindIt = true;
                }
                if (!FindIt)
                {
                    MessageBox.Show("Eksik ürün giriþi yaptýnýz!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            */
        }

        private void txtMatnrEan11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtMenge.Focus();
            }
        }
    }
}