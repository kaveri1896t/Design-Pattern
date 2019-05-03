// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "EmployeePrototype.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Prototype
{
    using System;

    /// <summary>
    /// Employee prototype to create clone of Employee
    /// </summary>
    public class EmployeePrototype
    {
        /// <summary>
        /// Tests the prototype design pattern.
        /// </summary>
        public void TestPrototype()
        {
            try
            {
                Employee employee = new Employee("Kaveri", "A1", 10000.00);

                ////Copy the existing object into new empty object
                Employee employee1 = employee.Clone(employee);

                ////Display the objects
                Console.WriteLine("Original Instance : \n");
                Console.WriteLine(employee.ToString());
                Console.WriteLine("\nCloned Instance : \n");
                Console.WriteLine(employee1.ToString());
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
