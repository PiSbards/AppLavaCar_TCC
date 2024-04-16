using AppLavaCar.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppLavaCar.Controller
{
    public class ControllerGeral
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
                agenda.cpf = (int)dr["cpf"];
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
            string sql = "SELECT * FROM agenda WHERE DATE(agendamento) = '"+data+"'";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Agenda agenda = new Agenda();
                agenda.id = (int)dr["id"];
                agenda.nomeCliente = dr["nomeCliente"].ToString();
                agenda.cpf = (int)dr["cpf"];
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
        public List<Agenda> listaCheckin()
        {
            List<Agenda> li = new List<Agenda>();
            string sql = "SELECT * FROM checkin";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Agenda agenda = new Agenda();
                agenda.id = (int)dr["id"];
                agenda.nomeCliente = dr["nomeCliente"].ToString();
                agenda.cpf = (int)dr["cpf"];
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
        public DateTime[] BoldDates()
        {
            string sql = "SELECT agendamento FROM agenda";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand( sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            List<DateTime> li = new List<DateTime>();
            DateTime[] date;
            while(dr.Read())
            {
                li.Add((DateTime)dr["agendamento"]);
            }
            date = li.ToArray();
            dr.Close();
            conn.Close();
            return date;
        }

    }
}
