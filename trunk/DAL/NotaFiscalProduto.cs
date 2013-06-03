using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotaFiscalProduto;

namespace NotaFiscalProduto
{
    public class NotaFiscalProdutoDAL
    {

        #region Search
        public static List<NotaFiscalProdutoTO> listaNotaFiscalProdutoAll()
        {
            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                List<NotaFiscalProdutoTO> clsNotaFiscalProdutos = new List<NotaFiscalProdutoTO>();

                string strSql = "SELECT NotaFiscalProduto.* FROM NotaFiscalProduto";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();

                while (adap.Read())
                {
                    NotaFiscalProdutoTO clsNotaFiscalProduto = new NotaFiscalProdutoTO();

                    clsNotaFiscalProduto.IDNotaFiscalProduto = Convert.ToInt32(adap["IDNotaFiscalProduto"]);
                    clsNotaFiscalProduto.IDNotaFiscal = Convert.ToInt32(adap["IDNotaFiscal"].ToString());
                    clsNotaFiscalProduto.IDProduto = Convert.ToInt32(adap["IDProduto"]);
                    clsNotaFiscalProduto.QtdProduto = Convert.ToInt32(adap["QtdProduto"]);
                    clsNotaFiscalProduto.ValorTotal = Convert.ToDouble(adap["ValorTotal"]);
                    clsNotaFiscalProduto.ValorTotal = Convert.ToDouble(adap["icsm"]);
                    clsNotaFiscalProduto.ValorTotal = Convert.ToDouble(adap["ipi"]);

                    clsNotaFiscalProdutos.Add(clsNotaFiscalProduto);
                }

                return clsNotaFiscalProdutos;
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
        public static List<NotaFiscalProdutoTO> getNotaFiscalProdutoByNF(int IDNotaFiscal)
        {
            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {
                List<NotaFiscalProdutoTO> clsNotaFiscalProdutos = new List<NotaFiscalProdutoTO>();




                string strSql = "SELECT notafiscalproduto.*, produto.descricao as NomeProduto,produto.valorUnitario as ValorUnitario FROM notafiscalproduto INNER JOIN Produto ON Produto.idProduto = notafiscalProduto.idproduto WHERE IDNotaFiscal=@IDNotaFiscal";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;

                cmd.Parameters.AddWithValue("@IDNotaFiscal", IDNotaFiscal);
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();

                while (adap.Read())
                {
                    NotaFiscalProdutoTO clsNotaFiscalProduto = new NotaFiscalProdutoTO();

                    clsNotaFiscalProduto.IDNotaFiscalProduto = Convert.ToInt32(adap["idNotaFiscalProduto"]);
                    clsNotaFiscalProduto.IDNotaFiscal = Convert.ToInt32(adap["IDNotaFiscal"]);
                    clsNotaFiscalProduto.IDProduto = Convert.ToInt32(adap["IDProduto"]);
                    clsNotaFiscalProduto.QtdProduto = Convert.ToInt32(adap["QtdProduto"]);
                    clsNotaFiscalProduto.ValorTotal = Convert.ToDouble(adap["ValorTotal"]);
                    clsNotaFiscalProduto.Icms = Convert.ToDouble(adap["icms"]);
                    clsNotaFiscalProduto.Ipi = Convert.ToDouble(adap["ipi"]);
                    clsNotaFiscalProduto.NomeProduto = adap["NomeProduto"].ToString();
                    clsNotaFiscalProduto.ValorUnitario = Convert.ToDouble(adap["ValorUnitario"]);
                    clsNotaFiscalProdutos.Add(clsNotaFiscalProduto);
                }

                return clsNotaFiscalProdutos;
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
       
        public static NotaFiscalProdutoTO GetNotaFiscalProdutoByID(int ID)
        {

            NotaFiscalProdutoTO clsNotaFiscalProduto = new NotaFiscalProdutoTO();

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {


                string strSql = "SELECT NotaFiscalProduto.* FROM NotaFiscalProduto WHERE NotaFiscalProduto.idNotaFiscalProduto = @idNotaFiscalProduto";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.Parameters.AddWithValue("@idNotaFiscalProduto", ID);
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();
                while (adap.Read())
                {
                    clsNotaFiscalProduto.IDNotaFiscalProduto = Convert.ToInt32(adap["IDNotaFiscalProduto"]);
                    clsNotaFiscalProduto.IDNotaFiscal = Convert.ToInt32(adap["IDNotaFiscal"].ToString());
                    clsNotaFiscalProduto.IDProduto = Convert.ToInt32(adap["IDProduto"]);
                    clsNotaFiscalProduto.QtdProduto = Convert.ToInt32(adap["QtdProduto"]);
                    clsNotaFiscalProduto.ValorTotal = Convert.ToDouble(adap["ValorTotal"]);
                    clsNotaFiscalProduto.ValorTotal = Convert.ToDouble(adap["icsm"]);
                    clsNotaFiscalProduto.ValorTotal = Convert.ToDouble(adap["ipi"]);
                }

                return clsNotaFiscalProduto;
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
        public static void insert(NotaFiscalProdutoTO clsNotaFiscalProduto)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("INSERT INTO NotaFiscalProduto(IDNotaFiscal, IDProduto, QtdProduto, ValorTotal, Icms, Ipi)VALUES (@IDNotaFiscal, @IDProduto, @QtdProduto, @ValorTotal, @Icms, @Ipi);");
                strSql.Append("SELECT NotaFiscalProduto.* FROM NotaFiscalProduto WHERE NotaFiscalProduto.idNotaFiscalProduto=@@IDENTITY;");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                
                cmd.Parameters.AddWithValue("@IDNotaFiscal", clsNotaFiscalProduto.IDNotaFiscal);
                cmd.Parameters.AddWithValue("@IDProduto", clsNotaFiscalProduto.IDProduto);
                cmd.Parameters.AddWithValue("@QtdProduto", clsNotaFiscalProduto.QtdProduto);
                cmd.Parameters.AddWithValue("@ValorTotal", clsNotaFiscalProduto.ValorTotal);
                cmd.Parameters.AddWithValue("@Icms", clsNotaFiscalProduto.Icms);
                cmd.Parameters.AddWithValue("@Ipi", clsNotaFiscalProduto.Ipi);


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
        public static Boolean Delete(NotaFiscalProdutoTO clsNotaFiscalProduto)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM NotaFiscalProduto WHERE idNotaFiscalProduto=@idNotaFiscalProduto");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@idNotaFiscalProduto", clsNotaFiscalProduto.IDNotaFiscalProduto);

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
        public static Boolean Update(NotaFiscalProdutoTO clsNotaFiscalProduto)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("UPDATE NotaFiscalProduto SET IDNotaFiscal=@IDNotaFiscal, IDProduto=@IDProduto, QtdProduto=@QtdProduto, ValorTotal=@ValorTotal, Icms=@Icms, Ipi=@Ipi WHERE idNotaFiscalProduto=@idNotaFiscalProduto");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@idNotaFiscalProduto", clsNotaFiscalProduto.IDNotaFiscalProduto);
                cmd.Parameters.AddWithValue("@IDNotaFiscal", clsNotaFiscalProduto.IDNotaFiscal);
                cmd.Parameters.AddWithValue("@IDProduto", clsNotaFiscalProduto.IDProduto);
                cmd.Parameters.AddWithValue("@QtdProduto", clsNotaFiscalProduto.QtdProduto);
                cmd.Parameters.AddWithValue("@ValorTotal", clsNotaFiscalProduto.ValorTotal);
                cmd.Parameters.AddWithValue("@Icms", clsNotaFiscalProduto.Icms);
                cmd.Parameters.AddWithValue("@Ipi", clsNotaFiscalProduto.Ipi);

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
