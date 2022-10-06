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
    public partial class Frm_AddProblema : Form
    {


        public Frm_AddProblema()
        {
            InitializeComponent();
        }

        //fazendo macaquice, e brincando com a variável, relaxa.

        string user = "";

        public Frm_AddProblema(string usuario)
        {
            InitializeComponent();
            user = usuario;
        }


        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            //volta. kkk
            this.Hide();
            Frm_Problems f = new Frm_Problems(user);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }

        private void Form_AddProblema_Load(object sender, EventArgs e)
        {
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //chama a função de cadastrar que vem la da classe dbsolutions, passando como parâmetro os valores
            Cliente std = new Cliente(txt_problema.Text, txt_solucao.Text);
            DBsolutions.AddProblema(std,user, txt_problema.Text, txt_solucao.Text);
            this.Hide();
            Frm_Problems f = new Frm_Problems(user);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
        }
    }
}
