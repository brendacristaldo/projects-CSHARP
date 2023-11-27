using System;

class Program
{
    static void Main()
    {
        // Instancia e chama a classe professor
        Professor professor = new Professor("John Doe", 5000);
        professor.ApresentarDados();

        // Instancia e chama a classe disciplina
        Disciplina disciplina = new Disciplina("Matemática", professor);
        disciplina.ApresentarDados();

         / Instancia e chama a classe disciplina
        Aluno aluno = new Aluno("Alice", "123456", disciplina);
        aluno.ApresentarDados();
    }
}

class Professor
{
    public string Nome { get; }
    public double Salario { get; }

    public Professor(string nome, double salario)
    {
        Nome = nome;
        Salario = salario;
    }

    public void ApresentarDados()
    {
        Console.WriteLine($"Nome do Professor: {Nome}\nSalário do Professor: {Salario:C}\n");
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
        Console.WriteLine($"Nome da Disciplina: {Nome}");
        Console.WriteLine("Professor Responsável:");
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
        Console.WriteLine($"Nome do Aluno: {Nome}\nRA do Aluno: {RA}");
        Console.WriteLine("Disciplina Cadastrada:");
        DisciplinaCadastrada.ApresentarDados();
    }
}
