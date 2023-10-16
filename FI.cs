using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_4
{
    public class FI
    {
        private Bank bank;
        public FI(Bank bank) 
        { 
        this.bank = bank;
        }
        public void PayEmployee(int employeeId , decimal amount)
        {
        // Call the bank methods to perform financial transactions 
        bank.WithdrawMoney(employeeId, amount);
        // Your logic for processing the payment goes here 
        Console.WriteLine($"Paying {amount} money to employee with Id {employeeId}");
        }
    }
}
