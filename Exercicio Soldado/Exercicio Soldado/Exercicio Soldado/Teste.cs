using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Soldado.Exercicio_Soldado
{
    class Teste
    {
        public void teste()
        {
            Soldado s = new Soldado();
            s.falar();
            s.setArma(new Revolver());
            s.desenhar();
            s.Arma();
            Console.WriteLine("\n");
            General g = new General();
            g.falar();
            g.setArma(new Fuzil());
            g.desenhar();
            g.Arma();
            Console.WriteLine("\n");
            Lutador l = new Lutador();
            l.falar();
            l.setArma(new Desarmado());
            l.desenhar();
            l.Arma();
            Console.WriteLine("\n");
            Terrorista t = new Terrorista();
            t.falar();
            t.setArma(new LançaFoguetes());
            t.desenhar();
            t.Arma();
            Console.WriteLine("\n");
            Mago m = new Mago();
            m.falar();
            m.setArma(new Desarmado());
            m.desenhar();
            m.Arma();
            m.magia();
            Console.WriteLine("\nPara se acomodar o Dragão seria necessario a mudança a classe Personagem, onde talvez não haveria mais fala(), dependendo de quem esta fazendo o jogo kkk, tambem seria necessario criar uma interface para que o Dragão pudesse lançar chamas para se defender e/ou atacar.");
        }
    }
}
