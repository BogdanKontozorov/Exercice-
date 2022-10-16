using Exercice_1;

class Program
{
    public static void Main(string[] agrs)
    {
        Cercle c = new Cercle(6.25);

        Console.WriteLine(c.GetArea());
        Console.WriteLine(c.GetPerimeter());
    }
}