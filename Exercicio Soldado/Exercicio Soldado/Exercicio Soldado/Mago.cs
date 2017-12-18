using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Soldado.Exercicio_Soldado
{
    class Mago : Personagem, IMagia
    {
        public override void falar()
        {
            Console.WriteLine("Eu sou um Mago.");
        }
        public override void desenhar()
        {
            Console.WriteLine("Mago sendo desenhado ...");
        }
        public void magia()
        {
            Console.WriteLine("Minha magia despedaçara você. Magia sendo conjurada ...");
        }
    }
}
