using AppLavaCar.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppLavaCar.Controller
{
    public class ClienteController
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\AppLavaCar\\AppLavaCar\\DbLavaCarro.mdf;Integrated Security=True");

        public List<Cliente> listaCliente()
        {
            List<Cliente> li = new List<Cliente>();
            string sql = "SELECT * FROM cliente";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Cliente cliente = new Cliente();
                cliente.id = (int)dr["id"];
                cliente.cpf = dr["cpf"].ToString();
                cliente.nome = dr["nome"].ToString();
                cliente.telefone = dr["telefone"].ToString();
                li.Add(cliente);
            }
            dr.Close();
            conn.Close();
            return li;
        }

        public void Inserir(string nome, string cpf, string telefone)
        {
            string sql = "INSERT INTO cliente(nome,cpf,telefone) VALUES(@nome,@cpf,@telefone)";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = telefone;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        public void Atualizar(int id, string nome, string cpf, string telefone)
        {
            string sql = "UPDATE cliente SET nome=@nome,cpf=@cpf,telefone=@telefone WHERE id=@id";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = telefone;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        public void Excluir(int id)
        {
            string sql = "DELETE FROM cliente WHERE id=@id";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }

        public Cliente Localizar(string cpf)
        {
            Cliente cliente = null;
            string sql = "SELECT * FROM cliente WHERE cpf = @cpf";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            cliente = new Cliente
                            {
                                id = (int)dr["id"],
                                nome = dr["nome"].ToString(),
                                cpf = dr["cpf"].ToString(),
                                telefone = dr["telefone"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception)
            {
                cliente = null;
            }
            finally
            {
                conn.Close();
            }
            return cliente;
        }

        public bool RegistroRepetido(string cpf)
        {
            string sql = "SELECT COUNT(*) FROM cliente WHERE cpf='" + cpf + "'";
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
