namespace FormsVisual
{
    partial class Materia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_situação = new System.Windows.Forms.ComboBox();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.txt_descriçao = new System.Windows.Forms.TextBox();
            this.txtx_nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data de Cadastro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Situação";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_situação
            // 
            this.cb_situação.FormattingEnabled = true;
            this.cb_situação.Location = new System.Drawing.Point(204, 230);
            this.cb_situação.Name = "cb_situação";
            this.cb_situação.Size = new System.Drawing.Size(221, 23);
            this.cb_situação.TabIndex = 2;
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(204, 188);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(221, 23);
            this.txt_data.TabIndex = 3;
            // 
            // txt_descriçao
            // 
            this.txt_descriçao.Location = new System.Drawing.Point(204, 80);
            this.txt_descriçao.Multiline = true;
            this.txt_descriçao.Name = "txt_descriçao";
            this.txt_descriçao.Size = new System.Drawing.Size(255, 90);
            this.txt_descriçao.TabIndex = 3;
            // 
            // txtx_nome
            // 
            this.txtx_nome.Location = new System.Drawing.Point(204, 41);
            this.txtx_nome.Name = "txtx_nome";
            this.txtx_nome.Size = new System.Drawing.Size(221, 23);
            this.txtx_nome.TabIndex = 3;
            // 
            // Materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 377);
            this.Controls.Add(this.txtx_nome);
            this.Controls.Add(this.txt_descriçao);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.cb_situação);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Materia";
            this.Text = "Materia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_situação;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.TextBox txt_descriçao;
        private System.Windows.Forms.TextBox txtx_nome;
    }
}