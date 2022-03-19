using System;
using System.Collections.Generic;
using AbstractExercicesFix.Entities;

namespace AbstractExercicesFix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> payers = new List<Payer>();

            Console.Write("Enter the number payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the Payer {i+1} data: ");
                Console.Write("The payer is Person legal or physical(l or p)? ");
                string type = Console.ReadLine().Trim().ToLower();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double AnnualIncome = double.Parse(Console.ReadLine());

                if (type.Equals("l"))
                {
                    Console.Write("Enter the number employees: ");
                    int NEmployees= int.Parse(Console.ReadLine());
                    Payer p = new LegalPerson(name, AnnualIncome, NEmployees);
                    payers.Add(p);
                }
                else if (type.Equals("p")) 
                {
                    Console.Write("Enter the value Health Spending: ");
                    double hs = double.Parse(Console.ReadLine());
                    payers.Add(new PhysicalPerson(name, AnnualIncome, hs));

                }
                double total= 0;
                payers.ForEach(p =>Console.WriteLine($"Payer:{p.name}, " +
                    $"Tax: {p.TaxAmount()}"));
                payers.ForEach(p => total += p.TaxAmount());
                Console.WriteLine($"Total tax ={total}");


            }











        }
    }
}
