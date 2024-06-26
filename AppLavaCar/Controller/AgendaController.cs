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
    public class AgendaController
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\AppLavaCar\\AppLavaCar\\DbLavaCarro.mdf;Integrated Security=True");

        public List<Agenda> listaAgendaDia()
        {
            List<Agenda> li = new List<Agenda>();
            string sql = "SELECT * FROM agenda WHERE DATE(agendamento) = CURDATE()";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Agenda agenda = new Agenda();
                agenda.id = (int)dr["id"];
                agenda.nomeCliente = dr["nomeCliente"].ToString();
                agenda.cpf = dr["cpf"].ToString();
                agenda.telefone = dr["telefone"].ToString();
                agenda.placaCarro = dr["placaCarro"].ToString();
                agenda.tipoTratamento = dr["tipoTratamento"].ToString();
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
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add(new SqlParameter("@data",data));
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Agenda agenda = new Agenda();
                agenda.id = (int)dr["id"];
                agenda.nomeCliente = dr["nomeCliente"].ToString();
                agenda.cpf = dr["cpf"].ToString();
                agenda.telefone = dr["telefone"].ToString();
                agenda.placaCarro = dr["placaCarro"].ToString();
                agenda.tipoTratamento = dr["tipoTratamento"].ToString();
                agenda.agendamento = (DateTime)dr["agendamento"];
                li.Add(agenda);
            }
            dr.Close();
            conn.Close();
            return li;
        }        
        public void AlterarAgendamento(int id, string nome, string cpf, string telefone, string placaCarro, string tipoTratamento, DateTime agendamento)
        {
            string sql = "UPDATE agenda SET nomeCliente=@nomeCliente,cpf=@cpf,telefone=@telefone,tipoTratamento=@tipoTratamento," +
                "placaCarro=@placaCarro,agendamento=@agendamento WHERE id=@id";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@nomeCliente", SqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = telefone;
                cmd.Parameters.Add("@placaCarro", SqlDbType.VarChar).Value = placaCarro;
                cmd.Parameters.Add("@tipoTratamento", SqlDbType.VarChar).Value = tipoTratamento;
                cmd.Parameters.Add("@agendamento", SqlDbType.DateTime).Value = agendamento;

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            conn.Close();
        }
        public void AgendarCliente(string nome, string cpf, string telefone, string placaCarro, string tipoTratamento, DateTime agendamento)
        {
            string sql = "INSERT INTO agenda(nomeCliente,cpf,telefone,placaCarro,tipoTratamento,agendamento) VALUES(@nomeCliente,@cpf,@telefone,@placaCarro,@tipoTratamento,@agendamento)";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }            
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.Add("@nomeCliente", SqlDbType.VarChar).Value = nome;
                cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = telefone;
                cmd.Parameters.Add("@placaCarro", SqlDbType.VarChar).Value = placaCarro;
                cmd.Parameters.Add("@tipoTratamento", SqlDbType.VarChar).Value = tipoTratamento;
                cmd.Parameters.Add("@agendamento", SqlDbType.DateTime).Value = agendamento;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            conn.Close();
        }
        public void ExcluirAgendamento(int id)
        {
            string sql = "DELETE FROM agenda WHERE id='" + id + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
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
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                agenda.id = (int)dr["id"];
                agenda.cpf = dr["cpf"].ToString();
                agenda.nomeCliente = dr["nomeCliente"].ToString();
                agenda.telefone = dr["telefone"].ToString();
                agenda.placaCarro = dr["placaCarro"].ToString();
                agenda.tipoTratamento = dr["tipoTratamento"].ToString();
                agenda.agendamento = (DateTime)dr["agendamento"];
            }
            dr.Close();
            conn.Close();
            return agenda;
        }
    }
}
