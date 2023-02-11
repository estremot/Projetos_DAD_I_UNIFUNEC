using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2.Modelo
{
    public class Calculo
    {
        //Contrutor Padrão da Classe Cálculo
        public Calculo(double Nota1, double Nota2) { 
            this.Nota1 = Nota1;
            this.Nota2 = Nota2;
        }

        //Declaração dos Atributos
        public double Nota1 { get; set; }
        public double Nota2 { get; set;}
        public double Media { get; set;}
        public String Situacao { get; set;}



    }
}
