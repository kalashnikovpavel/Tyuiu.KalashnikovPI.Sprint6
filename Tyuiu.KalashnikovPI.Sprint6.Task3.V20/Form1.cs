using Tyuiu.KalashnikovPI.Sprint6.Task3.V2.Lib;
namespace Tyuiu.KalashnikovPI.Sprint6.Task3.V20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -14, 17, -19, 3, 2 }, { -4, -14, -19, -9, -1 }, { 1, 0, 13, 14, 8 }, { 13, 7, 8, -3, -15 }, { 2, -20, 12, -14, 4 } };
        private void Form1_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int cols = mtrx.Length / rows;

            dataGridView1.ColumnCount = cols;
            dataGridView1.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridView1.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mtrx = ds.Calculate(mtrx);

            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = mtrx[i, j];
                }
            }

            textBox2.Clear(); 
            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    textBox2.AppendText(mtrx[i, j].ToString() + " ");
                }
                textBox2.AppendText(Environment.NewLine); 
            }
        }
    }
}
