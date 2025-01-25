using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment01
{
    internal class FixedSizeList<T>
    {
        #region attributes
        private T[] items;
        private int count;
        #endregion

       
        #region Constructor
        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than 0.");

            items = new T[capacity];
            count = 0;
        }
        #endregion

        #region Methods
        // Method to add an element to the list
        public void Add(T item)
        {
            if (count >= items.Length)
                Console.WriteLine ("List is full. Cannot add more items.");

            items[count] = item;
            count++;
        }

        // Method to get an element at a specific index
        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Index is out of range.");

            return items[index];
        }
        #endregion

    }
}
