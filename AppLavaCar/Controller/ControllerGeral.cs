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
        public void AtualizarGraficos(System.Windows.Forms.DataVisualization.Charting.Chart chTipoTratamento, System.Windows.Forms.DataVisualization.Charting.Chart chSituacao)
        {
            string sql = "SELECT tipoTratamento, COUNT(id) as total FROM checkout GROUP BY tipoTratamento";
            string sql2 = "SELECT 'agenda' AS tabela, COUNT(id) AS total FROM agenda " +
                "UNION ALL SELECT 'checkin' AS tabela, COUNT(id) AS total FROM checkin " +
                "UNION ALL SELECT 'checkout' AS tabela, COUNT(id) AS total FROM checkout";

            using (conn)
            {
                try
                {
                    conn.Open();

                    chTipoTratamento.Series["Total"].Points.Clear();
                    chSituacao.Series["Total"].Points.Clear();

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                chTipoTratamento.Series["Total"].Points.AddXY(dataReader.GetString("tipoTratamento"), dataReader.GetInt32("total"));
                            }
                        }
                    }

                    using (MySqlCommand cmd2 = new MySqlCommand(sql2, conn))
                    {
                        using (MySqlDataReader dataReader2 = cmd2.ExecuteReader())
                        {
                            while (dataReader2.Read())
                            {
                                chSituacao.Series["Total"].Points.AddXY(dataReader2.GetString("tabela"), dataReader2.GetInt32("total"));
                            }
                        }
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK);
                }
            }
        }
        //public string indicadormodelo()
        //{
          //  string sql = "select ";
        //}
    }
}
