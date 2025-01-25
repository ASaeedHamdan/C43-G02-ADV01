using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment01
{
    internal class FirstNonRepeatedCharacter
    {

        public static int FindFirstNonRepeatedCharacterIndex(string input)
        {
            if (string.IsNullOrEmpty(input))
                return -1;

            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            
            foreach (char c in input)
            {
                if (charCounts.ContainsKey(c))
                    charCounts[c]++;
                else
                    charCounts[c] = 1;
            }

            // Find the first character with a count of 1
            for (int i = 0; i < input.Length; i++)
            {
                if (charCounts[input[i]] == 1)
                    return i;
            }
          
            return -1; 
        }
    }
}
