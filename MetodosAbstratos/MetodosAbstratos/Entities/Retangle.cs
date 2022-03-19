using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodosAbstratos.Enums;
namespace MetodosAbstratos.Entities
{
    class Retangle : Shape
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Retangle(double Base, double altura, Color color ) : base(color)
        {
            this.Base = Base;
            Altura = altura;
        }

        public override double Area()
        {
            return Base * Altura;    
        }
    }
}
