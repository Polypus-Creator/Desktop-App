using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App
{
    class PriceCard
    {
        private string elemento = "Price Card";
        private string[,] contenido = new string[3, 4];

        public PriceCard(string elemento, string[,] contenido)
        {
            Elemento = elemento;
            Contenido = contenido;
        }

        public string Elemento { get => elemento; set => elemento = value; }
        public string[,] Contenido { get => contenido; set => contenido = value; }
    }
}
