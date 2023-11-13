using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoAlunoAPI.Entities
{
    internal class Aluno
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Situacao { get; set; }
        public int Matricula { get; set; }

        public bool Vericacao = false;
    }
}
