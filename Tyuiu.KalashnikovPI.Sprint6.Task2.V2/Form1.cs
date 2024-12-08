using Tyuiu.KalashnikovPI.Sprint6.Task2.V2.Lib;
namespace Tyuiu.KalashnikovPI.Sprint6.Task2.V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int startStep = -5;
            int stopStep = 5;
            int len = ds.GetMassFunction(startStep, stopStep).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startStep, stopStep);

            for (int i = 0; i <= len - 1; i++)
            {
                this.dataGridView1.Rows.Add(startStep, valueArray[i]);
                startStep++;
            }
        }
    }
}
