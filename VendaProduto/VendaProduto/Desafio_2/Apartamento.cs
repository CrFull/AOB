using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaProduto.Desafio_2
{
    public class Apartamento : Propriedade
    {
        private string Tipo;
        private double Area;

        public Apartamento(string proprietario, string numeroFiscal, string tipo, double area) : base(proprietario, numeroFiscal)
        {
            Tipo = tipo;
            Area = area;
        }

        public double GetArea()
        {
            return Area;
        }
        public int CalcularRendaMinima(double area)
        {
            return base.calculaRendaMinima(area);
        }
        public  string getApartamento()
        {
            return base.ToString() + $", Tipo: {Tipo}, Área: {Area} m²";
        }
    }
}
