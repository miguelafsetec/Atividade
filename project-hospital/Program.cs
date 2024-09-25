using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ficha ficha = new Ficha();

            Console.WriteLine("Sistema Hospital");
            ficha.cadastro();
            Console.ReadKey();
        }
    }
}
