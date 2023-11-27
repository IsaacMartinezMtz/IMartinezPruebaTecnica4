using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PuntoUno
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] areglo = { 1, 2, 9, 10, 11, 78, 2 };
            string[] nombres = {"Marcos", "Antonio", "Luis", "Juan", "Martin", "Pedro" };
            Procesos obj = new Procesos();
            //For
            obj.MetodoCiclos();
            obj.MetodoCiclos(areglo);
            obj.MetodoCiclos(nombres);
        }
    }
}
