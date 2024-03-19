class Aluno
{
    public string Matricula = "";

    public string Nome = "";

    public Aluno(string nomeParam)
    {
        Nome = nomeParam;
    }

    public Aluno(string nomeParam, string MatriculaParam)
    {
        Nome = nomeParam;
        Matricula = MatriculaParam;
    }

    public Aluno()
    {


    }

    public double Nota1;

    public double Nota2;
}