using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_StokIadeDegistir : Form
    {
        public frm_StokIadeDegistir()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            string _iadeTipi = "";
            try
            {
                if (String.IsNullOrEmpty(txtBelgeNo.Text)) return;

                Cursor.Current = Cursors.WaitCursor;
                WS_Stok.service srv = new KoctasMobil.WS_Stok.service();
                WS_Stok.ZktmobilGetIade iade = new KoctasMobil.WS_Stok.ZktmobilGetIade();
                WS_Stok.ZktmobilGetIadeResponse resp = new KoctasMobil.WS_Stok.ZktmobilGetIadeResponse();

                srv.Url = Utility.getWsUrl("zktmobil_stok");
                srv.Credentials = ProgramGlobalData.g_credential;

                iade.IFormno = txtBelgeNo.Text.Trim();
                iade.ItIades = new KoctasMobil.WS_Stok.ZktmobilIade2[0];

                resp = srv.ZktmobilGetIade(iade);

                if (resp.ItIades.Length == 0 && resp.EReturn != null && resp.EReturn.RcCode == "E")
                {
                    throw new Exception(resp.EReturn.RcText);
                }

                DataTable dt_mal = new DataTable();
                dt_mal.Columns.Add("matnr");
                dt_mal.Columns.Add("maktx");
                dt_mal.Columns.Add("menge");
                dt_mal.Columns.Add("meins");
                dt_mal.Columns.Add("itip");

                foreach (WS_Stok.ZktmobilIade2 iades in resp.ItIades)
                {
                    DataRow row = dt_mal.NewRow();
                    row["matnr"] = iades.Matnr;
                    row["maktx"] = iades.Maktx;
                    row["menge"] = iades.Menge;
                    row["meins"] = iades.Meins;
                    row["itip"] = Utility.getIadeTip(iades.ITip);
                    _iadeTipi = iades.ITip;
                    dt_mal.Rows.Add(row);
                }

                frm_StokIadeDegistir2 frm = new frm_StokIadeDegistir2(dt_mal);
                frm.Formno = iade.IFormno;
                frm.iadeTipi = _iadeTipi;
                Cursor.Current = Cursors.Default;
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    this.Close();
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

        private void bntVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBelgeNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnGetir_Click(txtBelgeNo, new EventArgs());
            }
        }

        private void frm_SiparisAra_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}