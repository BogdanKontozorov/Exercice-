using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_4
{
    public class Door 
    {
       
        public string Color { get; set; }

        public Door(string color)
        {
            Color = color;
        }

        public void Dispay()
        {
            Console.WriteLine($"Je suis une porte, ma couleur est {Color}");
        }
    }
}
