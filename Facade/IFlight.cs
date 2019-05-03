// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "IFlight.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Facade
{
    using System;

    /// <summary>
    /// Interface flight to book ticket of flight
    /// </summary>
    public interface IFlight
    {
        /// <summary>
        /// Books the flight ticket.
        /// </summary>
        /// <param name="numberOfSeats">The number of seats.</param>
        void BookFlightTicket(int numberOfSeats);
    }
}
