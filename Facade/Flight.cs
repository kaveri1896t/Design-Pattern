// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "Flight.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Facade
{
    using System;

    /// <summary>
    /// Flight inherits the properties of interface 
    /// </summary>
    public class Flight : IFlight
    {
        /// <summary>
        /// The flight capacity
        /// </summary>
        private int FlightCapacity = 100;

        /// <summary>
        /// The booked ticket count
        /// </summary>
        private int BookedTicketCount = 0;

        /// <summary>
        /// Books the flight ticket.
        /// </summary>
        /// <param name="numberOfSeats">The number of seats.</param>
        public void BookFlightTicket(int numberOfSeats)
        {
            try
            {
                ////Check whether specified seats are available or not
                if (this.IsAvailable(numberOfSeats))
                {
                    ////if available then book specified number of tickets
                    this.BookedTicketCount = this.BookedTicketCount + numberOfSeats;

                    ////update the capacity of flight 
                    this.FlightCapacity = this.FlightCapacity - this.BookedTicketCount;
                    Console.WriteLine("\nTickets booked successfully....");
                    return;
                }
                else
                {
                    Console.WriteLine("\n" + numberOfSeats + " seats are not available...");
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Determines whether the specified number of seats are available or not.
        /// </summary>
        /// <param name="number">The number of seats.</param>
        /// <returns>
        ///   <c>true</c> if the specified number is available; otherwise, <c>false</c>.
        /// </returns>
        public bool IsAvailable(int number)
        {
            if (number <= this.FlightCapacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
