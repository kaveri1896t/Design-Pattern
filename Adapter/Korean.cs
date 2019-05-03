// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "Korean.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Adapter
{
    using System;

    /// <summary>
    /// Interface for korean language
    /// </summary>
    public class Korean : IKorean
    {
        /// <summary>
        /// Korean language chat.
        /// </summary>
        public void KoreanChat()
        {
            int choice;
            char answer;
            LanguageAdapter languageAdapter = new LanguageAdapter();
            try
            {
                do
                {
                    Console.WriteLine("***************************");
                    Console.WriteLine("1. Annyeonghaseyo");
                    Console.WriteLine("2. Dangsin-ui ileum?");
                    Console.WriteLine("3. nae ileum-eun");
                    Console.WriteLine("4. Jal jinaess-eoyo?");
                    Console.WriteLine("5. naneun gwaenchanh-ayo");
                    Console.WriteLine("6. Annyeong");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            ////Hi
                            Console.WriteLine(languageAdapter.ConvertToEnglish("Annyeonghaseyo"));
                            break;

                        case 2:
                            ////What is your name
                            Console.WriteLine(languageAdapter.ConvertToEnglish("Dangsin-ui ileum?"));
                            break;

                        case 3:
                            ////My name is
                            Console.WriteLine(languageAdapter.ConvertToEnglish("nae ileum-eun"));
                            break;

                        case 4:
                            ////How are you
                            Console.WriteLine(languageAdapter.ConvertToEnglish("Jal jinaess-eoyo?"));
                            break;

                        case 5:
                            ////I am fine
                            Console.WriteLine(languageAdapter.ConvertToEnglish("naneun gwaenchanh-ayo"));
                            break;

                        case 6:
                            Console.WriteLine(languageAdapter.ConvertToEnglish("Annyeong"));
                            break;

                        default:
                            return;
                    }

                    Console.WriteLine("*********************************************");
                    Console.WriteLine("\ngyesog hasigessseubnikka? (y/n) : ");
                    answer = Convert.ToChar(Console.ReadLine());
                }
                while (answer == 'y' || answer == 'Y');
                Console.WriteLine("\nGomabseubnida....");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
