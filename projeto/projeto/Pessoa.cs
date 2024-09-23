using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace projeto
{
    internal class Pessoa
    {
        public string nome;
        public string CPF;
        public string Endereço;
        public int idade;
        public int Ano_de_Nascimento;
        public int dia;
        public int mes;
        public string email;
        public string prioridade;
        public string telefone;



        public virtual void  cadastro()
        {
            Console.WriteLine("Digite seu nome Completo");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu cpf");
            CPF = Console.ReadLine();
            Console.WriteLine("digite seu Endereço");
            Endereço = Console.ReadLine();
            Console.WriteLine("Qual sua idade");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o ano do seu ");
            idade = int.Parse(Console.ReadLine());



        }



    }
}
