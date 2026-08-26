using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineCidadeAtv
{
    internal class Class1
    {
        string nomeCliente { get; set; }

        int qntIngressos { get; set; }

        string cupomDesconto { get; set; }

        int idadeCliente { get; set; }

        public double custoBruto { get; set; }

        public double custoFinal { get; set; }

        //Cadastrar cliente
        public void CadastrarCliente()
        { 
            Console.Write("Digite o nome do cliente: ");
            nomeCliente = Console.ReadLine();

            Console.Write("Digite o cupom de desconto: ");
            cupomDesconto = Console.ReadLine();

            Console.Write("Digite a quantidade de ingressos: ");
            qntIngressos = int.Parse(Console.ReadLine());

            Console.Write("Digite a idade do cliente: ");
            idadeCliente = int.Parse(Console.ReadLine());

        } 

        //Adicionando regras de negócio 

        public void CalcularCustoBruto()
        {
            custoBruto = 5 + (25 * qntIngressos);
        }

        public void CalcularDesconto()
        {
            if (cupomDesconto == "CINEMA10")
            {
                custoFinal = custoBruto - (custoBruto * 0.10);
            }
               
        }

        //Exibindo valores finais

        public void ExibirValores()
        {
            Console.WriteLine($"Nome do cliente: {nomeCliente}");
            Console.WriteLine($"")
        
        
        
        }

    }

}
