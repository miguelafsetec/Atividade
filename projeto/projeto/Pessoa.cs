﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public int op;
        public int connt;



        public virtual void cadastro()
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

            Console.WriteLine("Qual sua idade");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o ano você nasceu");
            Ano_de_Nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o dia?");
            dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual mês?");
            mes = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Digite seu email");
                email = Console.ReadLine();
            } while (!Validação_do_email(email));

            Console.WriteLine("Você tem alguma deficiência?");
            prioridade = Console.ReadLine();

            do
            {
                Console.WriteLine("Digite seu telefone celular");
                telefone = Console.ReadLine();
            } while (!Validação_do_Telefone(telefone));

            Console.WriteLine($"Nome completo: {nome} \nCPF: {CPF} \nEndereço: {Endereço} \nIdade: {idade} \nData de nascimento: {dia}/{mes}/{Ano_de_Nascimento} \nEmail para contato: {email} \nPrioridade: {prioridade} \nTelefone: {telefone} \nSeus dados estão corretos? Digite 1) sim \n2) não");
            connt = int.Parse(Console.ReadLine());
            switch (connt)
            {

                case 1:

                    Console.WriteLine("CADASTRO FINALIZADO COM EXECITO");
                    break;
                case 2:
                    while (connt == 2)
                    {
                        Console.WriteLine("Digite seu nome Completo");
                        nome = Console.ReadLine();
                        Console.WriteLine("Digite seu cpf");
                        CPF = Console.ReadLine();
                        Console.WriteLine("digite seu Endereço");
                        Endereço = Console.ReadLine();
                        Console.WriteLine("Qual sua idade");
                        idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o ano você nasceu");
                        Ano_de_Nascimento = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual o dia ?");
                        dia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Qual mês? ");
                        mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite seu email ");
                        email = Console.ReadLine();
                        Console.WriteLine("você tem alguma defeciência? ");
                        prioridade = Console.ReadLine();
                        Console.WriteLine("Digite seu telefone celular");
                        telefone = Console.ReadLine();
                        Console.WriteLine($"Nome completo {nome} \n CPF {CPF} \n Endereço {Endereço} \n idade {idade} \n data de nascimeto {dia}/{mes}/{Ano_de_Nascimento} \n email para contato {email} \n prioridade {prioridade} \n telefone {telefone} \n seus dados estão corretos ? digite 1) sim \n 2)não");
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




    








    

