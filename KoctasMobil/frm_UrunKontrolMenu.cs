using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_UrunKontrolMenu : Form
    {
        public frm_UrunKontrolMenu()
        {
            InitializeComponent();
        }

        private void frm_SayimMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_UrunKontrol_Click(object sender, EventArgs e)
        {
            frm_UrunKontrol frm = new frm_UrunKontrol();
            frm.ShowDialog();
        }

        private void btn_Gap_Click(object sender, EventArgs e)
        {
            frm_GapRaf frm = new frm_GapRaf();
            frm.ShowDialog();
        }

        private void btn_UrunAcikSiparisKontrol_Click(object sender, EventArgs e)
        {
            frm_AcikSiparis frm = new frm_AcikSiparis(); frm.ShowDialog();
        }

        private void btn_ListelemeKontrol_Click(object sender, EventArgs e)
        {
            frm_ListKontrol frm = new frm_ListKontrol();
            frm.ShowDialog();
        }

        private void btn_Etiket_Click(object sender, EventArgs e)
        {
            frm_Etiket frm = new frm_Etiket();
            frm.ShowDialog();
        }
    }
}