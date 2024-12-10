namespace Tyuiu.KalashnikovPI.Sprint6.Task6.V27
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
            buttonInout = new Button();
            buttonOutPut = new Button();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBoxIn = new TextBox();
            groupBox3 = new GroupBox();
            textBoxOut = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonInout
            // 
            buttonInout.Location = new Point(12, 12);
            buttonInout.Name = "buttonInout";
            buttonInout.Size = new Size(134, 52);
            buttonInout.TabIndex = 0;
            buttonInout.Text = "выполнить";
            buttonInout.UseVisualStyleBackColor = true;
            buttonInout.Click += buttonInout_Click;
            // 
            // buttonOutPut
            // 
            buttonOutPut.Location = new Point(152, 12);
            buttonOutPut.Name = "buttonOutPut";
            buttonOutPut.Size = new Size(134, 52);
            buttonOutPut.TabIndex = 1;
            buttonOutPut.Text = "вывод";
            buttonOutPut.UseVisualStyleBackColor = true;
            buttonOutPut.Click += buttonOutPut_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(308, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(468, 72);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxIn);
            groupBox2.Location = new Point(12, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(376, 304);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод";
            // 
            // textBoxIn
            // 
            textBoxIn.Location = new Point(6, 22);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.Size = new Size(364, 276);
            textBoxIn.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxOut);
            groupBox3.Location = new Point(406, 134);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(376, 304);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод";
            // 
            // textBoxOut
            // 
            textBoxOut.Location = new Point(6, 22);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.Size = new Size(364, 276);
            textBoxOut.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonOutPut);
            Controls.Add(buttonInout);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonInout;
        private Button buttonOutPut;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBoxIn;
        private GroupBox groupBox3;
        private TextBox textBoxOut;
        private OpenFileDialog openFileDialog1;
    }
}
