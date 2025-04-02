using Dominio;

namespace Practico_3_EJ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto(new Marca("BMW","Alemania"),"X6",2008,Tipo.NUEVO,"ABC1234", new DateTime(2023,01,01)); 
            Console.WriteLine(auto.ToString());
            Console.WriteLine(auto.ProxService());


        }
    }
}
