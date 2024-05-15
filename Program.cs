using System.Runtime.CompilerServices;

//criando banda atribuindo o nome que agora é obrigatorio por conta do construtor criado
Banda queen = new Banda("Queen");

//criando album
Album albumDoQueen = new Album("A night at the opera");


//criando as musicas com os construtores(info obrigatoria) e estrutura possivel para informações opcionais
Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

//inserindo musicas no album
albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

albumDoQueen.ExibirMusicasDoAlbum();

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();





