// --------------------------------------------------------------------------------------------------------------------
// <copyright file = "Employee.cs" company="Bridgelabz">
//   Copyright © 2019 Company = "BridgeLabz"
// </copyright>
// <creator name= "Kaveri Tekawade"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Design_Patterns.Prototype
{
    using System;

    /// <summary>
    /// Employee details
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// The name of the employee
        /// </summary>
        private string employeeName;

        /// <summary>
        /// The employee identifier
        /// </summary>
        private string employeeId;

        /// <summary>
        /// The salary of the employee
        /// </summary>
        private double salary;

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="name">The name of the employee.</param>
        /// <param name="id">The identifier of the employee.</param>
        /// <param name="salary">The salary of the employee.</param>
        public Employee(string name, string id, double salary)
        {
            this.employeeName = name;
            this.employeeId = id;
            this.salary = salary;
        }

        /// <summary>
        /// Clones the specified employee.
        /// </summary>
        /// <param name="employee">The employee to be cloned.</param>
        /// <returns>cloned employee</returns>
        public Employee Clone(Employee employee)
        {
            try
            {
                ////Copy all members of existing object into another object
                this.employeeName = employee.employeeName;
                this.employeeId = employee.employeeId;
                this.salary = employee.salary;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return this;
        }

        /// <summary>
        /// Prints the employee details
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "Id : " + this.employeeId + ", Name : " + this.employeeName + ", Salary : " + this.salary;
        }
    }
}
