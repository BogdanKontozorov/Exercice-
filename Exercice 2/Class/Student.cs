using System.Net.Cache;

namespace Exercice_2.Class
{
    public class Student : Person
    {

        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class.");
        }

        public void DisplayAge(int age)
        {
            Console.WriteLine("My age is : " + age + " years old.");
        }

    
    }
}
