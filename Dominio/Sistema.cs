using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sistema
    {
        private static Sistema instancia;
        public static Sistema Instancia
        {
            get
            {
                if(instancia == null) instancia = new Sistema();
                return instancia;
            }
        }

        private Sistema()
        {


        }
    }
}
