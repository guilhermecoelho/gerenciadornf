using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotaFiscalTransportados;

namespace NotaFiscalTransportados
{
    public class NotaFiscalTransportadosDAL
    {

        #region Search
        public static List<NotaFiscalTransportadosTO> listaNotaFiscalTransportadosAll()
        {
            try
            {
                List<NotaFiscalTransportadosTO> clsNotaFiscalTransportadoss = new List<NotaFiscalTransportadosTO>();


                String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

                MySqlConnection connection = new MySqlConnection(myConnection);
                MySqlCommand cmd;
                connection.Open();

                string strSql = "SELECT NotaFiscalTransportados.* FROM NotaFiscalTransportados";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();

                while (adap.Read())
                {
                    NotaFiscalTransportadosTO clsNotaFiscalTransportados = new NotaFiscalTransportadosTO();

                    clsNotaFiscalTransportados.IDNotaFiscalTransportados = Convert.ToInt32(adap["IDNotaFiscalTransportados"]);
                    clsNotaFiscalTransportados.IDNotaFiscal = Convert.ToInt32(adap["IDNotaFiscal"].ToString());
                    clsNotaFiscalTransportados.Qtd = Convert.ToInt32(adap["Qtd"]);
                    clsNotaFiscalTransportados.Especie = adap["Especie"].ToString();
                    clsNotaFiscalTransportados.Marca = adap["Marca"].ToString();
                    clsNotaFiscalTransportados.Numero = adap["Numero"].ToString();
                    clsNotaFiscalTransportados.PesoBruto = Convert.ToDouble(adap["PesoBruto"]);
                    clsNotaFiscalTransportados.PesoLiquido = Convert.ToDouble(adap["PesoLiquido"]);

                    clsNotaFiscalTransportadoss.Add(clsNotaFiscalTransportados);
                }

                return clsNotaFiscalTransportadoss;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }
       
        public static NotaFiscalTransportadosTO GetNotaFiscalTransportadosByID(int ID)
        {
            try
            {

                NotaFiscalTransportadosTO clsNotaFiscalTransportados = new NotaFiscalTransportadosTO();

                String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

                MySqlConnection connection = new MySqlConnection(myConnection);
                MySqlCommand cmd;
                connection.Open();

                string strSql = "SELECT NotaFiscalTransportados.* FROM NotaFiscalTransportados WHERE NotaFiscalTransportados.idNotaFiscalTransportados = @idNotaFiscalTransportados";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.Parameters.AddWithValue("@idNotaFiscalTransportados", ID);
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();
                while (adap.Read())
                {
                    clsNotaFiscalTransportados.IDNotaFiscalTransportados = Convert.ToInt32(adap["IDNotaFiscalTransportados"]);
                    clsNotaFiscalTransportados.IDNotaFiscal = Convert.ToInt32(adap["IDNotaFiscal"].ToString());
                    clsNotaFiscalTransportados.Qtd = Convert.ToInt32(adap["Qtd"]);
                    clsNotaFiscalTransportados.Especie = adap["Especie"].ToString();
                    clsNotaFiscalTransportados.Marca = adap["Marca"].ToString();
                    clsNotaFiscalTransportados.Numero = adap["Numero"].ToString();
                    clsNotaFiscalTransportados.PesoBruto = Convert.ToDouble(adap["PesoBruto"]);
                    clsNotaFiscalTransportados.PesoLiquido = Convert.ToDouble(adap["PesoLiquido"]);
                }

                return clsNotaFiscalTransportados;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }
        #endregion
        #region Persistence
        public static void insert(NotaFiscalTransportadosTO clsNotaFiscalTransportados)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("INSERT INTO NotaFiscalTransportados(IDNotaFiscal, Qtd, Especie, Marca, Numero, PesoBruto, PesoLiquido)VALUES (@IDNotaFiscal, @Qtd, @Especie, @Marca, @Numero, @PesoBruto, @PesoLiquido);");
                strSql.Append("SELECT NotaFiscalTransportados.* FROM NotaFiscalTransportados WHERE NotaFiscalTransportados.idNotaFiscalTransportados=@@IDENTITY;");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDNotaFiscal", clsNotaFiscalTransportados.IDNotaFiscal);
                cmd.Parameters.AddWithValue("@Qtd", clsNotaFiscalTransportados.Qtd);
                cmd.Parameters.AddWithValue("@Especie", clsNotaFiscalTransportados.Especie);
                cmd.Parameters.AddWithValue("@Marca", clsNotaFiscalTransportados.Marca);
                cmd.Parameters.AddWithValue("@Numero", clsNotaFiscalTransportados.Numero);
                cmd.Parameters.AddWithValue("@PesoBruto", clsNotaFiscalTransportados.PesoBruto);
                cmd.Parameters.AddWithValue("@PesoLiquido", clsNotaFiscalTransportados.PesoLiquido);

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
        public static Boolean Delete(NotaFiscalTransportadosTO clsNotaFiscalTransportados)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM NotaFiscalTransportados WHERE idNotaFiscalTransportados=@idNotaFiscalTransportados");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@idNotaFiscalTransportados", clsNotaFiscalTransportados.IDNotaFiscalTransportados);

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
        public static Boolean Update(NotaFiscalTransportadosTO clsNotaFiscalTransportados)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("UPDATE NotaFiscalTransportados SET IDNotaFiscal=@IDNotaFiscal, Qtd=@Qtd, Especie=@Especie, Marca=@Marca, Numero=@Numero, PesoBruto=@PesoBruto, PesoLiquido=@PesoLiquido");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@idNotaFiscalTransportados", clsNotaFiscalTransportados.IDNotaFiscalTransportados);
                cmd.Parameters.AddWithValue("@IDNotaFiscal", clsNotaFiscalTransportados.IDNotaFiscal);
                cmd.Parameters.AddWithValue("@Qtd", clsNotaFiscalTransportados.Qtd);
                cmd.Parameters.AddWithValue("@Especie", clsNotaFiscalTransportados.Especie);
                cmd.Parameters.AddWithValue("@Marca", clsNotaFiscalTransportados.Marca);
                cmd.Parameters.AddWithValue("@Numero", clsNotaFiscalTransportados.Numero);
                cmd.Parameters.AddWithValue("@PesoBruto", clsNotaFiscalTransportados.PesoBruto);
                cmd.Parameters.AddWithValue("@PesoLiquido", clsNotaFiscalTransportados.PesoLiquido);

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
