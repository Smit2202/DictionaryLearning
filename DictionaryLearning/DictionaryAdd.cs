using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLearning
{
    public class DictionaryAdd
    {
        public void Add(Dictionary<string, string> dictionaryName)
        {
            // Take Key Inpute string from user.
            Console.Write("Enter the Key: ");
            string userInputKeyString = Console.ReadLine();

            // Take Value Inpute string from user.
            Console.Write("Enter the Value: ");
            string userInputValueString = Console.ReadLine();

            dictionaryName.Add(userInputKeyString, userInputValueString);
        }
    }
}
