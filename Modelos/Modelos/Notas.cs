using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletimEscolar.Modelos
{
    public class Notas
    {
        public int Id { get; set; }

        public double Nota { get; set; }

        public int IdAluno { get; set; }
        public int IdMateria { get; set; }

        public virtual Aluno Alunos { get; set; }
        public virtual Materia Materias { get; set; }
    }
}
