using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            if (rbDark.Checked)
            {
                this.BackColor = Color.Black;
                rbDark.ForeColor = Color.White;
                rbLight.ForeColor = Color.White;
            }
            if (rbLight.Checked)
            {
                this.BackColor = Color.White;
                rbDark.ForeColor = Color.Black;
                rbLight.ForeColor = Color.Black;
            }
        }
    }
}
