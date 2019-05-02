// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "Factory.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Factory
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Factory is an Abstract class which defines methos to get properties of types of computers
    /// </summary>
    public abstract class Factory
    {
        /// <summary>
        /// Gets the computer.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="ram">The ram of computer.</param>
        /// <param name="hdd">The HDD computer.</param>
        /// <param name="cpu">The cpu computer.</param>
        /// <returns></returns>
        public static Computer getComputer(String type, String ram, String hdd, String cpu)
        {
            if ("PC".Equals(type) || "pc".Equals(type))
            {
                return new PersonalComputer(ram, hdd, cpu);
            }
            else if ("Server".Equals(type) || "server".Equals(type))
            {
                return new Server(ram, hdd, cpu);
            }
            else if ("Laptop".Equals(type) || "laptop".Equals(type))
            {
                return new Laptop(ram, hdd, cpu);
            }

            return null;
        }
    }
}
