using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_hospital
{
    internal class Ficha:Paciente
    {
        public int opcao;

        public override void cadastro()
        {
            Fila fila = new Fila();
            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Cadastrar paciente");
                Console.WriteLine("2. Inserir paciente na fila");
                Console.WriteLine("3. Listar fila de pacientes");
                Console.WriteLine("4. Incluir paciente prioritário");
                Console.WriteLine("5. Atender paciente");
                Console.WriteLine("q. Sair");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        base.cadastro();

                        break;
                    case 2:

                        Console.WriteLine("Deseja adicionar o: {0} na fila? sim [1] não [2]", this.nome);
                        int y = int.Parse(Console.ReadLine());
                        if(y == 1)
                        {
                            fila.incluirFila(this.nome, this.prioridade);
                            Console.WriteLine("Inserido com sucesso!\n");

                        }
                        else { }

                        break;
                    case 3:
                        fila.mostrarFilaAtual();

                        break;
                    case 4:
                        Console.WriteLine("Deseja adicionar o: {0} na fila? sim [1] não [2]", this.nome);
                        int t = int.Parse(Console.ReadLine());
                        if (t == 1)
                        {
                            fila.incluirFila(this.nome, this.prioridade);
                            Console.WriteLine("Inserido com sucesso!\n");

                        }
                        else { }

                        break;
                    case 5:
                        Console.WriteLine("Deseja atender o: {0} na fila? sim [1] não [2]", fila[1]);
                        int b = int.Parse(Console.ReadLine());
                        if (b == 1)
                        {
                            fila.atendeFila();
                            Console.w

                        }
                        else { }


                        break;
                }
            } while (opcao != 'q');
        }
    }
}
