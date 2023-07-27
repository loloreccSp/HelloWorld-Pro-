using System.Text;

namespace Lesson
{

    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {

                Console.Write("\nHello! It's calculator, my all math actions: '+', '-', '*', '/' and degree ('^'). Please enter your first number: ");
                double first_num = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nPlease enter math action: ");
                char action = Convert.ToChar(Console.ReadLine());


                string math = action.ToString();

                if (math == "^")
                {
                    Console.WriteLine("\nEnter degree: ");
                    int degree = Convert.ToInt32(Console.ReadLine());
                    Calculator sos = new Calculator(first_num, action, 0, degree);

                }
                else
                {
                    Console.WriteLine("\nEnter second number: ");
                    double second_num = Convert.ToDouble(Console.ReadLine());
                    Calculator sos = new Calculator(first_num, action, second_num, 0);

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
    }

}