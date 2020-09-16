using BoletimEscolar.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BoletimEscolaFormsVisual
{
    public partial class FormCurso : Form
    {
        public int i = 0;
        public FormCurso()
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdmistrador();
            this.Hide();//vai “esconder” o formulário atual
            menu.Show();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            var caminho = "https://localhost:44343/CadastroCurso/Curso";
            Curso curso = new Curso();
            curso.Id = i;
            curso.Nome = txt_nome.Text;
            curso.Situação = cb_situação.Text;
            lb_resposta.Text = new add().Add(curso, caminho); 
            txt_nome.Clear();
            i++;
           
        }
    }
}
