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
    [Route("CadastroCurso")]

    public class CursoController : ControllerBase
    {

        public static List<Curso> listacurso = new List<Curso>();
        [HttpGet]
        [Route("MostraCurso")]
        public ActionResult Get()
        {
            return Ok(listacurso);
        }

        [HttpPost]
        [Route("Curso")]
        public ActionResult Post(Curso curso)
        {
            listacurso.Add(curso);
            return Ok(listacurso);
        }

        [HttpGet]
        [Route("FiltroCurso")]
        public ActionResult Filtro(string nome)
        {
            var resultado = listacurso.Where(q => q.Nome.Contains(nome)).ToList();

            if (resultado.Count() == 0)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            return Ok(listacurso);
        }

        [HttpPut]
        [Route("PessoaCurso")]
        public ActionResult Atualizar(int id, string novonome)
        {

            var resultado = listacurso.Where(q => q.Id == id).ToList().FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            resultado.Nome = novonome;
            return Ok(Resultado.Sucesso);

        }

        [HttpDelete]
        [Route("DeletarCurso")]
        public ActionResult Deletar(int id)
        {

            var resultado = listacurso.Where(q => q.Id == id).FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            listacurso.Remove(resultado);
            return Ok(Resultado.Sucesso);

        }





    }

}
