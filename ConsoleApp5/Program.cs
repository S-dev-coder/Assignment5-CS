
namespace ConsoleApp5



{
    class Program
    {
        static void Main(string[] args)
        {
            // Instance of the BackgroundOperation class
            BackgroundOperation bgOperation = new BackgroundOperation();
            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Write \"Hello World\"");
                Console.WriteLine("2. Write Current Date");
                Console.WriteLine("3. Write OS Version");
                Console.WriteLine("4. Exit");

                var choices = Console.ReadLine();

                switch (choices)
                {
                    case "1":
                        var option1 = bgOperation.WriteToFileAsync(" Hello World ");
                        break;
                    case "2":
                        var option2 = bgOperation.WriteToFileAsync(DateTime.Now.ToString("dd-MM-yyyy"));
                        break;
                    case "3":
                        var option3 = bgOperation.WriteToFileAsync(Environment.OSVersion.VersionString);
                        break;
                    case "4":
                        Console.WriteLine("Exiting Operations");
                        return;
                    default:
                        Console.WriteLine("You have selected Invalid option.");
                        break;
                }
            }
            }
        }
        public class BackgroundOperation
        {
        public async Task WriteToFileAsync(string message)
        {
            await Task.Delay(3000); // Simulate some work
            await File.WriteAllTextAsync("tmp.txt", message);
        }
        }
      
    
}


