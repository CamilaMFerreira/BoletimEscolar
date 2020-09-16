namespace BoletimEscolaFormsVisual
{
    partial class MenuAdmistrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_materia = new System.Windows.Forms.Button();
            this.btn_curso = new System.Windows.Forms.Button();
            this.bnt_aluno = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_materia
            // 
            this.btn_materia.Location = new System.Drawing.Point(85, 114);
            this.btn_materia.Name = "btn_materia";
            this.btn_materia.Size = new System.Drawing.Size(236, 43);
            this.btn_materia.TabIndex = 0;
            this.btn_materia.Text = "Cadastrar Matéria";
            this.btn_materia.UseVisualStyleBackColor = true;
            this.btn_materia.Click += new System.EventHandler(this.btn_materia_Click);
            // 
            // btn_curso
            // 
            this.btn_curso.Location = new System.Drawing.Point(85, 205);
            this.btn_curso.Name = "btn_curso";
            this.btn_curso.Size = new System.Drawing.Size(236, 43);
            this.btn_curso.TabIndex = 0;
            this.btn_curso.Text = "Cadastrar Curso";
            this.btn_curso.UseVisualStyleBackColor = true;
            this.btn_curso.Click += new System.EventHandler(this.btn_curso_Click);
            // 
            // bnt_aluno
            // 
            this.bnt_aluno.Location = new System.Drawing.Point(85, 295);
            this.bnt_aluno.Name = "bnt_aluno";
            this.bnt_aluno.Size = new System.Drawing.Size(236, 43);
            this.bnt_aluno.TabIndex = 0;
            this.bnt_aluno.Text = "Cadastrar Aluno";
            this.bnt_aluno.UseVisualStyleBackColor = true;
            this.bnt_aluno.Click += new System.EventHandler(this.bnt_aluno_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 26);
            this.button3.TabIndex = 0;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Portal do Adminstrador";
            // 
            // MenuAdmistrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bnt_aluno);
            this.Controls.Add(this.btn_curso);
            this.Controls.Add(this.btn_materia);
            this.Name = "MenuAdmistrador";
            this.Text = "MenuAdmistrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_materia;
        private System.Windows.Forms.Button btn_curso;
        private System.Windows.Forms.Button bnt_aluno;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}