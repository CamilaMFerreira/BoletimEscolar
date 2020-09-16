using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoletimEscolar.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos.Util;

namespace BoletimEscola.Controllers
{
    [ApiController]

    [Route("CadastroNota")]
    public class NotasController : ControllerBase
    {

        public static List<Notas> listaNotas = new List<Notas>();
        [HttpGet]
        [Route("MostraNotass")]
        public ActionResult Get()
        {

            return Ok(listaNotas);
        }

        [HttpPost]
        [Route("Notas")]
        public ActionResult Post(Notas Notas)
        {
            listaNotas.Add(Notas);
            return Ok(listaNotas);
        }

        [HttpGet]
        [Route("FiltroNotass")]
        public ActionResult Filtro(string nome)
        {
            var resultado = listaNotas.Where(q => q.Alunos.Nome.Contains(nome)).ToList();

            if (resultado.Count() == 0)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            return Ok(listaNotas);
        }

        [HttpPut]
        [Route("PessoaNotas")]
        public ActionResult Atualizar(int id, int nota)
        {

            var resultado = listaNotas.Where(q => q.Id == id).ToList().FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            resultado.Nota = nota;
            return Ok(Resultado.Sucesso);

        }

        [HttpDelete]
        [Route("DeletarNotas")]
        public ActionResult Deletar(int id)
        {

            var resultado = listaNotas.Where(q => q.Id == id).FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            listaNotas.Remove(resultado);
            return Ok(Resultado.Sucesso);
        }
    }
}
