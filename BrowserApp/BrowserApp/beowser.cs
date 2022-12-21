using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BrowserApp
{
    public partial class browser : Form
    {
        public browser()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        public void button4_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            set.Show();
            this.Hide();
        }

        private Sub browser_Load(object sender, EventArgs e, Handles, MyBase.Load)
        webBrowser1.ScriptErrorsSuppressed scriptErrorsSuppressed = true
        End Sub
        
        Sub checkAdress() Handles webBrowser1.DocumentCompleted
            textBox1.Text = webBrowser1.Url.ToString
        End Sub
        private void button1_Click(object sender, EventArgs e)
        {
            if webBrowser1.CanGoBack then 
               webBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward) Then, webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh(); 
        }
    }
}
