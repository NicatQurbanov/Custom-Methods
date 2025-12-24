namespace Var
{
    public class Program
    { 
        public static int Addition(params int[] nums)
        {
            int sum = 0;    
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
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

        
      public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");

            int firstnum;
            int.TryParse(Console.ReadLine(), out firstnum);

            Console.WriteLine("Enter second number:");

            int secondnum;
            int.TryParse(Console.ReadLine(), out secondnum);

            Console.WriteLine("Enter second number:");

            int thirdnum;
            int.TryParse(Console.ReadLine(), out thirdnum);

            Console.WriteLine(Addition(firstnum, secondnum));

            Console.WriteLine(Substraction(firstnum, secondnum, thirdnum));

        }
    }
}
