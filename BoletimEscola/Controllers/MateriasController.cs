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
    [Route("CadastroMateria")]

    public class MateriasController : ControllerBase
    {
        public static List<Materia> listamateria = new List<Materia>();
        [HttpGet]
        [Route("MostraMaterias")]
        public ActionResult Get()
        {
            List<string> lista = new List<string>();
            listamateria.ForEach(s => lista.Add(s.Nome)); 
            return Ok(lista);
        }

        [HttpPost]
        [Route("Materias")]
        public ActionResult Post(Materia materia)
        {
            listamateria.Add(materia);
            return Ok(listamateria);
        }

        [HttpGet]
        [Route("FiltroMaterias")]
        public ActionResult Filtro(string nome)
        {
            var resultado = listamateria.Where(q => q.Nome.Contains(nome)).ToList();

            if (resultado.Count() == 0)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            return Ok(listamateria);
        }

        [HttpPut]
        [Route("MateriasAtualizar")]
        public ActionResult Atualizar(int id, string novonome)
        {

            var resultado = listamateria.Where(q => q.Id == id).ToList().FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            resultado.Nome = novonome;
            return Ok(Resultado.Sucesso);

        }

        [HttpDelete]
        [Route("DeletarMaterias")]
        public ActionResult Deletar(int id)
        {

            var resultado = listamateria.Where(q => q.Id == id).FirstOrDefault();
            if (resultado is null)
            {
                return BadRequest(Resultado.NãoSucesso);
            }
            listamateria.Remove(resultado);
            return Ok(Resultado.Sucesso);
        }
    }
}
