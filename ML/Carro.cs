using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Carro
    {
        public int IdCarro { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }
        public string Color { get; set; }
        public string PaisOrigen { get; set; }
        public string Placa { get; set; }
        public List<object> Carros { get; set; }
    }
}
