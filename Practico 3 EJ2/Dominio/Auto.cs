using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public enum Tipo
    {
        NUEVO = 1,
        USADO = 2
    }
    public class Auto
    {
        Marca marca;
        string modelo;
        int year;
        Tipo tipo;
        string matricula;
        DateTime ultService;

        public Marca Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Year { get => year; set => year = value; }
        public Tipo Tipo { get => tipo; set => tipo = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public DateTime UltService { get => ultService; set => ultService = value; }

        public Auto()
        {
        }

        public Auto(Marca marca, string modelo, int year, Tipo tipo, string matricula, DateTime ultService)
        {
            Marca = marca;
            Modelo = modelo;
            Year = year;
            Tipo = tipo;
            Matricula = matricula;
            UltService = ultService;
        }


        public DateTime ProxService()
        {
            return ultService.AddYears(1); // Le agrega un año a la fecha actual.
        }

        public override string ToString()
        {
            return $"{Marca},{Modelo},{Year},{Tipo},{Matricula},{UltService}";
        }
    }
}
