using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaProduto
{
    public class VendasProdA:Vendas
    {
        private int quant;
        private double pu;

        public VendasProdA(double valor)
        {
            setVenda(valor);
        }
    }
}
