using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InfoLab1
{
    public partial class FormOrg : Form
    {
        struct Record
        {
            public string Date;
            public DateTime Time;
            public string MyText;
            public string TipeEvent;
        }
        List<Record> RecordsList = new List<Record>();
        List<Record> NewRecordsList = new List<Record>();
        List<Record> SortRecordsList = new List<Record>();
        public FormOrg()
        {
            InitializeComponent();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            ListViewItem lvi = new ListViewItem(DataForm.MyEvent);
            lvi.SubItems.Add(Convert.ToString(DataForm.Time.ToLongTimeString()));
            lvi.SubItems.Add(DataForm.Date);
            ListView.Items.Add(lvi);
            Record record;
            record.MyText = DataForm.MyEvent;
            record.Time = DataForm.Time;
            record.Date = DataForm.Date;
            record.TipeEvent = DataForm.MyTipe;
            RecordsList.Add(record);
            NewRecordsList.Add(record);
        }
        private void FormOrg_Load(object sender, EventArgs e)
        {
            ListView.ContextMenuStrip = ContextMenu;
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime = RecordsList[0].Time;
                ListView.Items.Clear();
                SortRecordsList.Clear();
                for (int i = 0, index = 0; i < RecordsList.Count;)
                {
                    if (DateTime.Compare(Convert.ToDateTime(RecordsList[i].Time.ToLongTimeString()), Convert.ToDateTime(dateTime.ToLongTimeString())) < 0)
                    {
                        dateTime = RecordsList[i].Time;
                        index = i;
                        i = 0;
                    }
                    else
                    {
                        i++;
                    }
                    if (i >= RecordsList.Count)
                    {
                        ListViewItem lvi = new ListViewItem(RecordsList[index].MyText);
                        lvi.SubItems.Add(Convert.ToString(RecordsList[index].Time.ToLongTimeString()));
                        lvi.SubItems.Add(RecordsList[index].Date);
                        ListView.Items.Add(lvi);
                        SortRecordsList.Add(RecordsList[index]);
                        RecordsList.RemoveAt(index);
                        index = 0;
                        i = 0;
                        if (RecordsList.Count != 0)
                            dateTime = RecordsList[0].Time;
                    }
                }
                RecordsList.Clear();
                for (int i = 0; i < NewRecordsList.Count; i++)
                {
                    RecordsList.Add(NewRecordsList[i]);
                }
            }
            catch
            {
                MessageBox.Show("Данные уже отсортированы БАЛБЕС");
            }
        }

        private void Tipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Category.Checked)
            {
                ListView.Items.Clear();
                if (Tipe.SelectedIndex == 0)
                {
                    ListView.Items.Clear();
                    if (SortRecordsList.Count == 0)
                    {
                        ListView.Items.Clear();
                        for (int i = 0; i < RecordsList.Count; i++)
                        {
                            if (RecordsList[i].TipeEvent == "Meeting")
                            {
                                ListViewItem lvi = new ListViewItem(RecordsList[i].MyText);
                                lvi.SubItems.Add(Convert.ToString(RecordsList[i].Time.ToLongTimeString()));
                                lvi.SubItems.Add(RecordsList[i].Date);
                                ListView.Items.Add(lvi);
                            }
                        }
                    }
                    else
                    {
                        ListView.Items.Clear();
                        for (int i = 0; i < SortRecordsList.Count; i++)
                        {
                            if (SortRecordsList[i].TipeEvent == "Meeting")
                            {
                                ListViewItem lvi = new ListViewItem(SortRecordsList[i].MyText);
                                lvi.SubItems.Add(Convert.ToString(SortRecordsList[i].Time.ToLongTimeString()));
                                lvi.SubItems.Add(SortRecordsList[i].Date);
                                ListView.Items.Add(lvi);
                            }
                        }
                    }
                }
                if (Tipe.SelectedIndex == 1)
                {
                    ListView.Items.Clear();
                    if (SortRecordsList.Count == 0)
                    {
                        ListView.Items.Clear();
                        for (int i = 0; i < RecordsList.Count; i++)
                        {
                            if (RecordsList[i].TipeEvent == "Task")
                            {
                                ListViewItem lvi = new ListViewItem(RecordsList[i].MyText);
                                lvi.SubItems.Add(Convert.ToString(RecordsList[i].Time.ToLongTimeString()));
                                lvi.SubItems.Add(RecordsList[i].Date);
                                ListView.Items.Add(lvi);
                            }
                        }
                    }
                    else
                    {
                        ListView.Items.Clear();
                        for (int i = 0; i < SortRecordsList.Count; i++)
                        {
                            if (SortRecordsList[i].TipeEvent == "Task")
                            {
                                ListViewItem lvi = new ListViewItem(SortRecordsList[i].MyText);
                                lvi.SubItems.Add(Convert.ToString(SortRecordsList[i].Time.ToLongTimeString()));
                                lvi.SubItems.Add(SortRecordsList[i].Date);
                                ListView.Items.Add(lvi);
                            }
                        }
                    }
                }
                if (Tipe.SelectedIndex == 2)
                {
                    ListView.Items.Clear();
                    if (SortRecordsList.Count == 0)
                    {
                        ListView.Items.Clear();
                        for (int i = 0; i < RecordsList.Count; i++)
                        {
                            if (RecordsList[i].TipeEvent == "Memo")
                            {
                                ListViewItem lvi = new ListViewItem(RecordsList[i].MyText);
                                lvi.SubItems.Add(Convert.ToString(RecordsList[i].Time.ToLongTimeString()));
                                lvi.SubItems.Add(RecordsList[i].Date);
                                ListView.Items.Add(lvi);
                            }
                        }
                    }
                    else
                    {
                        ListView.Items.Clear();
                        for (int i = 0; i < SortRecordsList.Count; i++)
                        {
                            if (SortRecordsList[i].TipeEvent == "Memo")
                            {
                                ListViewItem lvi = new ListViewItem(SortRecordsList[i].MyText);
                                lvi.SubItems.Add(Convert.ToString(SortRecordsList[i].Time.ToLongTimeString()));
                                lvi.SubItems.Add(SortRecordsList[i].Date);
                                ListView.Items.Add(lvi);
                            }
                        }
                    }
                }
            }
        }

        private void Category_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void All_CheckedChanged(object sender, EventArgs e)
        {
            if (All.Checked)
            {
                ListView.Items.Clear();
                if (SortRecordsList.Count == 0 || SortRecordsList.Count != RecordsList.Count)
                {
                    for (int i = 0; i < RecordsList.Count; i++)
                    {
                        ListViewItem lvi = new ListViewItem(RecordsList[i].MyText);
                        lvi.SubItems.Add(Convert.ToString(RecordsList[i].Time.ToLongTimeString()));
                        lvi.SubItems.Add(RecordsList[i].Date);
                        ListView.Items.Add(lvi);
                    }
                }
                else
                {
                    for (int i = 0; i < SortRecordsList.Count; i++)
                    {
                        ListViewItem lvi = new ListViewItem(SortRecordsList[i].MyText);
                        lvi.SubItems.Add(Convert.ToString(SortRecordsList[i].Time.ToLongTimeString()));
                        lvi.SubItems.Add(SortRecordsList[i].Date);
                        ListView.Items.Add(lvi);
                    }
                }
            }
        }

        private void Find_Click(object sender, EventArgs e)
        {
            ListView.Items.Clear();
            RecordsList.Clear();
            for (int i = 0; i < NewRecordsList.Count; i++)
            {
                RecordsList.Add(NewRecordsList[i]);
            }
            Form4 form4 = new Form4();
            form4.ShowDialog();
            for(int i = 0; i < RecordsList.Count; i++)
            {
                if (RecordsList[i].MyText.Contains(DataForm.FindText))
                {
                    ListViewItem lvi = new ListViewItem(RecordsList[i].MyText);
                    lvi.SubItems.Add(Convert.ToString(RecordsList[i].Time.ToLongTimeString()));
                    lvi.SubItems.Add(RecordsList[i].Date);
                    ListView.Items.Add(lvi);
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                if (ListView.Items.Count != 0)
                {
                    for (int i = 0; i < RecordsList.Count; i++)
                    {
                        if (ListView.SelectedItems[0].Text == RecordsList[i].MyText)
                        {
                            RecordsList.RemoveAt(i);
                        }
                        if (ListView.SelectedItems[0].Text == NewRecordsList[i].MyText)
                        {
                            NewRecordsList.RemoveAt(i);
                        }
                        if (SortRecordsList.Count != 0 && ListView.SelectedItems[0].Text == SortRecordsList[i].MyText)
                        {
                            SortRecordsList.RemoveAt(i);
                        }
                    }
                    ListView.Items.Remove(ListView.SelectedItems[0]);
                }
            }
            else if(result == DialogResult.No)
            {

            }
        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            if(ListView.Items.Count != 0)
            {
                for (int i = 0; i < RecordsList.Count; i++)
                {
                    Record rec;
                    rec.MyText = DataForm.MyEvent;
                    rec.Time = DataForm.Time;
                    rec.Date = DataForm.Date;
                    rec.TipeEvent = DataForm.MyTipe;
                    if (ListView.SelectedItems[0].Text == RecordsList[i].MyText)
                    {
                        RecordsList.RemoveAt(i);
                        RecordsList.Insert(i, rec);
                    }
                    if (ListView.SelectedItems[0].Text == NewRecordsList[i].MyText)
                    {
                        NewRecordsList.RemoveAt(i);
                        NewRecordsList.Insert(i, rec);
                    }
                    if (SortRecordsList.Count != 0 && ListView.SelectedItems[0].Text == SortRecordsList[i].MyText)
                    {
                        SortRecordsList.RemoveAt(i);
                        SortRecordsList.Insert(i, rec);
                    }
                }
                ListView.SelectedItems[0].Text = DataForm.MyEvent;
                ListView.SelectedItems[0].SubItems[1].Text = Convert.ToString(DataForm.Time);
                ListView.SelectedItems[0].SubItems[2].Text = DataForm.Date;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
