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
                Console.Write(">>");
                string input = Console.ReadLine().Trim();
                int whitSpaceIndex = input.IndexOf(' ');
                string command = input.Substring(0,whitSpaceIndex).ToLower();
                string path = input.Substring(whitSpaceIndex+1).Trim();
                if (command == "list")
                {
                    foreach (var entry in Directory.GetDirectories(path))
                    {
                        Console.WriteLine($"[Directory] {entry}");
                    }
                    foreach (var entry in Directory.GetFiles(path))
                    {
                        Console.WriteLine($"[Directory] {entry}");
                    }
                }
                else if (command == "info")
                {
                    if (Directory.Exists(path))
                    {
                        var dirInfo = new DirectoryInfo(path);
                        Console.WriteLine("Directory");
                        Console.WriteLine($"Created at: {dirInfo.CreationTime}");
                        Console.WriteLine($"Last modified at: {dirInfo.LastWriteTime}");
                    }
                    else if (Directory.Exists(path))
                    {
                        var fileInfo = new FileInfo(path);
                        Console.WriteLine("File");
                        Console.WriteLine($"Created at: {fileInfo.CreationTime}");
                        Console.WriteLine($"Last modified at: {fileInfo.LastWriteTime}");
                        Console.WriteLine($"Size in Bytes: {fileInfo.Length}");
                    }
                }
                else if (command == "mkdir")
                {
                    Directory.CreateDirectory(path);
                }
                else if (command == "remove")
                {
                    if (Directory.Exists(path))
                    {
                        Directory.Delete(path, true);
                    }
                    else if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                }
                else if (command == "print")
                {
                    if (File.Exists(path))
                    {
                        var content = File.ReadAllText(path);
                        Console.WriteLine(content);
                    }
                }
                else if (command == "exit")
                {
                    break;
                }
            }
        }
    }
}