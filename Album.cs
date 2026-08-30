using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using WaveSteam;

class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }

     private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {

     musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"As Músicas do álbum {Nome}:");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }








}