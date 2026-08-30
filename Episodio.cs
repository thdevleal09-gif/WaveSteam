class Episodio
{

    private List<string> ListaDeConvidados = new List<string>();



    public Episodio(string ordem, int titulo, string duracao, string resumo)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
        }

    public string Ordem { get;  }
    public int Titulo { get;  }
    public string Duracao { get;  }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min)  - Convidados: {string.Join(", ", ListaDeConvidados)}";


    public void AdicionarConvidados(string convidado)
    {

    ListaDeConvidados.Add(convidado);

    }

}