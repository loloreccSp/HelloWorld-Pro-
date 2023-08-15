
namespace HomeWork2
{
    public class Money
    {
        public int entire;
        public int pennies;

        public Money(int entire, int pennies)
        {
            this.entire = entire;
            this.pennies = pennies;
        }

        public void SnowAll()
        {
            Console.WriteLine($"Balance: {entire} hryvnia and {pennies} penny");
        }

        public class Product : Money
        {
            public string name;
            public int entire_cost;
            public int penny_cost;
            public Product(int entire, int pennies, string name, int entire_cost, int penny_cost)
                : base(entire, pennies)
            {
                this.entire = entire;
                this.pennies = pennies;
                this.name = name;
                this.entire_cost = entire_cost;
                this.penny_cost = penny_cost;
            }
            public void Merchandise()
            {
                Console.WriteLine($"Product: {name}; Cost: {entire_cost} hryvnia, {penny_cost} penny");
                Console.WriteLine($"Balance {entire} hryvnia, {pennies} penny");
                Console.WriteLine($"Remainder: {entire - entire_cost} hryvnia, {pennies - penny_cost} penny");
                int new_entire = entire - entire_cost;
                int new_penny = pennies - penny_cost;
                Money balance = new Money(new_entire, new_penny);
            }
        }
    }
}
