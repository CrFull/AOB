using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOO___Semana_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite o limite de reservas");
            //int contaClientes;
            //string nomeCliente, tipoDeQuarto, andar;
            //bool servicoQ;
            //int limiteReservas = int.Parse(Console.ReadLine());

            //ClienteFreq cliente = new ClienteFreq(nomeCliente, tipoDeQuarto, andar, servicoQ);

            List <ClienteFreq> 
            ClienteFreq cliente = new ClienteFreq("João Victor", "Suíte","2°",false);
            ClienteFreq cliente1 = new ClienteFreq("Maria Antunes", "Suite", "3°", true);
            ClienteFreq cliente2 = new ClienteFreq("Felipe Guimarães", "Premium", "6°", true);
            ClienteFreq cliente3 = new ClienteFreq("Rayssa", "Duplo", "10°", false);
            ClienteFreq[] todosOsClientes = new ClienteFreq[4];
            pessoas.Add(new Pessoa(50, "Macoratti"));

            Console.WriteLine(todosOsClientes.ToString());

            Console.ReadKey();
        }

    }
}
