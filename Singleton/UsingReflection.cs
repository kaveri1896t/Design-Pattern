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
        static int count = 0;

        /// <summary>
        /// The single instance is an instance of using reflection class
        /// </summary>
        public static readonly UsingReflection singleInstance = new UsingReflection();

        private UsingReflection()
        {
            ////Increment the count after object creaation
            count++;
            Console.WriteLine(count + " Instance created...");
        }

    }

    /// <summary>
    /// Reflection to break singleton pattern
    /// </summary>
    public class ReflectionTest
    {
        /// <summary>
        /// Tests the reflection.
        /// </summary>
        public static void TestReflection()
        {
            /*
            Type myType = typeof(UsingReflection);
            Constructor[] constructors = myType.GetConstructor();
            foreach (Constructor info in constructors)
            {
                Console.WriteLine("Instance.hashCode():- " + info.GetHashCode());
            }
            */
        }

        private class Constructor
        {
        }
    }
}

