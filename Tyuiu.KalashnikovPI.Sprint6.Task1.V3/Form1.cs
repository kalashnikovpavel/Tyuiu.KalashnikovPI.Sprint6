using Tyuiu.KalashnikovPI.Sprint6.Task1.V3.Lib;
namespace Tyuiu.KalashnikovPI.Sprint6.Task1.V3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            int startStep = -5;
            int stopStep = 5;
            string strLine;
            int len = ds.GetMassFunction(startStep, stopStep).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startStep, stopStep);
            textBoxResult.Text = "";
            textBoxResult.AppendText("+---------+--------------+" + Environment.NewLine);
            textBoxResult.AppendText("|    X    |      f(x)    |" + Environment.NewLine);
            textBoxResult.AppendText("+---------+--------------+" + Environment.NewLine);

            for (int i = 0; i <= len - 1; i++)
            {
                strLine = String.Format("|{0,5:d}    |    {1, 5:f2}    | ", startStep, valueArray[i]);
                textBoxResult.AppendText(strLine + Environment.NewLine);
                startStep++;
            }

            textBoxResult.AppendText("+---------+--------------+" + Environment.NewLine);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
