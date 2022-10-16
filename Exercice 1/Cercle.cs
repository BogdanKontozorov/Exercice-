using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    public class Cercle
    {

        public double Rayon { get; set; }

        public Cercle(double rayon)
        {
            Rayon = rayon;
        }


        public double GetArea()
        {
            return 3.1415926535 * (Rayon * Rayon);
        }

        public double GetPerimeter()
        {
            return 2 * 3.1415926535 * Rayon;
        }
    }

}
