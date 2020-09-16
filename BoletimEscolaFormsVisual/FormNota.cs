using BoletimEscolar.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BoletimEscolaFormsVisual
{
    public partial class FormNota : Form
    {
        public int i = 0;
        public FormNota()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Hide();//vai “esconder” o formulário atual
            menu.Show();
        }

        private void cb_materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            var caminho = "https://localhost:44343/CadastroMaterias/MostraMaterias";
            cb_materia = new listar().MeuGet(caminho).; 

        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            var caminho = "https://localhost:44343/CadastroNota/Notas";
            Notas nota = new Notas();
            nota.Id = i;
            nota.IdMateria = Convert.ToInt32(cb_materia.Text);
            nota.IdAluno = Convert.ToInt32(cb_aluno.Text);
            nota.Nota = Convert.ToInt32(txt_Nota.Text);
            lb_sucesso.Text= new add().Add(nota, caminho);
            txt_Nota.Clear();
            i++;
        }
    }
}
