class Album
{
    private List<Musica> musicas = new List<Musica>();//campo lista de musicas

    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao); //funcao 

    public void AdicionarMusica(Musica musica) //metodo com parametro tipo Musica atribuído
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum: {Nome}: \n");
        foreach (var musica in musicas)
        {
        Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir esse algum todo, você precisa de {DuracaoTotal} segundos.");
    }

}