using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdnext_Click(object sender, EventArgs e)
        {
            server.Service1 server = new server.Service1();
            server.SetText(txtText.Text);
            Next_forn Nf = new Next_forn();
            Nf.Show();
            this.Hide();
        }
    }
}
