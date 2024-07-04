using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaProduto
{
    public class VendasProdB : Vendas
    {
        private double valorTrans;

        public VendasProdB(double valorTrans){
            this.valorTrans = valorTrans;
            setVenda(valorTrans);
        }

        private void SetValorTrans(double valor)
        {
             this.valorTrans += valor;
        }
    }
}
