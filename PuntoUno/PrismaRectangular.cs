using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoUno
{
    public class PrismaRectangular
    {
        public double Altura { get; set; }
        public double Longitud { get; set; }
        public double Ancho { get; set; }

        public PrismaRectangular(double altura, double longitud, double ancho)
        {
            Altura = altura;
            Longitud = longitud;
            Ancho = ancho;
        }
        public double GetVolumen()
        {
            return Altura * Longitud * Ancho;
        }

        public static PrismaRectangular Sumar(PrismaRectangular prisma1, PrismaRectangular prisma2)
        {
            double nuevaAltura = prisma1.Altura + prisma2.Altura;
            double nuevaLongitud = prisma1.Longitud + prisma2.Longitud;
            double nuevoAncho = prisma1.Ancho + prisma2.Ancho;

            return new PrismaRectangular(nuevaAltura, nuevaLongitud, nuevoAncho);
        }
    }
}
