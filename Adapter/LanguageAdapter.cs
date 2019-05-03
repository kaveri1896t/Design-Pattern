// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "LanguageAdapter.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Adapter
{
    using System;

    /// <summary>
    /// Adapter between two languages
    /// </summary>
    public class LanguageAdapter
    {
        /// <summary>
        /// Converts the specified message into another language.
        /// </summary>
        /// <param name="message">The message to be translated.</param>
        /// <returns>translated message</returns>
        public string ConvertToKorean(string message)
        {
            if (message == "Hi")
            {
                return "Annyeonghaseyo";
            }
            else if (message == "What is your name?")
            {
                return "Dangsin-ui ileum?";
            }
            else if (message == "My name is")
            {
                return "nae ileum-eun";
            }
            else if (message == "How are you?")
            {
                return "Jal jinaess-eoyo?";
            }
            else if (message == "I am fine")
            {
                return "naneun gwaenchanh-ayo";
            }
            else if (message == "Bye")
            {
                return "Annyeong";
            }
            else
            {
                return "Sorry!   Phrase not found...";
            }
        }

        /// <summary>
        /// Converts from Korean to english.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>Translated string in English</returns>
        public string ConvertToEnglish(string message)
        {
            if (message == "Annyeonghaseyo")
            {
                return "Hi";
            }
            else if (message == "Dangsin-ui ileum?")
            {
                return "What is your name?";
            }
            else if (message == "nae ileum-eun")
            {
                return "My name is";
            }
            else if (message == "Jal jinaess-eoyo?")
            {
                return "How are you?";
            }
            else if (message == "naneun gwaenchanh-ayo")
            {
                return "I am fine";
            }
            else if (message == "Annyeong")
            {
                return "Bye";
            }
            else
            {
                return "Sorry!   Phrase not found...";
            }
        }
    }
}