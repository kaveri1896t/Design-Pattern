// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "TravelPackage.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Facade
{
    using System;

    /// <summary>
    /// Travelling Package with Flight and hotel booking
    /// </summary>
    public class TravelPackage
    {
        /// <summary>
        /// The number of members for travelling
        /// </summary>
        private int NumberOfMembers;

        /// <summary>
        /// Starts travelling
        /// </summary>
        public void StartTravel()
        {
            char choice;
            string name;
            bool flag = true;
            try
            {
                Console.WriteLine("\n--(>_-)-- GOA TRIP BOOKING --(-_<)--");
                this.ShowDetails();
                Console.WriteLine("\nWould you like to go on a trip with us : (y/n)");
                choice = Convert.ToChar(Console.ReadLine());
                if (choice == 'y' || choice == 'Y')
                {
                    Console.WriteLine("\nEnter your name : ");
                    name = Console.ReadLine();
                    while (flag)
                    {
                        Console.WriteLine("\nEnter number of members (Maximum 10): ");
                        this.NumberOfMembers = Convert.ToInt32(Console.ReadLine());
                        if (this.NumberOfMembers <= 10)
                        {
                            flag = false;
                            ////Flight object 
                            Flight flight = new Flight();

                            ////Book flight ticket for specified number of people
                            flight.BookFlightTicket(this.NumberOfMembers);

                            ////Hotel object
                            Hotel hotel = new Hotel();
                            if (this.NumberOfMembers > 5 && this.NumberOfMembers <= 10)
                            {
                                ////Book hotel rooms for specified number of people
                                hotel.BookHotel(2);
                            }

                            if (this.NumberOfMembers > 0 && this.NumberOfMembers <= 5)
                            {
                                hotel.BookHotel(1);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sorry... Maximum limit per trip is 10 only...");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Thank you for visiting....");
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Shows the details of trip.
        /// </summary>
        public void ShowDetails()
        {
            Console.WriteLine("\nPlace : Goa\nDuration : 1 week\nTraveling : Via Flight\nStay : Hotel" +
                "\nDate : 15 May to 22 May\nStart time : 4 AM\n");
        }
    }
}
