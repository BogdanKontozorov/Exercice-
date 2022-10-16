using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2.Class
{
    public class Test
    {

        public static void Main(string[] agrs)
        {
            Person personne = new Person();

            Student student = new Student();

            Teacher teacher = new Teacher();

            //AGE
            student.SetAge(15);
            teacher.SetAge(40);
            //int s = 15;

            //Hello de person
            personne.Hello();

            Console.WriteLine("-------------------------------");


            //Hello avec explication de age
            student.Hello();
            student.GoToClasses();
            student.DisplayAge(15);//J'ai pas compris comment mettre ici le SetAge de la ligne 21 du coup j'improvise xD
            Console.WriteLine("-------------------------------");


            teacher.Hello();
            teacher.Explain();
            Console.WriteLine("-------------------------------");












        }
    }
}
