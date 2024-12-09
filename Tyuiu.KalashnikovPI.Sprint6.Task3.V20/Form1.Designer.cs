namespace Tyuiu.KalashnikovPI.Sprint6.Task3.V20
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(643, 438);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(305, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(332, 410);
            dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(293, 215);
            textBox1.TabIndex = 1;
            textBox1.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в пятой строке на 0.\r\n\r\n-14  17 -19   3   2\r\n\r\n  -4 -14 -19  -9  -1\r\n\r\n   1   0  13  14   8\r\n\r\n  13   7   8  -3 -15\r\n\r\n   2 -20  12 -14   4";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(661, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // button1
            // 
            button1.Location = new Point(208, 390);
            button1.Name = "button1";
            button1.Size = new Size(88, 30);
            button1.TabIndex = 1;
            button1.Text = "Выполнить\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Location = new Point(6, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(296, 203);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Результат";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 22);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(284, 175);
            textBox2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 20 | Калашников П.И.";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
