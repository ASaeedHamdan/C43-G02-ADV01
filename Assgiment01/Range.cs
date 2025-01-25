using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment01
{
    internal class Range<T> where T : IComparable<T>
    {
        private T Min { get; }
        private T Max { get; }

     
        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
                Console.WriteLine("Min must be less than or equal to Max.");

            Min = min;
            Max = max;
        }

        // Method to check if a value is within the range
        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        // Method to calculate the length of the range
        public T Length()
        {
            dynamic min = Min;
            dynamic max = Max;
            return max - min;
        }
    }
}
