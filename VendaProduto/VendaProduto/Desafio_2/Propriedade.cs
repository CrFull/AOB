using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace VendaProduto.Desafio_2
{
     public class Propriedade
    {
        private string proprietario;
        private string numeroFiscalProprietario;

        public Propriedade(string nome, string numero) {
            proprietario = nome;
            numeroFiscalProprietario = numero;
        }

        protected int calculaRendaMinima(double area)
        {
            double P1 = 02;
            double P2 = 0.3;
            double renda;
            if (area < 50)
                renda = 100;
            else if (area < 100)
                renda = 100 + P1 * area;
            else
                renda = 100 + P2 * area;

            return (int)renda;

        }

        private string getProprietario()
        {
            return $"Nome: {proprietario}, Numero Fiscal: {numeroFiscalProprietario}";
        }
    }
}
