using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_SayimMenu : Form
    {
        public frm_SayimMenu()
        {
            InitializeComponent();
        }

        private void frm_SayimMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_SayimGirisi_Click(object sender, EventArgs e)
        {
            frm_SayimRaf RafAdresi = new frm_SayimRaf();
            RafAdresi.ShowDialog();            
        }

        private void btn_EkSayimGirisi_Click(object sender, EventArgs e)
        {
            frm_SayimRaf RafAdresi = new frm_SayimRaf();
            RafAdresi.SayimTipi = "E";
            RafAdresi.ShowDialog();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btn_MalGirisi_Click(object sender, EventArgs e)
        //{
        //    frm_malgiris frm = new frm_malgiris();
        //    frm.ShowDialog();
        //}

        //private void frm_StokMenu_Load(object sender, EventArgs e)
        //{
        //    
        //}

        //private void btn_cikis_Click(object sender, EventArgs e)
        //{
        //   
        //}
    }
}