using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Mascota
    {
        string nombre;
        string raza;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Raza { get => raza; set => raza = value; }

        public Mascota() { }
        public Mascota(string nombre, string raza)
        {
            Nombre = nombre;
            Raza = raza;
        }


        public void Validar()
        {
            ValidarNombre();
            ValidarRaza();
        }

        private void ValidarNombre()
        {
            if (string.IsNullOrEmpty(nombre)) throw new Exception("Nombre vacio");
        }

        private void ValidarRaza()
        {
            if (string.IsNullOrEmpty(raza)) throw new Exception("Raza vacia");
        }

        public override string ToString()
        {
            return $"{nombre}\t\t {raza}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Mascota mascota && mascota.Raza == raza && mascota.Nombre == nombre;    
        }

        
    }
}

    
