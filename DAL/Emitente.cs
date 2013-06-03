using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emitente;
using System.Data;

namespace Emitente
{
    public class EmitenteDAL
    {
        #region Search
        public static List<EmitenteTO> listaEmitenteAll()
        {
            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {
                List<EmitenteTO> clsEmitentes = new List<EmitenteTO>();

                string strSql = "SELECT Emitente.* FROM Emitente";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();

                while (adap.Read())
                {
                    EmitenteTO clsEmitente = new EmitenteTO();

                    clsEmitente.IDEmitente = Convert.ToInt32(adap["IDEmitente"]);
                    clsEmitente.Nome = adap["nome"].ToString();
                    clsEmitente.NomeFantasia = adap["NomeFantasia"].ToString();
                    clsEmitente.Cep = adap["Cep"].ToString();
                    clsEmitente.Logradura = adap["Logradura"].ToString();
                    clsEmitente.Numero = adap["Numero"].ToString();
                    clsEmitente.Complemento = adap["Complemento"].ToString();
                    clsEmitente.Uf = adap["Uf"].ToString();
                    clsEmitente.Cidade = adap["Cidade"].ToString();
                    clsEmitente.Telefone = adap["Telefone"].ToString();
                    clsEmitente.Cnpj = adap["Cnpj"].ToString();
                    clsEmitente.InscricaoEstadual = adap["InscricaoEstadual"].ToString();
                    clsEmitente.CertDigital = adap["CertDigital"].ToString();

                    clsEmitentes.Add(clsEmitente);
                }

                return clsEmitentes;
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
       
        public static EmitenteTO GetEmitenteByID(int IDEmitente)
        {
            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {

                EmitenteTO clsEmitente = new EmitenteTO();

                string strSql = "SELECT Emitente.* FROM Emitente WHERE Emitente.IDEmitente = @IDEmitente";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.Parameters.AddWithValue("@IDEmitente", IDEmitente);
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();
                while (adap.Read())
                {
                    clsEmitente.IDEmitente = Convert.ToInt32(adap["IDEmitente"]);
                    clsEmitente.Nome = adap["nome"].ToString();
                    clsEmitente.NomeFantasia = adap["NomeFantasia"].ToString();
                    clsEmitente.Cep = adap["Cep"].ToString();
                    clsEmitente.Logradura = adap["Logradura"].ToString();
                    clsEmitente.Numero = adap["Numero"].ToString();
                    clsEmitente.Complemento = adap["Complemento"].ToString();
                    clsEmitente.Uf = adap["Uf"].ToString();
                    clsEmitente.Cidade = adap["Cidade"].ToString();
                    clsEmitente.Telefone = adap["Telefone"].ToString();
                    clsEmitente.Cnpj = adap["Cnpj"].ToString();
                    clsEmitente.InscricaoEstadual = adap["InscricaoEstadual"].ToString();
                    clsEmitente.CertDigital = adap["CertDigital"].ToString();
                }

                return clsEmitente;
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
        public static void insert(EmitenteTO clsEmitente)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("INSERT INTO emitente(IDEMITENTE, NOME, NOMEFANTASIA, CEP, LOGRADURA, NUMERO, COMPLEMENTO, UF, CIDADE, TELEFONE, CNPJ, INSCRICAOESTADUAL, CERTDIGITAL)  ");
                strSql.Append("VALUES (IDEMITENTE,@NOME,@NOMEFANTASIA,@CEP,@LOGRADURA,@NUMERO,@COMPLEMENTO,@UF,@CIDADE,@TELEFONE,@CNPJ,@INSCRICAOESTADUAL,@CERTDIGITAL); ");
                strSql.Append("SELECT Emitente.* FROM Emitente WHERE Emitente.IDEmitente=@@IDENTITY;");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDEmitente", clsEmitente.IDEmitente);
                cmd.Parameters.AddWithValue("@Nome", clsEmitente.Nome );
                cmd.Parameters.AddWithValue("@NomeFantasia", clsEmitente.NomeFantasia);
                cmd.Parameters.AddWithValue("@Cep", clsEmitente.Cep );
                cmd.Parameters.AddWithValue("@Logradura", clsEmitente.Logradura );
                cmd.Parameters.AddWithValue("@Numero", clsEmitente.Numero);
                cmd.Parameters.AddWithValue("@Complemento", clsEmitente.Complemento );
                cmd.Parameters.AddWithValue("@Uf", clsEmitente.Uf );
                cmd.Parameters.AddWithValue("@Cidade", clsEmitente.Cidade );
                cmd.Parameters.AddWithValue("@Telefone", clsEmitente.Telefone );
                cmd.Parameters.AddWithValue("@Cnpj", clsEmitente.Cnpj );
                cmd.Parameters.AddWithValue("@InscricaoEstadual", clsEmitente.InscricaoEstadual);
                cmd.Parameters.AddWithValue("@CertDigital", clsEmitente.CertDigital);

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
        public static Boolean Delete(EmitenteTO clsEmitente)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM Emitente WHERE IDEmitente=@IDEmitente");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDEmitente", clsEmitente.IDEmitente);

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
        public static Boolean Update(EmitenteTO clsEmitente)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("UPDATE emitente SET IDEMITENTE=@IDEMITENTE,NOME=@NOME,NOMEFANTASIA=@NOMEFANTASIA,CEP=@CEP,LOGRADURA=@LOGRADURA,NUMERO=@NUMERO,COMPLEMENTO=@COMPLEMENTO,UF=@UF,CIDADE=@CIDADE,TELEFONE=@TELEFONE,CNPJ=@CNPJ,INSCRICAOESTADUAL=@INSCRICAOESTADUAL,CERTDIGITAL=@CERTDIGITAL WHERE IDEmitente=@IDEmitente ");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDEmitente", clsEmitente.IDEmitente);
                cmd.Parameters.AddWithValue("@Nome", clsEmitente.Nome );
                cmd.Parameters.AddWithValue("@NomeFantasia", clsEmitente.NomeFantasia);
                cmd.Parameters.AddWithValue("@Cep", clsEmitente.Cep );
                cmd.Parameters.AddWithValue("@Logradura", clsEmitente.Logradura );
                cmd.Parameters.AddWithValue("@Numero", clsEmitente.Numero);
                cmd.Parameters.AddWithValue("@Complemento", clsEmitente.Complemento );
                cmd.Parameters.AddWithValue("@Uf", clsEmitente.Uf );
                cmd.Parameters.AddWithValue("@Cidade", clsEmitente.Cidade );
                cmd.Parameters.AddWithValue("@Telefone", clsEmitente.Telefone );
                cmd.Parameters.AddWithValue("@Cnpj", clsEmitente.Cnpj );
                cmd.Parameters.AddWithValue("@InscricaoEstadual", clsEmitente.InscricaoEstadual);
                cmd.Parameters.AddWithValue("@CertDigital", clsEmitente.CertDigital);

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
