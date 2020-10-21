using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_SatisMenu : Form
    {
        public frm_SatisMenu()
        {
            InitializeComponent();
        }

        private void frm_SatisMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_NormalSiparisYarat_Click(object sender, EventArgs e)
        {
            frm_NormalSiparisYarat frm = new frm_NormalSiparisYarat(frm_NormalSiparisYarat.Title.normal);
            frm.ShowDialog();
        }       

        private void btn_Cikis_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_transferliSatis_Click(object sender, EventArgs e)
        {
            frm_NormalSiparisYarat frm = new frm_NormalSiparisYarat(frm_NormalSiparisYarat.Title.transferli);
            frm.Transferli = "X";
            
            frm.ShowDialog();
        }

        private void btn_SiparisDegistir_Click(object sender, EventArgs e)
        {
            frm_SiparisAra frm = new frm_SiparisAra(frm_SiparisAra.op.degistir);
            frm.ShowDialog();
        }

        private void btn_SiparisBirlestir_Click(object sender, EventArgs e)
        {
            frm_SiparisBirlestir1 frm = new frm_SiparisBirlestir1();
            frm.ShowDialog();            
        }

        private void btn_SiparisKopyala_Click(object sender, EventArgs e)
        {
            frm_SiparisAra frm = new frm_SiparisAra(frm_SiparisAra.op.kopyala);
            frm.ShowDialog();
        }

        private void btn_SiparisSil_Click(object sender, EventArgs e)
        {
            frm_SiparisSil frm = new frm_SiparisSil();
            frm.ShowDialog();
        }

        private void btn_SiparisYazdir_Click(object sender, EventArgs e)
        {
            frm_Yazdir frm = new frm_Yazdir();
            frm.ShowDialog(); 
        }

        private void btn_SatisIade_Click(object sender, EventArgs e)
        {
            frm_SiparisIade frm = new frm_SiparisIade();
            frm.ShowDialog();
        }      
    }
}