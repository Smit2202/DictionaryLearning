using System;
using System.Collections.Generic;


namespace DictionaryLearning
{
    class DictionaryLearning
    {
        public static void Main(string[] args)
        {
            // Create Dictionary 
            Dictionary<string,string> NameDetails = new Dictionary<string,string>();

            // Loop for take inpute from user.
            bool quit = false;
            while (!quit)
            {
                UserInput userInputobj = new UserInput();
                // Taking inpute from user for which task Perform.
                string UserInputModule = userInputobj.Input();

                switch (UserInputModule)
                {
                    // Add Element in Dictionary.
                    case "add":
                        DictionaryAdd dictionaryAddobj = new DictionaryAdd();
                        dictionaryAddobj.Add(NameDetails);
                        break;
                    // Show Element of Dictionary.
                    case "show":
                        DictionaryShow dictionaryShowobj = new DictionaryShow();
                        dictionaryShowobj.Show(NameDetails);
                        break;
                    // Show Element of Dictionary.
                    case "showall":
                        DictionaryAllList dictionaryAllListobj = new DictionaryAllList();
                        dictionaryAllListobj.AllList(NameDetails);
                        break;
                    // Change the Element of Dictionary .
                    case "change":
                        DictionaryChangeElement dictionaryChangeElementobj = new DictionaryChangeElement();
                        dictionaryChangeElementobj.ChangeElement(NameDetails);
                        break;
                    // Remove the Element from Dictionary.
                    case "remove":
                        DictionaryRemoveElement dictionaryRemoveElementobj = new DictionaryRemoveElement();
                        dictionaryRemoveElementobj.RemoveElement(NameDetails);
                        break;
                    // Quit the Application.
                    case "quit":
                        quit = true;
                        break;
                    // Invalid Inpute.
                    default:
                        Console.WriteLine("Enter Valid Inpute");
                        break;
                }
            }
        }
    }
}