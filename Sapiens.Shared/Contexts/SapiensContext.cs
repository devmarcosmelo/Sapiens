using Sapiens.Shared.Entities;

namespace Sapiens.Shared.Contexts;

public class SapiensContext
{
    public List<Curso> Cursos { get; set; }
    public List<Disciplina> Disciplinas { get; set; }
    public List<Professor> Professores { get; set; }

    public List<Aluno> Alunos { get; set; }
    public List<Funcionario> Funcionarios { get; set; } //precisar criar metodos para add cada lista


    public void AdicionaCurso( Curso curso)
    {

    }
    public void AdicionaAluno(Aluno aluno)
    {

    }



    public SapiensContext()
    {
        Cursos = new();
        Disciplinas = new();
    }
}
