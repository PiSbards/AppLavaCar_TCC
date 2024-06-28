using AppLavaCar.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLavaCar.Controller
{
    public class CarroController
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\AppLavaCar\\AppLavaCar\\DbLavaCarro.mdf;Integrated Security=True");
        public List<Carro> listaCarro()
        {
            List<Carro> li = new List<Carro>();
            string sql = "SELECT * FROM carro";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Carro carro = new Carro();
                carro.id = (int)dr["id"];
                carro.placaCarro = dr["placaCarro"].ToString();
                carro.nomeDono = dr["nomeDono"].ToString();
                carro.cpfDono = dr["cpfDono"].ToString();
                carro.marca = dr["marca"].ToString();
                carro.modelo = dr["modelo"].ToString();
                li.Add(carro);
            }
            dr.Close();
            conn.Close();
            return li;
        }
        public void Inserir(string placaCarro, string nomeDono, string cpfDono, string marca, string modelo)
        {
            string sql = "INSERT INTO carro(placaCarro,nomeDono,cpfDono,marca,modelo) VALUES(@placaCarro,@nomeDono,@cpfDono,@marca,@modelo)";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@placaCarro", SqlDbType.VarChar).Value = placaCarro;
                cmd.Parameters.Add("@nomeDono", SqlDbType.VarChar).Value = nomeDono;
                cmd.Parameters.Add("@cpfDono", SqlDbType.VarChar).Value = cpfDono;
                cmd.Parameters.Add("@marca", SqlDbType.VarChar).Value = marca;
                cmd.Parameters.Add("@modelo", SqlDbType.VarChar).Value = modelo;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }
        public void Atualizar(int id, string placaCarro, string nomeDono, string cpfDono, string marca, string modelo)
        {
            string sql = "UPDATE carro SET placaCarro=@placaCarro,nomeDono=@nomeDono,cpfDono=@cpfDono,marca=@marca,modelo=@modelo WHERE id=@id";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@placaCarro", SqlDbType.VarChar).Value = placaCarro;
                cmd.Parameters.Add("@nomeDono", SqlDbType.VarChar).Value = nomeDono;
                cmd.Parameters.Add("@cpfDono", SqlDbType.VarChar).Value = cpfDono;
                cmd.Parameters.Add("@marca", SqlDbType.VarChar).Value = marca;
                cmd.Parameters.Add("@modelo", SqlDbType.VarChar).Value = modelo;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
        public void Excluir(int id)
        {
            string sql = "DELETE FROM carro WHERE id='" + id + "'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Carro LocalizarPelaPlaca(string placaCarro)
        {
            Carro carro = new Carro();
            string sql = "SELECT * FROM carro WHERE placaCarro='" + placaCarro + "'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                carro.id = (int)dr["id"];
                carro.placaCarro = dr["placaCarro"].ToString();
                carro.nomeDono = dr["nomeDono"].ToString();
                carro.cpfDono = dr["cpfDono"].ToString();
                carro.modelo = dr["modelo"].ToString();
                carro.marca = dr["marca"].ToString();
            }
            dr.Close();
            conn.Close();
            return carro;
        }

        public bool RegistroRepetido(string placaCarro)
        {
            string sql = "SELECT * FROM carro WHERE placaCarro='" + placaCarro + "'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return true;
            }
            conn.Close();
            return false;
        }
        public List<string> CarregaCbxCarro(string cpfDono)
        {
            string sql = "SELECT * FROM carro WHERE cpfDono='" + cpfDono + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            List<string> list = new List<string>();
            while (dr.Read())
            {
                list.Add(dr["placaCarro"].ToString());
            }
            return list;
        }
    }
}
