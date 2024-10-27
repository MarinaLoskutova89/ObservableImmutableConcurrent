using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
    public class Shop
    {
        public ObservableCollection<Item> Items = new();
        public void Add(string? itemName)
        {
            if (string.IsNullOrEmpty(itemName)) throw new ArgumentNullException("Entered value must not be null or empty!");
            Items.Add(new Item(Items.Count, $"{itemName} <{DateTime.Now}>"));
        }
        public void Remove(string? itemId)
        {
            if (itemId == null) throw new ArgumentNullException("Entered value must not be null!");
            Item? removingItem = Items.Where(r => r.Id == Convert.ToInt32(itemId)).FirstOrDefault();
            if (removingItem == null) throw new ArgumentNullException("Shop doesn't have any item!");
            Items.Remove(removingItem);
        }
        public void ShowAllItems()
        {
            Console.WriteLine("List of avaliable items:");
            foreach (Item item in Items)
            {
                Console.WriteLine($"{item.Id} - {item.Name}");
            }
            Console.WriteLine();
        }
    }
}
