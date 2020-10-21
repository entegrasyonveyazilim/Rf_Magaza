using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KoctasMobil
{
    public partial class FixMalMiktarDegistirmeDialog : Form
    {
        public string ReturnValue1 { get; set; } 

        public FixMalMiktarDegistirmeDialog(String miktar)
        {
            InitializeComponent();
            ReturnValue1 = miktar;

        }

        private void save_Click(object sender, EventArgs e)
        {
            ReturnValue1 = quantity.Text();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}