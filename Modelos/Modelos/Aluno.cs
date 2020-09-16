using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletimEscolar.Modelos
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        //public int IdNotas { get; set; }

        //public virtual Notas Notas { get; set; }

        //public ICollection<Notas> Notas { get; set; } = new HashSet<Notas>();
      
    }
}
