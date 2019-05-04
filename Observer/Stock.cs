// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "Stock.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Observer
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Stock class is an abstract class having abstract method
    /// </summary>
    public abstract class Stock
    {
        /// <summary>
        /// The symbol is a symbol of the company
        /// </summary>
        private string _symbol;

        /// <summary>
        /// The price of share
        /// </summary>
        private double _price;

        /// <summary>
        /// The investors list
        /// </summary>
        private List<IInvestor> _investors = new List<IInvestor>();

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double Price
        {
            get
            {
                return this._price;
            }
            set
            {
                ////Check if change happened in price
                if (this._price != value)
                {
                    ////If yes then update the price
                    this._price = value;

                    ////Notify to all observers
                    this.Notify();
                }
            }
        }

        /// <summary>
        /// Gets the symbol 
        /// </summary>
        public string Symbol
        {
            get
            {
                return this._symbol;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stock"/> class.
        /// </summary>
        /// <param name="symbol">The symbol of company.</param>
        /// <param name="price">The price of share.</param>
        public Stock(string symbol, double price)
        {
            try
            {
                this._symbol = symbol;
                this._price = price;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Attaches the specified investor into the list.
        /// </summary>
        /// <param name="investor">The investor.</param>
        public void Attach(IInvestor investor)
        {
            this._investors.Add(investor);
        }

        /// <summary>
        /// Detaches the specified investor from the list.
        /// </summary>
        /// <param name="investor">The investor.</param>
        public void Detach(IInvestor investor)
        {
            this._investors.Remove(investor);
        }

        /// <summary>
        /// Notifies all investors about change
        /// </summary>
        public void Notify()
        {
            try
            {
                foreach (IInvestor investor in this._investors)
                {
                    ////Notifying each investor
                    investor.Update(this);
                }

                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
