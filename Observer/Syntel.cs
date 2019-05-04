// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "Infotech.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Observer
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// class infotech which updates the price.
    /// </summary>
    /// <seealso cref="Design_Patterns.Observer.Stock" />
    public class Syntel : Stock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Syntel"/> class.
        /// </summary>
        /// <param name="symbol">The symbol of company.</param>
        /// <param name="price">The price of share.</param>
        public Syntel(string symbol, double price) : base(symbol, price)
        {
        }
    }
}
