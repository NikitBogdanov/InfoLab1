
namespace InfoLab1
{
    partial class FormOrg
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Category = new System.Windows.Forms.RadioButton();
            this.All = new System.Windows.Forms.RadioButton();
            this.Tipe = new System.Windows.Forms.ComboBox();
            this.ListView = new System.Windows.Forms.ListView();
            this.Event = new System.Windows.Forms.ColumnHeader();
            this.Time = new System.Windows.Forms.ColumnHeader();
            this.Data = new System.Windows.Forms.ColumnHeader();
            this.Filter = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.Category, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.All, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Tipe, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ListView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Filter, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Find, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Add, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.37126F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.26946F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.35928F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(3, 3);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(186, 24);
            this.Category.TabIndex = 0;
            this.Category.TabStop = true;
            this.Category.Text = "Конкретная категория";
            this.Category.UseVisualStyleBackColor = true;
            this.Category.CheckedChanged += new System.EventHandler(this.Category_CheckedChanged);
            // 
            // All
            // 
            this.All.AutoSize = true;
            this.All.Location = new System.Drawing.Point(3, 52);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(129, 24);
            this.All.TabIndex = 1;
            this.All.TabStop = true;
            this.All.Text = "Все категории";
            this.All.UseVisualStyleBackColor = true;
            this.All.CheckedChanged += new System.EventHandler(this.All_CheckedChanged);
            // 
            // Tipe
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Tipe, 2);
            this.Tipe.FormattingEnabled = true;
            this.Tipe.Items.AddRange(new object[] {
            "Meeting",
            "Task",
            "Memo"});
            this.Tipe.Location = new System.Drawing.Point(261, 3);
            this.Tipe.Name = "Tipe";
            this.Tipe.Size = new System.Drawing.Size(512, 28);
            this.Tipe.TabIndex = 2;
            this.Tipe.SelectedIndexChanged += new System.EventHandler(this.Tipe_SelectedIndexChanged);
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Event,
            this.Time,
            this.Data});
            this.tableLayoutPanel1.SetColumnSpan(this.ListView, 3);
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(3, 104);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(770, 233);
            this.ListView.TabIndex = 3;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            // 
            // Event
            // 
            this.Event.Text = "Event";
            this.Event.Width = 100;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 90;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 200;
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(3, 343);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(252, 80);
            this.Filter.TabIndex = 4;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(261, 343);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(252, 80);
            this.Find.TabIndex = 5;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(519, 343);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(254, 80);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ContextMenu
            // 
            this.ContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(148, 52);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // FormOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormOrg";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormOrg_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion   

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton Category;
        private System.Windows.Forms.RadioButton All;
        private System.Windows.Forms.ComboBox Tipe;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader Event;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader d;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Data;
    }
}