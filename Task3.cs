using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please Select an option:");
                Console.WriteLine("[1]Change Background Color\t\t[2]Change Text Color");
                string selectedOption = Console.ReadLine();

                foreach (var color in Enum.GetNames(typeof(ConsoleColor)))
                {
                    Console.WriteLine($"Color: {color}");
                }

                Console.Write("Please write color name: ");
                string colorName = Console.ReadLine();

                ConsoleColor selectedColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName, true);
                if (selectedOption == "1")
                    Console.BackgroundColor = selectedColor;
                else if (selectedOption == "2")
                    Console.ForegroundColor = selectedColor;
                else
                {
                    Console.WriteLine("Invalid Option");
                    return;
                }
                Console.WriteLine("100DayOfDotNet");
            }
        }
    }
}