using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cliente;
using System.Data;

namespace Cliente
{
    public class ClienteDAL
    {
        #region Search
        public static List<ClienteTO> listaClienteAll()
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {
                List<ClienteTO> clsClientes = new List<ClienteTO>();

                string strSql = "SELECT Cliente.* FROM Cliente";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();

                while (adap.Read())
                {
                    ClienteTO clsCliente = new ClienteTO();

                    clsCliente.IDCliente = Convert.ToInt32(adap["IDCliente"]);
                    clsCliente.Nome = adap["nome"].ToString();
                    clsCliente.Email = adap["email"].ToString();
                    clsCliente.Tipo = Convert.ToInt32(adap["tipo"]);
                    clsCliente.NomeFantasia = adap["NomeFantasia"].ToString();
                    clsCliente.Cep = adap["Cep"].ToString();
                    clsCliente.Logradura = adap["Logradura"].ToString();
                    clsCliente.Numero = adap["Numero"].ToString();
                    clsCliente.Complemento = adap["Complemento"].ToString();
                    clsCliente.Uf = adap["Uf"].ToString();
                    clsCliente.Cidade = adap["Cidade"].ToString();
                    clsCliente.Telefone = adap["Telefone"].ToString();
                    clsCliente.Cnpj = adap["Cnpj"].ToString();
                    clsCliente.Cpf = adap["Cpf"].ToString();
                    clsCliente.InscricaoEstadual = adap["InscricaoEstadual"].ToString();
                    clsCliente.InscricaoMunicipal = adap["InscricaoMunicipal"].ToString();

                    clsClientes.Add(clsCliente);
                }

                return clsClientes;
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

        public static ClienteTO GetClienteByID(int IDCliente)
        {
            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {

                ClienteTO clsCliente = new ClienteTO();

                string strSql = "SELECT cliente.* FROM cliente WHERE Cliente.IDCliente = @IDCliente";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.Parameters.AddWithValue("@IDCliente", IDCliente);
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();
                while (adap.Read())
                {
                    clsCliente.IDCliente = Convert.ToInt32(adap["IDCliente"]);
                    clsCliente.Nome = adap["nome"].ToString();
                    clsCliente.Email = adap["email"].ToString();
                    clsCliente.Tipo = Convert.ToInt32(adap["tipo"]);
                    clsCliente.NomeFantasia = adap["NomeFantasia"].ToString();
                    clsCliente.Cep = adap["Cep"].ToString();
                    clsCliente.Logradura = adap["Logradura"].ToString();
                    clsCliente.Numero = adap["Numero"].ToString();
                    clsCliente.Complemento = adap["Complemento"].ToString();
                    clsCliente.Uf = adap["Uf"].ToString();
                    clsCliente.Cidade = adap["Cidade"].ToString();
                    clsCliente.Telefone = adap["Telefone"].ToString();
                    clsCliente.Cnpj = adap["Cnpj"].ToString();
                    clsCliente.Cpf = adap["Cpf"].ToString();
                    clsCliente.InscricaoEstadual = adap["InscricaoEstadual"].ToString();
                    clsCliente.InscricaoMunicipal = adap["InscricaoMunicipal"].ToString();
                }

                return clsCliente;
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
        public static void insert(ClienteTO clsCliente)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("INSERT INTO cliente(IDCliente, NOME, EMAIL, TIPO, NOMEFANTASIA, CEP, LOGRADURA, NUMERO, COMPLEMENTO, UF, CIDADE, TELEFONE, CNPJ, CPF, INSCRICAOESTADUAL, INSCRICAOMUNICIPAL) ");
                strSql.Append("VALUES (@IDCliente, @NOME, @EMAIL, @TIPO, @NOMEFANTASIA, @CEP, @LOGRADURA, @NUMERO, @COMPLEMENTO, @UF, @CIDADE, @TELEFONE, @CNPJ, @CPF, @INSCRICAOESTADUAL, @INSCRICAOMUNICIPAL); ");
                strSql.Append("SELECT cliente.* FROM cliente WHERE cliente.IDCliente=@@IDENTITY;");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDCliente", clsCliente.IDCliente);
                cmd.Parameters.AddWithValue("@Nome", clsCliente.Nome);
                cmd.Parameters.AddWithValue("@Email", clsCliente.Email);
                cmd.Parameters.AddWithValue("@Tipo", clsCliente.Tipo);
                cmd.Parameters.AddWithValue("@NomeFantasia", clsCliente.NomeFantasia);
                cmd.Parameters.AddWithValue("@Cep", clsCliente.Cep);
                cmd.Parameters.AddWithValue("@Logradura", clsCliente.Logradura);
                cmd.Parameters.AddWithValue("@Numero", clsCliente.Numero);
                cmd.Parameters.AddWithValue("@Complemento", clsCliente.Complemento);
                cmd.Parameters.AddWithValue("@Uf", clsCliente.Uf);
                cmd.Parameters.AddWithValue("@Cidade", clsCliente.Cidade);
                cmd.Parameters.AddWithValue("@Telefone", clsCliente.Telefone);
                cmd.Parameters.AddWithValue("@Cnpj", clsCliente.Cnpj);
                cmd.Parameters.AddWithValue("@Cpf", clsCliente.Cpf);
                cmd.Parameters.AddWithValue("@InscricaoEstadual", clsCliente.InscricaoEstadual);
                cmd.Parameters.AddWithValue("@InscricaoMunicipal", clsCliente.InscricaoMunicipal);

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
        public static Boolean Delete(ClienteTO clsCliente)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM cliente WHERE IDCliente=@IDCliente");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDCliente", clsCliente.IDCliente);

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
        public static Boolean Update(ClienteTO clsCliente)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("UPDATE cliente SET IDCliente=@IDCliente,NOME=@NOME,EMAIL=@EMAIL,TIPO=@TIPO,NOMEFANTASIA=@NOMEFANTASIA,CEP=@CEP,LOGRADURA=@LOGRADURA,NUMERO=@NUMERO,COMPLEMENTO=@COMPLEMENTO,UF=@UF,CIDADE=@CIDADE,TELEFONE=@TELEFONE,CNPJ=@CNPJ,CPF=@CPF,INSCRICAOESTADUAL=@INSCRICAOESTADUAL,INSCRICAOMUNICIPAL=@INSCRICAOMUNICIPAL WHERE IDCliente=@IDCliente ");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDCliente", clsCliente.IDCliente);
                cmd.Parameters.AddWithValue("@Nome", clsCliente.Nome);
                cmd.Parameters.AddWithValue("@Email", clsCliente.Email);
                cmd.Parameters.AddWithValue("@Tipo", clsCliente.Tipo);
                cmd.Parameters.AddWithValue("@NomeFantasia", clsCliente.NomeFantasia);
                cmd.Parameters.AddWithValue("@Cep", clsCliente.Cep);
                cmd.Parameters.AddWithValue("@Logradura", clsCliente.Logradura);
                cmd.Parameters.AddWithValue("@Numero", clsCliente.Numero);
                cmd.Parameters.AddWithValue("@Complemento", clsCliente.Complemento);
                cmd.Parameters.AddWithValue("@Uf", clsCliente.Uf);
                cmd.Parameters.AddWithValue("@Cidade", clsCliente.Cidade);
                cmd.Parameters.AddWithValue("@Telefone", clsCliente.Telefone);
                cmd.Parameters.AddWithValue("@Cnpj", clsCliente.Cnpj);
                cmd.Parameters.AddWithValue("@Cpf", clsCliente.Cpf);
                cmd.Parameters.AddWithValue("@InscricaoEstadual", clsCliente.InscricaoEstadual);
                cmd.Parameters.AddWithValue("@InscricaoMunicipal", clsCliente.InscricaoMunicipal);

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
