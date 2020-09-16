namespace BoletimForms
{
    partial class Aluno
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nome = new System.Windows.Forms.Label();
            this.sobrenome = new System.Windows.Forms.Label();
            this.datanascimento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nome.Location = new System.Drawing.Point(67, 68);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(46, 19);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome";
            // 
            // sobrenome
            // 
            this.sobrenome.AutoSize = true;
            this.sobrenome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sobrenome.Location = new System.Drawing.Point(67, 118);
            this.sobrenome.Name = "sobrenome";
            this.sobrenome.Size = new System.Drawing.Size(79, 19);
            this.sobrenome.TabIndex = 0;
            this.sobrenome.Text = "Sobrenome";
            // 
            // datanascimento
            // 
            this.datanascimento.AutoSize = true;
            this.datanascimento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datanascimento.Location = new System.Drawing.Point(67, 160);
            this.datanascimento.Name = "datanascimento";
            this.datanascimento.Size = new System.Drawing.Size(133, 19);
            this.datanascimento.TabIndex = 0;
            this.datanascimento.Text = "Data de Nascimento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datanascimento);
            this.Controls.Add(this.sobrenome);
            this.Controls.Add(this.nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label sobrenome;
        private System.Windows.Forms.Label datanascimento;
    }
}

