using System;
using GameTOP.interfaqce;

namespace GameTOP
{
public class JogoFODA
    {

        private readonly IJogador _JogadorA;

        private readonly IJogador _JogadorB;

        public JogoFODA(IJogador JogadorA, IJogador JogadorB)
        {
            _JogadorA = JogadorA;
            _JogadorB = JogadorB;
        }
        public void IniciarJogo()
        {
            System.Console.WriteLine(_JogadorA.Corre());
            System.Console.WriteLine(_JogadorA.Chuta());
            System.Console.WriteLine(_JogadorA.Passe());

            System.Console.WriteLine(_JogadorB.Chuta());
            System.Console.WriteLine(_JogadorB.Corre());
            System.Console.WriteLine(_JogadorB.Passe());

        }


    } 












}