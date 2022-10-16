using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_4
{
    public class House
    {
        public double _surface;

        public double Surface 
        { 
            get
            {
                return _surface;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("La largeur ne peut être négative");
                }
                else
                {
                    _surface = value;
                }
            }
                }
        public House(double surface)
        {
            _surface = surface;
        }

        public House()
        {
        }

        public void Display()
        {
            Console.WriteLine($"Je suis une maison, ma surface est de {_surface} m2.");
        }


        public Door GetDoor(Door d)
        {
            return d;
        }
    }


}
