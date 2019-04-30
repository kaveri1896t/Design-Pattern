// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "SingletonTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Test all types of initializations here
    /// </summary>
    public class SingletonTest
    {
        /// <summary>
        /// Tests the instance of singleton design pattern.
        /// </summary>
        public static void TestEagerInstance()
        {
            try
            {
                ////Assigning instance of class to new instance of class
                EagerInitialization eagerInitialization1 = EagerInitialization.SingleInstance;
                EagerInitialization eagerInitialization2 = EagerInitialization.SingleInstance;
                Console.WriteLine("Object1 == Object2 = " + (eagerInitialization1 == eagerInitialization2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Tests the lazy instance of singleton design pattern.
        /// </summary>
        public static void TestLazyInstance()
        {
            try
            {
                ////pass the functions to delegate 
                Parallel.Invoke(
                    () => PrintObject1(),
                    () => PrintObject2()
                    );
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Tests the thread safe singleton design pattern.
        /// </summary>
        public static void TestThreadSafe()
        {
            try
            {
                ////pass the functions to delegate 
                Parallel.Invoke(
                    () => PrintObject1(),
                    () => PrintObject2()
                    );
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Prints the object 1.
        /// </summary>
        private static void PrintObject1()
        {
            LazyInitialization lazyInitialization = LazyInitialization.SingleInstance;
            lazyInitialization.Display("Object1");
        }

        /// <summary>
        /// Prints the object 2.
        /// </summary>
        private static void PrintObject2()
        {
            LazyInitialization lazyInitialization = LazyInitialization.SingleInstance;
            lazyInitialization.Display("Object2");
        }
    }
}
