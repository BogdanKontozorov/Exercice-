using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_4
{
    public class Apartment : House
    {
        public double Surface { get; set; } = 50;

        public Apartment(double surface)
        {
            Surface = surface;
        }

        public Apartment()
        {
        }
    }
}
