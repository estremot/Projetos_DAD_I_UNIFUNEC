using Projeto_3.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_3.Controle
{
    public class C_Venda
    {
        public Venda calculaVenda(Venda obj)
        {
            double qa = obj.Quantidade;
            double va = obj.Valor;

            obj.Total = qa * va;

            return obj;
        }
    }
}
