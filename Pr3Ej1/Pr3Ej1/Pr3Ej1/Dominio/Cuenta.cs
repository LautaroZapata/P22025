using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cuenta
    {
        public enum Moneda { UYU = 858, USD = 840};
        Moneda tipoMoneda;
        int numero;
        static int ultimoNumero;
        decimal saldo;
        static decimal tc = 44.50M; // CON LA M INDICAMOS QUE ES DECIMAL
        int contadorDeDepositos; // queda para desarrollar.

        public Moneda TipoMoneda { get => tipoMoneda; set => tipoMoneda = value; }
        public int Numero { get => numero; set => numero = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }
        public static decimal Tc { get => tc; set => tc = value; }

        public Cuenta()
        {
        }

        public Cuenta(Moneda tipoMoneda)
        {
            TipoMoneda = tipoMoneda;
            Numero = ++ultimoNumero; // LO HACEMOS AUTONUMERICO. PRIMERO CALCULA EL NUEVO VALOR Y LUEGO LO ASIGNA
        }

        public void Validar()
        {
            ValidarNroCuenta();
        }
        private void ValidarNroCuenta()
        {
            if (numero == 0) throw new Exception("La cuenta no puede ser cero.");
        }

        public void Retirar(decimal monto )
        {
            if (saldo < monto) throw new Exception("Saldo insuficiente.");
            saldo = saldo - monto;
        }

        public void Depositar(decimal monto, Moneda moneda)
        {
            if (tipoMoneda == moneda) saldo += monto;
            else
            {
                if(tipoMoneda == Moneda.USD)
                {
                    saldo += monto / tc;
                }
                else
                {
                    saldo += monto * tc;
                }
            }
        }

        public override string ToString()
        {
            return  $" Cuenta:{numero} \n Moneda:{TipoMoneda}\n Saldo: {saldo.ToString("0.00")}\n"; 
        }


    }
}
