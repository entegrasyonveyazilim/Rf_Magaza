using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_PaketlemeYukleme : Form
    {
        public frm_PaketlemeYukleme()
        {
            InitializeComponent();
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_PaketlemeYukleme_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_YuklemeEkle_Click(object sender, EventArgs e)
        {
            if (txt_formNo.Text.Trim() == "")
            {
                return;
            }

            try { decimal.Parse(txt_formNo.Text.Trim()); }
            catch
            {
                MessageBox.Show("Koli No alanına yalnız sayısal değer girebilirsiniz.", "HATA");
                return;
            }

            try {
                Cursor.Current = Cursors.WaitCursor;

                WS_Paket.SERVICE srv = new KoctasMobil.WS_Paket.SERVICE();
                WS_Paket.ZkmobilReturn ret = new KoctasMobil.WS_Paket.ZkmobilReturn();

                WS_Paket.ZktmobilPakCheckKoli chkKoli = new KoctasMobil.WS_Paket.ZktmobilPakCheckKoli();
                WS_Paket.ZktmobilPakCheckKoliResponse chkKoliResp = new KoctasMobil.WS_Paket.ZktmobilPakCheckKoliResponse();

                chkKoli.EReturn = ret;

                string koliNo = txt_formNo.Text.Trim().PadLeft(10, '0');
                bool listEkle = true;
                chkKoli.ImPaketno = koliNo;
                srv.Credentials = ProgramGlobalData.g_credential;
                srv.Url = Utility.getWsUrl("zktmobil_paket");

                chkKoliResp = srv.ZktmobilPakCheckKoli(chkKoli);

                if (chkKoliResp.EReturn.RcCode.ToUpper() == "E")
                {
                    txt_formNo.Text = "";
                    MessageBox.Show(chkKoliResp.EReturn.RcText, "HATA");
                }
                else
                {
                    for (int i = 0; i < lst_Koli.Items.Count; i++)
                    {
                        if (lst_Koli.Items[i].ToString() == koliNo)
                        {
                            listEkle = false;
                        }
                    }

                    if (listEkle)
                    {
                        lst_Koli.Items.Add(koliNo);
                    }

                    txt_formNo.Text = "";
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

        private void btn_YuklemeCikart_Click(object sender, EventArgs e)
        {
            if (lst_Koli.SelectedIndex >= 0)
            {
                lst_Koli.Items.RemoveAt(lst_Koli.SelectedIndex);
            }
            else
            {
                return;
            }
        }

        private void txt_formNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_YuklemeEkle_Click(new object(), new EventArgs());
            }
        }

        private void btn_yukleme_Click(object sender, EventArgs e)
        {
            if (lst_Koli.Items.Count == 0)
            {
                return;
            }

            try
            {

                Cursor.Current = Cursors.WaitCursor;

                WS_Paket.SERVICE srv = new KoctasMobil.WS_Paket.SERVICE();
                WS_Paket.ZkmobilReturn ret = new KoctasMobil.WS_Paket.ZkmobilReturn();
                WS_Paket.Ztoplama3[] koliList = new KoctasMobil.WS_Paket.Ztoplama3[lst_Koli.Items.Count];

                WS_Paket.ZktmobilPakYuklemeSave saveYukle = new KoctasMobil.WS_Paket.ZktmobilPakYuklemeSave();
                WS_Paket.ZktmobilPakYuklemeSaveResponse saveYukleResp = new KoctasMobil.WS_Paket.ZktmobilPakYuklemeSaveResponse();

                for (int i = 0; i < lst_Koli.Items.Count; i++)
                {
                    koliList[i] = new KoctasMobil.WS_Paket.Ztoplama3();
                    koliList[i].PaketNo = lst_Koli.Items[i].ToString();
                }

                saveYukle.ItData = koliList;

                srv.Credentials = ProgramGlobalData.g_credential;
                srv.Url = Utility.getWsUrl("zktmobil_paket");
                saveYukleResp = srv.ZktmobilPakYuklemeSave(saveYukle);

                if (saveYukleResp.EReturn.RcCode.ToUpper() == "E")
                {
                    MessageBox.Show(saveYukleResp.EReturn.RcText, "HATA");
                }
                else
                {
                    MessageBox.Show(saveYukleResp.ExYuklmno.ToString() + " nolu yükleme kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    lst_Koli.Items.Clear();
                    txt_formNo.Text = "";
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
    }
}