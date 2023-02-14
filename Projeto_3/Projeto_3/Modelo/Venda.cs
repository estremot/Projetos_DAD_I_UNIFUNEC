using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_3.Modelo
{
    public class Venda
    {
        public String Nome { get; set; }
        public double Total { get; set; }
        public double Quantidade { get; set; }
        public double Valor { get; set; }

        public Venda(String Nome, double Quantidade, double Valor) {
            this.Nome = Nome;   
            this.Quantidade = Quantidade;
            this.Valor = Valor;        
        }

        public Venda() {
            Console.WriteLine("Objeto Vazio");
        }
    }
}
