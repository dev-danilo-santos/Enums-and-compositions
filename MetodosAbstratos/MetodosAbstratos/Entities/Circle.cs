using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodosAbstratos.Enums;
namespace MetodosAbstratos.Entities
{
    class Circle : Shape
    {
        public double Pi { get; set; } = Math.PI;
        public double Raio { get; set; }

        public Circle(double raio, Color color) : base(color)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Pi * (Math.Pow(Raio, 2));
        }
    }
}
