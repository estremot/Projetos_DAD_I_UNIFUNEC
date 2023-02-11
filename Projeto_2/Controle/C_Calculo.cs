using Projeto_2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2.Controle
{
    public class C_Calculo
    {
        public Calculo calcular(Calculo obj)
        {
            obj.Media = (obj.Nota1 + obj.Nota2) / 2;

            if(obj.Media >= 7)
            {
                obj.Situacao = "APROVADO";
            }
            else
            {
                obj.Situacao = "REPROVADO";
            }

            return obj;
        }
    }
}
