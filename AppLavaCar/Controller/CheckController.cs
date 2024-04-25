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
    public class CheckController
    {
        MySqlConnection conn = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_DbProvisorio;user id=freedb_PipsProvisorio;password=8Jc4zG&SThRn#H4;charset=utf8");
        public List<CheckIn> listaCheckin()
        {
            List<CheckIn> li = new List<CheckIn>();
            string sql = "SELECT * FROM checkin";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CheckIn check = new CheckIn();
                check.id = (int)dr["id"];
                check.nomeCliente = dr["nomeCliente"].ToString();
                check.cpf = dr["cpf"].ToString();
                check.telefone = dr["telefone"].ToString();
                check.defeitos = dr["defeitos"].ToString();
                check.clienteCiente = dr["clienteCiente"].ToString();                
                check.tipoTratamento = dr["tipoTratamento"].ToString();
                check.placaCarro = dr["placaCarro"].ToString();
                check.agendamento = (DateTime)dr["agendamento"];
                check.observacao1 = dr["observacao1"].ToString();
                check.imagem1 = dr["imagem1"].ToString();
                check.imagem2 = dr["imagem2"].ToString();
                check.imagem3 = dr["imagem3"].ToString();
                check.imagem4 = dr["imagem4"].ToString();
                check.imagem5 = dr["imagem5"].ToString();
                li.Add(check);
            }
            dr.Close();
            conn.Close();
            return li;
        }        
        public void InserirCheckIn(string nome, string cpf, string telefone,string defeitos,string clienteCiente,string tipoTratamento , string placaCarro,
            DateTime agendamento, string observacao1, string imagem1,string imagem2,string imagem3,string imagem4,string imagem5)
        {
            string sql = "INSERT INTO checkin(nome,cpf,telefone,defeitos,clienteCiente,tipoTratamento,placaCarro,agendamento,observacao,imagem1" +
                "imagem2,imagem3,imagem4,imagem5) VALUES(@nome,@cpf,@telefone,@defeitos,@clienteCiente,@tipoTratamento,@placaCarro,@agendamento," +
                "@observacao1,@imagem1,@imagem2,@imagem3,@imagem4,@imagem5)";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;
                cmd.Parameters.Add("@defeitos",MySqlDbType.VarChar).Value = defeitos;
                cmd.Parameters.Add("@clienteCiente",MySqlDbType.VarChar).Value= clienteCiente;                
                cmd.Parameters.Add("@tipoTratamento", MySqlDbType.VarChar).Value = tipoTratamento;
                cmd.Parameters.Add("@placaCarro", MySqlDbType.VarChar).Value = placaCarro;
                cmd.Parameters.Add("@agendamento", MySqlDbType.DateTime).Value = agendamento;
                cmd.Parameters.Add("@observacao1", MySqlDbType.VarChar).Value = observacao1;
                cmd.Parameters.Add("@imagem1", MySqlDbType.VarChar).Value = imagem1;
                cmd.Parameters.Add("@imagem2", MySqlDbType.VarChar).Value = imagem2;
                cmd.Parameters.Add("@imagem3", MySqlDbType.VarChar).Value = imagem3;
                cmd.Parameters.Add("@imagem4", MySqlDbType.VarChar).Value = imagem4;
                cmd.Parameters.Add("@imagem5", MySqlDbType.VarChar).Value = imagem5;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }
        public void ExcluirCheckin(int id)
        {
            string sql = "DELETE * FROM checkin WHERE id='" + id + "'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<CheckOut> listaCheckOut()
        {
            List<CheckOut> li = new List<CheckOut>();
            string sql = "SELECT * FROM checkout";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CheckOut check = new CheckOut();
                check.id = (int)dr["id"];
                check.nomeCliente = dr["nomeCliente"].ToString();
                check.cpf = dr["cpf"].ToString();
                check.telefone = dr["telefone"].ToString();
                check.clienteCiente = dr["clienteCiente"].ToString();
                check.tipoTratamento = dr["tipoTratamento"].ToString();
                check.defeitos = dr["defeitos"].ToString();
                check.placaCarro = dr["placaCarro"].ToString();
                check.agendamento = (DateTime)dr["agendamento"];
                check.pagamento= dr["pagamento"].ToString();                
                check.observacao = dr["observacao1"].ToString();
                check.imagem1 = dr["imagem1"].ToString();
                check.imagem2 = dr["imagem2"].ToString();
                check.imagem3 = dr["imagem3"].ToString();
                check.imagem4 = dr["imagem4"].ToString();
                check.imagem5 = dr["imagem5"].ToString();
                li.Add(check);
            }
            dr.Close();
            conn.Close();
            return li;
        }
        public void InserirCheckOut(string nome, string cpf, string telefone, string defeitos, string clienteCiente, string tipoTratamento, string placaCarro, 
            DateTime agendamento,string pagamento, string observacao, string imagem1,string imagem2, string imagem3, string imagem4, string imagem5)
        {
            string sql = "INSERT INTO checkout(nome,cpf,telefone,defeitos,clienteCiente,tipoTratamento,placaCarro,agendamento,pagamento,observacao1,imagem1" +
                "imagem2,imagem3,imagem4,imagem5) VALUES(@nome,@cpf,@telefone,@defeitos,@clienteCiente,@tipoTratamento,@placaCarro,@agendamento,@pagamento" +
                "@observacao,@imagem1,@imagem2,@imagem3,@imagem4,@imagem5)";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;
                cmd.Parameters.Add("@defeitos", MySqlDbType.VarChar).Value = defeitos;
                cmd.Parameters.Add("@clienteCiente", MySqlDbType.VarChar).Value = clienteCiente;
                cmd.Parameters.Add("@tipoTratamento", MySqlDbType.VarChar).Value = tipoTratamento;
                cmd.Parameters.Add("@placaCarro", MySqlDbType.VarChar).Value = placaCarro;
                cmd.Parameters.Add("@agendamento", MySqlDbType.DateTime).Value = agendamento;
                cmd.Parameters.Add("@pagamento", MySqlDbType.VarChar).Value = pagamento;
                cmd.Parameters.Add("@observacao1", MySqlDbType.VarChar).Value = observacao;
                cmd.Parameters.Add("@imagem1", MySqlDbType.VarChar).Value = imagem1;
                cmd.Parameters.Add("@imagem2", MySqlDbType.VarChar).Value = imagem2;
                cmd.Parameters.Add("@imagem3", MySqlDbType.VarChar).Value = imagem3;
                cmd.Parameters.Add("@imagem4", MySqlDbType.VarChar).Value = imagem4;
                cmd.Parameters.Add("@imagem5", MySqlDbType.VarChar).Value = imagem5;
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }
    }
}
