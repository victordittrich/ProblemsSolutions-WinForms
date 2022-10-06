using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionsApp
{
    class DBsolutions
    {
        //conecção com database 
        public static MySqlConnection GetMySqlConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=root;database=situationsapp";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro na conecção com o banco de dados!\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            return con;

        }
        //função pra cadastrar cliente
        public static void AddCliente(Cliente std, string usuario, string senha)
        {
            string sql = "INSERT INTO clientes VALUES (NULL, '"+usuario+ "', '" + senha + "')";
            MySqlConnection con = GetMySqlConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Adicionado no banco de dados!\n ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao adicionar no banco de dados!\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
        }

        //função para verificar se existe o cadatro no database (login)
        public static void LoginCliente(Cliente std, string user, string senha)
        {
            string sql = "SELECT `usuario`, `senha` FROM `clientes` WHERE usuario = '"+user+"' AND senha = '"+senha+"'";
            MySqlConnection con = GetMySqlConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Clienteusuario", MySqlDbType.VarChar).Value = std.usuario;
            cmd.Parameters.Add("@Clientesenha", MySqlDbType.VarChar).Value = std.senha;
            MySqlDataReader logado = cmd.ExecuteReader();
            if (logado.HasRows)
            {
                
                Frm_Problems pbm = new Frm_Problems(user);
                pbm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário o senha inválidos!");
            }
            con.Close();
        }

        //função para cadastrar um problema, solução...
        public static void AddProblema(Cliente std,string usuario, string problema, string solucao)
        {
            var DateAndTime = DateTime.Now;
            var date = DateAndTime.Date.ToString("dd-MM-yyyy");
            string sql = "INSERT INTO problemas VALUES (NULL, '"+usuario+"', '"+problema+"', '"+solucao+"', '"+date+"')";
            MySqlConnection con = GetMySqlConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Adicionado no banco de dados!\n ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao adicionar no banco de dados!\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            con.Close();
        }


        //função para listar os problemas e soluções cadastrados
        public static void Display(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetMySqlConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }


    }
}
