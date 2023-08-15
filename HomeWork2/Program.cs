using HomeWork2;
using System.Text;

namespace HomeWork2
{
    public class Program
    {


        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Задание 1

            //int hryven = 0;
            //int penny = 0;
            //int cost_hrn = 0;
            //int cost_penny = 0;
            //int exit = 1;

            //while (exit > 0)
            //{
            //    try
            //    {
            //        Console.WriteLine("\nEnter 1 for replenishment your balance, enter 2 to show you balance, enter 3 to buy product, enter 0 for exit");
            //        int menu_read = Convert.ToInt32(Console.ReadLine());

            //        if (menu_read == 1)
            //        {
            //            Console.WriteLine("Enter hryven: ");
            //            int add_hrn = Convert.ToInt32(Console.ReadLine());
            //            hryven += add_hrn;
            //            Console.WriteLine("Enter pennies: ");
            //            int add_penny = Convert.ToInt32(Console.ReadLine());
            //            penny += add_penny;

            //        }

            //        int all_hrn = hryven;
            //        int all_penny = penny;

            //        if (menu_read == 3)
            //        {
            //            Console.WriteLine("Enter name product: ");
            //            string? name_product = Convert.ToString(Console.ReadLine());
            //            Console.WriteLine("Enter the price in hryvnia for the product: ");
            //            int price_hrn = Convert.ToInt32(Console.ReadLine());
            //            cost_hrn += price_hrn;
            //            Console.WriteLine("Enter the price in pennies for the item");
            //            int price_penny = Convert.ToInt32(Console.ReadLine());
            //            cost_penny += price_penny;

            //            Product new_balance = new Product(all_hrn, all_penny, name_product, cost_hrn, cost_penny);
            //            new_balance.Merchandise();
            //        }

            //        int ostatok_hrn = all_hrn - cost_hrn;
            //        int ostatok_penny = all_penny - cost_penny;

            //        if (menu_read == 2)
            //        {

            //            Money all = new Money(ostatok_hrn, ostatok_penny);
            //            all.SnowAll();
            //        }
            //        else if (menu_read == 0)
            //        {
            //            break;
            //        }
            //        else if (menu_read != 1 && menu_read != 3)
            //        {
            //            throw new Exception("Inccorect number!");
            //        }



            //        menu_read++;
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Enter only number!");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            //Задание 2

            //int exit = 1;

            //while (exit != 0)
            //{
            //    Console.WriteLine("\nMusical Instruments menu: Violin - 1, Trombone - 2, Ukulele - 3, Cello - 4; 0 for exit");

            //    try
            //    {
            //        Console.Write("\nEnter your number: ");
            //        int menu = Convert.ToInt32(Console.ReadLine());

            //        if (menu == 1)
            //        {
            //            string sound = "*melodic squeak*";
            //            string show = "Violin";
            //            string desc = "A stringed musical bowed instrument." +
            //                " It has four strings tuned to a fifth (g, d1, a1, e2).";
            //            string history = "Appeared in the middle of the 16th century.";

            //            var vio = new Musical_instruments.Violin(sound, show, desc, history);
            //            vio.Sound();
            //            vio.Show();
            //            vio.Desc();
            //            vio.History();
            //        }
            //        else if (menu == 2)
            //        {
            //            string sound = "*tytytyty*";
            //            string show = "Trombone";
            //            string desc = "A musical instrument of the brass family.";
            //            string history = "The trombone was invented in the 15th century.";

            //            var trombone = new Musical_instruments.Violin(sound, show, desc, history);
            //            trombone.Sound();
            //            trombone.Show();
            //            trombone.Desc();
            //            trombone.History();
            //        }
            //        else if (menu == 3)
            //        {
            //            string sound = "*Mini guitar with sweet sound*";
            //            string show = "Ukulele";
            //            string desc = "Ukulele - it is a four-stringed musical instrument that is considered one of the varieties of the guitar.";
            //            string history = "The ukulele first appeared in Hawaii, which is why it is called the Hawaiian guitar. The second half of the 19th century";

            //            var ukulele = new Musical_instruments.Violin(sound, show, desc, history);
            //            ukulele.Sound();
            //            ukulele.Show();
            //            ukulele.Desc();
            //            ukulele.History();
            //        }
            //        else if (menu == 4)
            //        {
            //            string sound = "*A large violin with a heavy sound*";
            //            string show = "Cello";
            //            string desc = "The cello belongs to the instruments of the violin family.";
            //            string history = "The appearance of the cello dates back to the beginning of the 16th century.";

            //            var cello = new Musical_instruments.Violin(sound, show, desc, history);
            //            cello.Sound();
            //            cello.Show();
            //            cello.Desc();
            //            cello.History();
            //        }
            //        else if (menu == 0)
            //        {
            //            Console.WriteLine("Bye-bye");
            //            break;
            //        }
            //        else
            //        {
            //            throw new Exception("\nInccorect number!");
            //        }

            //        exit++;
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("\nEnter only numbers!");
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}

            // Задание 3
            try
            {
                Console.WriteLine("Enter measurement system: binary - 1; octal - 2; hexadecimal - 3.");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                switch (choice) 
                {
                    case 1:

                        DecimalNumber binary = new DecimalNumber(num);
                        binary.BinarySystem();
                        break;
                    case 2:

                        DecimalNumber octal = new DecimalNumber(num);
                        octal.OctalSystem();
                        break;
                    case 3:

                        DecimalNumber hexadecimal = new DecimalNumber(num);
                        hexadecimal.HexadecimalSystem();
                        break;

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nEnter only numbers!");    
            }
            catch (Exception x)
            {
               Console.WriteLine($"{x.Message}");
            }
            //Console.WriteLine("Enter number: ");
            //int num = Convert.ToInt32(Console.ReadLine());


            //DecimalNumber binary = new DecimalNumber(num);
            ////binary.BinarySystem();
            //binary.OctalSystem();

        }
    }
}

