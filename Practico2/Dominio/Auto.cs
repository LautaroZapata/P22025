using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Auto
    {
        string? marca;
        string? modelo;
        bool exoneraImpuestos;
        string? matricula;
        int year;

        

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public bool ExoneraImpuestos { get => exoneraImpuestos; set => exoneraImpuestos = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public int Year { get => year; set => year = value; }



        public Auto()
        {

        }
        public Auto(string marca, string modelo, bool exoneraImpuestos, string matricula, int year)
        {
          Marca = marca;
          Modelo = modelo;
          ExoneraImpuestos = exoneraImpuestos;
          Matricula = matricula;
          Year = year;
        }

        private void ValidarMatricula()
        {
            if (matricula.Length != 7) throw new Exception("La matricula ingresada debe ser igual a 7 digitos");
        }

        private decimal CalcularPatente()
        {
            decimal pagoPatente = 0;

            if(year < 2015)
            {
                if (exoneraImpuestos)
                {
                    pagoPatente = 10000;
                }
                else
                {
                    pagoPatente =  12000;

                }
            }
            else if (year > 2015)
            {
                pagoPatente = 17000;

            }
            return pagoPatente;
        }
        public void Validar()
        {
            ValidarMatricula();
            CalcularPatente();
        }

        public override string ToString()
        {
            return $"Su vehiculo es : {Marca} - {Modelo} - {ExoneraImpuestos} - {Matricula} - {Year} \n El valor a pagar de patente es : {CalcularPatente()}";
        }

    }
}
