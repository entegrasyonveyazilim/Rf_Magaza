using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class frm_UrunTeslimat_2_Timestamp : Form
    {
        public frm_UrunTeslimat_2_Timestamp()
        {
            InitializeComponent();
        }

        public String timestamp = "";

        private void button1_Click(object sender, EventArgs e)
        {
            timestamp = dateTimePicker1.Text.ToString().Replace(".", "").Replace(":", "").Replace(" ", "");
            this.Close();
        }
    }
}