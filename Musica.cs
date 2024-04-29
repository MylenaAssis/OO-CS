//estrutura de classe
using System.Security.Cryptography.X509Certificates;

class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; } //acesso a essa caracteristica só pode ser feito de dentro da classe; Esse atributo tem operacao de leitura e de escrita
    //ao atribuir get e set para um atributo, ele passa a ser chamado de PROPRIEDADE e escrito em PascalCase
    public string DescricaoResumida //classe so tem o get porque nao desejamos permitir a alteração com set
    {
        get //editando o get
        {
            return $"A musica {Nome} pertence à banda {Artista}.";
        }
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}.");
        Console.WriteLine($"Artista: {Artista}.");
        Console.WriteLine($"Duração: {Duracao}.");
    }
}

