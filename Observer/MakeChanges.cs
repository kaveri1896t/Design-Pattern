
namespace Design_Patterns.Observer
{
    using System;

    /// <summary>
    /// Make changes into price and notify all investors
    /// </summary>
    public class MakeChanges
    {
        /// <summary>
        /// Make Changes in prices.
        /// </summary>
        public void Changes()
        {
            try
            {
                ////Create Infotech instance with name and price
                Syntel syntel = new Syntel("Syntel", 120.00);

                ////Add investors to the list
                syntel.Attach(new Investor("Atos"));
                syntel.Attach(new Investor("Infosys"));

                ////Changes in prices will notify the investors
                syntel.Price = 120.10;
                syntel.Price = 121.00;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return;
        }
    }
}
