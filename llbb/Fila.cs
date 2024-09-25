using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_hospital
{
    internal class Fila : Paciente
    {
        public string[] fila = new string[0];

        public void incluirFila(string Paciente, bool prioridade)
        {
            if (prioridade == true)
            {
                Array.Resize(ref fila, fila.Length + 1);
                for (int i = fila.Length - 1; i > 0; i--)
                {
                    fila[i] = fila[i - 1];
                }
                fila[0] = Paciente;
            }
            else
            {
                Array.Resize(ref fila, fila.Length + 1);
                fila[fila.Length - 1] = Paciente;
            }

        }

        public void atendeFila()
        {
            if (fila.Length > 0)
            {
                for (int i = 0; i < fila.Length - 1; i++)
                {
                    fila[i] = fila[i + 1];
                }
                Array.Resize(ref fila, fila.Length - 1);
            }
            else
            {
                Console.WriteLine("A fila está vazia.");
            }
        }

        public void mostrarFilaAtual()
        {
            if (fila.Length > 0)
            {
                Console.WriteLine("Fila atual de pacientes:");
                foreach (var paciente in fila)
                {
                    Console.WriteLine($"Paciente: {paciente}");
                }
            }
            else
            {
                Console.WriteLine("A fila está vazia.");
            }
        }

        //Incluir paciente
        //Incluir pacientes prioritarios
        //atender cliente
        //mostrar fila atual
    }
}
