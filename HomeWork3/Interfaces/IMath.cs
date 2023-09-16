
namespace HomeWork3.Interfaces
{
    public interface IMath
    {
        int Maxx(int[] numbers)
        {
            //if (numbers == null)
            //{
            //    Console.WriteLine("Error!");
            //}
            //return numbers.Max(x => x);
            //foreach (int number in numbers) 
            //{
            //    Math.Max(number, number);
            //    return number;
            //}
            //return Math.Max(0, numbers);
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
