using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPesos.Entidades
{
    public class Peso
    {
        private static double _cotizacionRespectoDolar;
        private double _cantidad;

        static Peso()
        {
            _cotizacionRespectoDolar = 102.65;
        }
        public double GetCantidad() => _cantidad;

        public static double GetCotizacion() => _cotizacionRespectoDolar;

        public Peso(double cotizacion, double cantidad):this (cantidad)
        {
            _cotizacionRespectoDolar = cotizacion;
        }
        public Peso(double cantidad)
        {
            _cantidad= cantidad;
        }

        public static implicit operator double(Peso v)
        {
            return v.GetCantidad();
        }

        public static implicit operator Peso(double v)
        {
            return new Peso(v);
        }

        public static explicit operator Peso(Dolar v)
        {
            return new Peso(v.GetCantidad() * Peso.GetCotizacion());
        }

        public static bool operator ==(Peso p, Peso p2)
        {
            return p._cantidad==p2._cantidad;
        }
        public static bool operator!=(Peso p, Peso p2)
        {
            return !(p==p2);
        }
        public static bool operator ==(Peso p, Dolar d)
        {
            return p.GetCantidad() == d.GetCantidad() * Peso.GetCotizacion();
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !( p == d);
        }

        public static Peso operator +(Peso p, Peso p2)
        {
            return new Peso(p.GetCantidad() + p2.GetCantidad());
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad()+d.GetCantidad()*Peso.GetCotizacion());
        }
    }
}
