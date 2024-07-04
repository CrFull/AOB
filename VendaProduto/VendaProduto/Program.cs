using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaProduto.Desafio_2;

namespace VendaProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desafio 1
            //    VendasProdA prod = new VendasProdA(100);
            //    VendasProdB prod2 = new VendasProdB(200);
            //    VendasProdA prod3 = new VendasProdA(300);
            //    VendasProdB prod4 = new VendasProdB(905);

            //    Vendas.getVenda();
            Moradia moradia = new Moradia("João", "123", "Porto");
            Apartamento apartamento = new Apartamento("Maria", "456", "T2", 120);

            int rendaMoradia = moradia.CalcularRendaMinima();
            int rendaApartamento = apartamento.CalcularRendaMinima(apartamento.GetArea());

            Console.WriteLine("Renda mínima para a moradia no Porto: " + rendaMoradia);
            Console.WriteLine("Renda mínima para o apartamento T2 com 120m²: " + rendaApartamento);
            Console.ReadKey();

        }
    }
}
