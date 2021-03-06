﻿using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoletimEscolar.Modelos
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descrição { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Situação { get; set; }
        public int IdCurso { get; set; }
        public virtual Curso Curso { get; set; }
        public ICollection<Notas> Notas { get; set; } = new HashSet<Notas>();
        public virtual ICollection<MateriaAluno> alunos { get; set; } = new HashSet<MateriaAluno>();

    }
}
