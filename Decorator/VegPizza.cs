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
    public class VegPizza : PizzaMaker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VegPizza"/> class.
        /// </summary>
        /// <param name="pizza1">The pizza1 is the pizza type.</param>
        public VegPizza(IPizza pizza1) : base(pizza1)
        {
        }

        /// <summary>
        /// Makes the pizza override method from interface
        /// </summary>
        public new void MakePizza()
        {
            base.MakePizza();
        }
    }
}
