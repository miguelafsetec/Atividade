using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_hospital
{
    internal class Ficha : Paciente
    {
        public string opcao;

        public override void cadastro()
        {
            Fila filaVetor = new Fila();
            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das opções abaixo");
                Console.WriteLine("1. Cadastrar o paciente");
                Console.WriteLine("2. colocar paciente na fila");
                Console.WriteLine("3. Listar os pacientes que estão na fila");
                Console.WriteLine("4. Incluir os pacientes prioritários");
                Console.WriteLine("5. Atender os pacientes ");
                Console.WriteLine("Digite q para sair ");
                opcao = Console.ReadLine();
                Console.WriteLine();

                switch (opcao)
                {
                    case "1":
                        base.cadastro();

                        break;
                    case "2":

                        Console.WriteLine("Deseja adicionar o: {0} na fila? sim [1] não [2]", this.nome);
                        int y = int.Parse(Console.ReadLine());
                        if (y == 1)
                        {
                            filaVetor.incluirFila(this.nome, this.prioridade);
                            Console.WriteLine("Inserido com sucesso!\n");

                        }
                        else { }

                        break;
                    case "3":
                        filaVetor.mostrarFilaAtual();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Deseja adicionar o: {0} na fila? sim [1] não [2]", this.nome);
                        int t = int.Parse(Console.ReadLine());
                        if (t == 1)
                        {
                            filaVetor.incluirFila(this.nome, this.prioridade);
                            Console.WriteLine("Inserido com sucesso!\n");

                        }
                        else { }

                        break;
                    case "5":
                        Console.WriteLine("Deseja atender o: {0} na fila? sim [1] não [2]", filaVetor.fila[0]);
                        int b = int.Parse(Console.ReadLine());
                        if (b == 1)
                        {
                            filaVetor.atendeFila();
                            Console.WriteLine("{0} Atendido com sucesso", filaVetor.fila[0]);


                        }
                        else { }


                        break;
                }
            } while (opcao != "q");
        }
    }
}
