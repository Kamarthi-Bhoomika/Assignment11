using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>
            { "Amit","Sam"}; 
            LargeDataCollection largeDataCollection = new LargeDataCollection(list);
            largeDataCollection.Read();
            Console.WriteLine("Enter Element to Add: ");
            string name = Console.ReadLine();
            largeDataCollection.Add(name);
            largeDataCollection.Read();
            Console.WriteLine("Enter element to remove: ");
            string remove = Console.ReadLine();
            largeDataCollection.Remove(remove);
            largeDataCollection.Read();
            Console.WriteLine("Enter element to search: ");
            string get = Console.ReadLine();
            largeDataCollection.getItem(get);
            largeDataCollection.Read();

            largeDataCollection.Dispose();

            Console.ReadKey();
        }
    }
}
