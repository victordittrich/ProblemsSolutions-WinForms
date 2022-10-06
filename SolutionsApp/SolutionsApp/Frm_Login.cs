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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

         
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //se não tiver login, vai pro cadastrar
            Frm_Cadastro cad = new Frm_Cadastro();
            cad.ShowDialog();
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            //chama a função logincliente para verificar o login
            Cliente std = new Cliente(txt_usuario.Text.Trim(), txt_senha.Text.Trim());
            DBsolutions.LoginCliente(std, txt_usuario.Text.Trim(), txt_senha.Text.Trim());
            
            
        }
        

    }
}
