// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "IInvestor.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Observer
{
    using System;

    /// <summary>
    /// Interface investor
    /// </summary>
    public interface IInvestor
    {
        /// <summary>
        /// Updates the specified stock price.
        /// </summary>
        /// <param name="stock">The stock.</param>
        void Update(Stock stock);
    }
}
