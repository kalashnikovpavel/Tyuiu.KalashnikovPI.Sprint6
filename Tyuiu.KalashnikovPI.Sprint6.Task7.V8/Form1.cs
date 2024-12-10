using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.KalashnikovPI.Sprint6.Task7.V8.Lib;

namespace Tyuiu.KalashnikovPI.Sprint6.Task7.V8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;

            // Загрузка матрицы из .csv файла
            int[,] arrayValues = ds.GetMatrix(openFilePath);
            rows = arrayValues.GetLength(0);
            columns = arrayValues.GetLength(1);

            // Настройка DataGridView
            dataGridView1.ColumnCount = columns;
            dataGridView1.RowCount = rows;
            dataGridView2.ColumnCount = columns;
            dataGridView2.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridView1.Columns[i].Width = 25;
                dataGridView2.Columns[i].Width = 25;
            }

            // Заполнение первого DataGridView
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridView1.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            // Установка кнопки "Готово" в активное состояние
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            // Получение измененной матрицы из DataService
            int[,] arrayValues = ds.GetMatrix(openFilePath);

            // Заполнение второго DataGridView
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridView2.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            // Установка кнопки "Сохранить" в активное состояние
            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "OutPutFileTask7.csv";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.ShowDialog();

            string path = saveFileDialog1.FileName;

            // Проверка на существование файла и удаление, если необходимо
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            int rows = dataGridView2.RowCount;
            int columns = dataGridView2.ColumnCount;

            // Сохранение данных в .csv файл
            for (int i = 0; i < rows; i++)
            {
                string str = "";
                for (int j = 0; j < columns; j++)
                {
                    str += dataGridView2.Rows[i].Cells[j].Value;

                    // Добавление запятой, если это не последний элемент строки
                    if (j != columns - 1)
                    {
                        str += ",";
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
            }
        }
    }
}
