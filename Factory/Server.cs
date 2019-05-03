// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "Server.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Factory
{
    using System;

    /// <summary>
    /// Server class which inherit the properties of computer class 
    /// by overriding methods declared in Computer class
    /// </summary>
    /// <seealso cref="Design_Patterns.Factory.Computer" />
    public class Server : Computer
    {
        /// <summary>
        /// The ram of the Server
        /// </summary>
        private string ram;

        /// <summary>
        /// The HDD of the Server
        /// </summary>
        private string hdd;

        /// <summary>
        /// The cpu of the Server
        /// </summary>
        private string cpu;

        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        /// <param name="ram">The ram of the Server.</param>
        /// <param name="hdd">The HDD of the Server.</param>
        /// <param name="cpu">The cpu of the Server.</param>
        public Server(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        /// <summary>
        /// Gets the ram of the Server.
        /// </summary>
        /// <returns>
        /// Ram of the Server
        /// </returns>
        public override string getRAM()
        {
            return this.ram;
        }

        /// <summary>
        /// Gets the HDD of the Server.
        /// </summary>
        /// <returns>
        /// hdd of the Server
        /// </returns>
        public override string getHDD()
        {
            return this.hdd;
        }

        /// <summary>
        /// Gets the cpu of the Server.
        /// </summary>
        /// <returns>
        /// cpu of the Server
        /// </returns>
        public override string getCPU()
        {
            return this.cpu;
        }
    }
}
