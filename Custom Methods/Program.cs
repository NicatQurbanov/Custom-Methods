using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Var
{
    public class Program
    { 
        public static int Addition(params int[] nums)
        {
            int result = 0;    
            foreach (int num in nums)
            {
                result += num;
            }
            return result;
        }

        public static int Substraction(params int[] nums)
        {
            int result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result -= nums[i];
            }
            return result;
        }

        public static int Multiplication(params int[] nums)
        {
            int result = 1;

            foreach (int num in nums)
            {
                result *= num;
            }

            return result;
        }

        public static int Division(params int[] nums)
        {
            int result = nums[0];

            for (int i = 1;  i < nums.Length; i++)
            {
                result /= nums[i];
            }

            return result;
        }
      public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");

            int firstnum;
            int.TryParse(Console.ReadLine(), out firstnum);

            Console.WriteLine("Enter second number:");

            int secondnum;
            int.TryParse(Console.ReadLine(), out secondnum);

            int[] nums = { firstnum, secondnum };

            Console.WriteLine("Do you want to add additional numbers?\n 1.Yes \n 2.No");
             
            string answer = Console.ReadLine();

            if (answer == "1")
            {
                while (answer == "1")
                {
                    Array.Resize(ref nums, nums.Length + 1);

                    Console.WriteLine("Enter additional number:");
                    int additionalNumber;
                    int.TryParse(Console.ReadLine(), out additionalNumber);

                    nums[nums.Length - 1] = additionalNumber;

                    Console.WriteLine("Do you want to add additional numbers?\n 1.Yes \n 2.No");
                    answer = Console.ReadLine();
                }
            } 
            else if (answer != "2") 
            {
                Console.WriteLine("Please choose appropriate answer.");
            }
 
            bool operatorChosen = false;

            while (!operatorChosen)
            {

                Console.WriteLine("Choose operator:\n" +
                              "1. Addition.\n" +
                              "2. Substraction.\n" +
                              "3. Multiplication.\n" +
                              "4. Division.");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine(Addition(nums));
                        operatorChosen = true;
                        break;
                    case "2":
                        Console.WriteLine(Substraction(nums));
                        operatorChosen = true;
                        break;

                    case "3":
                        Console.WriteLine(Multiplication(nums));
                        operatorChosen = true;
                        break;
                    case "4":
                        Console.WriteLine(Division(nums));
                        operatorChosen = true;
                        break;
                    default:
                        Console.WriteLine("Please choose the right option: " +
                                          "either \"1\", \"2\", \"3\" or \"4\"");
                        break;
                }
            }
        }
    }
}
