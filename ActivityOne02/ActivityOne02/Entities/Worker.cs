using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActivityOne02.Entities;

namespace ActivityOne02.Entities
{
    class Worker
    {   
        public String  Name { get; private set; }
        public WorkerLevel Level  { get; private set; }
        protected double BaseSalary { get; private  set; }
        public Department department { get; set; } 
        
        List<HourContract> Contracts = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, string department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            this.department = new Department();
            this.department.Name = department;
        }

        public void addContract(HourContract contract) {
            Contracts.Add(contract);
            contract.id = Contracts.IndexOf(contract);
            Console.WriteLine("Contract added");
        }

        public void RemoveContract(int id) {
            Contracts.RemoveAt(id);
            Console.WriteLine("Contract Removed");
        }
        
        public double Income(int month, int year)
        {   

            double resultado = 0;
            foreach ( HourContract c in Contracts ) 
            {
                if (c.Date.Month == month && c.Date.Year == year)
                {
                    resultado += c.TotalValue();
                }
                else Console.WriteLine("No contracts signed");
            }
            return resultado + BaseSalary;

        }

    }
}
