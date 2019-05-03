// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "IHotel.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Facade
{
    using System;

    /// <summary>
    /// Interface hotel to book hotel
    /// </summary>
    public interface IHotel
    {
        /// <summary>
        /// Books the hotel.
        /// </summary>
        /// <param name="number">The number of rooms.</param>
        void BookHotel(int number);
    }
}
