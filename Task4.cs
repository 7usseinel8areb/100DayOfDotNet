namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("[1]Generate Random Number\t\t[2]Generate Random String");
                var selectedOption = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                switch (selectedOption)
                {
                    case "1":
                        Console.WriteLine(GenerateRandomNumber());
                        break;
                    case "2":
                        Console.WriteLine(GenerateRandomString());
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option please choose from the valid options.");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static string GenerateRandomNumber()
        {
            var random = new Random();
            var value = random.Next(1000, 9999);
            return $"Your random Number is {value}";
        }
        static string GenerateRandomString()
        {
            const string Buffer = "abcdefghijklmnobqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder s = new StringBuilder();
            var random = new Random();
            while(s.Length <9) {
                var value = random.Next(0,Buffer.Length);
                s.Append(Buffer[value]);
            }
            
            return $"Your random string is {s}";
        }
    }
}