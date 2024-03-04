using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLearning
{
    public class DictionaryRemoveElement
    {
        public void RemoveElement(Dictionary<string, string> dictionaryName)
        {
            if (DictionaryNull.CheckNull(dictionaryName)) // Check that Dictionary Is Empty or not ?
            {
                string? userInputWantremove ;
                bool checkInputeRemove = false;

                while(!checkInputeRemove)
                {
                    // Take Element Inpute string from user which they want to remove.
                    Console.Write("Enter the Key of Element which you want to remove: ");
                    userInputWantremove = Console.ReadLine();

                    if (StringNullOrEmpty.NullOrEmpty(userInputWantremove))
                    {
                        if (DictionaryContainOrNot.ContainOrNot(dictionaryName, userInputWantremove))
                        {
                            dictionaryName.Remove(userInputWantremove);
                            checkInputeRemove = true;
                        }
                    }
                }
            }
        }
    }
}
