// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "Proxy.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Proxy
{
    using System;

    /// <summary>
    /// Proxy request handler
    /// </summary>
    public class Proxy
    {
        /// <summary>
        /// The password object of password class
        /// </summary>
        private Password passwordObject = new Password();

        /// <summary>
        /// Determines whether [is valid user] [the specified user identifier].
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>
        ///   <c>true</c> if [is valid user] [the specified user identifier]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsAdmin(string userId)
        {
            ////check if valid user
            if (this.passwordObject.UserId == userId)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Views the details of specified user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        public void ViewDetails(string userName)
        {
            try
            {
                ////Check  the user name to view details
                if (this.passwordObject.UserId != userName)
                {
                    Console.WriteLine("\nUsername : " + userName + "\nNumber of directories : 67" + "\nTotal Memory allocated : 100GB" + "\nMemory Used : 45GB" + "\nAvailable Memory : 55GB\n");
                }
                else
                {
                    Console.WriteLine("\nUsername : " + userName + "\nNumber of directories : 145" + "\nTotal Memory allocated : 560GB" + "\nMemory Used : 370GB" + "\nAvailable Memory : 190GB\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Updates the details.
        /// </summary>
        /// <param name="userid">The userid.</param>
        public void UpdatePassword(string userid)
        {
            try
            {
                ////Check for admin
                if (this.IsAdmin(userid))
                {
                    this.passwordObject.UpdatePassword();
                    return;
                }
                else
                {
                    Console.WriteLine("\nUnauthorized user... Access Denied...");
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Updates the details of user.
        /// </summary>
        public void Update()
        {
            int choice;
            char answer;
            string inputName;
            try
            {
                ////Take username from user
                Console.WriteLine("\nEnter the username : ");
                inputName = Console.ReadLine();
                do
                {
                    Console.WriteLine("-------------------------------------\n");
                    Console.WriteLine("1.View Details");
                    Console.WriteLine("2.Update password");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            this.ViewDetails(inputName);
                            break;

                        case 2:
                            this.UpdatePassword(inputName);
                            break;

                        default:
                            break;
                    }

                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("\nDo you want to operate more? (y/n) : ");
                    answer = Convert.ToChar(Console.ReadLine());
                }
                while (answer == 'y' || answer == 'Y');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
