using AppLavaCar.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppLavaCar.Controller
{
    public class UsuarioController
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\AppLavaCar\\AppLavaCar\\DbLavaCarro.mdf;Integrated Security=True");

        public void AlterarSenha(string senha, string cpf)
        {
            string sql = "UPDATE funcionario SET senha=@senha WHERE cpf=@cpf";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {                                
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
        public Funcionario Login(string cpf, string senha)
        {
            Funcionario funcionario = new Funcionario();
            string sql = "SELECT * FROM funcionario WHERE cpf='" + cpf + "'AND senha='"+senha+"'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                funcionario.id = (int)dr["id"];
                funcionario.nome = dr["nome"].ToString();
                funcionario.cpf = dr["cpf"].ToString();
                funcionario.senha = dr["senha"].ToString();
                funcionario.email = dr["email"].ToString();
                var gerente = dr["gerente"];
                if (Convert.ToInt32(gerente) == 1)
                {
                    funcionario.gerente = "SIM";
                }
                else
                {
                    funcionario.gerente = "NÃO";
                }

            }
            dr.Close();
            conn.Close();
            return funcionario;
        }
        public List<Funcionario> listaFuncionario()
        {
            List<Funcionario> li = new List<Funcionario>();
            string sql = "SELECT * FROM funcionario";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Funcionario func = new Funcionario();
                func.id = (int)dr["id"];
                func.cpf = dr["cpf"].ToString();
                func.nome = dr["nome"].ToString();
                func.senha = dr["senha"].ToString();
                func.email = dr["email"].ToString();
                int gerente = (int)dr["gerente"];
                if (gerente == 1)
                {
                    func.gerente = "SIM";
                }
                else
                {
                    func.gerente = "NÃO";
                }

                li.Add(func);
            }
            dr.Close();
            conn.Close();
            return li;
        }
        public void Inserir(string nome, string cpf, string senha, string email, bool gerente)
        {
            string sql = "INSERT INTO funcionario(nome,cpf,senha,email,gerente) VALUES(@nome,@cpf,@senha,@email,@gerente)";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@gerente", SqlDbType.TinyInt).Value = gerente;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }

        public void Atualizar(int id,string nome, string cpf, string senha, string email, bool gerente)
        {
            string sql = "UPDATE funcionario SET nome=@nome,cpf=@cpf,senha=@senha,gerente=@gerente WHERE id=@id";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@gerente", SqlDbType.TinyInt).Value = gerente;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
        public void Excluir(int id)
        {
            string sql = "DELETE FROM funcionario WHERE id='" + id + "'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public Funcionario Localizar(int id)
        {
            Funcionario funcionario = new Funcionario();
            string sql = "SELECT * FROM funcionario WHERE id='" + id + "'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                funcionario.id = (int)dr["id"];
                funcionario.nome = dr["nome"].ToString();
                funcionario.cpf = dr["cpf"].ToString();
                funcionario.senha = dr["epi"].ToString();
                funcionario.email = dr["email"].ToString();
                int gerente = (int)dr["gerente"];
                if (gerente == 1)
                {
                    funcionario.gerente = "SIM";
                }
                else
                {
                    funcionario.gerente = "NÃO";
                }
                
            }
            dr.Close();
            conn.Close();
            return funcionario;
        }
        public bool LocalizarPorCPF(string cpf)
        {
            string sql = "SELECT * FROM funcionario WHERE cpf='" + cpf + "'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return (int)result > 0;
            }
            conn.Close();
            return false;
        }

        public bool RegistroRepetido(string nome, string cpf, string email)
        {
            string sql = "SELECT * FROM funcionario WHERE nome='" + nome + "' AND cpf='" + cpf + "' AND email='"+email+"'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return (int)result > 0;
            }
            conn.Close();
            return false;
        }
    }
}
