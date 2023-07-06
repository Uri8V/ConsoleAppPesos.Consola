using ConsoleAppPesos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPesos.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Peso p = new Peso(5000);
            double d = p;
            Peso peso = d;//implicto

            Dolar dolar = new Dolar(100);
            Peso peso2 = (Peso)dolar;

            
        }
    }
}
