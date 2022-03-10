using System;
using ActivityOne.Entities;
using ActivityOne.Entities.Enums;
using ActivityOne.Functions;

namespace ActivityOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Department Name: ");
            string departmentName = Console.ReadLine();

            Console.Write("Worker name: ");
            string nameWorker = Console.ReadLine();

            Console.Write("Enter the worker level (Junior, MidLevel, Senior): ");
            string workerLevel = Console.ReadLine();
            WorkerLevel wl = Enum.Parse<WorkerLevel>(workerLevel);

            Console.Write("Enter the base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Worker worker = new Worker(nameWorker, wl, baseSalary, departmentName);
            
            Console.Write("What is the number of contract signatures? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter contract data #{i+1}: ");
                Console.Write("Data contract (dd/MM/yyy): ");
                string dateContract = Console.ReadLine();
                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine());
                Console.Write("Total hours worked: ");
                int totalHours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(DateTime.Parse(dateContract), valueHour, totalHours);
                worker.AddContract(contract); 

            }

            Console.Write("Enter the month and year to calculate income(MM/yyyy): ");
            string dateIncome = Console.ReadLine();
            int month = int.Parse(dateIncome.Substring(0,2));
            int year = int.Parse(dateIncome.Substring(3,4));
            double totalIncome =  worker.BaseSalary + worker.Income(month,year);

            Console.WriteLine(worker);
            Console.WriteLine($"Income for {dateIncome}: {totalIncome}");

        }
    }
}
