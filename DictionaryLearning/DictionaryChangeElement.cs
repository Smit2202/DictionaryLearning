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
            // Take Element Inpute string from user which they want to update.
            Console.Write("Enter the Value which you want to Update: ");
            string userInputWantChange = Console.ReadLine();

            // Take New Element Inpute string from user for update.
            Console.Write("Enter the New Value : ");
            string updatedvalue = Console.ReadLine();

            dictionaryName[userInputWantChange] = updatedvalue;
        }
    }
}
