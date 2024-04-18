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
        MySqlConnection conn = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_DbProvisorio;user id=freedb_PipsProvisorio;password=8Jc4zG&SThRn#H4;charset=utf8");

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
                cliente.cpf = (int)dr["cpf"];
                cliente.nome = dr["nome"].ToString();
                cliente.telefone = dr["telefone"].ToString();
                cliente.placaCarro = dr["placaCarro"].ToString();
                cliente.marca = dr["marca"].ToString();
                cliente.modelo = dr["modelo"].ToString();
                li.Add(cliente);
            }
            dr.Close();
            conn.Close();
            return li;
        }
        
        public void Inserir(string nome, int cpf, string telefone, string placaCarro, string marca,string modelo)
        {
            string sql = "INSERT INTO cliente(nome,cpf,telefone,placaCarro,marca,modelo) VALUES(@nome,@cpf,@telefone,@placaCarro,@marca,@modelo)";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@cpf", MySqlDbType.Int32).Value = cpf;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;
                cmd.Parameters.Add("@placaCarro", MySqlDbType.VarChar).Value = placaCarro;
                cmd.Parameters.Add("@marca", MySqlDbType.VarChar).Value = marca;
                cmd.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = modelo;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }

        public void Atualizar(int id, string nome, int cpf, string telefone, string placaCarro,string marca,string modelo)
        {
            string sql = "UPDATE cliente SET nome=@nome,cpf=@cpf,telefone=@telefone,placaCarro=@placaCarro,marca=@marca,modelo=@modelo WHERE id=@id";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@cpf", MySqlDbType.Int32).Value = cpf;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;
                cmd.Parameters.Add("@placaCarro", MySqlDbType.VarChar).Value = placaCarro;
                cmd.Parameters.Add("@marca", MySqlDbType.VarChar).Value = marca;
                cmd.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = modelo;
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
        
        public Cliente Localizar(int cpf)
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
                cliente.cpf = (int)dr["cpf"];
                cliente.nome = dr["nome"].ToString();
                cliente.telefone = dr["telefone"].ToString();
                cliente.placaCarro = dr["placaCarro"].ToString();
                cliente.marca = dr["marca"].ToString();
                cliente.modelo = dr["modelo"].ToString();
            }
            dr.Close();
            conn.Close();
            return cliente;
        }

        public bool RegistroRepetido(string nome, int cpf,string placaCarro)
        {
            string sql = "SELECT * FROM cliente WHERE nome='" + nome + "' AND cpf='" + cpf + "' AND placaCarro='"+placaCarro+"'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            MySqlCommand cmd = new MySqlCommand(sql, conn);
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
