using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BoletimEscolar.Modelos;
using Modelos.Util;

namespace BoletimEscola.Controllers
{
    [ApiController]
    [Route("Cadastro")]
    public class AlunoController : ControllerBase
    {
        public static List<Aluno> listaalunos = new List<Aluno>();
       [HttpGet]
        [Route("MostraAlunos")]
        public ActionResult Get()
        {
            return Ok(listaalunos);
        }

        [HttpPost]
        [Route("Alunos")]
        public ActionResult Post(Aluno pessoa)
        {
            listaalunos.Add(pessoa);
            return Ok(Resultado.Sucesso);
        }

        [HttpGet]
        [Route("FiltroAlunos")]
        public ActionResult Filtro(string nome)
        {
            var resultado = listaalunos.Where(q => q.Nome.Contains(nome)).ToList();

            if (resultado.Count() == 0)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            return Ok(listaalunos);
        }

        [HttpPut]
        [Route("PessoaAtulizar")]
        public ActionResult Atualizar(int id, string novonome)
        {

            var resultado = listaalunos.Where(q => q.Id==id).ToList().FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            resultado.Nome = novonome;
            return Ok(Resultado.Sucesso);

        }

        [HttpDelete]
        [Route("Deletar")]
        public ActionResult Deletar(int id)
        {

            var resultado = listaalunos.Where(q => q.Id == id).FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            listaalunos.Remove(resultado);
            return Ok(Resultado.Sucesso);

        }


    }
}
