namespace SolutionsApp
{
    partial class Frm_AddProblema
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddProblema));
            this.tabelaLogin = new System.Windows.Forms.GroupBox();
            this.txt_solucao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.txt_problema = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabelaLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelaLogin
            // 
            this.tabelaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.tabelaLogin.Controls.Add(this.txt_solucao);
            this.tabelaLogin.Controls.Add(this.label3);
            this.tabelaLogin.Controls.Add(this.btCadastrar);
            this.tabelaLogin.Controls.Add(this.btVoltar);
            this.tabelaLogin.Controls.Add(this.txt_problema);
            this.tabelaLogin.Controls.Add(this.label2);
            this.tabelaLogin.Controls.Add(this.label1);
            this.tabelaLogin.Location = new System.Drawing.Point(140, 61);
            this.tabelaLogin.Name = "tabelaLogin";
            this.tabelaLogin.Size = new System.Drawing.Size(357, 399);
            this.tabelaLogin.TabIndex = 2;
            this.tabelaLogin.TabStop = false;
            // 
            // txt_solucao
            // 
            this.txt_solucao.FormattingEnabled = true;
            this.txt_solucao.ItemHeight = 13;
            this.txt_solucao.Items.AddRange(new object[] {
            resources.GetString("txt_solucao.Items"),
            resources.GetString("txt_solucao.Items1"),
            resources.GetString("txt_solucao.Items2"),
            resources.GetString("txt_solucao.Items3"),
            resources.GetString("txt_solucao.Items4")});
            this.txt_solucao.Location = new System.Drawing.Point(27, 258);
            this.txt_solucao.Name = "txt_solucao";
            this.txt_solucao.Size = new System.Drawing.Size(296, 21);
            this.txt_solucao.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 55);
            this.label3.TabIndex = 6;
            this.label3.Text = "PROBLEMAS";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(237, 337);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 5;
            this.btCadastrar.Text = "Adicionar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btVoltar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.Location = new System.Drawing.Point(27, 337);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 4;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // txt_problema
            // 
            this.txt_problema.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_problema.Location = new System.Drawing.Point(27, 140);
            this.txt_problema.Multiline = true;
            this.txt_problema.Name = "txt_problema";
            this.txt_problema.Size = new System.Drawing.Size(296, 85);
            this.txt_problema.TabIndex = 2;
            this.txt_problema.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Solução";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Problema";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Frm_AddProblema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 545);
            this.Controls.Add(this.tabelaLogin);
            this.Name = "Frm_AddProblema";
            this.Text = "Form_AddProblema";
            this.Load += new System.EventHandler(this.Form_AddProblema_Load);
            this.tabelaLogin.ResumeLayout(false);
            this.tabelaLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tabelaLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_solucao;
        private System.Windows.Forms.TextBox txt_problema;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}