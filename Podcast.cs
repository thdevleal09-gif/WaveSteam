class Podcast
{
    private List<Episodio> episodios = new();



    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios { get; set; }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);

    }
    public void ExibirDetalhesDoPodcast()
    {
        Console.WriteLine($"Podcast: {Nome}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Total de Episódios: {episodios.Count}");
        Console.WriteLine("Episódios:");
        foreach (var episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
    }


}