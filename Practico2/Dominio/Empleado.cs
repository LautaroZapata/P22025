using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Empleado
    {
        string? nombre;
        string? apellido;
        DateTime fechaNac;
        decimal valorHora;
        int antiguedad;
        int horasTrabajadas;

        

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public decimal ValorHora { get => valorHora; set => valorHora = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }
        public int HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
        
        public Empleado ()
        {

        }

        public Empleado(string nombre, string apellido, DateTime fechaNac, decimal valorHora, int antiguedad, int horasTrabajadas)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechaNac;
            ValorHora = valorHora;
            Antiguedad = antiguedad;
            HorasTrabajadas = horasTrabajadas;
        }

        public decimal CalcularSalario()
        {
            return valorHora * horasTrabajadas;
        }

        public int CalcularLicencia()
        {
            int dias = 0;
            if(antiguedad <= 5)
            {
                dias = 20;
            } else if(antiguedad >=5 && antiguedad <= 9)
            {
                dias = 21;
            } else if(antiguedad > 10)
            {
                dias = 25;
            }else
            {
                throw new Exception("La cantidad debe ser un valor positivo");
            }
                return dias;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} {Apellido} \n Fecha de nacimiento: {FechaNac} \n Valor hora: {ValorHora} \n Antiguedad {Antiguedad} \n Horas trabajadas {HorasTrabajadas} \n Su salario es: {CalcularSalario()} \n Su licencia es de: {CalcularLicencia()} dias";
        }
    }
}
