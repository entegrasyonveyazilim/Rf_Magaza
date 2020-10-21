using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public struct datatocopy 
    {
        public string musteri;
        public string siparistipi;
        public string semt;
        public string not;
        public string evtel;
        public string istel;
        public string ceptel;
    }

    public partial class frm_SiparisAra : Form
    {
        public frm_SiparisAra(op operation)
        {
            InitializeComponent();
            _operation = operation;
        }
        public enum op
        {
            kopyala, degistir
        }

        op _operation = new op();

        private void btnGetir_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                WS_Satis.SERVICE SRV = new WS_Satis.SERVICE();
                SRV.Url = Utility.getWsUrl("zktmobil_satis");
                SRV.Credentials = ProgramGlobalData.g_credential;

                WS_Satis.ZktmobilItemsGet items = new KoctasMobil.WS_Satis.ZktmobilItemsGet();
                items.IVbeln = txtBelgeNo.Text.Trim();
                items.TiKalemler = new KoctasMobil.WS_Satis.ZktmobilSItemslist[0];
                items.TiOrders = new KoctasMobil.WS_Satis.ZktmobilOrders[0];
                WS_Satis.ZktmobilItemsGetResponse response = SRV.ZktmobilItemsGet(items);
                Cursor.Current = Cursors.Default;
                if (response.EReturn.RcCode == "E")
                {
                    MessageBox.Show(response.EReturn.RcText, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    return;
                }
                datatocopy copydata = new datatocopy();
                copydata.musteri = response.TiOrders[0].Name2;
                copydata.semt = response.TiOrders[0].Name3;
                copydata.not = response.TiOrders[0].Notes;
                copydata.siparistipi = response.TiOrders[0].Stipi;
                copydata.evtel = response.TiOrders[0].Telf1;
                copydata.ceptel = response.TiOrders[0].Telf3;
                copydata.istel = response.TiOrders[0].Telf2;
                frm_NormalSiparisYarat yarat = null;
                switch (_operation)
                {
                    case op.kopyala:
                        yarat = new frm_NormalSiparisYarat(response.TiKalemler, "",frm_NormalSiparisYarat.Title.kopyala);
                        yarat.Copyingdata = copydata;
                        if (rdb_Transferli.Checked)  
                        {
                            yarat.Transferli = "X";
                        }
                        else if (rdb_Normal.Checked)
                        {
                            yarat.Transferli = "";
                        }
                        break;
                    case op.degistir:
                        yarat = new frm_NormalSiparisYarat(response.TiKalemler, txtBelgeNo.Text.Trim(),frm_NormalSiparisYarat.Title.degistir);
                        yarat.Copyingdata = copydata;
                        break;
                    default:
                        break;
                }
                DialogResult dr = DialogResult.None;
                if (response.TiKalemler.Length > 0)
                {
                    dr = yarat.ShowDialog();
                }
                    
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
            if (_operation == op.kopyala)
            {
                rdb_Normal.Visible = true;
                rdb_Transferli.Visible = true;
            }
            else 
            {
                rdb_Normal.Visible = false;
                rdb_Transferli.Visible = false;                
            }
        }
    }
}