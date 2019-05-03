// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "Password.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Proxy
{
    using System;

    /// <summary>
    /// Password class Allows only admin to change the password
    /// </summary>
    /// <seealso cref="Design_Patterns.Proxy.PasswordUpdation" />
    public class Password : PasswordUpdation
    {
        /// <summary>
        /// The user identifier
        /// </summary>
        private string userId;

        /// <summary>
        /// The password for that user Id
        /// </summary>
        private string password;

        /// <summary>
        /// Initializes a new instance of the <see cref="Password"/> class.
        /// set default values to data members
        /// </summary>
        public Password()
        {
            this.userId = "Kaveri123";
            this.password = "Kaveri123@#";
        }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public string UserId
        {
            get { return this.userId; }
            set { this.userId = value; }
        }

        /// <summary>
        /// Gets or sets the pass word.
        /// </summary>
        /// <value>
        /// The pass word.
        /// </value>
        public string PassWord
        {
            get
            {
                return this.password;
            }

            set
            {
                this.password = value;
            }
        }

        /// <summary>
        /// override the update password method from interface password update
        /// </summary>
        public void UpdatePassword()
        {
            string oldPassword, newPassword, repeatNewPassword;
            bool flag = true, outerFlag = true;
            int passwordCount = 0;
            try
            {
                while (outerFlag)
                {
                    Console.WriteLine("\nEnter your old password : ");
                    oldPassword = Console.ReadLine();
                    passwordCount++;

                    ////Check for authorised user
                    if (this.password.Equals(oldPassword))
                    {
                        outerFlag = false;
                        while (flag)
                        {
                            ////Take new password
                            Console.WriteLine("\nEnter your new password : ");
                            newPassword = Console.ReadLine();

                            ////Re-enter the password
                            Console.WriteLine("\nRe-Enter your new password : ");
                            repeatNewPassword = Console.ReadLine();

                            ////Check for same password 
                            if (newPassword == repeatNewPassword)
                            {
                                ////update the password by new password
                                this.password = newPassword;
                                Console.WriteLine("\nPassword updated successfully...\nYour new password is " + this.password);
                                flag = false;
                            }
                            else
                            {
                                Console.WriteLine("\nEntered password not matched...");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nIncorrect Password....");
                    }

                    if (passwordCount == 3)
                    {
                        Console.WriteLine("\n3 times incorrect Password....Access denied...");
                        return;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return;
        }
    }
}
