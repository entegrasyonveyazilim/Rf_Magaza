using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_PaketlemeMenu : Form
    {
        public frm_PaketlemeMenu()
        {
            InitializeComponent();
        }

        private void frm_PaketlemeMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_cikis_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Toplama_Click_1(object sender, EventArgs e)
        {
            frm_PaketlemeToplama frm = new frm_PaketlemeToplama();
            frm.ShowDialog();
        }

        private void btn_Yukleme_Click(object sender, EventArgs e)
        {
            frm_PaketlemeYukleme frm = new frm_PaketlemeYukleme();
            frm.ShowDialog();
        }


        private void btn_Degistir_Click(object sender, EventArgs e)
        {
            frm_PaketlemeToplamaDegistirKoliNo frm = new frm_PaketlemeToplamaDegistirKoliNo();
            frm.ShowDialog();
        }
    }
}