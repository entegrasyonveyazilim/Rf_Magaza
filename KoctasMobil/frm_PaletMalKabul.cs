using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{

    public partial class frm_PaletMalKabul : Form
    {
        WS_Satis.ZktmobilPaletleMalKabul02Response paletMalzemeleri;
        WS_Satis.ZktmobilPaletleMalKabul03Response girisListe;

        DataTable _dt_palet;
        DataTable _dt_malzeme;
        DataTable _dt_total;
        DataTable _dt_total2;

        public frm_PaletMalKabul()
        {
            InitializeComponent();

            if (_dt_palet == null)
            {
                _dt_palet = new DataTable();
                _dt_palet.Columns.Add("PALETNO");
                _dt_palet.Columns.Add("TIP");
            }

            grd_Palet.DataSource = _dt_palet;
            SetPaletGridColumWidth();

            if (_dt_malzeme == null)
            {
                _dt_malzeme = new DataTable();
                _dt_malzeme.Columns.Add("MALZEMENO");
                _dt_malzeme.Columns.Add("MIKTAR");
            }

            grd_Malzeme.DataSource = _dt_malzeme;
            SetMalzemeGridColumWidth();

            if (_dt_total == null)
            {
                _dt_total = new DataTable();
                _dt_total.Columns.Add("G");
                _dt_total.Columns.Add("SASNO");
                _dt_total.Columns.Add("MALZEMENO");
                _dt_total.Columns.Add("NAKIL");
                _dt_total.Columns.Add("GIRIS");
                _dt_total.Columns.Add("FARK");
            }

            if (_dt_total2 == null)
            {
                _dt_total2 = new DataTable();
                _dt_total2.Columns.Add("GIRIS");
            }

            grd_Total.DataSource = _dt_total;
            SetTotalGridColumWidth();

            ShowFirstPanel();

            txt_TUNumarasi.Focus();
        }

        public void SetPaletGridColumWidth()
        {
            grd_Palet.TableStyles.Clear();
            DataGridTableStyle tableStyle = new DataGridTableStyle();
            tableStyle.MappingName = _dt_palet.TableName;

            foreach (DataColumn item in _dt_palet.Columns)
            {
                DataGridTextBoxColumn tbcName = new DataGridTextBoxColumn();

                switch (item.ColumnName)
                {
                    case "PALETNO":
                        tbcName.Width = 250;
                        break;
                    case "TIP":
                        tbcName.Width = 30;
                        break;
                    default:
                        break;
                }

                tbcName.MappingName = item.ColumnName;
                tbcName.HeaderText = item.ColumnName;
                tableStyle.GridColumnStyles.Add(tbcName);
            }

            grd_Palet.TableStyles.Add(tableStyle);
        }

        public void SetMalzemeGridColumWidth()
        {
            grd_Malzeme.TableStyles.Clear();
            DataGridTableStyle tableStyle = new DataGridTableStyle();
            tableStyle.MappingName = _dt_malzeme.TableName;

            foreach (DataColumn item in _dt_malzeme.Columns)
            {
                DataGridTextBoxColumn tbcName = new DataGridTextBoxColumn();

                switch (item.ColumnName)
                {
                    case "MALZEMENO":
                        tbcName.Width = 200;
                        break;
                    case "MIKTAR":
                        tbcName.Width = 75;
                        break;
                    default:
                        break;
                }

                tbcName.MappingName = item.ColumnName;
                tbcName.HeaderText = item.ColumnName;
                tableStyle.GridColumnStyles.Add(tbcName);
            }

            grd_Malzeme.TableStyles.Add(tableStyle);
        }

        public void SetTotalGridColumWidth()
        {
            grd_Total.TableStyles.Clear();
            DataGridTableStyle tableStyle = new DataGridTableStyle();
            tableStyle.MappingName = _dt_total.TableName;

            foreach (DataColumn item in _dt_total.Columns)
            {
                DataGridTextBoxColumn tbcName = new DataGridTextBoxColumn();

                switch (item.ColumnName)
                {
                    case "G":
                        tbcName.Width = 20;
                        break;
                    case "SASNO":
                        tbcName.Width = 75;
                        break;
                    case "MALZEMENO":
                        tbcName.Width = 75;
                        break;
                    case "NAKIL":
                        tbcName.Width = 38;
                        break;
                    case "GIRIS":
                        tbcName.Width = 38;
                        break;
                    case "FARK":
                        tbcName.Width = 38;
                        break;
                    default:
                        break;
                }

                tbcName.MappingName = item.ColumnName;
                tbcName.HeaderText = item.ColumnName;
                tableStyle.GridColumnStyles.Add(tbcName);
            }

            grd_Total.TableStyles.Add(tableStyle);
        }

        public void ShowFirstPanel()
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;

            panel1.Location = new Point(0, 0);
            panel1.Focus();
        }

        public void ShowSecondPanel()
        {
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;

            panel2.Location = new Point(0, 0);
            panel2.Focus();
        }

        public void ShowThirdPanel()
        {
            panel3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;

            panel3.Location = new Point(0, 0);
            panel3.Focus();
        }

        private void frm_PaletMalKabul_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_Listele_Click_1(object sender, EventArgs e)
        {
            TUListele();
        }

        private void btn_Devam_Click(object sender, EventArgs e)
        {
            PaletAc();
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Geri2_Click(object sender, EventArgs e)
        {
            ShowFirstPanel();
        }

        private void btn_Devam2_Click(object sender, EventArgs e)
        {
            MalzemeleriGonder();
        }

        private void btn_Geri3_Click(object sender, EventArgs e)
        {
            ShowSecondPanel();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            MalzemeEkle();
        }

        private void btn_MalGirisiPaletKapat_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in _dt_total.Rows)
            {
                decimal nakil = decimal.Parse(row["NAKIL"].ToString());
                decimal giris = decimal.Parse(row["GIRIS"].ToString());

                if (giris > nakil)
                {
                    string sasno = row["SASNO"].ToString();
                    string malzeme = row["MALZEMENO"].ToString();

                    MessageBox.Show(sasno + " SAS no'lu " + malzeme + " malzemede giriş miktarını nakil miktarından fazla olamaz.", 
                        "HATA!", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Hand, 
                        MessageBoxDefaultButton.Button1);

                    grd_Total.Select(_dt_total.Rows.IndexOf(row));
                    grd_Total.CurrentRowIndex = _dt_total.Rows.IndexOf(row);

                    return;
                }
            }

            Cursor.Current = Cursors.WaitCursor;
            WS_Satis.SERVICE SRV = new KoctasMobil.WS_Satis.SERVICE();
            WS_Satis.ZktmobilMalGirisi request = new KoctasMobil.WS_Satis.ZktmobilMalGirisi();
            WS_Satis.ZktmobilMalGirisiResponse response = new KoctasMobil.WS_Satis.ZktmobilMalGirisiResponse();

            try
            {
                SRV.Url = Utility.getWsUrl("zktmobil_satis");
                SRV.Credentials = ProgramGlobalData.g_credential;

                request.IvKayitTarih = DateTime.Parse(txt_KayitTarihi.Text).ToString("yyyy-MM-dd");

                var malGirisListe = new List<WS_Satis.ZktmobilStPaletMalkabul>();

                foreach (DataRow row in _dt_total.Rows)
                {
                    var tmp = new WS_Satis.ZktmobilStPaletMalkabul();

                    tmp.Matnr = row["MALZEMENO"].ToString();
                    tmp.Amenge = decimal.Parse(row["GIRIS"].ToString());
                    tmp.Ebeln = row["SASNO"].ToString();
                    
                    if (tmp.Amenge > 0)
                    {
                        foreach (var item in girisListe.EtMalGrsListe)
                        {
                            if (item.Matnr.TrimStart('0') == tmp.Matnr && item.Ebeln == tmp.Ebeln)
                            {
                                item.Amenge = decimal.Parse(row["GIRIS"].ToString());
                                
                                malGirisListe.Add(item); 
                            }
                        }
                    }
                }

                request.ItMalGrsListe = malGirisListe.ToArray();

                request.TeReturn = new KoctasMobil.WS_Satis.ZkmobilReturn[0];

                SRV.Timeout = 300000;

                response = SRV.ZktmobilMalGirisi(request);

                if (response.TeReturn.Length > 0)
                {
                    if (response.TeReturn[0].RcCode == "E")
                    {
                        MessageBox.Show(response.TeReturn[0].RcText, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        return;
                    }

                    if (response.TeReturn[0].RcCode == "S")
                    {
                        MessageBox.Show(response.TeReturn[0].RcText, "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    }
                }

                for (int i = 0; i < _dt_palet.Rows.Count; i++)
                {
                    if (_dt_palet.Rows[i]["PALETNO"].ToString() == txt_PaletNumarasi2.Text.Trim())
                    {
                        _dt_palet.Rows.Remove(_dt_palet.Rows[i]);

                        ShowFirstPanel();
                        txt_PaletNumarasi.Focus();

                        if (_dt_palet.Rows.Count == 0)
                        {
                            txt_TUNumarasi.Text = "";
                            txt_TUNumarasi.Focus();
                        }
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

        private void btn_MalGirisiTUKapat_Click(object sender, EventArgs e)
        {
            if (_dt_palet.Rows.Count > 0)
            {
                MessageBox.Show("Bu araçta işlem yapmadığınız paletler bulunuyor.", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            else
            {
                ShowFirstPanel();
                txt_TUNumarasi.Text = "";
                txt_PaletNumarasi.Text = "";
                txt_TUNumarasi.Focus();
            }
        }

        private void btn_GirisGuncelle_Click(object sender, EventArgs e)
        {
            GirisMiktariGuncelle();
        }

        private void txt_TUNumarasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TUListele();
            }
        }

        private void txt_Miktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MalzemeEkle();
            }
        }

        private void txt_MalzemeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txt_Miktar.Focus();
            }
        }

        private void txt_GirisGuncelleme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                GirisMiktariGuncelle();
            }
        }

        private void txt_PaletNumarasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PaletAc();
            }
        }

        private void grd_Total_CurrentCellChanged(object sender, EventArgs e)
        {
            txt_GirisGuncelleme.Focus();
        }

        private void grd_Palet_DoubleClick(object sender, EventArgs e)
        {
            PaletAc();
        }

        public void GirisMiktariGuncelle()
        {
            try
            {
                decimal yeniGirisMiktar = decimal.Parse(txt_GirisGuncelleme.Text.Trim());
                decimal ilkGirisMiktar = decimal.Parse(_dt_total2.Rows[grd_Total.CurrentCell.RowNumber]["GIRIS"].ToString());

                decimal farkMiktar = ilkGirisMiktar - yeniGirisMiktar;

                _dt_total.Rows[grd_Total.CurrentCell.RowNumber]["GIRIS"] = yeniGirisMiktar.ToString();
                _dt_total.Rows[grd_Total.CurrentCell.RowNumber]["FARK"] = farkMiktar.ToString();

                txt_GirisGuncelleme.Text = "";
            }
            catch { }
        }

        public void TUListele()
        {
            _dt_palet.Clear();

            Cursor.Current = Cursors.WaitCursor;
            WS_Satis.SERVICE SRV = new KoctasMobil.WS_Satis.SERVICE();
            WS_Satis.ZktmobilPaletleMalKabul01 request = new KoctasMobil.WS_Satis.ZktmobilPaletleMalKabul01();
            WS_Satis.ZktmobilPaletleMalKabul01Response response = new KoctasMobil.WS_Satis.ZktmobilPaletleMalKabul01Response();

            try
            {
                SRV.Url = Utility.getWsUrl("zktmobil_satis");
                SRV.Credentials = ProgramGlobalData.g_credential;

                request.IvKayitTarih = DateTime.Parse(txt_KayitTarihi.Text).ToString("yyyy-MM-dd");
                request.IvTuNumber = txt_TUNumarasi.Text.Trim();
                request.TeReturn = new KoctasMobil.WS_Satis.ZkmobilReturn[0];

                response = SRV.ZktmobilPaletleMalKabul01(request);

                if (response.TeReturn.Length > 0)
                {
                    if (response.TeReturn[0].RcCode == "E")
                    {
                        MessageBox.Show(response.TeReturn[0].RcText, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }

                foreach (var item in response.EtExidv)
                {
                    var row = _dt_palet.NewRow();

                    row["PALETNO"] = item.Exidv.TrimStart('0');
                    row["TIP"] = item.Vhilm;

                    _dt_palet.Rows.Add(row);
                }

                grd_Palet.Refresh();
                txt_PaletNumarasi.Focus();
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

        public void PaletAc()
        {
            _dt_malzeme.Clear();

            bool kontrol = false;
            string paletNo = txt_PaletNumarasi.Text;

            if (string.IsNullOrEmpty(paletNo))
            {
                paletNo = _dt_palet.Rows[grd_Palet.CurrentRowIndex]["PALETNO"].ToString();
            }

            if (string.IsNullOrEmpty(paletNo))
            {
                MessageBox.Show("Devam edebilmek için palet no okutunuz ya da listeden seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                return;
            }

            foreach (DataRow row in _dt_palet.Rows)
            {
                if (row["PALETNO"].ToString() == paletNo)
                {
                    kontrol = true;
                    break;
                }
            }

            if (!kontrol)
            {
                MessageBox.Show("Okutulan palet nakliye numarası içerisinde bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                return;
            }

            if (PaletMalzemeleriCek(paletNo))
            {
                ShowSecondPanel();

                txt_PaletNumarasi2.Text = paletNo;
                txt_MalzemeNo.Focus();
            }
        }

        public void MalzemeleriGonder()
        {
            Cursor.Current = Cursors.WaitCursor;
            WS_Satis.SERVICE SRV = new KoctasMobil.WS_Satis.SERVICE();
            WS_Satis.ZktmobilPaletleMalKabul03 request = new KoctasMobil.WS_Satis.ZktmobilPaletleMalKabul03();
            girisListe = new KoctasMobil.WS_Satis.ZktmobilPaletleMalKabul03Response();

            try
            {
                SRV.Url = Utility.getWsUrl("zktmobil_satis");
                SRV.Credentials = ProgramGlobalData.g_credential;

                request.IvKayitTarih = DateTime.Parse(txt_KayitTarihi.Text).ToString("yyyy-MM-dd");

                var malzemeler = new List<WS_Satis.ZktmobilStMatnrAmenge>();
                var malzemeDetaylari = new List<WS_Satis.ZktmobilStPaletMalkabul>();

                foreach (DataRow row in _dt_malzeme.Rows)
                {
                    var tmp = new WS_Satis.ZktmobilStMatnrAmenge();

                    tmp.Matnr = row["MALZEMENO"].ToString();
                    tmp.Amenge = decimal.Parse(row["MIKTAR"].ToString());

                    malzemeler.Add(tmp);
                }

                /*
                foreach (var item in malzemeler)
                {
                    foreach (var malzemeDetay in paletMalzemeleri.EtDetay)
                    {
                        var tmpMalzemeNo = decimal.Parse(malzemeDetay.Matnr).ToString();

                        if (tmpMalzemeNo == item.Matnr)
                        {
                            malzemeDetaylari.Add(malzemeDetay);
                        }
                    }
                }
                */

                request.ItMatnrAmenge = malzemeler.ToArray();
                request.ItDetay = paletMalzemeleri.EtDetay;
                request.TeReturn = new KoctasMobil.WS_Satis.ZkmobilReturn[0];

                if (request.ItMatnrAmenge.Length == 0)
                {
                    var tmpList = new List<KoctasMobil.WS_Satis.ZktmobilStMatnrAmenge>();

                    tmpList.Add(new KoctasMobil.WS_Satis.ZktmobilStMatnrAmenge());

                    request.ItMatnrAmenge = tmpList.ToArray();
                }

                foreach (var item in request.ItDetay)
                {
                    item.Matnr = item.Matnr.TrimStart('0');
                }

                girisListe = SRV.ZktmobilPaletleMalKabul03(request);

                if (girisListe.TeReturn.Length > 0)
                {
                    if (girisListe.TeReturn[0].RcCode == "E")
                    {
                        MessageBox.Show(girisListe.TeReturn[0].RcText, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }

                MalzemeleriListeyeEkle();

                ShowThirdPanel();
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

        public void MalzemeleriListeyeEkle()
        {
            _dt_total.Clear();
            _dt_total2.Clear();

            foreach (var item in girisListe.EtMalGrsListe)
            {
                var row = _dt_total.NewRow();
                var row2 = _dt_total2.NewRow();

                row["G"] = item.Giris;
                row["SASNO"] = item.Ebeln;
                row["MALZEMENO"] = item.Matnr.TrimStart('0');
                row["NAKIL"] = item.Smenge.ToString();
                row["GIRIS"] = item.Amenge.ToString();
                row["FARK"] = item.Fmenge.ToString();

                row2["GIRIS"] = item.Amenge.ToString();

                _dt_total.Rows.Add(row);
                _dt_total2.Rows.Add(row2);
            }

            grd_Total.Refresh();
        }

        public void MalzemeEkle()
        {
            decimal miktar = 0;

            if (!string.IsNullOrEmpty(txt_Miktar.Text))
            {
                try
                {
                    miktar = decimal.Parse(txt_Miktar.Text.Trim());

                    if (miktar < 0)
                    {
                        return;
                    }
                }
                catch { }
            }

            if (paletMalzemeleri != null)
            {
                if (paletMalzemeleri.EtMatnrSmenge != null)
                {
                    foreach (var item in paletMalzemeleri.EtMatnrSmenge)
                    {
                        string tmp = double.Parse(item.Matnr).ToString();

                        if (tmp == txt_MalzemeNo.Text.Trim())
                        {
                            bool kontrol = false;
                            int rowIndex = 0;

                            for (int i = 0; i < _dt_malzeme.Rows.Count; i++)
                            {
                                if (_dt_malzeme.Rows[i]["MALZEMENO"].ToString() == txt_MalzemeNo.Text.Trim())
                                {
                                    kontrol = true;
                                    rowIndex = i;

                                    miktar += decimal.Parse(_dt_malzeme.Rows[i]["MIKTAR"].ToString());
                                }
                            }

                            if (miktar > item.Smenge)
                            {
                                MessageBox.Show("Bu malzeme için en fazla " + item.Smenge.ToString() + " kadar giriş yapabilirsiniz.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                                txt_Miktar.Focus();
                            }
                            else
                            {
                                if (kontrol)
                                {
                                    _dt_malzeme.Rows[rowIndex]["MIKTAR"] = miktar.ToString();
                                }
                                else
                                {
                                    var row = _dt_malzeme.NewRow();

                                    row["MALZEMENO"] = txt_MalzemeNo.Text.Trim();
                                    row["MIKTAR"] = miktar.ToString();

                                    _dt_malzeme.Rows.Add(row);
                                }

                                grd_Malzeme.Refresh();

                                txt_MalzemeNo.Text = "";
                                txt_Miktar.Text = "";

                                txt_MalzemeNo.Focus();
                            }

                            return;
                        }
                    }  
                }

                MessageBox.Show("Malzeme palet malzeme listesinde bulanamadı.", "UYARI!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        public bool PaletMalzemeleriCek(string paletNo)
        {
            bool kontrol = true;

            Cursor.Current = Cursors.WaitCursor;
            WS_Satis.SERVICE SRV = new KoctasMobil.WS_Satis.SERVICE();
            WS_Satis.ZktmobilPaletleMalKabul02 request = new KoctasMobil.WS_Satis.ZktmobilPaletleMalKabul02();
            paletMalzemeleri = new KoctasMobil.WS_Satis.ZktmobilPaletleMalKabul02Response();

            try
            {
                SRV.Url = Utility.getWsUrl("zktmobil_satis");
                SRV.Credentials = ProgramGlobalData.g_credential;

                request.IvKayitTarih = DateTime.Parse(txt_KayitTarihi.Text).ToString("yyyy-MM-dd");
                request.IvPaletNo = paletNo;

                request.TeReturn = new KoctasMobil.WS_Satis.ZkmobilReturn[0];

                paletMalzemeleri = SRV.ZktmobilPaletleMalKabul02(request);

                if (paletMalzemeleri.TeReturn.Length > 0)
                {
                    if (paletMalzemeleri.TeReturn[0].RcCode == "E")
                    {
                        MessageBox.Show(paletMalzemeleri.TeReturn[0].RcText, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                        kontrol = false;
                        
                        return kontrol;
                    }
                }
            }
            catch (Exception ex)
            {
                kontrol = false;
                MessageBox.Show(ex.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

            return kontrol;
        }

        private void grd_Total_Click(object sender, EventArgs e)
        {
            txt_GirisGuncelleme.Focus();
        }

        private void btn_MalzemeSil_Click(object sender, EventArgs e)
        {
            if (true)
            {
                _dt_malzeme.Rows.RemoveAt(grd_Palet.CurrentRowIndex);
                grd_Malzeme.Refresh();
            }
        }
    }
}

