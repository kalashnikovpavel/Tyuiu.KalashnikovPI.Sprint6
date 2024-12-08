namespace Tyuiu.KalashnikovPI.Sprint6.Task2.V2
{
    partial class Form1
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
            textBoxValue = new TextBox();
            textBoxStopValue = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(12, 415);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.ReadOnly = true;
            textBoxValue.Size = new Size(100, 23);
            textBoxValue.TabIndex = 0;
            textBoxValue.Text = "-5";
            textBoxValue.TextChanged += textBox1_TextChanged;
            // 
            // textBoxStopValue
            // 
            textBoxStopValue.Location = new Point(118, 415);
            textBoxStopValue.Name = "textBoxStopValue";
            textBoxStopValue.ReadOnly = true;
            textBoxStopValue.Size = new Size(100, 23);
            textBoxStopValue.TabIndex = 1;
            textBoxStopValue.Text = "5";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(410, 250);
            textBox1.TabIndex = 2;
            textBox1.Text = "протабулировать функцию";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(578, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(618, 426);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "f(x)";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 50;
            // 
            // button1
            // 
            button1.Location = new Point(296, 388);
            button1.Name = "button1";
            button1.Size = new Size(126, 49);
            button1.TabIndex = 4;
            button1.Text = "Выполнить\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(textBoxStopValue);
            Controls.Add(textBoxValue);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxValue;
        private TextBox textBoxStopValue;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button button1;
    }
}
