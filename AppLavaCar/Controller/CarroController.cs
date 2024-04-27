﻿using AppLavaCar.Model;
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
        public List<Carro> listaCarro()
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
                carro.placaCarro = dr["plcaCarro"].ToString();
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
        public void Inserir(string placaCarro, string nomeDono, string cpfDono,string marca, string modelo)
        {
            string sql = "INSERT INTO carro(placaCarro,nomeDono,cpfDono,marca,modelo) VALUES(@placaCarro,@nomeDono,@cpfDono,@marca,@modelo)";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@placaCarro", MySqlDbType.VarChar).Value = placaCarro;
                cmd.Parameters.Add("@nomeDono", MySqlDbType.VarChar).Value = nomeDono;
                cmd.Parameters.Add("@cpfDono", MySqlDbType.VarChar).Value = cpfDono;
                cmd.Parameters.Add("@marca",MySqlDbType.VarChar).Value = marca;
                cmd.Parameters.Add("@modelo",MySqlDbType.VarChar).Value=modelo;
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
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("@placaCarro", MySqlDbType.VarChar).Value = placaCarro;
                cmd.Parameters.Add("@nomeDono", MySqlDbType.VarChar).Value = nomeDono;
                cmd.Parameters.Add("@cpfDono", MySqlDbType.VarChar).Value = cpfDono;
                cmd.Parameters.Add("@marca", MySqlDbType.VarChar).Value = marca;
                cmd.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = modelo;
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

        public Carro Localizar(string placaDono)
        {
            Carro carro = new Carro();
            string sql = "SELECT * FROM carro WHERE cpf='" + placaDono + "'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
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

        public bool RegistroRepetido( string cpfDono, string placaCarro)
        {
            string sql = "SELECT * FROM carro WHERE cpfDono='" + cpfDono + "' AND placaCarro='" + placaCarro + "'";
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