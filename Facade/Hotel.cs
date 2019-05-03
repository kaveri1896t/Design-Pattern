// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "Hotel.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Facade
{
    using System;

    /// <summary>
    /// Hotel class override book hotel method of interface
    /// </summary>
    public class Hotel : IHotel
    {
        /// <summary>
        /// The hotel capacity
        /// </summary>
        private int HotelCapacity = 100;

        /// <summary>
        /// The booked ticket count
        /// </summary>
        private int BookedRoomCount = 0;

        /// <summary>
        /// Books the hotel.
        /// </summary>
        /// <param name="numberOfRooms">The number of rooms.</param>
        public void BookHotel(int numberOfRooms)
        {
            try
            {
                ////Check room availability
                if (this.IsAvailable(numberOfRooms))
                {
                    this.BookedRoomCount = this.BookedRoomCount + numberOfRooms;
                    this.HotelCapacity = this.HotelCapacity - this.BookedRoomCount;
                    Console.WriteLine("\nRooms booked successfully....");
                    return;
                }
                else
                {
                    Console.WriteLine("\n" + numberOfRooms + " rooms are not available...");
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Determines whether the specified number of rooms are available.
        /// </summary>
        /// <param name="number">The number of rooms.</param>
        /// <returns>
        ///   <c>true</c> if the specified number is available; otherwise, <c>false</c>.
        /// </returns>
        public bool IsAvailable(int number)
        {
            if (number <= this.HotelCapacity)
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
