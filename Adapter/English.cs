// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "English.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Adapter
{
    using System;

    /// <summary>
    /// Interface for english language
    /// </summary>
    public class English : IEnglish
    {
        /// <summary>
        /// Convert English to korean.
        /// </summary>
        public void EnglishChat()
        {
            int choice;
            char answer;
            try
            {
                LanguageAdapter languageAdapter = new LanguageAdapter();
                do
                {
                    Console.WriteLine("***************************");
                    Console.WriteLine("1. Hi");
                    Console.WriteLine("2. What is your name?");
                    Console.WriteLine("3. My name is ");
                    Console.WriteLine("4. How are you?");
                    Console.WriteLine("5. I am fine");
                    Console.WriteLine("6. Bye");
                    choice = Convert.ToInt32(Console.ReadLine());

                    ////Calls to convert to korean based on Phrase
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine(languageAdapter.ConvertToKorean("Hi"));
                            break;

                        case 2:
                            Console.WriteLine(languageAdapter.ConvertToKorean("What is your name?"));
                            break;

                        case 3:
                            Console.WriteLine(languageAdapter.ConvertToKorean("My name is"));
                            break;

                        case 4:
                            Console.WriteLine(languageAdapter.ConvertToKorean("How are you?"));
                            break;

                        case 5:
                            Console.WriteLine(languageAdapter.ConvertToKorean("I am fine"));
                            break;

                        case 6:
                            Console.WriteLine(languageAdapter.ConvertToKorean("Bye"));
                            break;

                        default:
                            return;
                    }

                    Console.WriteLine("*********************************************");
                    Console.WriteLine("\nDo you want to continue? (y/n) : ");
                    answer = Convert.ToChar(Console.ReadLine());
                }
                while (answer == 'y' || answer == 'Y');
                Console.WriteLine("\nThank you....");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
