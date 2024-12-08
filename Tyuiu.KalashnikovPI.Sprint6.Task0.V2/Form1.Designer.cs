using Tyuiu.KalashnikovPI.Sprint6.Task0.V2.Lib;
namespace Tyuiu.KalashnikovPI.Sprint6.Task0.V2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxResult = new TextBox();
            task = new TextBox();
            pictureBox1 = new PictureBox();
            buttunDone = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(12, 115);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(139, 23);
            textBoxResult.TabIndex = 0;
            textBoxResult.TextChanged += textBox1_TextChanged;
            // 
            // task
            // 
            task.Location = new Point(12, 37);
            task.Multiline = true;
            task.Name = "task";
            task.ReadOnly = true;
            task.Size = new Size(567, 42);
            task.TabIndex = 1;
            task.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой. ";
            task.TextChanged += task_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(585, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 71);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // buttunDone
            // 
            buttunDone.BackColor = SystemColors.Control;
            buttunDone.Location = new Point(585, 115);
            buttunDone.Name = "buttunDone";
            buttunDone.Size = new Size(105, 38);
            buttunDone.TabIndex = 3;
            buttunDone.Text = "Выполнить\r\n";
            buttunDone.UseVisualStyleBackColor = false;
            buttunDone.Click += buttunDone_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 175);
            Controls.Add(buttunDone);
            Controls.Add(pictureBox1);
            Controls.Add(task);
            Controls.Add(textBoxResult);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 |Таск 0 |Вариант2|Калашников П.И.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResult;
        private TextBox task;
        private PictureBox pictureBox1;
        private Button buttunDone;
    }
}
