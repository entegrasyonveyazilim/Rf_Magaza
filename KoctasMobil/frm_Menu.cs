using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }
        
        private void frm_Menu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            if (Program.adresleme)
            {
                btn_Adresleme.Visible = true;
            }
            else
            {
                btn_Adresleme.Visible = false;
            }
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btn_Satis_Click(object sender, EventArgs e)
        {
            frm_SatisMenu frm = new frm_SatisMenu();
            frm.ShowDialog();
        }

        private void btn_Stok_Click(object sender, EventArgs e)
        {
            frm_StokMenu frm = new frm_StokMenu();
            frm.ShowDialog();
        }

        private void btn_Sayim_Click(object sender, EventArgs e)
        {
            frm_SayimMenu frm = new frm_SayimMenu();
            frm.ShowDialog();
        }

        private void btn_Kontrol_Click(object sender, EventArgs e)
        {
            frm_UrunKontrolMenu frm = new frm_UrunKontrolMenu();
            frm.ShowDialog();
        }

        private void pictureButton1_Click(object sender, EventArgs e)
        {
            new frm_UrunTutanak().ShowDialog();
        }

        private void btn_Adresleme_Click(object sender, EventArgs e)
        {
            frm_AdreslemeMenu frm = new frm_AdreslemeMenu();
            frm.ShowDialog();
        }
    }
}