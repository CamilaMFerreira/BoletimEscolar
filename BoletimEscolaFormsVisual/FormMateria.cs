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
    public partial class FormMateria : Form
    {
        public int i = 0;
        public FormMateria()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var caminho = "https://localhost:44343/CadastroMateria/Materias";
            Materia materia = new Materia();
            materia.Id = i;
            materia.Nome = txt_nome.Text;
            materia.Descrição = txt_descrcao.Text;
            materia.DataCadastro = Convert.ToDateTime( txt_data.Text);
            materia.Situação = cb_situação.Text;
            var resultado = new add().Add(materia, caminho);
            txt_data.Clear();
            txt_descrcao.Clear();
            txt_nome.Clear();
            i++;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void bnt_volta_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdmistrador();
            this.Hide();//vai “esconder” o formulário atual
            menu.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
