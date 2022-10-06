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
    public partial class Frm_Problems : Form
    {
        public Frm_Problems(string user)
        {
            InitializeComponent();
            usuario = user;
        }

        //fazendo minhas macaquice, passando variável pra la e pra cá. testes...

        string usuario = "";

     
        public void Display()
        {
            DBsolutions.Display("SELECT `id`, `usuario`, `problema`, `solucao`, `data` FROM `problemas`", dataGridView);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            //adicionar novo problema
            this.Hide();
            Frm_AddProblema f = new Frm_AddProblema(usuario);
            f.Closed += (s, args) => this.Close();
            f.ShowDialog();
            
        }

        private void Frm_Problems_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Frm_Problems_Shown(object sender, EventArgs e)
        {
        }

        private void Frm_Problems_Shown_1(object sender, EventArgs e)
        {
            //lista os problemas e soluções cadastrados, assim que carregar o formulario
            Display();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_Problems_Click(object sender, EventArgs e)
        {
        }
    }
}
