using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class FixProductList : Form
    {
        public FixProductList()
        {
            InitializeComponent();
        }

        DataTable dt_mal;

        private void FixProductList_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
            
            dt_mal = new DataTable();
            dt_mal.Columns.Add("SA_Belge_No");
            dt_mal.Columns.Add("Klm");
            dt_mal.Columns.Add("Malzeme");
            dt_mal.Columns.Add("Malzeme_Tanimi");
            dt_mal.Columns.Add("Teslimat_Miktari");
            dt_mal.Columns.Add("Birim");
            dt_mal.Columns.Add("Giris_Miktari");
            
            txtSevkNo.Focus();
        }

        private void EditdwColumn(DataGrid dw)
        {
            //dw
            ////dw.Columns["Giris_Miktari"].ReadOnly = true;
            //foreach (DataGridColumn dc in dw.colu)
            //{
            //    if (dc.Name == "Giris_Miktari")
            //    {
            //        dc.ReadOnly = false;
            //    }
            //    else
            //    {
            //        dc.ReadOnly = true;
            //    }
            //}
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                KoctasMobil.WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKU serv = new WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKU();
                KoctasMobil.WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKUResponse resp = new WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKUResponse();
                KoctasMobil.WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKU1 req = new WS_Palet_Oku.Z_EWM_PALETLI_MAL_KABUL_OKU1();
                serv.Credentials = ProgramGlobalData.g_credential;
                req.I_SEVKNO = txtSevkNo.Text.Trim();
                req.ET_LIST = new WS_Palet_Oku.ZEWM_ST_PALET_MAL_KABUL[0];
                resp = serv.CallZ_EWM_PALETLI_MAL_KABUL_OKU(req);

                int count = resp.ET_LIST.Length;
                KoctasMobil.WS_Palet_Oku.ZEWM_ST_PALET_MAL_KABUL[] etlist = new WS_Palet_Oku.ZEWM_ST_PALET_MAL_KABUL[count];
                etlist = resp.ET_LIST;
                dt_mal = new DataTable();
                dt_mal.Columns.Add("SA_Belge_No");
                dt_mal.Columns.Add("Klm");
                dt_mal.Columns.Add("Malzeme");
                dt_mal.Columns.Add("Malzeme_Tanimi");
                dt_mal.Columns.Add("Teslimat_Miktari");
                dt_mal.Columns.Add("Birim");
                dt_mal.Columns.Add("Giris_Miktari");

                for (int i = 0; i < count; i++)
                {
                    DataRow row = dt_mal.NewRow();
                    row["SA_Belge_No"] = etlist[i].EBELN.ToString();
                    row["Klm"] = etlist[i].EBELP.ToString();
                    row["Malzeme"] = etlist[i].MATNR.ToString().Substring(8);
                    row["Malzeme_Tanimi"] = etlist[i].MAKTX.ToString();
                    row["Teslimat_Miktari"] = etlist[i].SMENGE.ToString().Split('.')[0];
                    row["Birim"] = etlist[i].MEINS.ToString();
                    row["Giris_Miktari"] = etlist[i].AMENGE.ToString();
                    //dt_mal.Rows.Add(row.ItemArray);
                    //dt_mal.Rows.InsertAt(row,i);
                    dt_mal.Rows.Add(row);
                }
                grd_mal.DataSource = null;
                grd_mal.DataSource = dt_mal;
                //grd_mal.ReadOnly = true;
                //DataTableGoster();
                // grd_mal.Row
                //EditdwColumn(grd_mal);
                Utility.selectText(txtSevkNo);
            }
            catch(Exception ex)
            {
                string mesaj = ex.Message;
                MessageBox.Show("3-" + mesaj);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }

        }

        

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                KoctasMobil.WS_Palet_Kaydet.Z_EWM_PALETLI_MAL_KABUL_KAYDET serv = new WS_Palet_Kaydet.Z_EWM_PALETLI_MAL_KABUL_KAYDET();
                KoctasMobil.WS_Palet_Kaydet.Z_EWM_PALETLI_MAL_KABUL_KAYDETResponse resp = new WS_Palet_Kaydet.Z_EWM_PALETLI_MAL_KABUL_KAYDETResponse();
                KoctasMobil.WS_Palet_Kaydet.Z_EWM_PALETLI_MAL_KABUL_KAYDET1 req = new WS_Palet_Kaydet.Z_EWM_PALETLI_MAL_KABUL_KAYDET1();
                serv.Credentials = ProgramGlobalData.g_credential;

                KoctasMobil.WS_Palet_Kaydet.ZEWM_ST_PALET_MAL_KABUL[] paletlist = new WS_Palet_Kaydet.ZEWM_ST_PALET_MAL_KABUL[dt_mal.Rows.Count];

                dtp_kayit.Format = DateTimePickerFormat.Custom;
                dtp_kayit.CustomFormat = "yyyy-MM-dd";
                String date = dtp_kayit.Value.ToString().Split(' ')[0].Replace('/','-');
                String ay;
                if (Int32.Parse(date.Split('-')[0]) < 10)
                {
                    ay = "0" + date.Split('-')[0];
                }
                else
                {
                    ay = date.Split('-')[0];
                }
                String date2=date.Split('-')[2] + '-' + ay + '-' + date.Split('-')[1];
                req.I_BUDAT = date2;
               for (int i = 0; i < dt_mal.Rows.Count; i++)
                {
                    paletlist[i] = new WS_Palet_Kaydet.ZEWM_ST_PALET_MAL_KABUL();
                    paletlist[i].EBELP = dt_mal.Rows[i]["Klm"].ToString();
                    paletlist[i].EBELN = dt_mal.Rows[i]["SA_Belge_No"].ToString();
                    paletlist[i].MATNR = dt_mal.Rows[i]["Malzeme"].ToString();
                    paletlist[i].MAKTX = dt_mal.Rows[i]["Malzeme_Tanimi"].ToString();
                    paletlist[i].SMENGE = decimal.Parse(dt_mal.Rows[i]["Teslimat_Miktari"].ToString());
                    paletlist[i].AMENGE = dt_mal.Rows[i]["Giris_Miktari"].ToString();
                    paletlist[i].MEINS = dt_mal.Rows[i]["Birim"].ToString();
                }
                req.IT_LIST = paletlist;
                req.ET_RETURN = new WS_Palet_Kaydet.BAPIRET2[0];

                resp = serv.CallZ_EWM_PALETLI_MAL_KABUL_KAYDET(req);
                Cursor.Current = Cursors.Default;
                if(resp.ET_RETURN[0].TYPE.Equals("S")){
                    MessageBox.Show("Tamamlandı", "SONUÇ");
                }else{
                    MessageBox.Show(resp.ET_RETURN[0].MESSAGE, "SONUÇ");
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "HATA");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureButton1_Click(object sender, EventArgs e)
        {
            dt_mal.Rows[rownum]["Giris_Miktari"] = textBox2.Text.Trim().TrimStart();
        }

        int rownum = 0;
        private void grd_mal_MouseClick(object sender, MouseEventArgs e)
        {
            rownum = grd_mal.CurrentCell.RowNumber;
            textBox2.Text = dt_mal.Rows[rownum]["Giris_Miktari"].ToString().Trim().TrimStart();
        }

        private void grd_mal_Click(object sender, EventArgs e)
        {
            rownum = grd_mal.CurrentCell.RowNumber;
            textBox2.Text = dt_mal.Rows[rownum]["Giris_Miktari"].ToString().Trim().TrimStart();
        }

        private void grd_mal_CurrentCellChanged_1(object sender, EventArgs e)
        {

        }
    }
    
}