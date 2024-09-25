using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace project_hospital
{
    internal class Paciente
    {
        public string nome;
        public string CPF;
        public string Endereço;
        public int idade;
        public int Ano_de_Nascimento;
        public int dia;
        public int mes;
        public string email;
        public bool prioridade;
        public string telefone;
        public int connt;

        public virtual string cadastroNome()
        {
            Console.WriteLine("Digite seu nome Completo");
            this.nome = Console.ReadLine();
            return this.nome;
        }

        public virtual bool cadastroPrioridade()
        {
            Console.WriteLine("Você tem alguma deficiência? sim [y] não [n]");
            string x = Console.ReadLine();

            if (x == "y")
            {
                this.prioridade = true;
            }
            else
            {
                this.prioridade = false;
            }
            return this.prioridade;
        }


        public virtual void cadastro()
        {

            cadastroNome();

            do
            {
                Console.WriteLine("Digite seu CPF, apenas Numeros");
                CPF = Console.ReadLine();
                if (!Validação_do_cpf(CPF))
                {
                    Console.WriteLine("ERRO!!! Digite novamente.");
                }
            } while (!Validação_do_cpf(CPF));

            Console.WriteLine("Digite seu Endereço");
            Endereço = Console.ReadLine();

            do
            {
                Console.WriteLine("Qual o ano você nasceu");
                Ano_de_Nascimento = int.Parse(Console.ReadLine());
                idade = DateTime.Now.Year - Ano_de_Nascimento;
                if (idade < 0 || idade > 120)
                {
                    Console.WriteLine("Idade inválida. Digite novamente.");
                }
            } while (idade < 0 || idade > 120);

            Console.WriteLine("Qual o dia?");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual mês?");
            mes = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Digite seu email");
                email = Console.ReadLine();
                if (!Validação_do_email(email))
                {
                    Console.WriteLine("ERRO!!! Digite novamente.");
                }
            } while (!Validação_do_email(email));

            cadastroPrioridade();



            do
            {
                Console.WriteLine("Digite seu telefone celular");
                telefone = Console.ReadLine();
                if (!Validação_do_Telefone(telefone))
                {
                    Console.WriteLine("ERRO!!! Digite novamente.");
                }
            } while (!Validação_do_Telefone(telefone));

            Console.WriteLine($"Nome completo: {nome} \nCPF: {CPF} \nEndereço: {Endereço} \nIdade: {idade} \nData de nascimento: {dia}/{mes}/{Ano_de_Nascimento} \nEmail para contato: {email} \nPrioridade: {prioridade} \nTelefone: {telefone} \nSeus dados estão corretos? Digite 1) sim \n 2) não \n ");
            connt = int.Parse(Console.ReadLine());



            switch (connt)
            {
                case 1:
                    Console.WriteLine("CADASTRO FINALIZADO COM SUCESSO");
                    break;
                case 2:
                    while (connt == 2)
                    {
                        Console.WriteLine("Digite seu nome Completo");
                        nome = Console.ReadLine();

                        do
                        {
                            Console.WriteLine("Digite seu CPF");
                            CPF = Console.ReadLine();
                        } while (!Validação_do_cpf(CPF));

                        Console.WriteLine("Digite seu Endereço");
                        Endereço = Console.ReadLine();

                        do
                        {
                            Console.WriteLine("Qual o ano você nasceu");
                            Ano_de_Nascimento = int.Parse(Console.ReadLine());
                            idade = DateTime.Now.Year - Ano_de_Nascimento;
                            if (idade < 0 || idade > 120)
                            {
                                Console.WriteLine("Idade inválida. Digite novamente.");
                            }
                        } while (idade < 0 || idade > 120);

                        Console.WriteLine("Qual o dia?");
                        dia = int.Parse(Console.ReadLine());

                        Console.WriteLine("Qual mês?");
                        mes = int.Parse(Console.ReadLine());

                        do
                        {
                            Console.WriteLine("Digite seu email");
                            email = Console.ReadLine();
                        } while (!Validação_do_email(email));


                        do
                        {
                            Console.WriteLine("Digite seu telefone celular");
                            telefone = Console.ReadLine();
                        } while (!Validação_do_Telefone(telefone));

                        Console.WriteLine($"Nome completo: {nome} \nCPF: {CPF} \nEndereço: {Endereço} \nIdade: {idade} \nData de nascimento: {dia}/{mes}/{Ano_de_Nascimento} \nEmail para contato: {email} \nPrioridade: {prioridade} \nTelefone: {telefone} \nSeus dados estão corretos? Digite 1) sim \n2) não");
                        connt = int.Parse(Console.ReadLine());
                    }
                    break;
            }
        }

        private bool Validação_do_cpf(string CPF)
        {
            return CPF.Length == 11 && long.TryParse(CPF, out _);
        }

        private bool Validação_do_email(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool Validação_do_Telefone(string telefone)
        {
            return telefone.Length == 11 && long.TryParse(telefone, out _);
        }



    }
}

