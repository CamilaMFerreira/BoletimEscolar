using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BoletimEscolaFormsVisual
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_aluno_Click(object sender, EventArgs e)
        {
            var menualuno = new MenuAluno();
            this.Hide();//vai “esconder” o formulário atual
            menualuno.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cadastronota = new FormNota();
            this.Hide();//vai “esconder” o formulário atual
            cadastronota.Show();

        }

        private void btn_admistrador_Click(object sender, EventArgs e)
        {
            var menuadmistrador = new MenuAdmistrador();
            this.Hide();//vai “esconder” o formulário atual
            menuadmistrador.Show();
        }
    }
}
