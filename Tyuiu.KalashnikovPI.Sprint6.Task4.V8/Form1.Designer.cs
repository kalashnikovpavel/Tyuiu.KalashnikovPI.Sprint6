namespace Tyuiu.KalashnikovPI.Sprint6.Task4.V8
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
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            textBoxStop = new TextBox();
            groupBox3 = new GroupBox();
            textBoxStart = new TextBox();
            groupBox5 = new GroupBox();
            textBoxResult = new TextBox();
            buttonResult = new Button();
            buttonSave = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(353, 72);
            textBox1.TabIndex = 0;
            textBox1.Text = "написать программу которая выводит таблицу згачений функции";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(393, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(395, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBoxStop);
            groupBox4.Location = new Point(128, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(116, 50);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Конец шага:";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(6, 22);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.ReadOnly = true;
            textBoxStop.Size = new Size(100, 23);
            textBoxStop.TabIndex = 0;
            textBoxStop.Text = "5";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxStart);
            groupBox3.Location = new Point(6, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(116, 50);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Старт шага:";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 21);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.ReadOnly = true;
            textBoxStart.Size = new Size(100, 23);
            textBoxStart.TabIndex = 0;
            textBoxStart.Text = "-5";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBoxResult);
            groupBox5.Location = new Point(18, 118);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(200, 320);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "Вывод";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 22);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(188, 292);
            textBoxResult.TabIndex = 3;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(696, 397);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(92, 41);
            buttonResult.TabIndex = 4;
            buttonResult.Text = "Результат";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(598, 397);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(92, 41);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(buttonResult);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Спринт 6 | Таск 4 | Вариант 8 | Калашников П. И.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private TextBox textBoxStop;
        private GroupBox groupBox3;
        private TextBox textBoxStart;
        private GroupBox groupBox5;
        private TextBox textBoxResult;
        private Button buttonResult;
        private Button buttonSave;
    }
}
