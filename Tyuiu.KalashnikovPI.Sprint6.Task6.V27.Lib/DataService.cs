using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KalashnikovPI.Sprint6.Task6.V27.Lib
{
    public class DataService : ISprint6Task6V27
    {
        public string CollectTextFromFile(string str, string path)
        {
            StringBuilder result = new StringBuilder();
            
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in words)
                    {
                        
                        if (word.Contains("H"))
                        {
                            
                            result.Append(word + " ");
                        }
                    }
                }
            }
            return result.ToString().Trim();
        }
    }
}
