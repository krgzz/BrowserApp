using Microsoft.Azure.Amqp.Framing;
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
    public partial class settings : Form
    {
        private const int V = 3;

        public object End { get; private set; }

        public settings()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private sub Settings_Load(object sender, EventArgs e) Handles MyBase.Load
            if My.Settings.SE = "Google" then comoBox1.SelectedIndex = 1
            else if My.Settings.SE = "Bing" then comoBox1.SelectedIndex = 2
            else if My.Settings.SE = "DuckDuckGo" then comoBox1.SelectedIndex = V
            End if
        End sub

        private void accept_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1) Then
                    My.Settings.SE = "Google"
            else if (comboBox1.SelectedIndex == 2) Then
                    My.Settings.SE = "Bing"
            else if (comboBox1.SelectedIndex == 3) Then 
                    My.Setttings.SE = "DuckDuckGo"

            My.Settings.Save()
            My.Settings.Reload()
            End if
        }
    }
}
