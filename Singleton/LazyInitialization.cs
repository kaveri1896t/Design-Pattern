﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "LazyInitialization.cs" company="Bridgelabz">
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
    /// Lazy Initialization of singleton design pattern
    /// </summary>
    public sealed class LazyInitialization
    {
        /// <summary>
        /// The count is to count number of instance created
        /// </summary>
        static int count = 0;

        /// <summary>
        /// The single instance is an instance of the Lazy initialization with deligation
        /// </summary>
        private static readonly Lazy<LazyInitialization> singleInstance = new Lazy<LazyInitialization>(() => new LazyInitialization());

        /// <summary>
        /// Prevents a default instance of the <see cref="LazyInitialization"/> class from being created.
        /// </summary>
        private LazyInitialization()
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
        public static LazyInitialization SingleInstance
        {
            get
            {
                return singleInstance.Value;
            }
        }

        /// <summary>
        /// Print the string.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Display(string string1)
        {
            Console.WriteLine(string1);
        }
    }
}
