using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_4
{
    public class Person
    {

        public string Name { get; set; }

        public House House { get; set; }

        public Door Door { get; set; }

        public Person(string name, House house, Door door)
        {
            Name = name;
            House = house;
            Door = door;
        }

        public Person()
        {
        }

        public void Dispay(Apartment home)
        {
            Console.WriteLine($"My name is {Name}, i live in  {home.Surface} m2, my door is {Door.Color}");
        }
    }
}
