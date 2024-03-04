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
            string? userInputKeyString = "";
            bool checkKey = false;
            while (!checkKey)
            {
                // Take Key Inpute string from user.
                Console.Write("Enter the Key: ");
                userInputKeyString = Console.ReadLine();

                if(StringNullOrEmpty.NullOrEmpty(userInputKeyString))
                {
                    checkKey = true;
                }
            }

            string? userInputValueString = "";
            bool checkValue = false;
            while (!checkValue)
            {
                // Take Value Inpute string from user.
                Console.Write("Enter the Value: ");
                userInputValueString = Console.ReadLine();

                if (StringNullOrEmpty.NullOrEmpty(userInputValueString))
                {
                    checkValue = true;
                }
            }
            dictionaryName.Add(userInputKeyString, userInputValueString);
        }
    }
}
