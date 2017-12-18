using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Soldado.Exercicio_Soldado
{
    class Terrorista : Personagem
    {
        public override void falar()
        {
            Console.WriteLine("Eu sou um Terrorista.");
        }
        public override void desenhar()
        {
            Console.WriteLine("Terrorista sendo desenhado ...");
        }

    }
}
