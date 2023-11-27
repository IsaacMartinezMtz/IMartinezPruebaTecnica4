using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PuntoUno
{
    public  class Procesos
    {
        public int[] Arreglo { get; set; }
        public string Nombre { get; set; }
        public int Numero { get; }

        

        //For 
        public  void MetodoCiclos()
        {
            Console.WriteLine("Metodo For");
            int[] areglo = { 1,6,8,9,10};

            for (int i = 0; i < areglo.Length; i++)
            {
                int resultado = areglo[i] % 2;
                if(resultado == 0)
                {
                    Console.WriteLine("Par");
                    Console.WriteLine("****");
                }
                else
                {
                    Console.WriteLine("Impar");
                    Console.WriteLine("****");

                }
                

            }
            Console.WriteLine("---------------------");

        }
        //ForEACH
        public void MetodoCiclos(int[] arreglo)
        {
            Console.WriteLine("Metodo foreach");
            foreach (var i in arreglo)
            {
                Console.WriteLine(i);
                Console.WriteLine("****");
            }
            Console.WriteLine("---------------------");

        }
        //While 
        public void MetodoCiclos(string[] nombres)
        {
            Console.WriteLine("Metodo While");
            int contador = 0;
            while (nombres.Length > contador)
            {
                if (nombres[contador] == "Luis")
                {
                    Console.WriteLine("Nombre encontrado en la posicion: " + contador);
                    contador= nombres.Length;
                }
                else
                {
                    Console.WriteLine("Nombre no encontrado en la posicion: " + contador);
                    contador++;
                }
            }
            Console.WriteLine("---------------------");
        }

    }
}
