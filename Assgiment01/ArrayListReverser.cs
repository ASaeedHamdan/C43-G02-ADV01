using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment01
{
    internal class ArrayListReverser
    {
        public static void ReverseArrayList(ArrayList list)
        {
            if (list == null || list.Count <= 1)
                return;

            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                // Swap elements
                object temp = list[left];
                list[left] = list[right];
                list[right] = temp;

                left++;
                right--;
            }
        }
    }
}
