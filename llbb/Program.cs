using llbb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ficha ficha = new ficha();
            ficha.cadastro();
            Console.ReadKey();
        }
    }
}
