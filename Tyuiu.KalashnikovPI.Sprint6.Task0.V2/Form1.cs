using Tyuiu.KalashnikovPI.Sprint6.Task0.V2.Lib;

namespace Tyuiu.KalashnikovPI.Sprint6.Task0.V2
{
    public partial class Form1 : Form
    {
        int x = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void task_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttunDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            textBoxResult.Text = Convert.ToString(ds.Calculate(x));
        }
    }
}
