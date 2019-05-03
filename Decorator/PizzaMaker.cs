// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "PizzaMaker.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Decorator
{
    using System;

    /// <summary>
    /// Pizza maker class inherit the properties of Pizza interface.
    /// This act as a Decorator for pizza making
    /// </summary>
    public class PizzaMaker : IPizza
    {
        /// <summary>
        /// The pizza is an instance of pizza interface
        /// </summary>
        private IPizza pizza;

        /// <summary>
        /// Initializes a new instance of the <see cref="PizzaMaker"/> class.
        /// </summary>
        /// <param name="pizza1">The pizza1 is the pizza type.</param>
        public PizzaMaker(IPizza pizza1)
        {
            this.pizza = pizza1;
        }

        /// <summary>
        /// Makes the pizza
        /// </summary>
        public void MakePizza()
        {
            this.pizza.MakePizza();
        }
    }
}
