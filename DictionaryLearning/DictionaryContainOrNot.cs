using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLearning
{
    public class DictionaryContainOrNot
    {
        public static bool ContainOrNot(Dictionary<string, string> dictionaryName, string UserInput)
        {
            if (!dictionaryName.ContainsKey(UserInput))
            {
                Console.WriteLine($"Sorry Dictionary not Contain {UserInput}.");
                return true;
            }
            return true;
        }
    }
}
