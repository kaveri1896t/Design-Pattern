// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "ThreadSafe.cs" company="Bridgelabz">
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
    /// Thread safe Singleton design pattern
    /// </summary>
    public sealed class ThreadSafe
    {
        /// <summary>
        /// The count is to count number of instance created
        /// </summary>
        static int count = 0;

        /// <summary>
        /// The single instance is an instance of the thread safe singleton class
        /// </summary>
        private static readonly object singleInstance = new object();

        /// <summary>
        /// Prevents a default instance of the <see cref="LazyInitialization"/> class from being created.
        /// </summary>
        private ThreadSafe()
        {
            ////Increment the count after object creaation
            count++;
            Console.WriteLine(count + " Instance created...");
        }

        private static ThreadSafe instance = null;
        /// <summary>
        /// Gets the single instance.
        /// </summary>
        /// <value>
        /// The single instance.
        /// </value>
        public static ThreadSafe SingleInstance
        {
            get
            {
                if(instance == null)
                {
                    lock (instance)
                    {
                        if(instance == null)
                        {
                            instance = new ThreadSafe();
                        }
                    }
                }

                return instance;
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
