namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Array Size: ");
            int arrSize = int.Parse(Console.ReadLine());
            int[] numbers = new int[arrSize];
            for (int i = 0;i < arrSize; i++)
            {
                Console.Write($"enter item number {i + 1}:");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Minimum value :{Min(numbers)}");
            Console.WriteLine($"Maximum value :{Max(numbers)}");
            Console.WriteLine($"Average value :{Avg(numbers)}");
        }
        static int Min(int[] nums)
        {
            int min = 10000000;
            foreach (int i in nums)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }
        static int Max(int[] nums)
        {
            int Max = -10000000;
            foreach (int i in nums)
            {
                if (i > Max)
                {
                    Max = i;
                }
            }
            return Max;
        }
        static double Avg(int[] nums)
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum/nums.Length;
        }
    }

}