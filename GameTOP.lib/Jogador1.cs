

using GameTOP.interfaqce;

namespace GameTOP.lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _Nome;



        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        //chuta
        public string Chuta()
        {
            return $"{_Nome} Está Chutando";
        }
        //corre
        public string Corre()
        {
            return $"{_Nome} Está Correndo";
        }
        
        //Passe
        public string Passe()
        {
            return $"{_Nome} Está Passando";
        }
    }
}