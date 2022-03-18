var deywid = new Aluno { Nome = "Deywid Felipe Lemes Chaves" };
var mauro = new Aluno { Nome = "Mauro Martins" };
var renato = new Aluno { Nome = "Renato da Silva Bastos Neto" };
var thiago = new Aluno { Nome = "Thiago Neckel" };

Avaliador.DarNotas(deywid);
Avaliador.DarNotas(mauro);
Avaliador.DarNotas(renato);
Avaliador.DarNotas(thiago);

Avaliador.AvaliarAluno(deywid);
Avaliador.AvaliarAluno(mauro);
Avaliador.AvaliarAluno(renato);
Avaliador.AvaliarAluno(thiago);

Console.WriteLine("Fim.");






public class Aluno
{
    public string Nome { get; set; } = "";
    public int NotaProjeto1 { get; set; }
    public int NotaProjeto2 { get; set; }
    public int NotaProjeto3 { get; set; }
    public int NotaProjeto4 { get; set; }
    public int NotaProjeto5 { get; set; }
    public int NotaProjeto6 { get; set; }

    public int MediaDasNotas { get; set; }

    public bool? Aprovado { get; set; } = null;
}

public class Avaliador
{
    public static void DarNotas(Aluno aluno)
    {
        Random rnd = new Random();

        aluno.NotaProjeto1 = rnd.Next(5, 11);
        aluno.NotaProjeto2 = rnd.Next(5, 11);
        aluno.NotaProjeto3 = rnd.Next(5, 11);
        aluno.NotaProjeto4 = rnd.Next(5, 11);
        aluno.NotaProjeto5 = rnd.Next(5, 11);
        aluno.NotaProjeto6 = rnd.Next(5, 11);
    }


    public static void AvaliarAluno(Aluno aluno)
    {
        var media = (aluno.NotaProjeto1 + aluno.NotaProjeto2 + aluno.NotaProjeto3 + aluno.NotaProjeto4 + aluno.NotaProjeto5 + aluno.NotaProjeto6) / 6;

        if (media >= 7)
            aluno.Aprovado = true;
        else
            aluno.Aprovado = false;

        aluno.MediaDasNotas = media;

    }
}