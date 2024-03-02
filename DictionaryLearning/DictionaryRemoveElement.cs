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
            // Take Element Inpute string from user which they want to remove.
            Console.Write("Enter the Value which you want to remove: ");
            string userInputWantremove = Console.ReadLine();

            dictionaryName.Remove(userInputWantremove);
        }
    }
}
