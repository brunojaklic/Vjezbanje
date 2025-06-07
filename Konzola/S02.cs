
namespace Konzola
{
    internal class S02
    {
        public static void Izvedi()
        {
            Console.Write("Unesi duzinu prostorije: ");

            double duzina = double.Parse(Console.ReadLine());

            Console.Write("Unesi sirinu prostorije: ");

            double sirina = double.Parse(Console.ReadLine());

            double povrsina = duzina * sirina;

            Console.WriteLine("Povrsina je {0} m2", povrsina);
        }
    }
}
