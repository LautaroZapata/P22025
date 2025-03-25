using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CitaMedica
    {
        int id;
        DateTime fecha;
        string cedula;
        string lugar;
        static decimal precioBase;
        bool urgente;

        

        public int Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Lugar { get => lugar; set => lugar = value; }
        public static decimal PrecioBase { get => precioBase; set => precioBase = value; }
        public bool Urgente { get => urgente; set => urgente = value; }

        public CitaMedica ()
        {

        }
        public CitaMedica(int id, DateTime fecha, string cedula, string lugar, decimal precioBase, bool urgente)
        {
            Id = id;
            Fecha = fecha;
            Cedula = cedula;
            Lugar = lugar;
            Urgente = urgente;
            PrecioBase = precioBase;
        }

        public decimal CalcularCosto()
        {
            if (Urgente) return precioBase * 2;
            return precioBase;
        }
        public override string ToString()
        {
            return $"Informacion de la cita: ID Paciente {Id} Cedula: {Cedula} \n Fecha de la consulta: {Fecha} \n Lugar: {Lugar} \n Es urgente: {Urgente} \n Costo de la consulta: ${CalcularCosto()}";
        }
    }
}
