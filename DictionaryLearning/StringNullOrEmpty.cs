using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLearning
{
    public class StringNullOrEmpty
    {
        public static bool NullOrEmpty(string UserInput)
        {
            if (string.IsNullOrEmpty(UserInput) || string.IsNullOrWhiteSpace(UserInput))
            {
                Console.WriteLine("You Enter Nothing Please Enter. ");
                Console.WriteLine("");
                return false;
            }
            return true;
        }
    }
}
