namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please select an option:");
                Console.WriteLine("[1]Generate Random Number\t\t[2]Generate Random String");
                var selectedOption = Console.ReadLine();
                if (selectedOption == "1")
                {
                    Console.Write("Enter the Minimum value: ");
                    int min = int.Parse(Console.ReadLine());
                    Console.Write("Enter the Maximum value: ");
                    int max = int.Parse(Console.ReadLine());
                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine(GenerateRandomNumber(min,max));
                }
                else if (selectedOption == "2")
                {
                    Console.Write("Enter string Length: ");int size = int.Parse(Console.ReadLine()); 
                    Console.Write("[1]Include capital letters?(y/n)");var a = Console.ReadLine();
                    Console.Write("[2]Include small letters?(y/n)");var b = Console.ReadLine();
                    Console.Write("[3]Include numbers?(y/n)");var c = Console.ReadLine();
                    Console.Write("[4]Include symbols?(y/n)");var d = Console.ReadLine();

                    Console.ForegroundColor= ConsoleColor.Green;
                    Console.WriteLine(GenerateRandomString(size,a,b,c,d));
                }
            }
        }
        static string GenerateRandomNumber(int min ,int max)
        {
            var random = new Random();
            var value = random.Next(min,max);
            return $"Your random Number is {value}";
        }
        static string GenerateRandomString(int size, string a, string b, string c, string d)
        {
            if (a == "n" && b == "n" && c == "n" && d == "n") 
                return $"Please choose at least one option";
            Dictionary<int,string> DictBuffer = new Dictionary<int, string>()
            {
                {1,"ABCDEFGHIJKLMNOPQRSTUVWXYZ" },
                {2,"abcdefghijklmnopqrstuvwxyz" },
                {3,"1234567890" },
                {4,"_!@#*" }
            };
            StringBuilder Buffer = new StringBuilder();
            if (a == "y") Buffer.Append(DictBuffer[1]);
            if (b == "y") Buffer.Append(DictBuffer[2]);
            if (c == "y") Buffer.Append(DictBuffer[3]);
            if (d == "y") Buffer.Append(DictBuffer[4]);
            
            StringBuilder s = new StringBuilder();
            var rnd = new Random();
            while(s.Length < size)
            {
                s.Append(Buffer[rnd.Next(0,Buffer.Length)]);
            }
            return $"Your random string is {s}";
        }
    }
}