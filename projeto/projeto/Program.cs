using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoa = new Pessoa[100];
            
            for(int i = 0; i < 2; i++)
            {

                Console.WriteLine("Pessoa {0}",i);
                pessoa[i] = new Pessoa();
                pessoa[i].cadastro();
                pessoa[i].prioridade=Console.ReadLine();
            }
            for (int i = 0; i < 2; i++)
            {
                if (pessoa[i].prioridade == "vermelho")
                {
                    Console.WriteLine($"nome: {pessoa[i].nome}");
                }
            }
            Console.ReadKey();
        }
    }
}
