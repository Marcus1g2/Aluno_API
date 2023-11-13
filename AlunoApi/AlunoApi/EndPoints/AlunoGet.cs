using AlunoApi.Entities;
using AlunoApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AlunoApi.Get
{
    public class AlunoGet
    {
        public static string Template => "/aluno/{id:int}";
        public static string[] Metodo => new string[] { HttpMethod.Get.ToString() };

        public static Delegate func => acao;

        public static IResult acao([FromRoute] int id)
        {
            AlunoRepository alunoRepository = new AlunoRepository();
            alunoRepository.BancoDeDados();

            Aluno aluno = AlunoRepository.Alunos.FirstOrDefault(x => x.Id.Equals(id));

            if (aluno!=null)
            {
                return Results.Ok(aluno);
            }
            else
            {
                return Results.NotFound();
            }
        }


    }
}
