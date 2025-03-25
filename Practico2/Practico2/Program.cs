using Dominio;

namespace Practico2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Auto auto = new Auto("Ford", "Ranger", true, "SAB1234", 2014);
                auto.Validar();
                Console.WriteLine(auto.ToString());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            try
            {
                Empleado empleado = new Empleado("Lautaro", "Zapata", new DateTime(2000,12,13), 1000, 5, 100);
                Console.WriteLine(empleado.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            CitaMedica cita = new CitaMedica(1, new DateTime(2025,3,20), "53213634", "Hospital", 3000, true);
            Console.Write(cita.ToString());

            try
            {
                Cuenta cuenta = new Cuenta("Lautaro", 5000, "CC - Cuenta Corriente", "$", 51000, 123456789);
                Console.WriteLine(cuenta.ToString());
            }
            catch (Exception)
            {

                Console.Write(.ToString());

            }

        }
    }
}
