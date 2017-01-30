using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControls
{
    public partial class TabControls : Form
    {
        public TabControls()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void TabControls_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           lblIndia.LinkVisited = true;

            System.Diagnostics.Process.Start("https://india.gov.in/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblCanada.LinkVisited = true;

            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Canada");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblUSA.LinkVisited = true;

            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/United_States");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblFrance.LinkVisited = true;

            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/France");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblLondon.LinkVisited = true;

            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/London");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblSydney.LinkVisited = true;

            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Sydney");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (object itemChecked in checkedListBox.CheckedItems)
            {
                    
            }
         }
        }
    }

