// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "UsingReflection.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Singleton
{
    using System;
    using System.Reflection;

    /// <summary>
    /// class which uses reflection to destroy the singleton pattern
    /// </summary>
    public sealed class UsingReflection
    {
        /// <summary>
        /// The count is to count number of instance created
        /// </summary>
        private static int count = 0;

        /// <summary>
        /// The single instance is an instance of using reflection class
        /// </summary>
        private static UsingReflection singleInstance = new UsingReflection();

        /// <summary>
        /// Prevents a default instance of the <see cref="UsingReflection"/> class from being created.
        /// </summary>
        private UsingReflection()
        {
            ////Increment the count after object creaation
            count++;
            Console.WriteLine(count + " Instance created...");
        }
    }
}