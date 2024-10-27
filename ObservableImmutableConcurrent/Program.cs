using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Concurrent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Librarian librarian = new();
            CancellationTokenSource cancellationToken = new();
            StringBuilder sb = new();
            ConsoleKeyInfo consoleKeyInfo;

            sb.Append("1 - add new book" + Environment.NewLine +
                      "2 - show list of books" + Environment.NewLine +
                      "3 - exit");
            Task ReadBookAsync = Task.Run(async() => await librarian.ReadBooks(cancellationToken.Token));

            try
            {
                do
                {
                    Console.WriteLine(sb);
                    consoleKeyInfo = Console.ReadKey();
                    Console.WriteLine();
                    if (consoleKeyInfo.Key == ConsoleKey.D1 || consoleKeyInfo.Key == ConsoleKey.NumPad1)
                    {
                        Console.WriteLine("Input name of book:");
                        string? newBook = Console.ReadLine();
                        if (!string.IsNullOrEmpty(newBook)) librarian.AddNewBook(newBook);
                        else Console.WriteLine("Value must not be null or empty!");
                    }
                    else if (consoleKeyInfo.Key == ConsoleKey.D2 || consoleKeyInfo.Key == ConsoleKey.NumPad2)
                    {
                        librarian.ShowAllBooks();
                    }

                } while (consoleKeyInfo.Key != ConsoleKey.D3 && consoleKeyInfo.Key != ConsoleKey.NumPad3);

                cancellationToken.Cancel();
                cancellationToken.Dispose();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
