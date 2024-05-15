class Banda
{
    private List<Album> albuns = new List<Album>(); //lista para inserir album

    //construtor solicitando string nome da banda
    public Banda(string nome)
    {
        Nome = nome;        
    }
    public string Nome { get; } //string Nome declarada so com leitor
    //observação importante: No c#, se colocar apenas uma opção de leitura, precisa inicializar o valor com o construtor ou atribuindo um valor no getter

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}