// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "EagerInitialization.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Eager initialization of singleton design pattern
    /// </summary>
    public sealed class EagerInitialization
    {
        /// <summary>
        /// The count is to count number of instance created
        /// </summary>
        private static int count = 0;

        /// <summary>
        /// The single instance is an instance of the Eager initialization 
        /// </summary>
        private static EagerInitialization singleInstance = new EagerInitialization();

        /// <summary>
        /// Prevents a default instance of the <see cref="EagerInitialization"/> class from being created.
        /// </summary>
        private EagerInitialization()
        {
            ////Increment the count after object creaation
            count++;
            Console.WriteLine(count + " Instance created...");
        }

        /// <summary>
        /// Gets the single instance.
        /// </summary>
        /// <value>
        /// The single instance.
        /// </value>
        public static EagerInitialization SingleInstance
        {
            get
            {
                return singleInstance;
            }
        }
    }
}
