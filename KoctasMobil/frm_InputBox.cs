using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_InputBox : Form
    {

        public string msg = "";
        public string title = "";
        public string deger = "";
        
        public frm_InputBox()
        {
            InitializeComponent();
        }

        private void picBtn_Iptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            
        }

        private void formInputBox_Load(object sender, EventArgs e)
        {
            lbl_Msg.Text = msg;
            this.Text = title;
            txtInput.SelectAll();
            txtInput.Focus();
            
        }

        private void picBtn_OK_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Trim() == "") return;
            this.deger = txtInput.Text.Trim();
            this.DialogResult = DialogResult.OK;
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                picBtn_OK_Click(txtInput, new EventArgs());
            }
        }
    }
}