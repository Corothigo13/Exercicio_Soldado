using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Soldado.Exercicio_Soldado
{
    class Lutador : Personagem
    {
        public override void falar()
        {
            Console.WriteLine("Eu sou um Lutador de Sumo.");
        }
        public override void desenhar()
        {
            Console.WriteLine("Lutador de Sumo sendo desenhado ... Isso irá demorar um pouquinho ...");
        }

    }
}
