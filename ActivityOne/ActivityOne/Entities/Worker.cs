using ActivityOne.Entities.Enums;
using ActivityOne.Functions;
using System.Collections.Generic;
using ActivityOne.Entities;


namespace ActivityOne.Entities
{
    class Worker
    {
        List<HourContract> ListContracts = new List<HourContract>();
        private Department department = new Department();
        public string Name { get; private set; }
        public WorkerLevel Level { get; private set; }
        public double BaseSalary { get; private set; }

        public Worker(string name, WorkerLevel level, double baseSalary, string department)
        {
            this.department.Name = department;
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Level: {Level} and Base Salary {BaseSalary}" +
                $"\nDepartment {department.Name}.";
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

        
        public double Income(int month, int year)
        {
            double resultado = 0;
            foreach(HourContract c in ListContracts)
            {
                if (ListContracts.Count !=0 &&  c.Date.Year == year && c.Date.Month == month) {
                    resultado += c.TotalValue();
                }
                else { System.Console.WriteLine("No exists contract signatures.");}
            }
            return resultado;
        }



    }
}
