// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "DefaultPizza.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Decorator
{
    using System;

    /// <summary>
    /// General pizza  
    /// </summary>
    public class DefaultPizza : IPizza
    {
        /// <summary>
        /// override the Methods make pizza.
        /// </summary>
        public void MakePizza()
        {
            Console.WriteLine("\nBasic Pizza");
        }
    }
}
