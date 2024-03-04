using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLearning
{
    public class DictionaryAllList
    {
        public void AllList(Dictionary<string, string> dictionaryName)
        {
            if (DictionaryNull.CheckNull(dictionaryName)) // Check that Dictionary Is Empty or not ?
            {
                foreach (KeyValuePair<string, string> item in dictionaryName)
                {
                    Console.WriteLine($"{item.Key} : {item.Value}");
                }

            }
        }
    }
}
