namespace SolutionsApp
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabelaLogin = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btLogar = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabelaLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelaLogin
            // 
            this.tabelaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tabelaLogin.Controls.Add(this.label3);
            this.tabelaLogin.Controls.Add(this.btCadastrar);
            this.tabelaLogin.Controls.Add(this.btLogar);
            this.tabelaLogin.Controls.Add(this.txt_senha);
            this.tabelaLogin.Controls.Add(this.txt_usuario);
            this.tabelaLogin.Controls.Add(this.label2);
            this.tabelaLogin.Controls.Add(this.label1);
            this.tabelaLogin.Location = new System.Drawing.Point(35, 42);
            this.tabelaLogin.Name = "tabelaLogin";
            this.tabelaLogin.Size = new System.Drawing.Size(357, 423);
            this.tabelaLogin.TabIndex = 0;
            this.tabelaLogin.TabStop = false;
            this.tabelaLogin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 55);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOGIN";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(93, 324);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 5;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btLogar
            // 
            this.btLogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLogar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogar.Location = new System.Drawing.Point(188, 324);
            this.btLogar.Name = "btLogar";
            this.btLogar.Size = new System.Drawing.Size(75, 23);
            this.btLogar.TabIndex = 4;
            this.btLogar.Text = "Logar";
            this.btLogar.UseVisualStyleBackColor = true;
            this.btLogar.Click += new System.EventHandler(this.btLogar_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(93, 233);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(170, 23);
            this.txt_senha.TabIndex = 3;
            this.txt_senha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(93, 160);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(170, 23);
            this.txt_usuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 206);
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
            this.label1.Location = new System.Drawing.Point(90, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 513);
            this.Controls.Add(this.tabelaLogin);
            this.MaximumSize = new System.Drawing.Size(456, 552);
            this.MinimumSize = new System.Drawing.Size(456, 552);
            this.Name = "Frm_Login";
            this.Text = "Solutions - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.tabelaLogin.ResumeLayout(false);
            this.tabelaLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tabelaLogin;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btLogar;
        private System.Windows.Forms.Label label3;
    }
}

