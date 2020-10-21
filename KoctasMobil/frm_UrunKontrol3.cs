using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{

    public partial class frm_UrunKontrol3 : Form
    {        
        public frm_UrunKontrol3()
        {
            InitializeComponent();            
        }

        public WS_Kontrol.ZktmobilRegionStockResponse resp = new KoctasMobil.WS_Kontrol.ZktmobilRegionStockResponse();
        public string matnr, barkod, maktx;
        DataTable dtstok = new DataTable();

        private void frm_UrunKontrol3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txt_matnr.Text = matnr;
            txt_Barkod.Text = barkod;
            txt_maktx.Text = maktx;
            try
            {
                if (resp != null)
                {      
                    dtstok.Columns.Add("werks");
                    dtstok.Columns.Add("lgort");
                    dtstok.Columns.Add("lgobe");
                    dtstok.Columns.Add("menge");
                    dtstok.Columns.Add("meins");                    

                    for (int i = 0; i < resp.ItBolgstk.Length; i++)
                    {
                        DataRow row = dtstok.NewRow();
                        row["werks"] = resp.ItBolgstk[i].Werks;
                        row["lgort"] = resp.ItBolgstk[i].Lgort;
                        row["lgobe"] = resp.ItBolgstk[i].Lgobe;
                        row["meins"] = resp.ItBolgstk[i].Meins;
                        row["menge"] = resp.ItBolgstk[i].Menge;
                        dtstok.Rows.Add(row);
                    }
                    grd_depostok.DataSource = dtstok;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conversion error: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }            
        }

        private void GeneralKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }                       
    }
}

