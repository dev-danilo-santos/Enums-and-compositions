using ActivityOne.Entities.Enums;
using ActivityOne.Functions;
using System.Collections.Generic;
using ActivityOne.Entities;

namespace ActivityOne.Entities
{
    class Worker
    {
        List<HourContract> ListContracts = new List<HourContract>();
        private Department WorkerDepartment;
        public string Name { get; private set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Worker(string name, WorkerLevel level, double baseSalary, string department)
        {
            WorkerDepartment.Name = department;
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Level: {Level} and Base Salary {BaseSalary}";
        }

        public void AddContract(HourContract contract )
        {
            ListContracts.Add(contract);
            System.Console.WriteLine("Contract added!");

        }

        public void RemoveContract(HourContract contract)
        {
            ListContracts.Remove(contract);
            System.Console.WriteLine("Contract Removed!");
        }

        // ainda terminar
        public double Income(int year, int mes)
        {
            double resultado;
            foreach(HourContract c in ListContracts)
            {
                if () { }


            }
        }

    }
}
