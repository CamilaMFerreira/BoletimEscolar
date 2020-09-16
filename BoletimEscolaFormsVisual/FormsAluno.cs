using BoletimEscolar.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BoletimEscolaFormsVisual
{
    public partial class FormsAluno : Form
    {
        public int i = 0;
        public FormsAluno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            var caminho = "https://localhost:44343/Cadastro/Alunos";
            Aluno aluno = new Aluno();
            aluno.Id = i;
            aluno.Nome = txt_nome.Text;
            aluno.Cpf = txt_cpf.Text;
            aluno.Sobrenome = txt_Sobrenome.Text;
            aluno.DataNascimento = Convert.ToDateTime(txtx_data.Text);
            var resultado = new add().Add(aluno, caminho);
            lb_sucesso.Text = resultado;
            txt_nome.Clear();
            txt_Sobrenome.Clear();
            txt_cpf.Clear();
            txtx_data.Clear();
            i++;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdmistrador();
            this.Hide();//vai “esconder” o formulário atual
            menu.Show();
        }

        private void Cpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
