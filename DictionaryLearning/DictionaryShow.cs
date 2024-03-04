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
            //Console.WriteLine(DictionaryNull.CheckNull(dictionaryName));
            if (DictionaryNull.CheckNull(dictionaryName)) // Check that Dictionary Is Empty or not ?
            {
                string? keyOfDictionary;
                bool checkKey = false;

                while (!checkKey)
                {
                    // Take Key Inpute string from user.
                    Console.Write("Enter Key String: ");
                    keyOfDictionary = Console.ReadLine();

                    if (StringNullOrEmpty.NullOrEmpty(keyOfDictionary))
                    {
                        if (DictionaryContainOrNot.ContainOrNot(dictionaryName, keyOfDictionary))
                        {
                            var showElementUsingKey = dictionaryName[keyOfDictionary];
                            Console.WriteLine($"The Value Of {keyOfDictionary} is {showElementUsingKey}");
                            checkKey = true;
                        }
                    }
                }                
            }
        }
    }
}
