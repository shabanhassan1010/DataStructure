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
    public class CreateListOfObject : IComparable<CreateListOfObject> 
    {
        // Properties
        public int EmployeeNo { get; set; }
        public string FullName { get; set; } = string.Empty;
        public decimal StartSalary { get; set; }
        public float WorkingHoursPerWeek { get; set; }
        public ContractType Contract { get; set; }  // Using the enum defined outside the class

        public CreateListOfObject()
        {
        }
        public CreateListOfObject(int employeeNo, string fullName, decimal startSalary, float workingHoursPerWeek, ContractType contract)
        {
            EmployeeNo = employeeNo;
            FullName = fullName;
            StartSalary = startSalary;
            WorkingHoursPerWeek = workingHoursPerWeek;
            Contract = contract;
        }

        public int CompareTo(CreateListOfObject? createListOfObject)
        {
            // StartSalary
            // Refers to the StartSalary property of the current instance of the CreateListOfObject class.
            // CreateListOfObject.StartSalary
            // Refers to the StartSalary property from Outside (from User)
            if (StartSalary > createListOfObject.StartSalary)
                //1: Indicates that the current instance(this) has a greater StartSalary than the compared instance
                return 1;
            else if (StartSalary < createListOfObject.StartSalary)
                // -1: Indicates that the current instance has a smaller StartSalary than the compared instance.
                return -1;
            else // If both StartSalary values are equal, the method returns 0.

                return 0;
        }
    }

}
