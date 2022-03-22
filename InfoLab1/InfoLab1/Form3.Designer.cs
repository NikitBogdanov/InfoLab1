
namespace InfoLab1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.Okey = new System.Windows.Forms.Button();
            this.TextBoxEve = new System.Windows.Forms.TextBox();
            this.ComboBoxTipe = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.MonthCalendar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Okey, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxEve, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxTipe, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.77235F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.22764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(793, 444);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonthCalendar.CalendarDimensions = new System.Drawing.Size(4, 1);
            this.tableLayoutPanel1.SetColumnSpan(this.MonthCalendar, 3);
            this.MonthCalendar.Location = new System.Drawing.Point(9, 9);
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.TabIndex = 0;
            // 
            // Okey
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Okey, 3);
            this.Okey.Location = new System.Drawing.Point(3, 328);
            this.Okey.Name = "Okey";
            this.Okey.Size = new System.Drawing.Size(787, 113);
            this.Okey.TabIndex = 1;
            this.Okey.Text = "OK";
            this.Okey.UseVisualStyleBackColor = true;
            this.Okey.Click += new System.EventHandler(this.Okey_Click);
            // 
            // TextBoxEve
            // 
            this.TextBoxEve.Location = new System.Drawing.Point(267, 272);
            this.TextBoxEve.Name = "TextBoxEve";
            this.TextBoxEve.Size = new System.Drawing.Size(258, 27);
            this.TextBoxEve.TabIndex = 2;
            // 
            // ComboBoxTipe
            // 
            this.ComboBoxTipe.FormattingEnabled = true;
            this.ComboBoxTipe.Items.AddRange(new object[] {
            "Meeting",
            "Task",
            "Memo"});
            this.ComboBoxTipe.Location = new System.Drawing.Point(531, 272);
            this.ComboBoxTipe.Name = "ComboBoxTipe";
            this.ComboBoxTipe.Size = new System.Drawing.Size(151, 28);
            this.ComboBoxTipe.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 272);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MonthCalendar MonthCalendar;
        private System.Windows.Forms.Button Okey;
        private System.Windows.Forms.TextBox TextBoxEve;
        private System.Windows.Forms.ComboBox ComboBoxTipe;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}