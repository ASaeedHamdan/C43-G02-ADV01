using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment01
{
    internal class EvenNumbers
    {
        public static List<int> FindEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                    evenNumbers.Add(number);
            }

            return evenNumbers;
        }
    }
}
