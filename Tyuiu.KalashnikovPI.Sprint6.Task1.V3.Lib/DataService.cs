using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KalashnikovPI.Sprint6.Task1.V3.Lib
{
    public class DataService : ISprint6Task1V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue)+ 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((5 - 3*x + ((1+Math.Sin(x))/(2*x-0.5))), 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
