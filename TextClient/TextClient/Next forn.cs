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
    public partial class Next_forn : Form
    {
        public Next_forn()
        {
            InitializeComponent();
            server.Service1 server = new server.Service1();
            string[] st = server.GetText();
            for (int i = 0; i < st.Length ; i++)
            {
              cmbItems.Items.Add(st[i]);
            }
        }

        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
    
}
