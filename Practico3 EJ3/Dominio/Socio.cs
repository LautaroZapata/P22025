using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Socio
    {
        string nombre;
        string apellido;
        DateTime fechaNac;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }

        public Socio()
        {
        }
        public Socio(string nombre, string apellido, DateTime fechaNac)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNac = fechaNac;
        }

        public string MayorEdad()
        {
            int year = DateTime.Now.Year - FechaNac.Year;
            if (year >= 18) return "Es mayor de edad";
            else return "Es menor de edad";
            
        }

        public override string ToString()
        {
            return $"{Nombre},{Apellido},{FechaNac}"; 
        }
    }
}
