using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_4.Modelo
{
    public class Calculo
    {
        public int Metros { get; set; } 
        public int Centimetros { get; set;}

        public Calculo(int Metros) { 
            this.Metros = Metros;
        }
    }
}
