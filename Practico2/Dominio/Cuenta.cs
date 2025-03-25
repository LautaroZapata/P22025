using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cuenta
    {
        string? titular;
        decimal saldoActual;
        string? tipoCuenta;
        string? moneda;
        decimal monto;
        int numCuenta;

        public string? Titular { get => titular; set => titular = value; }
        public decimal SaldoActual { get => saldoActual; set => saldoActual = value; }
        public string? TipoCuenta { get => tipoCuenta; set => tipoCuenta = value; }
        public string? Moneda { get => moneda; set => moneda = value; }
        public decimal Monto { get => monto; set => monto = value; }

        public int NumCuenta { get => numCuenta; set => numCuenta = value; }

        public Cuenta ()
        {

        }
        public Cuenta(string? titular, decimal saldoActual, string? tipoCuenta, string? moneda, decimal monto, int numCuenta)
        {
            Titular = titular;
            SaldoActual = saldoActual;
            TipoCuenta = tipoCuenta;
            Moneda = moneda;
            Monto = monto;
            NumCuenta = numCuenta;
        }

        private bool ValidarMoneda()
        {
            if (moneda == "$" || moneda == "USD")
            {
                return true;
            } else
            {
                throw new Exception("La moneda solo puede ser '$' o 'USD'");
            }
        }
        private string ValidarDeposito()
        {

            if(ValidarMoneda() &&  monto > 50000 || ValidarMoneda() && monto > 1000)
            {
                throw new Exception("El deposito debe ser menor a $50000 o USD 1000");
            }else
            {
                return "El deposito fue exitoso";

            }

        }
    }
}
