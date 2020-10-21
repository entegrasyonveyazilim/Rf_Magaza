using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_StokIadeMenu : Form
    {
        public frm_StokIadeMenu()
        {
            InitializeComponent();
        }



        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_normalIade_Click(object sender, EventArgs e)
        {
            frm_StokIade frm = new frm_StokIade();
            frm.iadeTuru = "A";
            frm.ShowDialog();
        }

        private void btn_ayipliIade_Click(object sender, EventArgs e)
        {
            frm_StokIade frm = new frm_StokIade();
            frm.iadeTuru = "B";
            frm.ShowDialog();
        }

        private void btn_stokFazlasiIade_Click(object sender, EventArgs e)
        {
            frm_StokIade frm = new frm_StokIade();
            frm.iadeTuru = "C";
            frm.ShowDialog();
        }

        private void btn_musteridenIade_Click(object sender, EventArgs e)
        {
            frm_StokIade frm = new frm_StokIade();
            frm.iadeTuru = "M";
            frm.ShowDialog();
        }

        private void frm_StokIadeMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_IadeDegistir_Click(object sender, EventArgs e)
        {
            frm_StokIadeDegistir frm = new frm_StokIadeDegistir();
            frm.ShowDialog();
        }       
    }
}