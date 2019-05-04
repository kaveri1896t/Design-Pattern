
namespace Design_Patterns.Visitor
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Start visiting to the products
    /// </summary>
    public class Visit
    {
        /// <summary>
        /// Starts the visiting to products.
        /// </summary>
        public void StartVisiting()
        {
            ////List of products
            List<Product> products = new List<Product> { new Book(12, 200), new Book(45, 205), new Car(1, 150000), new Car(3,1000000) };

            ////instance of price visitor to calculte the price of each product in product list
            PriceVisitor pricevisitor = new PriceVisitor();

            ////send request to the visitable by each product
            products.ForEach(x => {x.Accept(pricevisitor);});
            Console.WriteLine("");
        }
    }
}
