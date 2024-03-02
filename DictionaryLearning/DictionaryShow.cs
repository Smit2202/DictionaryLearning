using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLearning
{
    public class DictionaryShow
    {
        public void Show(Dictionary<string, string> dictionaryName)
        {
            // Take Key Inpute string from user.
            Console.Write("Enter Key String: ");
            string keyOfDictionary = Console.ReadLine();

            var showElementUsingKey = dictionaryName[keyOfDictionary];
            Console.WriteLine($"The Value Of {keyOfDictionary} is {showElementUsingKey}");
        }
    }
}
