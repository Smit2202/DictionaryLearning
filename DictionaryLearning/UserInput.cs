using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLearning
{
    public class UserInput
    {
        public string Input()
        {
            // Take Inpute string from user
            Console.WriteLine($"{Environment.NewLine}Add Elements = add, {Environment.NewLine}Access Elements = show, {Environment.NewLine}Show All Element of Dictionary = showall, {Environment.NewLine}Change Elements  = change, {Environment.NewLine}Remove Elements = remove, {Environment.NewLine}Quit = quit,");
            Console.WriteLine();
            Console.Write("Enter What You Want to do? : ");
            string UserInput = Console.ReadLine();

            // Return Value of UserInpute.
            return UserInput;
        }
    }
}
