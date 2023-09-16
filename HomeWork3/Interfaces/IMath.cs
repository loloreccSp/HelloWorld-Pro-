
namespace HomeWork3.Interfaces
{
    public interface IMath
    {
        int Maxx(int[] numbers)
        {
            int max = numbers.Max();
            return max;
        }
        int Minn(int[] numbers)
        {
            return numbers.Min();
        }
        double Aveg(int[] numbers)
        {
            return numbers.Average();
        }
        bool Search(int valueToSearch, int[] numbers)
        {
            foreach (int value in numbers) 
            {
                if (valueToSearch == value)
                    return true;
            }
            return false;
        }
    }
}
