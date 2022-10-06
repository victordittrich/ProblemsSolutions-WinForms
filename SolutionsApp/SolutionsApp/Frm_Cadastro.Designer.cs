namespace SolutionsApp
{
    partial class Frm_Cadastro
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
            this.tabelaLogin = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_csenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabelaLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelaLogin
            // 
            this.tabelaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tabelaLogin.Controls.Add(this.txt_csenha);
            this.tabelaLogin.Controls.Add(this.label4);
            this.tabelaLogin.Controls.Add(this.label3);
            this.tabelaLogin.Controls.Add(this.btCadastrar);
            this.tabelaLogin.Controls.Add(this.btVoltar);
            this.tabelaLogin.Controls.Add(this.txt_senha);
            this.tabelaLogin.Controls.Add(this.txt_usuario);
            this.tabelaLogin.Controls.Add(this.label2);
            this.tabelaLogin.Controls.Add(this.label1);
            this.tabelaLogin.Location = new System.Drawing.Point(42, 45);
            this.tabelaLogin.Name = "tabelaLogin";
            this.tabelaLogin.Size = new System.Drawing.Size(357, 423);
            this.tabelaLogin.TabIndex = 1;
            this.tabelaLogin.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 55);
            this.label3.TabIndex = 6;
            this.label3.Text = "CADASTRO";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(188, 331);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 5;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btVoltar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(93, 331);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 4;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(93, 209);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(170, 23);
            this.txt_senha.TabIndex = 3;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(93, 140);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(170, 23);
            this.txt_usuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // txt_csenha
            // 
            this.txt_csenha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_csenha.Location = new System.Drawing.Point(93, 271);
            this.txt_csenha.Name = "txt_csenha";
            this.txt_csenha.Size = new System.Drawing.Size(170, 23);
            this.txt_csenha.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirmar senha";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 513);
            this.Controls.Add(this.tabelaLogin);
            this.Name = "Frm_Cadastro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Cadastro_Load);
            this.tabelaLogin.ResumeLayout(false);
            this.tabelaLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tabelaLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_csenha;
        private System.Windows.Forms.Label label4;
    }
}