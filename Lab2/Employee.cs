using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Employee
    {
        // Publicly accessible employee details
        public string EmployeeName = "John Doe";

        // Private information accessible only within the HR department
        private string EmployeeSocialSecurityNumber = "123-45-6789";

        // Protected employee benefits information
        protected double EmployeeSalary = 60000.00;

        // Internal company policies and procedures
        internal string InternalPolicyDocument = "Confidential Policy Document";

        // Public method for general tasks
        public void PerformTask()
        {
            Console.WriteLine("Employee performing a general task.");
        }

        // Private method for HR-related confidential matters
        private void HRConfidentialMeeting()
        {
            Console.WriteLine("Private HR meeting discussing employee matters.");
        }

        // Protected method for salary negotiations
        protected void NegotiateSalary()
        {
            Console.WriteLine($"Salary negotiation in progress.");
        }

        // Internal method for accessing company policies
        internal void AccessCompanyPolicy()
        {
            Console.WriteLine("Accessing internal company policy document.");
        }
    }

    // Manager class with access to protected members
    public class Manager : Employee
    {
        public void AccessEmployeeBenefits()
        {
            // Accessing protected EmployeeSalary from the base class
            Console.WriteLine($"Employee salary: ${EmployeeSalary}");
        }

        public void InitiateSalaryNegotiation()
        {
            // Accessing protected NegotiateSalary method from the base class
            NegotiateSalary();
        }
    }
}
