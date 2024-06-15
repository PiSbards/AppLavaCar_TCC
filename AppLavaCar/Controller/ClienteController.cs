using AppLavaCar.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppLavaCar.Controller
{
    public class ClienteController
    {
        MySqlConnection conn = new MySqlConnection("server=sql10.freesqldatabase.com;port=3306;database=sql10714021;user id=sql10714021;password=1G5JjAjZ5H;charset=utf8");

        public List<Cliente> listaCliente()
        {
            List<Cliente> li = new List<Cliente>();
            string sql = "SELECT * FROM cliente";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
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
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;                
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
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;                
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
        public void Excluir(int id)
        {
            string sql = "DELETE FROM cliente WHERE id='" + id + "'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        
        public Cliente Localizar(string cpf)
        {
            Cliente cliente = new Cliente();
            string sql = "SELECT * FROM cliente WHERE cpf='" + cpf + "'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {                
                cliente.id = (int)dr["id"];
                cliente.nome = dr["nome"].ToString();
                cliente.cpf = dr["cpf"].ToString();
                cliente.telefone = dr["telefone"].ToString();
                
            }
            dr.Close();
            conn.Close();
            return cliente;
        }

        public bool RegistroRepetido(string cpf)
        {
            string sql = "SELECT * FROM cliente WHERE AND cpf='" + cpf + "'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return true;
            }
            conn.Close();
            return false;
        }
        
        

    }
}
