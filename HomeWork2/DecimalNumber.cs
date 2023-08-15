
namespace HomeWork2
{
    public struct DecimalNumber
    {
        public int number { get; set; }

        public DecimalNumber(int number)
        {
            this.number = number;
        }

        public void BinarySystem()
        {
            int num_check = number;
            int check = number % 2;
            int num = 0;
            List<int> binary = new List<int>();

            if (check <= 1)
            {
                for (int i = 0; i <= num_check / 2; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        num = num_check % 2;
                        num_check /= 2;


                        binary.Add(num);

                    }
                }

            }
            int[] nums = binary.ToArray();
            Array.Reverse(nums, 0, nums.Length);
            var str = string.Join("", nums);
            Console.Write($"Youre binary number: {str}");

        }
        public void OctalSystem()
        {
            int num_check = number;
            int check = number % 8;
            int num = 0;
            List<int> octal = new List<int>();

            if (check <= 7)
            {
                for (int i = 0; i <= num_check / 8; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        num = num_check % 8;
                        num_check /= 8;


                        octal.Add(num);

                    }
                }

            }
            int[] nums = octal.ToArray();
            Array.Reverse(nums, 0, nums.Length);
            var str = string.Join("", nums);
            Console.Write($"Youre octal number: {str}");
        }

        public void HexadecimalSystem()
        {
            int num_check = number;
            int check = number % 16;
            int num = 0;
            List<int> hexadecimal = new List<int>();

            if (check <= 15)
            {
                for (int i = 0; i <= num_check / 16; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        num = num_check % 16;
                        num_check /= 16;


                        hexadecimal.Add(num);

                    }
                }

            }
            int[] nums = hexadecimal.ToArray();
            Array.Reverse(nums, 0, nums.Length);
            var str = string.Join("", nums);
            Console.Write($"Youre hexadecimal number: {str}");
        }
    }
}
