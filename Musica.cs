using System;
using System.Collections.Generic;
using System.Text;

namespace WaveSteam
{
    internal class Musica
    {

    public Musica(string nome, Banda artista, int duracao, bool disponibilidade)
        {
            Nome = nome;
            Artista = artista;
            Duracao = duracao;
            Disponibilidade = disponibilidade;
        }


        public string Nome {  get; }
        public Banda Artista { get; }
        public int Duracao { get;  }
        public bool Disponibilidade { get; }

        public string DescricaoResumida =>
         $"A musica {Nome} pertence a banda {Artista.Nome} e tem duração de {Duracao} segundos.";
      
        

    public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao} segundos");
            if (Disponibilidade)
            {

                Console.WriteLine("Disponivel no plano.");
            }
            else
            {

                Console.WriteLine("Adquira o plano Plus+");

            }

        }
    }
}
