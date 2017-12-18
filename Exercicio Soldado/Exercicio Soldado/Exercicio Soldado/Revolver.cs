using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Soldado.Exercicio_Soldado
{
    class Revolver : IArma
    {
        public void usarArma()
        {
            Console.WriteLine("Tiro ... Tiro ... Tiro ...");
        }
    }
}
