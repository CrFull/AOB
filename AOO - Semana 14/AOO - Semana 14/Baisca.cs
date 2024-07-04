using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOO___Semana_14
{
    public class Baisca
    {
        private string nomeCliente;
        private string tipoDeQuarto;

        public Baisca(string nomeCliente, string tipoDeQuarto)
        {
            this.nomeCliente = nomeCliente;
            this.tipoDeQuarto = tipoDeQuarto;
        }

        public override String ToString()
        {
            return nomeCliente + "---" + tipoDeQuarto + "---";
        }
    }
}
