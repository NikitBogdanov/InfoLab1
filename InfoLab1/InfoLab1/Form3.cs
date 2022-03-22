using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InfoLab1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Value = DateTime.Now;
        }
        private void Okey_Click(object sender, EventArgs e)
        {
            DataForm.Date = Convert.ToString(MonthCalendar.TodayDate.Date);
            DataForm.Time = dateTimePicker1.Value;
            DataForm.MyEvent = TextBoxEve.Text;
            DataForm.MyTipe = ComboBoxTipe.Text;
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
    }
}
