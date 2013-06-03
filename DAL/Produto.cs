using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Produto;
using System.Data;

namespace Produto
{
    public class ProdutoDAL
    {
        #region Search
        public static List<ProdutoTO> listaProdutoAll()
        {


            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {
                List<ProdutoTO> clsProdutos = new List<ProdutoTO>();

                string strSql = "SELECT Produto.* FROM Produto";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();

                while (adap.Read())
                {
                    ProdutoTO clsProduto = new ProdutoTO();

                    clsProduto.IDProduto = Convert.ToInt32(adap["IDProduto"]);
                    clsProduto.Descricao = adap["Descricao"].ToString();
                    clsProduto.NCM = adap["NCM"].ToString();
                    clsProduto.CFOP = adap["CFOP"].ToString();
                    clsProduto.UnidadeComercializada = adap["UnidadeComercializada"].ToString();
                    clsProduto.ValorUnitario = Convert.ToDouble(adap["ValorUnitario"]);
                    clsProduto.UnidadeTributaria = adap["UnidadeTributaria"].ToString();

                    clsProdutos.Add(clsProduto);
                }

                return clsProdutos;
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

        public static ProdutoTO GetProdutoByID(int IDProduto)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {

                ProdutoTO clsProduto = new ProdutoTO();

                string strSql = "SELECT Produto.* FROM Produto WHERE Produto.IDProduto = @IDProduto";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.Parameters.AddWithValue("@IDProduto", IDProduto);
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();
                while (adap.Read())
                {
                    clsProduto.IDProduto = Convert.ToInt32(adap["IDProduto"]);
                    clsProduto.Descricao = adap["Descricao"].ToString();
                    clsProduto.NCM = adap["NCM"].ToString();
                    clsProduto.CFOP = adap["CFOP"].ToString();
                    clsProduto.UnidadeComercializada = adap["UnidadeComercializada"].ToString();
                    clsProduto.ValorUnitario = Convert.ToDouble(adap["ValorUnitario"]);
                    clsProduto.UnidadeTributaria = adap["UnidadeTributaria"].ToString();

                }

                return clsProduto;
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
        public static void insert(ProdutoTO clsProduto)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("INSERT INTO Produto(IDProduto,Descricao, NCM, CFOP, UnidadeComercializada, ValorUnitario, UnidadeTributaria) ");
                strSql.Append("VALUES (@IDProduto, @Descricao, @NCM, @CFOP, @UnidadeComercializada, @ValorUnitario, @UnidadeTributaria); ");
                strSql.Append("SELECT Produto.* FROM Produto WHERE Produto.IDProduto=@@IDENTITY;");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDProduto", clsProduto.IDProduto);
                cmd.Parameters.AddWithValue("@Descricao", clsProduto.Descricao);
                cmd.Parameters.AddWithValue("@NCM", clsProduto.NCM);
                cmd.Parameters.AddWithValue("@CFOP", clsProduto.CFOP);
                cmd.Parameters.AddWithValue("@UnidadeComercializada", clsProduto.UnidadeComercializada);
                cmd.Parameters.AddWithValue("@ValorUnitario", clsProduto.ValorUnitario);
                cmd.Parameters.AddWithValue("@UnidadeTributaria", clsProduto.UnidadeTributaria);


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
        public static Boolean Delete(ProdutoTO clsProduto)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM Produto WHERE IDProduto=@IDProduto");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDProduto", clsProduto.IDProduto);

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
        public static Boolean Update(ProdutoTO clsProduto)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("UPDATE Produto SET IDProduto=@IDProduto,Descricao=@Descricao, NCM=@NCM, CFOP=@CFOP, UnidadeComercializada=@UnidadeComercializada, ValorUnitario=@ValorUnitario, UnidadeTributaria=@UnidadeTributaria ");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDProduto", clsProduto.IDProduto);
                cmd.Parameters.AddWithValue("@Descricao", clsProduto.Descricao);
                cmd.Parameters.AddWithValue("@NCM", clsProduto.NCM);
                cmd.Parameters.AddWithValue("@CFOP", clsProduto.CFOP);
                cmd.Parameters.AddWithValue("@UnidadeComercializada", clsProduto.UnidadeComercializada);
                cmd.Parameters.AddWithValue("@ValorUnitario", clsProduto.ValorUnitario);
                cmd.Parameters.AddWithValue("@UnidadeTributaria", clsProduto.UnidadeTributaria);

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
