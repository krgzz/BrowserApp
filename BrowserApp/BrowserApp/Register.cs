using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserApp
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        public void button2_Click(object sender, EventArgs e)
        {
            login lgn = new login();
            lgn.Show();
            Close();
        }
    }
}
