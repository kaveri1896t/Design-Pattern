// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "NonvegPizzaExtraAdding.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Decorator
{
    using System;

    /// <summary>
    /// Non veg pizza with extra adding features
    /// </summary>
    /// <seealso cref="Design_Patterns.Decorator.PizzaMaker" />
    public class NonvegPizzaExtraAdding : PizzaMaker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VegPizza"/> class.
        /// </summary>
        /// <param name="pizza1">The pizza1 is the pizza type.</param>
        public NonvegPizzaExtraAdding(IPizza pizza1) : base(pizza1)
        {
            this.MakePizza();
        }

        /// <summary>
        /// Makes the pizza override method from interface
        /// </summary>
        public new void MakePizza()
        {
            ////Call to Base class method
            base.MakePizza();
            Console.WriteLine("\nAdding features of Extra toppings on Non Vegetarian pizza.");
        }
    }
}
