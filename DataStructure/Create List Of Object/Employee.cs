using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.NewFolder
{
    public enum ContractType
    {
        FullTime,
        PartTime,
        Freelance
    }
    // Class Definition
    public class Employee : IComparable<Employee> 
    {
        // Properties
        public int EmployeeNo { get; set; }
        public string FullName { get; set; } = string.Empty;
        public decimal StartSalary { get; set; }
        public float WorkingHoursPerWeek { get; set; }
        public ContractType Contract { get; set; }  // Using the enum defined outside the class

        public Employee()
        {
        }
        public Employee(int employeeNo, string fullName, decimal startSalary, float workingHoursPerWeek, ContractType contract)
        {
            EmployeeNo = employeeNo;
            FullName = fullName;
            StartSalary = startSalary;
            WorkingHoursPerWeek = workingHoursPerWeek;
            Contract = contract;
        }

        public int CompareTo(Employee? employee)
        {
            // StartSalary
            // Refers to the StartSalary property of the current instance of the Employee class.
            // Employee.StartSalary
            // Refers to the StartSalary property from Outside (from User)
            if (StartSalary > employee.StartSalary)
                //1: Indicates that the current instance(this) has a greater StartSalary than the compared instance
                return 1;
            else if (StartSalary < employee.StartSalary)
                return -1;
            else // If both StartSalary values are equal, the method returns 0.
                return 0;
        }
    }

}
