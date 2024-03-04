using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLearning
{
    public class DictionaryChangeElement
    {
        public void ChangeElement(Dictionary<string, string> dictionaryName)
        {
            if (DictionaryNull.CheckNull(dictionaryName)) // Check that Dictionary Is Empty or not ?
            {
                string? userInputWantChange ;
                string? userInputNewValue ;
                bool checkInputeChange = false;

                while (!checkInputeChange)
                {
                    // Take Element Inpute string from user which they want to update.
                    Console.Write("Enter the Key which you want to Update: ");
                    userInputWantChange = Console.ReadLine();

                    if (StringNullOrEmpty.NullOrEmpty(userInputWantChange))
                    {
                        if (DictionaryContainOrNot.ContainOrNot(dictionaryName, userInputWantChange))
                        {
                            bool checkInputeNewChange = false;
                            while (!checkInputeNewChange)
                            {
                                // Take New Element Inpute string from user for update.
                                Console.Write("Enter the New Value : ");
                                userInputNewValue = Console.ReadLine();

                                if (StringNullOrEmpty.NullOrEmpty(userInputNewValue))
                                {
                                    dictionaryName[userInputWantChange] = userInputNewValue;
                                    checkInputeNewChange = true;                                    
                                }
                            }
                        }
                        checkInputeChange = true;
                    }
                }
            }
        }
    }
}
