// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "VegPizza.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Decorator
{
    using System;

    /// <summary>
    /// Vegetarian pizza extends properties of pizza maker
    /// </summary>
    public class NonVegPizza : PizzaMaker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NonVegPizza"/> class.
        /// </summary>
        /// <param name="pizza1">The pizza1 is the pizza type.</param>
        public NonVegPizza(IPizza pizza1) : base(pizza1)
        {
            this.MakePizza();
        }

        /// <summary>
        /// Makes the pizza override method from interface
        /// </summary>
        public new void MakePizza()
        {
            base.MakePizza();
            Console.WriteLine("\nAdding feature of Non Vegetarian pizza.");
        }
    }
}
