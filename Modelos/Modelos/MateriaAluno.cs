using BoletimEscolar.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Modelos
{
    public class MateriaAluno
    {
        public int IdMateria { get; set; }
        public Materia Materia { get; set; }
        public int IdAluno { get; set; }
        public Aluno Aluno { get; set; }
        public double Nota { get; set; }

    }
}
