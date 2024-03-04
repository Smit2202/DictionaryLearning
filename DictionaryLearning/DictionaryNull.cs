using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLearning
{
    public class DictionaryNull
    {
        public static bool CheckNull(Dictionary<string, string> dictionaryName)
        {
            if (dictionaryName.Count == 0)
            {
                // Print that Dictionary is Empty.
                Console.WriteLine("The Dictionary is empty.");
                return false;
            }
            return true;
        }
    }
}
