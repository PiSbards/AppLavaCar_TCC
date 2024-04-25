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
    public class AgendaController
    {
        MySqlConnection conn = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_DbProvisorio;user id=freedb_PipsProvisorio;password=8Jc4zG&SThRn#H4;charset=utf8");

        public List<Agenda> listaAgendaDia()
        {
            List<Agenda> li = new List<Agenda>();
            string sql = "SELECT * FROM agenda WHERE DATE(agendamento) = CURDATE()";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Agenda agenda = new Agenda();
                agenda.id = (int)dr["id"];
                agenda.nomeCliente = dr["nomeCliente"].ToString();
                agenda.cpf = dr["cpf"].ToString();
                agenda.telefone = dr["telefone"].ToString();
                agenda.tipoTratamento = dr["tipoTratamento"].ToString();
                agenda.placaCarro = dr["placaCarro"].ToString();
                agenda.agendamento = (DateTime)dr["agendamento"];
                li.Add(agenda);
            }
            dr.Close();
            conn.Close();
            return li;
        }
        public List<Agenda> listaAgendaSelecionada(DateTime data)
        {
            List<Agenda> li = new List<Agenda>();
            data.ToString("yyyy/MM/dd");
            string sql = "SELECT * FROM agenda WHERE DATE(agendamento) = @data";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.Add(new MySqlParameter("data",data));
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Agenda agenda = new Agenda();
                agenda.id = (int)dr["id"];
                agenda.nomeCliente = dr["nomeCliente"].ToString();
                agenda.cpf = dr["cpf"].ToString();
                agenda.telefone = dr["telefone"].ToString();
                agenda.tipoTratamento = dr["tipoTratamento"].ToString();
                agenda.placaCarro = dr["placaCarro"].ToString();
                agenda.agendamento = (DateTime)dr["agendamento"];
                li.Add(agenda);
            }
            dr.Close();
            conn.Close();
            return li;
        }        
        public void AlterarAgendamento(int id, string nome, string cpf, string telefone, string placaCarro, string tipoTratamento, DateTime agendamento)
        {
            string sql = "UPDATE agendamento SET nomeCliente=@nomeCliente,cpf=@cpf,telefone=@telefone,tipoTratamento=@tipoTratamento,placaCarro=@placaCarro WHERE id=@id";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("@nomeCliente", MySqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;
                cmd.Parameters.Add("@tipoTratamento", MySqlDbType.VarChar).Value = tipoTratamento;
                cmd.Parameters.Add("@placaCarro", MySqlDbType.VarChar).Value = placaCarro;
                cmd.Parameters.Add("@agendamento", MySqlDbType.DateTime).Value = agendamento;

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
        public void AgendarCliente(string nome, string cpf, string telefone, string placaCarro, string tipoTratamento, DateTime agendamento)
        {
            string sql = "INSERT INTO agenda(nome,cpf,telefone,placaCarro,tipoTratamento,agendamento) VALUES(@nome,@cpf,@telefone,@placaCarro,@tipoTratamento,@agendamento)";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }            
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;
                cmd.Parameters.Add("@placaCarro", MySqlDbType.VarChar).Value = placaCarro;
                cmd.Parameters.Add("@tipoTratamento", MySqlDbType.VarChar).Value = tipoTratamento;
                cmd.Parameters.Add("@agendamento", MySqlDbType.DateTime).Value = agendamento;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }
        public void ExcluirAgendamento(int id)
        {
            string sql = "DELETE * FROM agenda WHERE id='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public Agenda localizarAgenda(int id)
        {
            Agenda agenda = new Agenda();
            string sql = "SELECT * FROM agenda WHERE id='" + id + "'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                agenda.id = (int)dr["id"];
                agenda.cpf = dr["cpf"].ToString();
                agenda.nomeCliente = dr["nomeCliente"].ToString();
                agenda.placaCarro = dr["placaCarro"].ToString();
                agenda.telefone = dr["telefone"].ToString();
                agenda.tipoTratamento = dr["tipoTratamento"].ToString();
                agenda.agendamento = (DateTime)dr["agendamento"];
            }
            dr.Close();
            conn.Close();
            return agenda;
        }
    }
}
