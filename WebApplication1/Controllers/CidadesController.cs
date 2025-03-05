using Cidades.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CidadesController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadesController : ControllerBase
    {
        // Lista estática para armazenar as cidades
        private static List<Cidade> Lista = new List<Cidade>();

        // GET: api/Cidades
        [HttpGet]
        public List<Cidade> Get()
        {
            return Lista;
        }

        // POST: api/Cidades
        [HttpPost]
        public string Post([FromBody] Cidade cidade)
        {
            Lista.Add(cidade);
            return "Cidade cadastrada com sucesso.";
        }

        // PUT: api/Cidades
        [HttpPut]
        public string Put([FromBody] Cidade cidade)
        {
            var cidadeExistente = Lista.FirstOrDefault(c => c.Codigo == cidade.Codigo);
            if (cidadeExistente != null)
            {
                cidadeExistente.Nome = cidade.Nome;
                cidadeExistente.Sigla = cidade.Sigla;
                return "Cidade atualizada com sucesso.";
            }
            return "Cidade não encontrada.";
        }

        // DELETE: api/Cidades/{codigo}
        [HttpDelete("{codigo}")]
        public string Delete(int codigo)
        {
            var cidadeExistente = Lista.FirstOrDefault(c => c.Codigo == codigo);
            if (cidadeExistente != null)
            {
                Lista.Remove(cidadeExistente);
                return "Cidade excluída com sucesso.";
            }
            return "Cidade não encontrada.";
        }
    }
}