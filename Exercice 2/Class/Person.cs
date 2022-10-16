using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2.Class
{
    public  class Person
    {
        public int Age { get; set; }

        public Person(int age)
        {
            Age = age;
        }

        public Person()
        {
        }


        public void SetAge(int age)
        {
            Age = age;
        }



        public void Hello()
        {
            Console.WriteLine("Hello");
        }
    }
}
