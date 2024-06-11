using AppLavaCar.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AppLavaCar.Controller
{
    public class ControllerGeral
    {
        private string connectionString = "server=sql.freedb.tech;port=3306;database=freedb_DbProvisorio;user id=freedb_PipsProvisorio;password=8Jc4zG&SThRn#H4;charset=utf8";

        public DateTime[] BoldDates()
        {
            string sql = "SELECT agendamento FROM agenda";
            List<DateTime> li = new List<DateTime>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            li.Add((DateTime)dr["agendamento"]);
                        }
                    }
                }
            }

            return li.ToArray();
        }

        public void AtualizarGraficos(System.Windows.Forms.DataVisualization.Charting.Chart chTipoTratamento, System.Windows.Forms.DataVisualization.Charting.Chart chSituacao)
        {
            string sql = "SELECT tipoTratamento, COUNT(id) as total FROM checkout GROUP BY tipoTratamento";
            string sql2 = "SELECT 'agenda' AS tabela, COUNT(id) AS total FROM agenda " +
                          "UNION ALL SELECT 'checkin' AS tabela, COUNT(id) AS total FROM checkin " +
                          "UNION ALL SELECT 'checkout' AS tabela, COUNT(id) AS total FROM checkout";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
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
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK);
            }
        }

        public string IndicadorModelo()
        {
            string sql = "SELECT c.modelo, COUNT(*) as count FROM carro c, checkout ch WHERE c.placaCarro = ch.placaCarro GROUP BY c.modelo ORDER BY count DESC LIMIT 1";
            string result = "";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = dr["modelo"].ToString();
                        }
                    }
                }
            }

            return result;
        }
        public string IndicadorTipoTratamento()
        {
            string sql = "SELECT tipoTratamento, count(*) as count FROM checkout GROUP BY tipoTratamento ORDER BY count DESC LIMIT 1";
            string result = "";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = dr["tipoTratamento"].ToString();
                        }
                    }
                }
            }

            return result;
        }
        public List<string> ObterTop3Clientes()
        {
            List<string> resultados = new List<string>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT nomeCliente, cpf, COUNT(*) as count FROM checkout GROUP BY nomeCliente ORDER BY count DESC LIMIT 3";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string nomeCliente = dr["nomeCliente"].ToString();
                                string cpf = dr["cpf"].ToString();
                                string count = dr["count"].ToString();

                                string resultado = $"Nome: {nomeCliente}, CPF: {cpf}";
                                resultados.Add(resultado);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter os top 3 clientes: " + ex.Message);
            }

            return resultados;
        }

    }

}
