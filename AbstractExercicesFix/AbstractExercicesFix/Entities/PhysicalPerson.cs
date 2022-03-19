using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExercicesFix.Entities
{
    class PhysicalPerson : Payer
    {
        public double HealthSpending { get; private set; }

        public PhysicalPerson(string name, double annualIncome, double healthSpending)
            : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double TaxAmount()
        {
            double tax;
            if (AnnualIncome < 20000.00)
            {
                tax = AnnualIncome * 0.15;
            }
            else { tax = AnnualIncome * 0.25; }

            if (HealthSpending != 0)
            {
                tax -= 0.5 * HealthSpending;
            }

            return tax;
        }
    }
}
