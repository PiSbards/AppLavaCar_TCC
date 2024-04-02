using AppLavaCar.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLavaCar.Controller
{
    public class CarroController
    {
        MySqlConnection conn = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_DbProvisorio;user id=freedb_PipsProvisorio;password=8Jc4zG&SThRn#H4;charset=utf8");

        public List<Carro> listaCarros()
        {
            List<Carro> li = new List<Carro>();
            string sql = "SELECT * FROM carro";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Carro carro = new Carro();
                carro.id = (int)dr["id"];
                carro.nomeDono = dr["cpf"].ToString();
                carro.marca = dr["marca"].ToString();
                carro.modelo = dr["modelo"].ToString();
                carro.placa = dr["placa"].ToString();                
                li.Add(carro);
            }
            dr.Close();
            conn.Close();
            return li;
        }
        public void Inserir(string nomeDono, string marca, string modelo, string placa)
        {
            string sql = "INSERT INTO carro(nomeDono,marca,modelo,placa) VALUES(@nomeDono,@marca,@modelo,@placa)";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nomeDono;
                cmd.Parameters.Add("@marca", MySqlDbType.VarChar).Value = marca;
                cmd.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = modelo;
                cmd.Parameters.Add("@placa", MySqlDbType.VarChar).Value = placa;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }

        public void Atualizar(int id, string nomeDono, string marca, string modelo, string placa)
        {
            string sql = "UPDATE carro SET marca=@marca,modelo=@modelo,placa=@placa,nomeDono=@nomeDono WHERE id=@id";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nomeDono;
                cmd.Parameters.Add("@marca", MySqlDbType.VarChar).Value = marca;
                cmd.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = modelo;
                cmd.Parameters.Add("@placa", MySqlDbType.VarChar).Value = placa;
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
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public Carro Localizar(int id)
        {
            Carro carro = new Carro();
            string sql = "SELECT * FROM carro WHERE id='" + id + "'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                carro.id = (int)dr["id"];
                carro.nomeDono = dr["cpf"].ToString();
                carro.marca = dr["marca"].ToString();
                carro.modelo = dr["modelo"].ToString();
                carro.placa = dr["placa"].ToString();
            }
            dr.Close();
            conn.Close();
            return carro;
        }

        public bool RegistroRepetido(string placa)
        {
            string sql = "SELECT * FROM carro WHERE placa='" + placa + "'";
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
