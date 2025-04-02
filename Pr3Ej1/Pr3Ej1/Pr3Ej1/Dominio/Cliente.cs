using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        string cedula;
        string nombre;
        List<Cuenta> cuentas = new List<Cuenta>();

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        #region Constructores
        public Cliente()
        {
        }

        public Cliente(string cedula, string nombre)
        {
            Cedula = cedula;
            Nombre = nombre;
        }
        #endregion

        public void Validar()
        {
            ValidarCedula();
            ValidarNombre();    
        }


        private void ValidarCedula()
        {
            if (string.IsNullOrEmpty(cedula)) throw new Exception("La cedula no puede ser vacia.");
        }

        private void ValidarNombre()
        {
            if (string.IsNullOrEmpty(nombre)) throw new Exception("El nombre no puede ser vacio.");
        }

        public override string ToString()
        {
            string salida = $"Cedula:{cedula}  -  Nombre:{nombre}\n"; 
            foreach(Cuenta unaCuenta in cuentas)
            {
                salida += $"{unaCuenta}";
            }
            return salida;

        }
        public override bool Equals(object? obj)
        {
            return (obj is Cliente unCliente && unCliente.Cedula == Cedula);
        }

        public void AgregarCuenta(Cuenta.Moneda laMoneda) // Entramos a la clase cuenta y al ENUM MONEDA para asignar la moneda pasada por parametro
        {
            try
            {
                Cuenta unaCta = new Cuenta(laMoneda);
                unaCta.Validar(); // Solo hacemos la validacion de la cuenta, no se repite porque la definimos autonumerica e incremental.
                cuentas.Add(unaCta);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public Cuenta? DevolverCuenta(int numero)
        {
            foreach(Cuenta unaCuenta in cuentas)
            {
                if(unaCuenta.Numero == numero) return unaCuenta;
            }
            return null;
        }

        public List<Cuenta> FiltrarPorMoneda(Cuenta.Moneda laMoneda)
        {
            List<Cuenta> aux = new List<Cuenta>();
            foreach (Cuenta unaCuenta in cuentas)
            {
                if (unaCuenta.TipoMoneda == laMoneda)
                {
                    aux.Add(unaCuenta);
                }
            }
            return aux;
        }
    }
}
