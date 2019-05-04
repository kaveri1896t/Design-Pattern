// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "Book.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Visitor
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Book class contains book attributes like number of books and prices
    /// </summary>
    public class Book : Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="numberOfBooks">The number of books.</param>
        /// <param name="price">The price per book.</param>
        public Book(int numberOfBooks, int price)
        {
            this.Quantity = numberOfBooks;
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