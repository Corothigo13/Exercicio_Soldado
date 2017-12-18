using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Soldado.Exercicio_Soldado
{
    class Soldado : Personagem
    {
        public override void falar()
        {
            Console.WriteLine("Eu sou um soldado.");
        }
        public override void desenhar()
        {
            Console.WriteLine("Soldado sendo desenhado ...");
        }
    }
}
