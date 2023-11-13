using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoAlunoAPI.Entities.Services
{
    internal class AlunoServices
    {
        public async Task<Aluno> BuscaAPI(int id)
        {
            HttpClient client = new HttpClient();
            var select = await client.GetAsync($"https://localhost:7219/Aluno/{id}");
            var jsonString = await select.Content.ReadAsStringAsync();

            Aluno jsonObject = JsonConvert.DeserializeObject<Aluno>(jsonString);

            if(jsonString != null)
            {
                return jsonObject;
            }
            else
            {
                return new Aluno
                {
                    Vericacao = true
                };
            }
        }
    }
}
