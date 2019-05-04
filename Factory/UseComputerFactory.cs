// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "UseComputerFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Factory
{
    using System;

    /// <summary>
    /// Use the Computer Factory products
    /// </summary>
    public class UseComputerFactory
    {
        /// <summary>
        /// The computer type choosen by user
        /// </summary>
        private string ComputerType;

        /// <summary>
        /// Gets the computer configuration according to type.
        /// </summary>
        public void GetComputerConfiguration()
        {
            char answer;
            Console.WriteLine("\n******Welcome to the Computer Factory*****\n\nWhich type of computer do you want : ");
            try
            {
                do
                {
                    Console.WriteLine("PC");
                    Console.WriteLine("Laptop");
                    Console.WriteLine("Server");
                    Console.WriteLine();
                    this.ComputerType = Console.ReadLine();
                    switch (this.ComputerType)
                    {
                        case "PC":
                            ////Pc configuration
                            Computer pc = Factory.getComputer(this.ComputerType, "2 GB", "500 GB", "2.4 GHz");
                            Console.WriteLine("Configuration of Personal Computer is :\n" + pc);
                            break;

                        case "Laptop":
                            ////Laptop configuration
                            Computer laptop = Factory.getComputer(this.ComputerType, "12 GB", "200 GB", "2.1 GHz");
                            Console.WriteLine("Configuration of Laptop is :\n" + laptop);
                            break;

                        case "Server":
                            ////Server Configuration
                            Computer server = Factory.getComputer(this.ComputerType, "16 GB", "12 TB", "2.9 GHz");
                            Console.WriteLine("Configuration of Serer is :\n" + server);
                            break;

                        default:
                            Console.WriteLine("\nChoice is case-sensitive.... Exiting from choice....");
                            break;
                    }

                    Console.WriteLine("*******************************");
                    Console.WriteLine("Do you want to know more in Computer Factory? (y/n) : ");
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
