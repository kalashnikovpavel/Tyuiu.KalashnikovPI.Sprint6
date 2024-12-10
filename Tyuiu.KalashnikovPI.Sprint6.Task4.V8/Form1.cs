using System.IO;
using Tyuiu.KalashnikovPI.Sprint6.Task4.V8.Lib;
namespace Tyuiu.KalashnikovPI.Sprint6.Task4.V8
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

        private void buttonResult_Click(object sender, EventArgs e)
        {
             try
            {
                int startstep = Convert.ToInt32(textBoxStart.Text);
                int stopstep = Convert.ToInt32(textBoxStop.Text);
                int len = ds.GetMassFunction(startstep, stopstep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startstep, stopstep);
                textBoxResult.Text = "";
                for (int i = 0; i <= len - 1; i++)
                {
                    textBoxResult.AppendText(valueArray[i] + Environment.NewLine);
                    startstep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask4V8.txt" });
                File.WriteAllText(path, textBoxResult.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно\n Открыть в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
