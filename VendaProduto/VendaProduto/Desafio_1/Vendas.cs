using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaProduto
{
   public class Vendas
    {
        private static double valorTotalVendasProduto;

        public static void setVenda(double valor)
        {
            valorTotalVendasProduto += valor;
        }

        public static void getVenda()
        {
            Console.WriteLine(valorTotalVendasProduto);
        }
       


    }
}
