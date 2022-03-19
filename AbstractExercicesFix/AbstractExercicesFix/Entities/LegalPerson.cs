using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExercicesFix.Entities
{
    class LegalPerson : Payer
    {
        public int EmployeesNumber { get; private set; }

        public LegalPerson(string name, double annualIncome, int employeesNumber)
            : base(name, annualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double TaxAmount()
        {
            double tax;
            if (EmployeesNumber > 10)
            {
                tax = AnnualIncome * 0.14;
            }
            else
            {
                tax = AnnualIncome * 0.16;
            }
            return tax;
        }
    }
}
