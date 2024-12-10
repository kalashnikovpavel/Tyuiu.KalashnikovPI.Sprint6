namespace Tyuiu.KalashnikovPI.Sprint6.Task7.V8
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
            groupBoxButtons = new GroupBox();
            buttonSave = new Button();
            buttonDone = new Button();
            button1 = new Button();
            groupBoxUsl = new GroupBox();
            textBox1 = new TextBox();
            groupBoxIn = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBoxOut = new GroupBox();
            dataGridView2 = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBoxButtons.SuspendLayout();
            groupBoxUsl.SuspendLayout();
            groupBoxIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBoxButtons
            // 
            groupBoxButtons.Controls.Add(buttonSave);
            groupBoxButtons.Controls.Add(buttonDone);
            groupBoxButtons.Controls.Add(button1);
            groupBoxButtons.Location = new Point(12, 12);
            groupBoxButtons.Name = "groupBoxButtons";
            groupBoxButtons.Size = new Size(776, 100);
            groupBoxButtons.TabIndex = 0;
            groupBoxButtons.TabStop = false;
            // 
            // buttonSave
            // 
            buttonSave.Image = Properties.Resources.page_save;
            buttonSave.Location = new Point(268, 19);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(125, 75);
            buttonSave.TabIndex = 2;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.Image = Properties.Resources.page_go;
            buttonDone.Location = new Point(137, 19);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(125, 75);
            buttonDone.TabIndex = 1;
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.folder_page1;
            button1.Location = new Point(6, 19);
            button1.Name = "button1";
            button1.Size = new Size(125, 75);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBoxUsl
            // 
            groupBoxUsl.Controls.Add(textBox1);
            groupBoxUsl.Location = new Point(18, 118);
            groupBoxUsl.Name = "groupBoxUsl";
            groupBoxUsl.Size = new Size(770, 100);
            groupBoxUsl.TabIndex = 1;
            groupBoxUsl.TabStop = false;
            groupBoxUsl.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(758, 72);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(dataGridView1);
            groupBoxIn.Location = new Point(18, 224);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(387, 255);
            groupBoxIn.TabIndex = 2;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Ввод";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(381, 227);
            dataGridView1.TabIndex = 0;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(dataGridView2);
            groupBoxOut.Location = new Point(411, 224);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(377, 255);
            groupBoxOut.TabIndex = 3;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(365, 227);
            dataGridView2.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 491);
            Controls.Add(groupBoxOut);
            Controls.Add(groupBoxIn);
            Controls.Add(groupBoxUsl);
            Controls.Add(groupBoxButtons);
            Name = "Form1";
            Text = "Спринт 6 | Таск 7 | Вариант 8 | Калашников | П. И.";
            groupBoxButtons.ResumeLayout(false);
            groupBoxUsl.ResumeLayout(false);
            groupBoxUsl.PerformLayout();
            groupBoxIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxButtons;
        private Button button1;
        private Button buttonSave;
        private Button buttonDone;
        private GroupBox groupBoxUsl;
        private TextBox textBox1;
        private GroupBox groupBoxIn;
        private GroupBox groupBoxOut;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
