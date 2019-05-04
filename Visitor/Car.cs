// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "Car.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Visitor
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class car having car properties
    /// </summary>
    public class Car : Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="numberOfCars">The number of cars.</param>
        /// <param name="price">The price per cars.</param>
        public Car(int numberOfCars, int price)
        {
            this.Quantity = numberOfCars;
            this.Price = price;
        }

        /// <summary>
        /// Accepts the specified visitor's request.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}