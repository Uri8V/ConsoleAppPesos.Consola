using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPesos.Entidades
{
    public class Dolar
    {
        private static double _cotizacionRespectoDolar;
        private double _cantidad;

        static Dolar()
        {
            _cotizacionRespectoDolar = 1;
        }
        public double GetCantidad() => _cantidad;

        public static double GetCotizacion() => _cotizacionRespectoDolar;

        public Dolar(double cotizacion, double cantidad) : this(cantidad)
        {
            _cotizacionRespectoDolar = cotizacion;
        }
        public Dolar(double cantidad)
        {
            _cantidad = cantidad;
        }

        public static implicit operator double(Dolar v)
        {
            return v.GetCantidad();
        }

        public static implicit operator Dolar(double v)
        {
            return new Dolar(v);
        }

        public static explicit operator Dolar(Peso v)
        {
            return new Dolar(v.GetCantidad()/Peso.GetCotizacion());
        }

        public static Dolar operator +(Dolar d, Dolar d2)
        {
            return new Dolar(d.GetCantidad() + d2.GetCantidad());
        }

        public static Dolar operator +(Peso p, Dolar d)
        {
            return new Dolar(d.GetCantidad() +p.GetCantidad()/ Peso.GetCotizacion());
        }
    }
}
