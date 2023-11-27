using System;

class Program
{
    static void Main()
    {
        // Instancia um professor e exibe os dados da classe professor
        Professor professor = new Professor("John Doe", 5000);
        professor.ApresentarDados();

        // Instancia a disciplina e exibe os dados da classe disciplina
        Disciplina disciplina = new Disciplina("Matemática", professor);
        disciplina.ApresentarDados();

        // Instancia um aluno e exibe os dados da classe aluno
        Aluno aluno = new Aluno("Alice", "123456", disciplina);
        aluno.ApresentarDados();

        // Acessando e modificando as propriedades
        Console.WriteLine($"Nome do professor pré-modificação: {professor.Nome}");
        professor.Nome = "Jane Doe"; // Modificando usando a propriedade
        Console.WriteLine($"Nome depois da modificação: {professor.Nome}");
    }
}

class Professor
{
    private string nome;
    private double salario;

    public Professor(string nome, double salario)
    {
        this.nome = nome;
        this.salario = salario;
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public double Salario
    {
        get { return salario; }
        set { salario = value; }
    }

    public void ApresentarDados()
    {
        Console.WriteLine($"Nome do Professor: {Nome} \nSalário do Professor: {Salario:C}\n");
    }
}

class Disciplina
{
    public string Nome { get; }
    public Professor ProfessorResponsavel { get; }

    public Disciplina(string nome, Professor professor)
    {
        Nome = nome;
        ProfessorResponsavel = professor;
    }

    public void ApresentarDados()
    {
        Console.WriteLine($"Nome da Disciplina: {Nome}\nProfessor Responsável:");
        ProfessorResponsavel.ApresentarDados();
    }
}

class Aluno
{
    public string Nome { get; }
    public string RA { get; }
    public Disciplina DisciplinaCadastrada { get; }

    public Aluno(string nome, string ra, Disciplina disciplina)
    {
        Nome = nome;
        RA = ra;
        DisciplinaCadastrada = disciplina;
    }

    public void ApresentarDados()
    {
        Console.WriteLine($"Nome do Aluno: {Nome}\nRA do Aluno: {RA}\nDisciplina Cadastrada:");
        DisciplinaCadastrada.ApresentarDados();
    }
}
