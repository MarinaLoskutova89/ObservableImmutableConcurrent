using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
    public class Customer
    {
        public void OnItemChanged(object? sender, NotifyCollectionChangedEventArgs notify)
        {
            var sb = new StringBuilder();

            switch (notify.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    if (notify.NewItems?[0] is Item newItem)
                    {
                        sb.AppendLine(Environment.NewLine + $"A product {newItem.Name} with identifier {newItem.Id} - has been added!");
                        Console.WriteLine(sb);
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    if (notify.OldItems?[0] is Item oldItem)
                    {
                        sb.AppendLine(Environment.NewLine + $"A product {oldItem.Name} - has been deleted!");
                        Console.WriteLine(sb);
                    }
                    break;
            }
        }
    }
}
