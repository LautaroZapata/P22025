using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        int id;
        static int ultimoId;
        string cedula;
        string nombre;
        List<Mascota> mascotas = new List<Mascota>();

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula { get => cedula; set => cedula = value; }

        public Persona()
        {
            Id = ultimoId++;
        }
        public Persona(string nombre, string cedula)
        {
            Id = ++ultimoId;
            Nombre = nombre;
            Cedula = cedula;
        }


        public override string ToString()
        {
            return $"{id} {nombre} {cedula}";
        }
        public override bool Equals(object? obj)
        {
            return obj is Persona persona && this.cedula == persona.cedula; // Si es una Persona la guarda en persona y si es verdadero compara la cedula de la persona con la del parametro
        }

        private void ExisteMascota(Mascota unaMascota)
        {
            if (mascotas.Contains(unaMascota)) throw new Exception("Mascota ya existe");
            // Contains usa el Equals de la clase (Mascota) de los elementos de la lista.
        }
        public void AgregarMascota(Mascota unaMascota)
        {
            try
            {
                unaMascota.Validar();
                ExisteMascota (unaMascota);
                mascotas.Add(unaMascota);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public List<Mascota> FiltrarMascotas(string nombreRaza)
        {
            List<Mascota> aux = new List<Mascota>();
            foreach (Mascota unaMascota in mascotas)
            {
                if(unaMascota.Raza == nombreRaza) aux.Add(unaMascota);
                
            }
            return aux;
        }

    }
}
