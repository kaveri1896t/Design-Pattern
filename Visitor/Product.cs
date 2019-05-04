// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "Product.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Visitor
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// class product
    /// </summary>
    public abstract class Product : IVisitable
    {
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price of the product.
        /// </value>
        public int Price
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity of the product.
        /// </value>
        public int Quantity
        {
            get;
            set;
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        public abstract void Accept(IVisitor visitor);
    }
}