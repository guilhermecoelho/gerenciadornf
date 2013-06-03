using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imposto;
using System.Data;

namespace Imposto
{
    public class ImpostoDAL
    {
        #region Search
        public static List<ImpostoTO> listaImpostoAll()
        {


            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {
                List<ImpostoTO> clsImpostos = new List<ImpostoTO>();

                string strSql = "SELECT Imposto.* FROM Imposto";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();

                while (adap.Read())
                {
                    ImpostoTO clsImposto = new ImpostoTO();

                    clsImposto.IDImposto = Convert.ToInt32(adap["IDImposto"]);
                    clsImposto.Nome = adap["nome"].ToString();
                    clsImposto.Descricao = adap["Descricao"].ToString();
                    clsImposto.Valor = Convert.ToInt32(adap["Valor"]);
                    clsImposto.ClassificacaoFiscal = adap["ClassificacaoFiscal"].ToString();
                    clsImposto.OrigemMercadoria = adap["OrigemMercadoria"].ToString();
                    clsImposto.SituacaoTributaria = adap["SituacaoTributaria"].ToString();
                    clsImposto.Modalidade = adap["Modalidade"].ToString();
                    clsImposto.AliquitaICMS = Convert.ToDouble(adap["AliquitaICMS"].ToString());
                    clsImposto.AliquitaIPI = Convert.ToDouble(adap["AliquitaIPI"].ToString());

                    clsImpostos.Add(clsImposto);
                }

                return clsImpostos;
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
       
        public static ImpostoTO GetImpostoByID(int IDImposto)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {

                ImpostoTO clsImposto = new ImpostoTO();

                string strSql = "SELECT Imposto.* FROM Imposto WHERE Imposto.IDImposto = @IDImposto";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.Parameters.AddWithValue("@IDImposto", IDImposto);
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();
                while (adap.Read())
                {
                    clsImposto.IDImposto = Convert.ToInt32(adap["IDImposto"]);
                    clsImposto.Nome = adap["nome"].ToString();
                    clsImposto.Descricao = adap["Descricao"].ToString();
                    clsImposto.Valor = Convert.ToInt32(adap["Valor"]);
                    clsImposto.ClassificacaoFiscal = adap["ClassificacaoFiscal"].ToString();
                    clsImposto.OrigemMercadoria = adap["OrigemMercadoria"].ToString();
                    clsImposto.SituacaoTributaria = adap["SituacaoTributaria"].ToString();
                    clsImposto.Modalidade = adap["Modalidade"].ToString();
                    clsImposto.AliquitaICMS = Convert.ToDouble(adap["AliquitaICMS"].ToString());
                    clsImposto.AliquitaIPI = Convert.ToDouble(adap["AliquitaIPI"].ToString());
                }

                return clsImposto;
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
        public static void insert(ImpostoTO clsImposto)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("INSERT INTO Imposto(IDImposto, Nome, Descricao, Valor, ClassificacaoFiscal, OrigemMercadoria, SituacaoTributaria, Modalidade, AliquitaICMS, AliquitaIPI ) ");
                strSql.Append("VALUES (@IDImposto, @Nome, @Descricao, @Valor, @ClassificacaoFiscal, @OrigemMercadoria, @SituacaoTributaria, @Modalidade, @AliquitaICMS, @AliquitaIPI ); ");
                strSql.Append("SELECT Imposto.* FROM Imposto WHERE Imposto.IDImposto=@@IDENTITY;");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDImposto", clsImposto.IDImposto);
                cmd.Parameters.AddWithValue("@Nome", clsImposto.Nome );
                cmd.Parameters.AddWithValue("@Descricao", clsImposto.Descricao);
                cmd.Parameters.AddWithValue("@Valor", clsImposto.Valor);

                cmd.Parameters.AddWithValue("@ClassificacaoFiscal", clsImposto.ClassificacaoFiscal);
                cmd.Parameters.AddWithValue("@OrigemMercadoria", clsImposto.OrigemMercadoria);
                cmd.Parameters.AddWithValue("@SituacaoTributaria", clsImposto.SituacaoTributaria);
                cmd.Parameters.AddWithValue("@Modalidade", clsImposto.Modalidade);
                cmd.Parameters.AddWithValue("@AliquitaICMS", clsImposto.AliquitaICMS);
                cmd.Parameters.AddWithValue("@AliquitaIPI", clsImposto.AliquitaIPI);


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
        public static Boolean Delete(ImpostoTO clsImposto)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM Imposto WHERE IDImposto=@IDImposto");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDImposto", clsImposto.IDImposto);

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
        public static Boolean Update(ImpostoTO clsImposto)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("UPDATE Imposto SET IDImposto=@IDImposto,Nome=@Nome,Descricao=@Descricao,Valor=@Valor, ClassificacaoFiscal=@ClassificacaoFiscal, OrigemMercadoria=@OrigemMercadoria, SituacaoTributaria=@SituacaoTributaria, Modalidade=@Modalidade, AliquitaICMS=@AliquitaICMS, AliquitaIPI=@AliquitaIPI ");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDImposto", clsImposto.IDImposto);
                cmd.Parameters.AddWithValue("@Nome", clsImposto.Nome);
                cmd.Parameters.AddWithValue("@Descricao", clsImposto.Descricao);
                cmd.Parameters.AddWithValue("@Valor", clsImposto.Valor);
                cmd.Parameters.AddWithValue("@ClassificacaoFiscal", clsImposto.ClassificacaoFiscal);
                cmd.Parameters.AddWithValue("@OrigemMercadoria", clsImposto.OrigemMercadoria);
                cmd.Parameters.AddWithValue("@SituacaoTributaria", clsImposto.SituacaoTributaria);
                cmd.Parameters.AddWithValue("@Modalidade", clsImposto.Modalidade);
                cmd.Parameters.AddWithValue("@AliquitaICMS", clsImposto.AliquitaICMS);
                cmd.Parameters.AddWithValue("@AliquitaIPI", clsImposto.AliquitaIPI);

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
