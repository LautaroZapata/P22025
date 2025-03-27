using Dominio;
namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Lautaro Zapata", "50506264");
            Persona persona2 = new Persona("Lautaro Zapata", "50506264");
            if (persona1.Equals(persona2)) 
            {
                Console.WriteLine("Son la misma");
            }
            else
            {
                Console.WriteLine("Son diferentes");
            }
            persona1.AgregarMascota(new Mascota("Milo", "Bulldog Ingles"));
        }
    }
}
