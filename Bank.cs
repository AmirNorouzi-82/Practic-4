using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_4
{
    public class Bank
    {
        public void DepositMoney(int employeeId, decimal amount) 
        {
            // Perform deposit operation for the given employee ID 
            Console.WriteLine($"Depositing {amount} money for employee with Id {employeeId}");
            // Your logic for depositing money goes hered
        }
        public void WithdrawMoney(int employeeId, decimal amount)
        {
            // Perform withdrawal operation for the given employee ID
            Console.WriteLine($"Withdrawing {amount} money for employee with Id {employeeId}");
            // Your logic for withdrawing money goes here
        }
    }
}
