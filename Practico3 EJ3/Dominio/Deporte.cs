using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public enum Grupal
    {
        SI = 1,
        NO = 2,
    }
    public class Deporte
    {
        
        string nombre;
        Grupal grupal;
        int cantProf;

        public Deporte()
        {
        }
        
        public string Nombre { get => nombre; set => nombre = value; }
        public Grupal Grupal { get => grupal; set => grupal = value; }
        public int CantProf { get => cantProf; set => cantProf = value; }

        public Deporte(string nombre, Grupal grupal, int cantProf)
        {
            Nombre = nombre;
            Grupal = grupal;
            CantProf = cantProf;
        }

        public decimal Costo()
        {
            return 1500 * cantProf;
        }

        public override string ToString()
        {
            return $"{Nombre}, Es grupal : {Grupal}, El costo es de ${CantProf}";
        }

    }
}
