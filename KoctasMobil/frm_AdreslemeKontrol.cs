using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_AdreslemeKontrol : Form
    {

        string kaynakAdres = "";


        DataTable drMal = new DataTable();
        
        public frm_AdreslemeKontrol()
        {
            InitializeComponent();
        }

 
        private void btn_Getir_Click_1(object sender, EventArgs e)
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

        private void frm_AdreslemeKontrol_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            drMal = new DataTable();
            drMal.Columns.Add("Matnr");
            drMal.Columns.Add("Meins");
            drMal.Columns.Add("Menge");
            drMal.Columns.Add("Nlpla");
        }

        private void txtKaynakAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)13))
            {
                btn_Getir_Click_1(new object(), new EventArgs());
            }
        }
    }
}