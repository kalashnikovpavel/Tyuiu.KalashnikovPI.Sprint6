using Tyuiu.KalashnikovPI.Sprint6.Task5.V8.Lib;
namespace Tyuiu.KalashnikovPI.Sprint6.Task5.V8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = Path.Combine(new string[] { Path.GetTempPath(), "InPutDataFileTask5V8.txt" });
        private void buttonRes_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Width = 20;
            dataGridView1.Columns[1].Width = 50;
            double[] numMass = new double[ds.len];
            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridView1.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
            }
        }
    }
}
