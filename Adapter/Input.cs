// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "Input.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Adapter
{
    using System;

    /// <summary>
    /// takes Input from user
    /// </summary>
    public class Input
    {
        /// <summary>
        /// Start the conversion.
        /// </summary>
        public void Start()
        {
            int choice;
            char answer;

            ////Adapter instance to access members of that class
            LanguageAdapter languageAdapter = new LanguageAdapter();
            try
            {
                ////Take choice from user
                do
                {
                    Console.WriteLine("***************************");
                    Console.WriteLine("1. Korean To English");
                    Console.WriteLine("2. English To Korean");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            ////Korean to English
                            Korean korean = new Korean();
                            korean.KoreanChat();
                            break;

                        case 2:
                            ////English to Korean
                            English english = new English();
                            english.EnglishChat();
                            break;

                        default:
                            break;
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