using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sistema
    {
        private static Sistema instacia;
        private List<Cliente> clientes = new List<Cliente>();


        #region Singleton

        public static Sistema Instancia
        {
            get
            {
                if (instacia == null)
                {
                    instacia = new Sistema();
                }
                return instacia;
            }
        }
        #endregion




        private Sistema()
        {
            AgregarCliente("1111", "Lautaro Zapata");
            AgregarCliente("2222", "Roman Caceres");
            DevolverCliente("1111").AgregarCuenta(Cuenta.Moneda.UYU); //1
            DevolverCliente("1111").AgregarCuenta(Cuenta.Moneda.USD);//2
            DevolverCliente("1111").AgregarCuenta(Cuenta.Moneda.UYU);//3
            DevolverCliente("1111").AgregarCuenta(Cuenta.Moneda.USD);//4
            DevolverCliente("1111").DevolverCuenta(2).Depositar(10000, Cuenta.Moneda.UYU);

        }

        public Cliente? DevolverCliente(string cedula)
        {
            foreach(Cliente unCliente in clientes)
            {
                if (unCliente.Cedula == cedula) return unCliente;
            }
            return null;
        }

        public void ModificarNombre(string cedula, string nuevoNombre)
        {
            DevolverCliente(cedula).Nombre = nuevoNombre;
        }
        public void ExisteCliente(Cliente elCliente)
        {
            if (clientes.Contains(elCliente)) throw new Exception("Cliente existente");
        }
        public void AgregarCliente(string cedula, string nombre)
        {
            try
            {
                Cliente unCliente = new Cliente(cedula, nombre);
                unCliente.Validar();
                ExisteCliente(unCliente);
                clientes.Add(unCliente);
            }

            catch (Exception ex) 
            {
                throw ex;
            }
        }
        public List<Cliente> DevolverClientes()  // Sacamos la lista de clientes para poder usarla en el program
        {
            return clientes;
        }
    }
}
