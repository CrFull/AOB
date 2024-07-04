using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOO___Semana_14
{
    public class Cliente:Baisca
    {
        private string andar;

        public Cliente(string nomeCliente, string tipoDeQuarto, string andar):base(nomeCliente, tipoDeQuarto)
        {
            this.andar = andar;
        }

        public override String ToString()
        {
            return base.ToString() + " " + andar;
        }
    }
}
