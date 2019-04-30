// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns
{
    using System;

    /// <summary>
    /// Menu for multiple programs
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            int choice, choice1;
            char answer, answer1;
            try
            {
                do
                {
                    Console.WriteLine("1.Singleton Design Pattern");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            do
                            {
                                Console.WriteLine("***************************");
                                Console.WriteLine("1.Eager Initialization");
                                Console.WriteLine("2.Lazy Initialization");
                                Console.WriteLine("3.Thread Safe ");
                                choice1 = Convert.ToInt32(Console.ReadLine());
                                switch (choice1)
                                {
                                    case 1:
                                        Console.WriteLine("\n******Eager Initialization******");
                                        Singleton.SingletonTest.TestEagerInstance();
                                        break;

                                    case 2:
                                        Console.WriteLine("\n******Lazy Initialization******");
                                        Singleton.SingletonTest.TestLazyInstance();
                                        break;

                                    case 3:
                                        Console.WriteLine("\n******Thread Safe******");
                                        Singleton.SingletonTest.TestThreadSafe();
                                        break;

                                    default:
                                        break;
                                }

                                Console.WriteLine("*******************************");
                                Console.WriteLine("Do you want to operate more in Singleton design pattern? (y/n) : ");
                                answer1 = Convert.ToChar(Console.ReadLine());
                            }
                            while (answer1 == 'y' || answer1 == 'Y');
                            break;

                        default:
                            break;
                    }

                    Console.WriteLine("*******************************");
                    Console.WriteLine("Do you want to operate more in Main menu? (y/n) : ");
                    answer = Convert.ToChar(Console.ReadLine());
                }
                while (answer == 'y' || answer == 'Y');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
