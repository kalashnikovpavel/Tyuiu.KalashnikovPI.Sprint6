using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KalashnikovPI.Sprint6.Task7.V8.Lib
{
    public class DataService : ISprint6Task7V8
    {
        public int[,] GetMatrix(string path)
        {
            var lines = File.ReadAllLines(path);
            int rowCount = lines.Length;
            int colCount = lines[0].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Length;

            // Создаем матрицу
            int[,] matrix = new int[rowCount, colCount];

            // Заполняем матрицу значениями из файла
            for (int i = 0; i < rowCount; i++)
            {
                var values = lines[i].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < colCount; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            // Изменяем значения в восьмом столбце
            for (int i = 0; i < rowCount; i++)
            {
                if (matrix[i, 7] != 5) // Проверяем 8-й столбец (индекс 7)
                {
                    matrix[i, 7] = -1; // Устанавливаем -1, если не равно 5
                }
            }

            return matrix;
        }
    }
}
