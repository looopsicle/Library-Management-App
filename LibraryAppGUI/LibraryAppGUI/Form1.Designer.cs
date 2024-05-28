namespace LibraryAppGUI
{
    partial class adminform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label3 = new Label();
            dataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            label2 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dataGridView);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(28, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(1241, 386);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumOrchid;
            label3.Location = new Point(8, 11);
            label3.Name = "label3";
            label3.Size = new Size(171, 30);
            label3.TabIndex = 5;
            label3.Text = "Books on library";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6 });
            dataGridView.GridColor = Color.White;
            dataGridView.Location = new Point(18, 98);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.ShowEditingIcon = false;
            dataGridView.Size = new Size(1200, 265);
            dataGridView.TabIndex = 4;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.HeaderText = "#";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 39;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Title";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Author";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 233;
            // 
            // Column4
            // 
            Column4.HeaderText = "ISBN";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 234;
            // 
            // Column6
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightCoral;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightCoral;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            Column6.DefaultCellStyle = dataGridViewCellStyle1;
            Column6.FlatStyle = FlatStyle.Flat;
            Column6.HeaderText = "";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Text = "Delete";
            Column6.UseColumnTextForButtonValue = true;
            Column6.Width = 234;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(896, 33);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 3;
            label2.Text = "Search book by title";
            // 
            // button2
            // 
            button2.BackColor = Color.Plum;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1120, 52);
            button2.Name = "button2";
            button2.Size = new Size(98, 26);
            button2.TabIndex = 2;
            button2.Text = "Find";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(895, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Plum;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1120, 88);
            button1.Name = "button1";
            button1.Size = new Size(98, 26);
            button1.TabIndex = 0;
            button1.Text = "Add New Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 49);
            label1.Name = "label1";
            label1.Size = new Size(251, 28);
            label1.TabIndex = 1;
            label1.Text = "Library Management";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(28, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(1241, 138);
            panel2.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(891, 67);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 10;
            label7.Text = "ISBN Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(588, 72);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 9;
            label6.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 69);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Book title";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(895, 90);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(219, 23);
            textBox5.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(588, 90);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(301, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(571, 23);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumOrchid;
            label4.Location = new Point(4, 11);
            label4.Name = "label4";
            label4.Size = new Size(154, 30);
            label4.TabIndex = 1;
            label4.Text = "Add new book";
            // 
            // adminform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1298, 677);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            MinimumSize = new Size(1314, 716);
            Name = "adminform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private DataGridView dataGridView;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn Column6;
    }
}
