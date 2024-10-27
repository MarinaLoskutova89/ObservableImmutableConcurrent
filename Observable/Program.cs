using System.Text;

namespace Observable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new();
            Customer customer = new();
            shop.Items.CollectionChanged += customer.OnItemChanged;

            StringBuilder sb = new StringBuilder();
            sb.Append("A - add new product" + Environment.NewLine +
                      "D - delete propuct" + Environment.NewLine +
                      "X - exit");

            ConsoleKeyInfo consoleKeyInfo;

            List<ConsoleKey> avaliableKeys = new List<ConsoleKey>()
            {
                ConsoleKey.A,
                ConsoleKey.D,
                ConsoleKey.S,
                ConsoleKey.X
            };

            try
            {
                do
                {
                    Console.WriteLine(sb);
                    if (shop.Items.Count != 0) Console.WriteLine("S - show all items");
                    consoleKeyInfo = Console.ReadKey();
                    Console.WriteLine();
                    if (!avaliableKeys.Contains(consoleKeyInfo.Key))
                    {
                        Console.WriteLine($"Option - {consoleKeyInfo.Key} doesn't exist");
                    }
                    else if (consoleKeyInfo.Key == ConsoleKey.A)
                    {
                        Console.WriteLine("Enter new product:");
                        string? newProduct = Console.ReadLine();
                        shop.Add(newProduct);
                    }
                    else if (consoleKeyInfo.Key == ConsoleKey.D)
                    {
                        Console.WriteLine("Enter id product:");
                        string? removeProduct = Console.ReadLine();
                        shop.Remove(removeProduct);
                    }
                    else if (consoleKeyInfo.Key == ConsoleKey.S)
                    {
                        shop.ShowAllItems();
                    }
                } while (consoleKeyInfo.Key != ConsoleKey.X);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
