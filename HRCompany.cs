using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practic_4
{
    public class HRCompany
    {
        private List<Employee> employees;
        public HRCompany()
        {
        employees= new List<Employee>();
        }
        public void HireEmployee(Employee employee)
        {
        employees.Add(employee);
        }
        public void FireEmployee(int EmployeeId)
        {
            Employee employee = employees.Find(emp => emp.Id == EmployeeId);
            if (employee != null)
            {
                employees.Remove(employee);
            }
        }
        public void UpdateEmployeeInformation ( int EmployeeId , string newName , string newFamily, int newAccountNumber ) 
        { 
        Employee employee = employees.Find(emp =>emp.Id == EmployeeId);
            if (employee != null) 
            {
               employee.FistName = newName;
               employee.LastName = newFamily;
               employee.AccountNumber = newAccountNumber;
               Console.WriteLine($"Employee information updated for employee with Id {EmployeeId})");
            }
            else 
            {
               Console.WriteLine($"Employee with Id {EmployeeId} not found");
             
            }
        }
        public void ShowEmployeeList()
        {
               Console.WriteLine("Employee List :");
            foreach(Employee employee in employees)
            { 
               Console.WriteLine($"Id:{employee.Id}, Name:{employee.FistName} {employee.LastName} ,Email:{employee.Email}; Hire Date:{employee.HireDate}, Account Number :{employee.AccountNumber}");
            }
               Console.WriteLine();
        }
    }
}
