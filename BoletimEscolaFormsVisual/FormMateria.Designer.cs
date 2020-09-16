namespace BoletimEscolaFormsVisual
{
    partial class FormMateria
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_descrcao = new System.Windows.Forms.TextBox();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.cb_situação = new System.Windows.Forms.ComboBox();
            this.bnt_volta = new System.Windows.Forms.Button();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.bl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descricão :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Cadastro :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Situação : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(63, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 46);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cadastro Matéria";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(149, 96);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(246, 23);
            this.txt_nome.TabIndex = 2;
            // 
            // txt_descrcao
            // 
            this.txt_descrcao.Location = new System.Drawing.Point(149, 149);
            this.txt_descrcao.Multiline = true;
            this.txt_descrcao.Name = "txt_descrcao";
            this.txt_descrcao.Size = new System.Drawing.Size(246, 55);
            this.txt_descrcao.TabIndex = 2;
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(149, 222);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(246, 23);
            this.txt_data.TabIndex = 2;
            // 
            // cb_situação
            // 
            this.cb_situação.FormattingEnabled = true;
            this.cb_situação.Items.AddRange(new object[] {
            "Ativo",
            "Desativado"});
            this.cb_situação.Location = new System.Drawing.Point(149, 270);
            this.cb_situação.Name = "cb_situação";
            this.cb_situação.Size = new System.Drawing.Size(246, 23);
            this.cb_situação.TabIndex = 3;
            this.cb_situação.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bnt_volta
            // 
            this.bnt_volta.Location = new System.Drawing.Point(40, 343);
            this.bnt_volta.Name = "bnt_volta";
            this.bnt_volta.Size = new System.Drawing.Size(75, 23);
            this.bnt_volta.TabIndex = 4;
            this.bnt_volta.Text = "Voltar";
            this.bnt_volta.UseVisualStyleBackColor = true;
            this.bnt_volta.Click += new System.EventHandler(this.bnt_volta_Click);
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Location = new System.Drawing.Point(196, 330);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(155, 48);
            this.btn_cadastro.TabIndex = 4;
            this.btn_cadastro.Text = "Cadastro";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            this.btn_cadastro.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(421, 343);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.button3_Click);
            // 
            // bl_resultado
            // 
            this.bl_resultado.AutoSize = true;
            this.bl_resultado.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bl_resultado.ForeColor = System.Drawing.Color.Red;
            this.bl_resultado.Location = new System.Drawing.Point(112, 379);
            this.bl_resultado.Name = "bl_resultado";
            this.bl_resultado.Size = new System.Drawing.Size(0, 28);
            this.bl_resultado.TabIndex = 5;
            // 
            // FormMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 416);
            this.Controls.Add(this.bl_resultado);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.bnt_volta);
            this.Controls.Add(this.cb_situação);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.txt_descrcao);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMateria";
            this.Text = "FormMateria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_descrcao;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.ComboBox cb_situação;
        private System.Windows.Forms.Button bnt_volta;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Label bl_resultado;
    }
}