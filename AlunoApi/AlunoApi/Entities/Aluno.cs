namespace AlunoApi.Entities
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Situacao { get; set; }
        public int Matricula { get; set; }

        public Aluno(int id, string name, string situacao, int matricula)
        {
            Id = id;
            Name = name;
            Situacao = situacao;
            Matricula = matricula;
        }
    }
}
