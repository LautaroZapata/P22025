using Dominio;
namespace Practico3_EJ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socio socio = new Socio("Lautaro","Zapata",new DateTime(2007,12,13));
            Deporte futbol = new Deporte("Futbol", Grupal.SI, 10);

            Console.WriteLine(socio);
            Console.WriteLine(futbol);
            Console.WriteLine(socio.MayorEdad());
            Console.WriteLine(futbol.Costo());
        }
    }
}
