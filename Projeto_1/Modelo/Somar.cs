using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_1.Modelo
{
    public class Somar
    {
        private int Valor1 { get; set; }
        private int Valor2 { get; set; }
        private int Total { get; set; }

        public int Calcular()
        {
            this.Total = this.Valor1 + this.Valor2;
            return this.Total;
        }

        public Somar(int Valor1, int Valor2)
        {
            this.Valor1 = Valor1;
            this.Valor2 = Valor2;
        }

      
    }
}
