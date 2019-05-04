// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "ReflectionTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Singleton
{
    using System;
    using System.Reflection;
    
    /// <summary>
    /// Reflection to break singleton pattern
    /// </summary>
    public sealed class ReflectionTest
    {
        /// <summary>
        /// Tests the reflection.
        /// </summary>
        public static void TestReflection()
        {
            Type myType = typeof(UsingReflection);
            UsingReflection reflection = (UsingReflection)Activator.CreateInstance(myType);
            ConstructorInfo[] constructors = myType.GetConstructors();
            
            ////Display hash code of objects
            foreach (ConstructorInfo info in constructors)
            {
                Console.WriteLine("Instance.hashCode():- " + info.GetHashCode());
            }
        }
    }
}
