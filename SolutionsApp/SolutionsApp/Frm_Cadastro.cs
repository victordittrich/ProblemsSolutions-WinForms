using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionsApp
{
    public partial class Frm_Cadastro : Form
    {
        public Frm_Cadastro()
        {
            InitializeComponent();
        }
        //função de limpar caixas de texto, só de zoas.
        public void Clear()
        {
            txt_usuario.Text = txt_senha.Text = txt_csenha.Text = string.Empty;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
        //verifica o cadastro (senhas curtas, diferentes, nome de usuario curto... etc)
        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if(txt_usuario.Text.Trim().Length < 3)
            {
                MessageBox.Show("Usuário curto demais! Mínimo 4 carac.");
                txt_usuario.Text = string.Empty;
                return;
            }
            if(txt_senha.Text.Trim().Length < 8)
            {
                MessageBox.Show("Senha curta demais! Mínimo 8 Carac.");
                txt_senha.Text = txt_csenha.Text = string.Empty;
                return;
            }
            if(txt_senha.Text != txt_csenha.Text)
            {
                MessageBox.Show("Senhas diferentes!");
                txt_senha.Text = txt_csenha.Text = string.Empty;
                return;
            }
            if (btCadastrar.Text == "Cadastrar")
            {
                Cliente std = new Cliente(txt_usuario.Text.Trim(), txt_senha.Text.Trim());
                DBsolutions.AddCliente(std, txt_usuario.Text.Trim(), txt_senha.Text.Trim());
                Clear();
            }
            this.Close();

        }

        private void Frm_Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
