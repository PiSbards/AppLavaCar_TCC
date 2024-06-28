using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppLavaCar.Controller
{
    public class ControllerGeral
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\AppLavaCar\\AppLavaCar\\DbLavaCarro.mdf;Integrated Security=True";

        public DateTime[] BoldDates()
        {
            string sql = "SELECT agendamento FROM agenda";
            List<DateTime> li = new List<DateTime>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
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
            /*string sql2 = "SELECT 'agenda' AS tabela, COUNT(id) AS total FROM agenda " +
                          "UNION ALL SELECT 'checkin' AS tabela, COUNT(id) AS total FROM checkin " +
                          "UNION ALL SELECT 'checkout' AS tabela, COUNT(id) AS total FROM checkout";*/
            string sql2 = "SELECT 'agenda' AS tabela, COUNT(id) AS total FROM agenda WHERE DATEPART(YEAR, agendamento) = DATEPART(YEAR, GETDATE()) AND DATEPART(MONTH, agendamento) = DATEPART(MONTH, GETDATE())" +
                " UNION ALL SELECT 'checkin' AS tabela, COUNT(id) AS total FROM checkin WHERE DATEPART(YEAR, agendamento) = DATEPART(YEAR, GETDATE()) AND DATEPART(MONTH, agendamento) = DATEPART(MONTH, GETDATE())" +
                " UNION ALL SELECT 'checkout' AS tabela, COUNT(id) AS total FROM checkout WHERE DATEPART(YEAR, agendamento) = DATEPART(YEAR, GETDATE()) AND DATEPART(MONTH, agendamento) = DATEPART(MONTH, GETDATE());";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    chTipoTratamento.Series["Total"].Points.Clear();
                    chSituacao.Series["Total"].Points.Clear();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {
                                string tipoTratamento = dataReader["tipoTratamento"].ToString();
                                int total = Convert.ToInt32(dataReader["total"]);
                                chTipoTratamento.Series["Total"].Points.AddXY(tipoTratamento, total);
                            }
                        }
                    }

                    using (SqlCommand cmd2 = new SqlCommand(sql2, conn))
                    {
                        using (SqlDataReader dataReader2 = cmd2.ExecuteReader())
                        {
                            while (dataReader2.Read())
                            {
                                string tabela = dataReader2["tabela"].ToString();
                                int total = Convert.ToInt32(dataReader2["total"]);
                                chSituacao.Series["Total"].Points.AddXY(tabela, total);
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
            string sql = "SELECT c.modelo,c.marca, COUNT(*) as count FROM carro c, checkout ch WHERE c.placaCarro = ch.placaCarro GROUP BY c.modelo,c.marca ORDER BY count DESC";
            string result = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = dr["modelo"].ToString().Trim() + " " + dr["marca"].ToString().Trim();
                        }
                    }
                }
            }

            return result;
        }

        public string IndicadorTipoTratamento()
        {
            string sql = "SELECT tipoTratamento, count(*) as count FROM checkout GROUP BY tipoTratamento ORDER BY count DESC";
            string result = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = dr["tipoTratamento"].ToString().Trim();
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
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT nomeCliente, cpf, COUNT(*) as count FROM checkout GROUP BY nomeCliente,cpf ORDER BY count DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string nomeCliente = dr["nomeCliente"].ToString().Trim();
                                string cpf = dr["cpf"].ToString().Trim();

                                string resultado = $"Nome: {nomeCliente},\n CPF: {cpf}";
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
