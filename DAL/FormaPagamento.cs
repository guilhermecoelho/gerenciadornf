using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaPagamento
{
    public class FormaPagamentoDAL
    {
        #region Search
        public static List<FormaPagamentoTO> listaFormaPagamentoAll()
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {
                List<FormaPagamentoTO> clsFormaPagamentos = new List<FormaPagamentoTO>();

                string strSql = "SELECT FormaPagamento.* FROM FormaPagamento";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();

                while (adap.Read())
                {
                    FormaPagamentoTO clsFormaPagamento = new FormaPagamentoTO();

                    clsFormaPagamento.IDFormaPagamento = Convert.ToInt32(adap["IDFormaPagamento"]);
                    clsFormaPagamento.Descricao = adap["Descricao"].ToString();
                    clsFormaPagamento.QtdParcela = Convert.ToInt32(adap["QtdParcela"]);
                    clsFormaPagamento.QtdDias = Convert.ToInt32(adap["QtdDias"]);
                    clsFormaPagamento.Indicador = adap["Indicador"].ToString();


                    clsFormaPagamentos.Add(clsFormaPagamento);
                }

                return clsFormaPagamentos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static FormaPagamentoTO GetFormaPagamentoByID(int IDFormaPagamento)
        {
            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {

                FormaPagamentoTO clsFormaPagamento = new FormaPagamentoTO();

                string strSql = "SELECT FormaPagamento.* FROM FormaPagamento WHERE FormaPagamento.IDFormaPagamento = @IDFormaPagamento";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.Parameters.AddWithValue("@IDFormaPagamento", IDFormaPagamento);
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();
                while (adap.Read())
                {
                    clsFormaPagamento.IDFormaPagamento = Convert.ToInt32(adap["IDFormaPagamento"]);
                    clsFormaPagamento.Descricao = adap["Descricao"].ToString();
                    clsFormaPagamento.QtdParcela = Convert.ToInt32(adap["QtdParcela"]);
                    clsFormaPagamento.QtdDias = Convert.ToInt32(adap["QtdDias"]);
                    clsFormaPagamento.Indicador = adap["Indicador"].ToString();
                }

                return clsFormaPagamento;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        #endregion
        #region Persistence
        public static void insert(FormaPagamentoTO clsFormaPagamento)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("INSERT INTO formapagamento(DESCRICAO,  QTDPARCELA, QTDDIAS, Indicador) VALUES (@DESCRICAO, @QTDPARCELA, @QTDDIAS, @Indicador);");
                strSql.Append("SELECT FormaPagamento.* FROM FormaPagamento WHERE FormaPagamento.IDFormaPagamento=@@IDENTITY;");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDFormaPagamento", clsFormaPagamento.IDFormaPagamento);
                cmd.Parameters.AddWithValue("@DESCRICAO", clsFormaPagamento.Descricao);
                cmd.Parameters.AddWithValue("@QTDPARCELA", clsFormaPagamento.QtdParcela);
                cmd.Parameters.AddWithValue("@QTDDIAS", clsFormaPagamento.QtdDias);
                cmd.Parameters.AddWithValue("@Indicador", clsFormaPagamento.Indicador);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public static Boolean Delete(FormaPagamentoTO clsFormaPagamento)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM FormaPagamento WHERE IDFormaPagamento=@IDFormaPagamento");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDFormaPagamento", clsFormaPagamento.IDFormaPagamento);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public static Boolean Update(FormaPagamentoTO clsFormaPagamento)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("UPDATE formapagamento SET IDFORMAPAGAMENTO= @IDFORMAPAGAMENTO,DESCRICAO= @DESCRICAO,QTDPARCELA= @QTDPARCELA,QTDDIAS= @QTDDIAS, Indicador=@Indicador WHERE IDFormaPagamento =@IDFormaPagamento ");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();

                cmd.Parameters.AddWithValue("@IDFormaPagamento", clsFormaPagamento.IDFormaPagamento);
                cmd.Parameters.AddWithValue("@DESCRICAO", clsFormaPagamento.Descricao);
                cmd.Parameters.AddWithValue("@QTDPARCELA", clsFormaPagamento.QtdParcela);
                cmd.Parameters.AddWithValue("@QTDDIAS", clsFormaPagamento.QtdDias);
                cmd.Parameters.AddWithValue("@Indicador", clsFormaPagamento.Indicador);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        #endregion
    }
}
