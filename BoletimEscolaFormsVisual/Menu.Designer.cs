namespace BoletimEscolaFormsVisual
{
    partial class Menu
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
            this.btn_aluno = new System.Windows.Forms.Button();
            this.btn_professor = new System.Windows.Forms.Button();
            this.btn_admistrador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_aluno
            // 
            this.btn_aluno.Location = new System.Drawing.Point(28, 132);
            this.btn_aluno.Name = "btn_aluno";
            this.btn_aluno.Size = new System.Drawing.Size(163, 42);
            this.btn_aluno.TabIndex = 0;
            this.btn_aluno.Text = "Aluno";
            this.btn_aluno.UseVisualStyleBackColor = true;
            this.btn_aluno.Click += new System.EventHandler(this.btn_aluno_Click);
            // 
            // btn_professor
            // 
            this.btn_professor.Location = new System.Drawing.Point(275, 132);
            this.btn_professor.Name = "btn_professor";
            this.btn_professor.Size = new System.Drawing.Size(163, 42);
            this.btn_professor.TabIndex = 0;
            this.btn_professor.Text = "Professor";
            this.btn_professor.UseVisualStyleBackColor = true;
            this.btn_professor.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_admistrador
            // 
            this.btn_admistrador.Location = new System.Drawing.Point(527, 132);
            this.btn_admistrador.Name = "btn_admistrador";
            this.btn_admistrador.Size = new System.Drawing.Size(163, 42);
            this.btn_admistrador.TabIndex = 0;
            this.btn_admistrador.Text = "Administrador";
            this.btn_admistrador.UseVisualStyleBackColor = true;
            this.btn_admistrador.Click += new System.EventHandler(this.btn_admistrador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_admistrador);
            this.Controls.Add(this.btn_professor);
            this.Controls.Add(this.btn_aluno);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aluno;
        private System.Windows.Forms.Button btn_professor;
        private System.Windows.Forms.Button btn_admistrador;
        private System.Windows.Forms.Label label1;
    }
}