using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    enum Math
    {
        Plus = '+',
        Minus = '-',
        Multiplyce = '*',
        Divide = '/',
        Degree = '^'
    }


    public class Calculator
    {
        public double first_num;
        public char math_action;
        public double second_num;
        public int amout;


        public Calculator(double first_num, char math_action, double second_num, int amout)
        {
            this.first_num = first_num;
            this.math_action = math_action;
            this.second_num = second_num;
            this.amout = amout;

            try
            {
                switch (math_action)
                {
                    case (char)Math.Plus:
                        Console.WriteLine($"\n {first_num} {math_action} {second_num} = {first_num + second_num} ");
                        break;
                    case (char)Math.Minus:
                        Console.WriteLine($"\n {first_num} {math_action} {second_num} = {first_num - second_num} ");
                        break;
                    case (char)Math.Multiplyce:
                        Console.WriteLine($"\n {first_num} {math_action} {second_num} = {first_num * second_num} ");
                        break;
                    case (char)Math.Divide:
                        Console.WriteLine($"\n {first_num} {math_action} {second_num} = {first_num / second_num} ");
                        break;
                    case (char)Math.Degree:
                        double result = 1;
                        for (int i = 1; i <= amout; i++)
                        {
                            result *= first_num;
                        }
                        Console.WriteLine($"{result}");
                        break;
                    default:
                        Console.WriteLine("Incorrect action!");
                        throw new Exception("Error");
                }


            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter only numbers!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero!");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }

        public void Result()
        {
            
        }
        


        
    }
}
