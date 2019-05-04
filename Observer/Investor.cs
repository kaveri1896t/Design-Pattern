// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "Investor.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Observer
{
    using System;

    /// <summary>
    /// Class investor
    /// </summary>
    public class Investor : IInvestor
    {
        /// <summary>
        /// The stock instance to access stock properties
        /// </summary>
        private Stock _stock;

        /// <summary>
        /// The name of the investor
        /// </summary>
        private string _name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Investor"/> class.
        /// </summary>
        /// <param name="name">The name of the investor.</param>
        public Investor(string name)
        {
            try
            {
                this._name = name;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Gets or sets the stock.
        /// </summary>
        /// <value>
        /// The stock.
        /// </value>
        public Stock Stock
        {
            get
            {
                return this._stock;
            }
            set
            {
                this._stock = value;
            }
        }
        
        /// <summary>
        /// Updates the specified stock price.
        /// </summary>
        /// <param name="stock">The stock instance.</param>
        public void Update(Stock stock)
        {
            try
            {
                ////Display changes made to all investors
                Console.WriteLine("Notified {0} of {1}'s change in stock price to {2:C}", this._name, stock.Symbol, stock.Price);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}