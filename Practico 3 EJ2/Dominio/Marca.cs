using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        string nombre;
        string pais;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }

        public Marca() { }

        public Marca(string nombre, string pais)
        {
            Nombre = nombre;
            Pais = pais;
        }
        public override string ToString()
        {
            {
                return $"{Nombre},{Pais}";
            }
        }
    }
}
