using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InfoLab1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            DataForm.FindText = textBox1.Text;
            this.Close();
        }
    }
}
