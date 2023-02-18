using Projeto_4.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_4.Controle
{
    public class C_Calculo
    {
        public Calculo calcular(Calculo obj)
        {
            obj.Centimetros = obj.Metros * 100;
            return obj;
        }
    }
}
