using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaProduto.Desafio_2
{
    public class Moradia : Propriedade
    {
        private string local;
        private char categoria;

        public Moradia(string proprietario, string numeroFiscal, string Local) : base(proprietario, numeroFiscal)
        {
            local = local;
            DeterminarCategoria();
        }

        private void DeterminarCategoria()
        {
            switch (local)
            {
                case "Lisboa":
                    categoria = 'A';
                    break;
                case "Porto":
                    categoria = 'B';
                    break;
                case "Coimbra":
                    categoria = 'C';
                    break;
                case "Braga":
                    categoria = 'D';
                    break;
                default:
                    categoria = 'D';
                    break;
            }
        }

        public int CalcularRendaMinima()
        {
            int renda;

            switch (categoria)
            {
                case 'A':
                case 'B':
                    renda = 1000;
                    break;
                case 'C':
                    renda = 600;
                    break;
                case 'D':
                    renda = 450;
                    break;
                default:
                    renda = 450;
                    break;
            }

            return renda;
        }

        public string getMoradia()
        {
            return base.ToString() + $", Local: {local}, Categoria: {categoria}";
        }


    }
}
