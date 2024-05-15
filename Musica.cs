
using System.Security.Cryptography.X509Certificates;


//estrutura de classe
class Musica
{
    //criando um construtor: ao criar uma musica, vamos obrigar a passar informações como a banda. Construtor nao tem retorno.
    public Musica(Banda artista) //pedir o argumento artista do tipo Banda
    {
        Artista = artista; //a propriedade Artista recebe o argumento artista do construtor
    }

    public string Nome { get; set; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; } //acesso a essa caracteristica só pode ser feito de dentro da classe; Esse atributo tem operacao de leitura e de escrita
    //ao atribuir get e set para um atributo, ele passa a ser chamado de PROPRIEDADE e escrito em PascalCase
    //criar uma propriedade com atalho: prop+tab
    public string DescricaoResumida //classe so tem o get porque nao desejamos permitir a alteração com set
    {
        get //editando o get
        {
            return $"A musica {Nome} pertence à banda {Artista}.";
        }
    }

    //outra possibilidade de funcao apenas com getter (lambda):
    //public string DescricaoResumida =>
    //  $"A musica {Nome} pertence à banda {Artista}.";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}.");
        Console.WriteLine($"Artista: {Artista}.");
        Console.WriteLine($"Duração: {Duracao}.");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no Plano");
        } else {
            Console.WriteLine("Adquira o Plano Plus+");
        }
    }
}