using System;
using ActivityOne02.Entities;

namespace ActivityOne02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the partment's name: ");
            string NameDepartment = Console.ReadLine();

            Console.WriteLine("enter the worker name: ");
            string WorkerName = Console.ReadLine();

            Console.WriteLine("Worker level(Junior, MidLevel, Senior): ");
            string WorkerLevel = Console.ReadLine();

            Console.WriteLine("Base Salary: ");
            double BaseSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("How many contracts signed? ");
            int n = int.Parse(Console.ReadLine());

            Worker worker = new Worker(WorkerName, Enum.Parse<WorkerLevel>(WorkerLevel),BaseSalary, NameDepartment);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the contract data {i+1}");
                Console.WriteLine("Enter date contract (DD/MM/YYYY):");
                DateTime DateContract = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Value per hour: ");
                double ValueHour = double.Parse(Console.ReadLine());

                Console.WriteLine("total hours worked: ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(DateContract, ValueHour, hours);
                worker.addContract(contract);
            }

            Console.WriteLine("Enter date to calculate income (MM/YYYY):");
            string date = Console.ReadLine();
            int month = int.Parse(date.Substring(0, 2));
            int year = int.Parse(date.Substring(3, 4));

            Console.WriteLine(worker.Income(month, year));

        }
    }
}
