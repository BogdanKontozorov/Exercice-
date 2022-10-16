using Exercice_4;

class Program
{



    public static void Main(string[] agrs)
    {



        Apartment apartment = new Apartment();

        Door door = new Door("Blue");

        Person person = new Person("Kenny", apartment, door ) ;



        person.Dispay(apartment);
    }
}