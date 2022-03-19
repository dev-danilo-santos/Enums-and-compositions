using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExercicesFix.Entities
{
    abstract class Payer
    {
        public string name { get; set; }
        public double AnnualIncome { get; private set; }

        protected Payer(string name, double annualIncome)
        {
            this.name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double TaxAmount();
    }
}
