using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Soldado.Exercicio_Soldado
{
    class Desarmado : IArma
    {
        public void usarArma()
        {
            Console.WriteLine("Personagem esta desarmado.");
        }
    }
}
