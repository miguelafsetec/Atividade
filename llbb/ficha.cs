using Microsoft.SqlServer.Server;
using Projetinho;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llbb
{
    internal class ficha:paciente
    {
        public int opcao;


        public override void cadastro()
        {
            do
            {
            
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Cadastrar paciente");
                Console.WriteLine("2. Inserir paciente na fila");
                Console.WriteLine("3. Listar fila de pacientes");
                Console.WriteLine("4. Incluir paciente prioritário");
                Console.WriteLine("5. Atender paciente");
                Console.WriteLine("q. Sair");
                opcao =int.Parse ( Console.ReadLine());
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        base.cadastro();
                      
                        break;
                    case '2':
                       
                        break;
                    case '3':
                        
                        break;
                    case '4':
                        
                        break;
                    case '5':
                        
                        break;
                }
            } while (opcao != 'q');
        }

    }
    }

