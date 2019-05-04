// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "IVisitable.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Visitor
{
    using System;

    /// <summary>
    /// interface visitable who accepts requests from visitors
    /// </summary>
    public interface IVisitable
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        void Accept(IVisitor visitor);
    }
}
