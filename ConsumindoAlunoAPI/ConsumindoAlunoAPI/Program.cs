// See https://aka.ms/new-console-template for more information
using ConsumindoAlunoAPI.Entities;
using ConsumindoAlunoAPI.Entities.Services;

Console.WriteLine("Digite o ID");
int id = int.Parse(Console.ReadLine());

AlunoServices alunoServices = new AlunoServices();

Aluno alunoSelect = await alunoServices.BuscaAPI(id);

if (!alunoSelect.Vericacao)
{
    Console.WriteLine( "Aluno encontrado ");
    Console.WriteLine("Aluno: "+alunoSelect.Name);
    Console.WriteLine("Situação: " + alunoSelect.Situacao);
    Console.WriteLine("Matricula: " + alunoSelect.Matricula);
}
else
{
    Console.WriteLine("Aluno não encontrado");
}