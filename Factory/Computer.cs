// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "Computer.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Factory
{
    using System;

    /// <summary>
    /// Computer class that declares properties of computer
    /// </summary>
    public abstract class Computer
    {
        /// <summary>
        /// Gets the ram.
        /// </summary>
        /// <returns>Ram of the computer</returns>
        public abstract string getRAM();

        /// <summary>
        /// Gets the cpu.
        /// </summary>
        /// <returns>cpu of the computer</returns>
        public abstract string getCPU();

        /// <summary>
        /// Gets the HDD.
        /// </summary>
        /// <returns>hdd of the computer</returns>
        public abstract string getHDD();

        /// <summary>
        /// Override the to string to display the output on the console.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "RAM = " + this.getRAM() + ", HDD = " + this.getHDD() + ", CPU = " + this.getCPU();
        }
    }
}