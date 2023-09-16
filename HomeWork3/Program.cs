
using HomeWork3.Interfaces;
using System.Collections;
using System.Collections.Immutable;
using System.Text;

namespace Homework3
{

    public class Array : IOutput, IMath, ISort
    {
        public List<int> numbers { get; set; }
        public Array(List<int> numbers)
        {
            this.numbers = numbers;
        }

        public void Show()
        {
            foreach (int i in numbers)
            {
                Console.Write($"{i}, ");
            }
        }

        public void Show(string info)
        {
            foreach (int i in numbers)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine($"{info}");
        }
        public int Maxx()
        {
            return numbers.Max();
        }
        public int Minn()
        {
            return numbers.Min();           
        }
        public double Aveg()
        {
            return numbers.Average();
        }
        public bool Search(int valueToSearch)
        {
            foreach (int value in numbers)
            {
                if (valueToSearch == value)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        public void SortAsc()
        {
            numbers.Sort();
        }
        public void SortDesc()
        {
            numbers.Sort();
            numbers.Reverse();
        }
        public void SortByParam(bool isAsk)
        {
            if (isAsk == true)
            {
                numbers.Sort();
            }
            else
            {
                numbers.Sort();
                numbers.Reverse();
            }
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            ////Завдання 1

            //string info = "This magic numbers";

            //List<int> numbers = new List<int> { 1, 78, 19, 125, 2687 };

            //Array numbs = new Array(numbers);

            //numbs.Show();
            //numbs.Show(info);

            //Завдання 2

            //List<int> numbers = new List<int> { 1, 78, 19, 125, 2687 };
            //try
            //{
            //    Array numbs = new Array(numbers);

            //    Console.WriteLine("Enter number for search: ");
            //    int search = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine($"You were looking for a number {search} - mission {numbs.Search(search)}");

            //    Console.WriteLine($"Max number: {numbs.Maxx()}");

            //    Console.WriteLine($"Min number: {numbs.Minn()}");

            //    Console.WriteLine($"Average: {numbs.Aveg()}");


            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Incorrect format! Enter only number!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            // Задание 3

            //try
            //{

            //    List<int> numbers = new List<int> { 1, 78, 19, 125, 2687 };

            //    Array numbs = new Array(numbers);

            //    //numbs.SortAsc();

            //    //for (int i = 0; i < numbers.Count; i++)
            //    //{
            //    //    int num = numbers[i];
            //    //    Console.WriteLine(num);
            //    //}

            //    //numbs.SortDesc();

            //    //for (int i = 0; i < numbers.Count; i++)
            //    //{
            //    //    int num = numbers[i];
            //    //    Console.WriteLine(num);
            //    //}    

            //    Console.WriteLine("Enter 1 for sorting; enter 0 for reverse sorting");
            //    int sortInfo = Convert.ToInt32(Console.ReadLine());

            //    if (sortInfo == 1)
            //    {
            //        numbs.SortAsc();

            //        for (int i = 0; i < numbers.Count; i++)
            //        {
            //            int num = numbers[i];

            //            Console.WriteLine($"Sorted: {num}");
            //        }

            //    }
            //    else if (sortInfo == 0)
            //    {
            //        numbs.SortDesc();

            //        for (int i = 0; i < numbers.Count; i++)
            //        {
            //            int num = numbers[i];
            //            Console.WriteLine($"Reversed sort: {num}");
            //        }
            //    }
            //    else
            //    {
            //        throw new Exception("Incorrect number!");
            //    }

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Error!" +
            //        " Incorrect number!");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}




        }
    }
}