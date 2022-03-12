using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityOne02.Entities
{
    class HourContract
    {
        public DateTime Date { get; private set; }
        public double ValuePerhour  { get; private set; }
        public int Hours { get; private set; }
        internal int  id { get; set; }

        public double TotalValue()
        {
          return Hours * ValuePerhour; 
        }

        public HourContract(DateTime date, double valuePerhour, int hours)
        {
            Date = date;
            ValuePerhour = valuePerhour;
            Hours = hours;
        }
    }
}
