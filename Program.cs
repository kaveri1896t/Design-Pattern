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
       public static void Main(string[] args)
        {
            int choice, choice1;
            char answer, answer1;
            try
            {
                do
                {
                    ////Operations to be choosen by user
                    Console.WriteLine("1.Singleton Design Pattern");
                    Console.WriteLine("2.Factory Design Pattern");
                    Console.WriteLine("3.Prototype Design Pattern");
                    Console.WriteLine("4.Adapter Design Pattern");
                    Console.WriteLine("5.Proxy Design Pattern");
                    Console.WriteLine("6.Facade Design Pattern");
                    Console.WriteLine("7.Decorator Design Pattern");
                    Console.WriteLine("8.Observer Design Pattern");
                    Console.WriteLine("9.Visitor Design Pattern");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            ////Singleton 
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                try
                                {
                                    do
                                    {
                                        Console.WriteLine("***************************");
                                        Console.WriteLine("1.Eager Initialization");
                                        Console.WriteLine("2.Lazy Initialization");
                                        Console.WriteLine("3.Thread Safe");
                                        Console.WriteLine("4.Reflection");
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

                                            case 4:
                                                Console.WriteLine("\n******Reflection******");
                                                Singleton.ReflectionTest.TestReflection();
                                                break;

                                            default:
                                                break;
                                        }

                                        Console.WriteLine("*********************************************");
                                        Console.WriteLine("\nDo you want to operate more in Singleton design pattern? (y/n) : ");
                                        answer1 = Convert.ToChar(Console.ReadLine());
                                    }
                                    while (answer1 == 'y' || answer1 == 'Y');
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }

                            break;

                        case 2:
                            ////Factory
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("*******Factory Design Pattern******");
                            Factory.UseComputerFactory factory = new Factory.UseComputerFactory();
                            factory.GetComputerConfiguration();
                            break;

                        case 3:
                            ////Prototype
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n******Prototype Design Pattern******");
                            Prototype.EmployeePrototype employee = new Prototype.EmployeePrototype();
                            employee.TestPrototype();
                            break;

                        case 4:
                            ////Adapter
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\n******Adapter Design Pattern******");
                            Adapter.Input input = new Adapter.Input();
                            input.Start();
                            break;

                        case 5:
                            ////Proxy
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("\n******Proxy Design Pattern******");
                            Proxy.Proxy proxy = new Proxy.Proxy();
                            proxy.Update();
                            break;

                        case 6:
                            ////Facade
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n******Facade Design Pattern******");
                            Facade.TravelPackage travelPackage = new Facade.TravelPackage();
                            travelPackage.StartTravel();
                            break;

                        case 7:
                            ////Decorator
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("\n******Decorator Design Pattern******");
                            Decorator.OrderPizza orderPizza = new Decorator.OrderPizza();
                            orderPizza.Order();
                            break;

                        case 8:
                            ////Observer
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n******Observer Design Pattern******");
                            Observer.MakeChanges makeChanges = new Observer.MakeChanges();
                            makeChanges.Changes();
                            break;

                        case 9:
                            ////Visitor
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n******Visitor Design Pattern******");
                            Visitor.Visit visit = new Visitor.Visit();
                            visit.StartVisiting();
                            break;

                        default:
                            Console.WriteLine("\nWrong choice...");
                            break;
                    }

                    Console.WriteLine("**************************************************");
                    Console.WriteLine("\nDo you want to operate more in Main menu? (y/n) : ");
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