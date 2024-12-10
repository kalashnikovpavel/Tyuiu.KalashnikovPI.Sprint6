using Tyuiu.KalashnikovPI.Sprint6.Task6.V27.Lib;
namespace Tyuiu.KalashnikovPI.Sprint6.Task6.V27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonInout_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxOut.Text = ds.CollectTextFromFile(str, openFilePath);
        }

        private void buttonOutPut_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            textBoxOut.Text = File.ReadAllText(openFilePath);
            groupBox3.Text = groupBox3.Text + " " + openFileDialog1.FileName;
            
        }
    }
}
