using System.Runtime.CompilerServices;

//criando banda
Banda queen = new Banda();
queen.Nome = "Queen";

//criando album
Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";

//criando as musicas
Musica musica1 = new Musica(queen);
musica1.Nome = "Love of my live";
musica1.Duracao = 213;

Musica musica2 = new Musica(queen);
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;

//inserindo musicas no album
albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicasDoAlbum();

queen.AdicionarAlbum(albumDoQueen);

queen.ExibirDiscografia();





