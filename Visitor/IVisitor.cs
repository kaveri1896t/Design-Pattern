// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "IVisitor.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Visitor
{
    using System;

    /// <summary>
    /// Interface visitor
    /// </summary>
    public interface IVisitor
    {
        /// <summary>
        /// visitor visits the specified book.
        /// </summary>
        /// <param name="book">The book.</param>
        void Visit(Book book);

        /// <summary>
        /// Visitor visits the specified car.
        /// </summary>
        /// <param name="car">The car.</param>
        void Visit(Car car);
    }
}