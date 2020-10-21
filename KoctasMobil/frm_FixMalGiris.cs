using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_FixMalGiris : Form
    {
        public frm_FixMalGiris()
        {
            InitializeComponent();
        }

        private void frm_FixMalGiris_Load(object sender, EventArgs e)
        {

        }

        private void txtTransportUnit_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTransportUnit.Text, "[^0-9]"))
            {
                MessageBox.Show("Sadece rakam giriniz");
                txtTransportUnit.Text = txtTransportUnit.Text.Remove(0, txtTransportUnit.Text.Length - 1);
            }
        }


        private void fixProductSearchButton_Click(object sender, EventArgs e)
        {
            if (txtTransportUnit.Text.Length != 10)
            {
                MessageBox.Show("10 karakter girmek zorunludur.");
                txtTransportUnit.Text = "";
            }
            else
            {
                FixProductList fixProductList = new FixProductList(txtTransportUnit.Text(), registerDate.Text());
                fixProductList.Show();
            }
        }

        private void btn_fix_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}