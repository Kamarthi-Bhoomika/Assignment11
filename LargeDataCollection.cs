using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public class LargeDataCollection : IDisposable
    {
        private List<string> list;
        static int totalLen = 0;
        bool disposedValue;
        public LargeDataCollection(string listName) 
        {
            
            if (list == null)
            {
                totalLen++;
                list = new List<string>();
            }
            Console.WriteLine("File Created");
            Console.WriteLine("Number of files are: " + totalLen);
        }
        public LargeDataCollection(List<string> list)
        {
            this.list = list;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    totalLen = 0;
                }
            }
            Console.WriteLine("List {0} has been disposed", list);
            list = null;
            disposedValue = true;
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        public void Add(string item)
        {
            list.Add(item);
            Console.WriteLine(item + " has been Added Successfully");
        }
        public void Read()
        {
            Console.WriteLine("************************");
            Console.WriteLine("List Items");
            foreach (string items in list)
            {
                Console.WriteLine(items);
            }
        }
        public void Remove(string item)
        {
            list.Remove(item);
            Console.WriteLine($"{item} removed from list");
        }
        public void getItem(string item)
        {
            if (list.Contains(item))
            {
                Console.WriteLine($"{item} is available in the list");
            }
            else { Console.WriteLine($"{item} is not available in the list"); }
        }
        ~LargeDataCollection()
        {
            Dispose(false);
        }
    }
}
