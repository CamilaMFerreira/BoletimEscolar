using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BoletimEscolaFormsVisual
{
    public partial class MenuAdmistrador : Form
    {
        public MenuAdmistrador()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Hide();//vai “esconder” o formulário atual
            menu.Show();
        }

        private void btn_materia_Click(object sender, EventArgs e)
        {
            var cadastromateria = new FormMateria();
            this.Hide();//vai “esconder” o formulário atual
            cadastromateria.Show();

        }

        private void btn_curso_Click(object sender, EventArgs e)
        {
            var cadastrocurso = new FormCurso();
            this.Hide();//vai “esconder” o formulário atual
            cadastrocurso.Show();
        }

        private void bnt_aluno_Click(object sender, EventArgs e)
        {
            var cadastroaluno = new FormsAluno();
            this.Hide();//vai “esconder” o formulário atual
            cadastroaluno.Show();
        }
    }
}
