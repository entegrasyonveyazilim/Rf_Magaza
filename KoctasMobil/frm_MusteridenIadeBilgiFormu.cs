using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_MusteridenIadeBilgiFormu : Form
    {
        public frm_MusteridenIadeBilgiFormu()
        {
            InitializeComponent();
        }

        public DataTable _dt_mal;

        private void frm_MusteridenIadeBilgiFormu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            txtFisTarih.Format = DateTimePickerFormat.Custom;
            txtFisTarih.CustomFormat = "dd-MM.yyyy";
            txtMusteriAd.Focus();
          }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {

        }

        private void txt_malzemeno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_malzemeno_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMusteriAd.Text.Trim())) {
                MessageBox.Show("Müşteri adını giriniz", "HATA!");
                txtMusteriAd.Focus();
                return;
            } else if (String.IsNullOrEmpty(txtMusteriTelefon.Text.Trim())) {
                MessageBox.Show("Müşteri telefonunu giriniz", "HATA!");
                txtMusteriTelefon.Focus();
                return;
            } else if (String.IsNullOrEmpty(txtFisTarih.Text)) {
                MessageBox.Show("Fatura/Fiş tarihini giriniz", "HATA!");
                txtFisTarih.Focus();
                return;
            } else if (String.IsNullOrEmpty(txtFisNo.Text.Trim())) {
                MessageBox.Show("Fatura/Fiş no giriniz", "HATA!");
                txtFisNo.Focus();
                return;
            }


            try
            {
                Cursor.Current = Cursors.WaitCursor;

                txtFisTarih.CustomFormat = "yyyyMMdd";

                WS_Stok.service srv = new KoctasMobil.WS_Stok.service();
                WS_Stok.ZktmobilCrtIade ret = new KoctasMobil.WS_Stok.ZktmobilCrtIade();
                WS_Stok.ZmobilIade1[] iade = new KoctasMobil.WS_Stok.ZmobilIade1[_dt_mal.Rows.Count];
                WS_Stok.ZktmobilCrtIadeResponse resp = new KoctasMobil.WS_Stok.ZktmobilCrtIadeResponse();
                

                srv.Url = Utility.getWsUrl("zktmobil_stok");
                srv.Credentials = ProgramGlobalData.g_credential;
                int i = 0;
                foreach (DataRow row in _dt_mal.Rows)
                {
                    iade[i] = new KoctasMobil.WS_Stok.ZmobilIade1();

                    //Urun bilgisi ekleniyor
                    iade[i].Matnr = row["matnr"].ToString();
                    iade[i].Menge = Convert.ToDecimal(row["menge"].ToString());

                    //Musteri bilgisi ekleniyor
                    iade[i].Fno = txtFisNo.Text.Trim().ToString();
                    iade[i].Ftarih = txtFisTarih.Text.Trim();
                    iade[i].Madi = txtMusteriAd.Text.Trim().ToString();
                    iade[i].Mtel = txtMusteriTelefon.Text.Trim().ToString();
                    iade[i].INeden = txtIadeNedeni.Text.Trim().ToString();
                    i++;
                }

                ret.Itab = iade;


                resp = srv.ZktmobilCrtIade(ret);

                if (String.IsNullOrEmpty(resp.FormNo) && resp.EReturn[0].RcCode == "E")
                {
                    throw new Exception(resp.EReturn[0].RcText);
                }

                MessageBox.Show(resp.FormNo + " nolu iade kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                this.DialogResult = DialogResult.Abort;
                _dt_mal.Clear();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                txtFisTarih.CustomFormat = "yyyy.MM.dd";
            }
            

            
        }

        private void txtMusteriAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                if (!String.IsNullOrEmpty(txtMusteriAd.Text.Trim())) {
                    txtMusteriTelefon.Focus();
                }
            }
        }

        private void txtMusteriTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!String.IsNullOrEmpty(txtMusteriTelefon.Text.Trim())) {
                    txtFisTarih.Focus();
                }
            }
        }

        private void txtFisNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!String.IsNullOrEmpty(txtFisNo.Text.Trim()))
                {
                    txtIadeNedeni.Focus();
                }
            }
        }

        private void txtFisTarih_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!String.IsNullOrEmpty(txtFisTarih.Text.Trim()))
                {
                    txtFisNo.Focus();
                }
            }
        }

    }
}