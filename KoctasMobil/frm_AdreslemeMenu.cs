using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_AdreslemeMenu : Form
    {
        public frm_AdreslemeMenu()
        {
            InitializeComponent();
        }

        private void frm_AdreslemeMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_cikis_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SayimGirisi_Click(object sender, EventArgs e)
        {
            frm_AdreslemeGiris frm = new frm_AdreslemeGiris();
            frm.ShowDialog();
        }

        private void btn_AdreslemeTransfer_Click(object sender, EventArgs e)
        {
            frm_AdreslemeTransfer frm = new frm_AdreslemeTransfer();
            frm.ShowDialog();
        }

        private void btn_AdreslemeKontrol_Click(object sender, EventArgs e)
        {
            frm_AdreslemeKontrol frm = new frm_AdreslemeKontrol();
            frm.ShowDialog();
        }

        private void btn_AdreslemeUrunKontrol_Click(object sender, EventArgs e)
        {
            frm_AdreslemeUrunKontrol frm = new frm_AdreslemeUrunKontrol();
            frm.ShowDialog();
        }
    }
}