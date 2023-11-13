using AlunoApi.Entities;

namespace AlunoApi.Repository
{
    public class AlunoRepository
    {
        public static List<Aluno> Alunos  = new List<Aluno>();
        
        public void BancoDeDados()
        {
            Aluno A1 = new Aluno(1,"Marcus","Concluido",520);
            Aluno A2 = new Aluno(2,"Julia","Concluido",570);
            Aluno A3 = new Aluno(3,"Thamires","Cursando",540);
            Aluno A4 = new Aluno(4,"Manuel","Concluido",530);

            Alunos.Add(A1);
            Alunos.Add (A2);
            Alunos.Add (A3);
            Alunos.Add (A4);
        }
    }
}
