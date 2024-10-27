using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent
{
    public class Librarian
    {
        public ConcurrentDictionary<string, int> AllBooks = new ConcurrentDictionary<string, int>();

        public void AddNewBook(string? newBook) 
        {
            if (string.IsNullOrEmpty(newBook)) throw new ArgumentNullException("Value must not be null or empty!");
            if (!AllBooks.ContainsKey(newBook)) 
            { 
                AllBooks.TryAdd(newBook, 0);
            }
        }

        public void ShowAllBooks()
        {
            Console.WriteLine("List of books:");

            if (AllBooks.IsEmpty)
            {
                Console.WriteLine("Empty. Everything has been read!");
            }
            AllBooks.ToList().ForEach(r => Console.WriteLine($"{r.Key} - {r.Value}%"));
        }

        public async Task ReadBooks(CancellationToken token)
        {
            while (true)
            {
                foreach (KeyValuePair<string, int> book in AllBooks)
                {
                    if (book.Value >= 100)
                    {
                        AllBooks.TryRemove(book);
                    }

                    AllBooks.TryUpdate(book.Key, book.Value + 1, book.Value);
                }
                await Task.Delay(500);
            }
        }
    }
}
