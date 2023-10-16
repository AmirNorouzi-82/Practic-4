namespace Practic_4
{
    internal class Program
    {
        static void Main()
        {
            HRCompany hrCompany = new HRCompany();

            // Hire employees 
            Employee emp1 = new Employee { Id = 1, FistName = "Amir", LastName = "Mohammadi",Email="Amir123@gmail.com",AccountNumber = 1057164531, HireDate = DateTime.Today };
            Employee emp2 = new Employee { Id = 2, FistName = "Mahdi", LastName = "Kamrani",Email ="mahdi456@yahoo.com",AccountNumber = 234532679, HireDate = DateTime.Now };
            hrCompany.HireEmployee(emp1);
            hrCompany.HireEmployee(emp2);

            //Show employee list 
            hrCompany.ShowEmployeeList();

            // Fire an employee
            hrCompany.FireEmployee(1);

            // show updated employee list 
            hrCompany.ShowEmployeeList();
           

            // create an instance of Bank 
            Bank bank = new Bank();

            //Create an instance of FI connected to the bank 
            FI fiCompany = new FI(bank);

            // pay an employee 
            decimal amount = 500;
            int employeeId = 2;
            fiCompany.PayEmployee(employeeId, amount);

            Console.ReadLine();
        }
    }
}
