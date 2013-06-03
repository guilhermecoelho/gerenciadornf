using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportadora;
using System.Data;

namespace Transportadora
{
    public class TransportadoraDAL
    {
        #region Search
        public static List<TransportadoraTO> listaTransportadoraAll()
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {
                List<TransportadoraTO> clsTransportadoras = new List<TransportadoraTO>();

                string strSql = "SELECT Transportadora.* FROM Transportadora";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();

                while (adap.Read())
                {
                    TransportadoraTO clsTransportadora = new TransportadoraTO();

                    clsTransportadora.IDTransportadora = Convert.ToInt32(adap["IDTransportadora"]);
                    clsTransportadora.Nome = adap["nome"].ToString();
                    clsTransportadora.Cep = adap["Cep"].ToString();
                    clsTransportadora.Logradura = adap["Logradura"].ToString();
                    clsTransportadora.Numero = adap["Numero"].ToString();
                    clsTransportadora.Complemento = adap["Complemento"].ToString();
                    clsTransportadora.Uf = adap["Uf"].ToString();
                    clsTransportadora.Cidade = adap["Cidade"].ToString();
                    clsTransportadora.Telefone = adap["Telefone"].ToString();
                    clsTransportadora.Cnpj = adap["Cnpj"].ToString();
                    clsTransportadora.InscricaoEstadual = adap["InscricaoEstadual"].ToString();


                    clsTransportadoras.Add(clsTransportadora);
                }

                return clsTransportadoras;
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
       
        public static TransportadoraTO GetTransportadoraByID(int IDTransportadora)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {

                TransportadoraTO clsTransportadora = new TransportadoraTO();

                string strSql = "SELECT Transportadora.* FROM Transportadora WHERE Transportadora.IDTransportadora = @IDTransportadora";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.Parameters.AddWithValue("@IDTransportadora", IDTransportadora);
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();
                while (adap.Read())
                {
                    clsTransportadora.IDTransportadora = Convert.ToInt32(adap["IDTransportadora"]);
                    clsTransportadora.Nome = adap["nome"].ToString();
                    clsTransportadora.Cep = adap["Cep"].ToString();
                    clsTransportadora.Logradura = adap["Logradura"].ToString();
                    clsTransportadora.Numero = adap["Numero"].ToString();
                    clsTransportadora.Complemento = adap["Complemento"].ToString();
                    clsTransportadora.Uf = adap["Uf"].ToString();
                    clsTransportadora.Cidade = adap["Cidade"].ToString();
                    clsTransportadora.Telefone = adap["Telefone"].ToString();
                    clsTransportadora.Cnpj = adap["Cnpj"].ToString();
                    clsTransportadora.InscricaoEstadual = adap["InscricaoEstadual"].ToString();
                }

                return clsTransportadora;
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
        public static void insert(TransportadoraTO clsTransportadora)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("INSERT INTO Transportadora(IDTransportadora, NOME, RazaoSocial , CEP, LOGRADURA, NUMERO, COMPLEMENTO, UF, CIDADE, TELEFONE, CNPJ,INSCRICAOESTADUAL) ");
                strSql.Append("VALUES (@IDTransportadora, @NOME, @RazaoSocial, @CEP, @LOGRADURA, @NUMERO, @COMPLEMENTO, @UF, @CIDADE, @TELEFONE, @CNPJ, @INSCRICAOESTADUAL); ");
                strSql.Append("SELECT Transportadora.* FROM Transportadora WHERE Transportadora.IDTransportadora=@@IDENTITY;");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDTransportadora", clsTransportadora.IDTransportadora);
                cmd.Parameters.AddWithValue("@Nome", clsTransportadora.Nome );
                cmd.Parameters.AddWithValue("@RazaoSocial", clsTransportadora.RazaoSocial);
                cmd.Parameters.AddWithValue("@Cep", clsTransportadora.Cep );
                cmd.Parameters.AddWithValue("@Logradura", clsTransportadora.Logradura );
                cmd.Parameters.AddWithValue("@Numero", clsTransportadora.Numero);
                cmd.Parameters.AddWithValue("@Complemento", clsTransportadora.Complemento );
                cmd.Parameters.AddWithValue("@Uf", clsTransportadora.Uf );
                cmd.Parameters.AddWithValue("@Cidade", clsTransportadora.Cidade );
                cmd.Parameters.AddWithValue("@Telefone", clsTransportadora.Telefone );
                cmd.Parameters.AddWithValue("@Cnpj", clsTransportadora.Cnpj );
                cmd.Parameters.AddWithValue("@InscricaoEstadual", clsTransportadora.InscricaoEstadual);


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
        public static Boolean Delete(TransportadoraTO clsTransportadora)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM Transportadora WHERE IDTransportadora=@IDTransportadora");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDTransportadora", clsTransportadora.IDTransportadora);

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
        public static Boolean Update(TransportadoraTO clsTransportadora)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("UPDATE Transportadora SET IDTransportadora=@IDTransportadora,NOME=@NOME,RazaoSocial=@RazaoSocial,CEP=@CEP,LOGRADURA=@LOGRADURA,NUMERO=@NUMERO,COMPLEMENTO=@COMPLEMENTO,UF=@UF,CIDADE=@CIDADE,TELEFONE=@TELEFONE,CNPJ=@CNPJ,CPF=@CPF,INSCRICAOESTADUAL=@INSCRICAOESTADUAL WHERE IDTransportadora=@IDTransportadora ");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDTransportadora", clsTransportadora.IDTransportadora);
                cmd.Parameters.AddWithValue("@Nome", clsTransportadora.Nome );
                cmd.Parameters.AddWithValue("@RazaoSocial", clsTransportadora.RazaoSocial);
                cmd.Parameters.AddWithValue("@Cep", clsTransportadora.Cep );
                cmd.Parameters.AddWithValue("@Logradura", clsTransportadora.Logradura );
                cmd.Parameters.AddWithValue("@Numero", clsTransportadora.Numero);
                cmd.Parameters.AddWithValue("@Complemento", clsTransportadora.Complemento );
                cmd.Parameters.AddWithValue("@Uf", clsTransportadora.Uf );
                cmd.Parameters.AddWithValue("@Cidade", clsTransportadora.Cidade );
                cmd.Parameters.AddWithValue("@Telefone", clsTransportadora.Telefone );
                cmd.Parameters.AddWithValue("@Cnpj", clsTransportadora.Cnpj );

                cmd.Parameters.AddWithValue("@InscricaoEstadual", clsTransportadora.InscricaoEstadual);


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
