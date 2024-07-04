using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOO___Semana_14
{
    public class ClienteFreq: Cliente
    {
        private bool servicoDeQuarto;

        public ClienteFreq(string nomeCliente, string tipoDeQuarto, string andar,bool servicoDeQuarto) :base(nomeCliente, tipoDeQuarto, andar)
        {
            this.servicoDeQuarto = servicoDeQuarto;
        }

        public override String ToString()
        {
            return base.ToString() +" " + servicoDeQuarto.ToString();
        }
    }
}
