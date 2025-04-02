using Dominio;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sistema unS = Sistema.Instancia;
            List<Cliente> clientes = unS.DevolverClientes();
            unS.ModificarNombre("1111", "Maldito Roman");
            foreach(Cliente unCliente in clientes)
            {
                Console.WriteLine(unCliente);
            }
            Cuenta.Moneda laMonedaLiedaDeConsola = LeerMoneda();
            Console.WriteLine(laMonedaLiedaDeConsola);

            static Cuenta.Moneda LeerMoneda()
            {
                Cuenta.Moneda monedaLeida;
                string strMoneda;
                bool exito;
                do
                {
                    foreach (string nombre in Enum.GetNames(typeof(Cuenta.Moneda)))
                    {
                        Console.WriteLine(nombre);
                    }
                    Console.Write("Ingrese Moneda: ");
                    
                    strMoneda = Console.ReadLine();
                    exito = Enum.TryParse<Cuenta.Moneda>(strMoneda, out monedaLeida); // EL OUT GUARDA EL VALOR LEIDO EN PANTALLA.
                    // LUEGO STRMONEDA SE PARSEA Y COMPRUEBA SI ES IGUAL AL VALOR DEL ENUM Y DEVUELVE EL BOOLEANO
                }
                while(!exito); // MIENTRAS QUE NO SEA EXITOSO SIGUE PREGUNTANDO
                return monedaLeida;
            }
        }
    }
}
