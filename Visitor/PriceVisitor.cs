// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "PriceVisitor.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Visitor
{
    using System;

    /// <summary>
    /// Price visitor
    /// </summary>
    public class PriceVisitor : IVisitor
    {
        /// <summary>
        /// Gets or sets the tax payable.
        /// </summary>
        /// <value>
        /// The tax payable.
        /// </value>
        public int TaxPayable
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the total price.
        /// </summary>
        /// <value>
        /// The total price.
        /// </value>
        public int totalPrice
        {
            get;
            set;
        }

        /// <summary>
        /// visitor visits the specified book.
        /// </summary>
        /// <param name="book">The book.</param>
        public void Visit(Book book)
        {
            ////Calculate total cost of number of books
            int cost = book.Quantity * book.Price;

            //// 10% tax
            var calculatedTax = (cost * 10) / 100;

            ////Total price including tax
            totalPrice += cost + calculatedTax;
            TaxPayable += calculatedTax;

            ////Print the tax and price
            Console.WriteLine("\nBooks : ");
            Console.WriteLine("\nTotal Tax : {0} ", TaxPayable);
            Console.WriteLine("\nTotal Price : {0} ", totalPrice);
        }

        /// <summary>
        /// Visitor visits the specified car.
        /// </summary>
        /// <param name="car">The car.</param>
        public void Visit(Car car)
        {
            ////Calculate total cost of number of cars
            int cost = car.Quantity * car.Price;

            //// 10% tax
            var calculatedTax = (cost * 10) / 100;

            ////Total price including tax
            totalPrice += cost + calculatedTax;
            TaxPayable += calculatedTax;

            ////Print the tax and price
            Console.WriteLine("\nCars : ");
            Console.WriteLine("\nTotal Tax : {0} ", TaxPayable);
            Console.WriteLine("\nTotal Price : {0} ", totalPrice);
        }
    }
}
