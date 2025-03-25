using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Utils
    {
        static public void Titulo(string titulo)
        {
            Console.Write($"{titulo}: ");
        }

        static public int PedirNumero(string mensaje = "Ingrese número.")
        {
            int numero;
            bool exito;
            do
            {
                Titulo(mensaje);
                exito = int.TryParse(Console.ReadLine(), out numero);
                if (!exito)
                {
                    MensajeError("Debe escribir solo numeros.");
                }
            } while (!exito);

            return numero;
        }

        static public decimal PedirImporte(string mensaje = "Ingrese importe.")
        {
            decimal importe;
            bool exito;
            do
            {
                Titulo(mensaje);
                exito = decimal.TryParse(Console.ReadLine(), out importe);
                if (!exito)
                {
                    MensajeError("Debe escribir solo numeros.");
                }
            } while (!exito);

            return importe;
        }

        static public string PedirLetras(string mensaje = "Ingrese el nombre.")
        {
            Titulo(mensaje);
            string texto = Console.ReadLine();
            return texto;
        }


        static public void MensajeError(string mensaje)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"---Error----> {mensaje}");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
