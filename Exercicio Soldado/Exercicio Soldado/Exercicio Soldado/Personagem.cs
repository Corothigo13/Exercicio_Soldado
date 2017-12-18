using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Soldado.Exercicio_Soldado
{
    abstract class Personagem
    {
        IArma arma;
        public abstract void desenhar();
        public virtual void falar()  { }
        public void setArma( IArma a )
        {
            arma = a;
        }
        public void Arma()
        {
            arma.usarArma();
        }
    }
}
