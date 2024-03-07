using System;
using System.Threading.Tasks;

namespace ConsoleApp5

 

{
    class Program
    {
        static async Task Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Write \"Hello World\"");
                Console.WriteLine("2. Write Current Date");
                Console.WriteLine("3. Write OS Version");
                Console.WriteLine("4. Exit");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        await WriteToFileAsync("Hello World");
                        break;
                    case "2":
                        await WriteToFileAsync(DateTime.Now.ToString("dd-MM-yyyy"));
                        break;
                    case "3":
                        await WriteToFileAsync(Environment.OSVersion.VersionString);
                        break;
                    case "4":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option selected.");
                        break;
                }
            }
        }

        private static async Task WriteToFileAsync(string message)
        {
            await Task.Delay(3000); // Simulate some work
            await File.WriteAllTextAsync("tmp.txt", message);
        }
    }
}

