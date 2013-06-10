using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotaFiscal;
using System.Data;

namespace NotaFiscal
{
    public class NotaFiscalDAL
    {

        #region Search
        public static List<NotaFiscalTO> listaNotaFiscalAll()
        {


            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {
                List<NotaFiscalTO> clsNotaFiscals = new List<NotaFiscalTO>();

                string strSql = "SELECT NotaFiscal.* FROM NotaFiscal";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();

                while (adap.Read())
                {
                    NotaFiscalTO clsNotaFiscal = new NotaFiscalTO();

                    clsNotaFiscal.IDNotaFiscal = Convert.ToInt32(adap["IDNotaFiscal"]);
                    clsNotaFiscal.IDEmitente = Convert.ToInt32(adap["IDEmitente"]);
                    clsNotaFiscal.IDTransportadora = Convert.ToInt32(adap["IDTransportadora"]);
                    clsNotaFiscal.IDCliente = Convert.ToInt32(adap["IDCliente"]);
                    clsNotaFiscal.iDFormaPagamento = Convert.ToInt32(adap["iDFormaPagamento"]);
                    clsNotaFiscal.ValorTotal = Convert.ToInt32(adap["ValorTotal"]);
                    clsNotaFiscal.DataCadastro = Convert.ToDateTime(adap["DataCadastro"]);

                    clsNotaFiscal.TipoSaidaEntrada = adap["TipoSaidaEntrada"].ToString();

                    clsNotaFiscal.DataSaidaEntrada = Convert.ToDateTime(adap["DataSaidaEntrada"]);

                    

                    clsNotaFiscal.QtdTransporte = Convert.ToInt32(adap["QtdTransporte"]);
                    clsNotaFiscal.TipoTransporte = adap["TipoTransporte"].ToString();
                    clsNotaFiscal.EspecieTransporte = adap["EspecieTransporte"].ToString();
                    clsNotaFiscal.MarcaTransporte = adap["MarcaTransporte"].ToString();
                    clsNotaFiscal.NumeroTransporte = Convert.ToInt32(adap["NumeroTransporte"]);
                    clsNotaFiscal.PesoBruto = Convert.ToDouble(adap["PesoBruto"]);
                    clsNotaFiscal.PesoLiquido = Convert.ToDouble(adap["PesoLiquido"]);

                    clsNotaFiscals.Add(clsNotaFiscal);
                }

                return clsNotaFiscals;
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
        public static List<NotaFiscalTO> GetNotaFiscalAll()
        {


            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {
                List<NotaFiscalTO> clsNotaFiscals = new List<NotaFiscalTO>();


                string strSql = "SELECT notafiscal.*, emitente.nome as nomeEmitente, cliente.nome as nomeCliente FROM notafiscal INNER JOIN Emitente ON emitente.idEmitente = notafiscal.idemitente INNER JOIN Cliente On cliente.idCliente = notafiscal.idCliente";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();

                while (adap.Read())
                {
                    NotaFiscalTO clsNotaFiscal = new NotaFiscalTO();

                    clsNotaFiscal.IDNotaFiscal = Convert.ToInt32(adap["IDNotaFiscal"]);
                    clsNotaFiscal.IDEmitente = Convert.ToInt32(adap["IDEmitente"]);
                    clsNotaFiscal.IDTransportadora = Convert.ToInt32(adap["IDTransportadora"]);
                    clsNotaFiscal.IDCliente = Convert.ToInt32(adap["IDCliente"]);
                    clsNotaFiscal.iDFormaPagamento = Convert.ToInt32(adap["iDFormaPagamento"]);
                    clsNotaFiscal.ValorTotal = Convert.ToInt32(adap["ValorTotal"]);
                    clsNotaFiscal.DataCadastro = Convert.ToDateTime(adap["DataCadastro"]);

                    clsNotaFiscal.TipoSaidaEntrada = adap["TipoSaidaEntrada"].ToString();

                    clsNotaFiscal.DataSaidaEntrada = Convert.ToDateTime(adap["DataSaidaEntrada"]);



                    clsNotaFiscal.QtdTransporte = Convert.ToInt32(adap["QtdTransporte"]);
                    clsNotaFiscal.TipoTransporte = adap["TipoTransporte"].ToString();
                    clsNotaFiscal.EspecieTransporte = adap["EspecieTransporte"].ToString();
                    clsNotaFiscal.MarcaTransporte = adap["MarcaTransporte"].ToString();
                    clsNotaFiscal.NumeroTransporte = Convert.ToInt32(adap["NumeroTransporte"]);
                    clsNotaFiscal.PesoBruto = Convert.ToDouble(adap["PesoBruto"]);
                    clsNotaFiscal.PesoLiquido = Convert.ToDouble(adap["PesoLiquido"]);

                    clsNotaFiscal.NomeCliente = adap["nomeCliente"].ToString();
                    clsNotaFiscal.NomeEmitente = adap["nomeEmitente"].ToString();

                    clsNotaFiscals.Add(clsNotaFiscal);
                }

                return clsNotaFiscals;
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
      
        public static NotaFiscalTO GetNotaFiscalByID(int IDNotaFiscal)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {

                NotaFiscalTO clsNotaFiscal = new NotaFiscalTO();

                string strSql = "SELECT NotaFiscal.* FROM NotaFiscal WHERE NotaFiscal.IDNotaFiscal = @IDNotaFiscal";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.Parameters.AddWithValue("@IDNotaFiscal", IDNotaFiscal);
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();
                while (adap.Read())
                {
                    clsNotaFiscal.IDNotaFiscal = Convert.ToInt32(adap["IDNotaFiscal"]);
                    clsNotaFiscal.IDEmitente = Convert.ToInt32(adap["IDEmitente"]);
                    clsNotaFiscal.IDTransportadora = Convert.ToInt32(adap["IDTransportadora"]);
                    clsNotaFiscal.IDCliente = Convert.ToInt32(adap["IDCliente"]);
                    clsNotaFiscal.iDFormaPagamento = Convert.ToInt32(adap["iDFormaPagamento"]);
                    clsNotaFiscal.ValorTotal = Convert.ToInt32(adap["ValorTotal"]);
                    clsNotaFiscal.DataCadastro = Convert.ToDateTime(adap["DataCadastro"]);

                    clsNotaFiscal.TipoSaidaEntrada = adap["TipoSaidaEntrada"].ToString();
                    clsNotaFiscal.DataSaidaEntrada = Convert.ToDateTime(adap["DataSaidaEntrada"]);

                    clsNotaFiscal.QtdTransporte = Convert.ToInt32(adap["QtdTransporte"]);
                    clsNotaFiscal.TipoTransporte = adap["TipoTransporte"].ToString();
                    clsNotaFiscal.EspecieTransporte = adap["EspecieTransporte"].ToString();
                    clsNotaFiscal.MarcaTransporte = adap["MarcaTransporte"].ToString();
                    clsNotaFiscal.NumeroTransporte = Convert.ToInt32(adap["NumeroTransporte"]);
                    clsNotaFiscal.PesoBruto = Convert.ToDouble(adap["PesoBruto"]);
                    clsNotaFiscal.PesoLiquido = Convert.ToDouble(adap["PesoLiquido"]);
                }

                return clsNotaFiscal;
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

        public static List<NotaFiscalTO> GetNotaFiscalBusca(String strNumeroNota, int intIDEmitente, int intIDCliente)
        {


            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {
                List<NotaFiscalTO> clsNotaFiscals = new List<NotaFiscalTO>();

                StringBuilder strSql = new StringBuilder();
                Boolean blnSqlWhere= false;
                strSql.Append(" SELECT notafiscal.*, emitente.nome as nomeEmitente, cliente.nome as nomeCliente FROM notafiscal INNER JOIN Emitente ON emitente.idEmitente = notafiscal.idemitente INNER JOIN Cliente On cliente.idCliente = notafiscal.idCliente ");

                if (!string.IsNullOrEmpty(strNumeroNota))
                {
                    if (!blnSqlWhere)
                    {
                        strSql.Append(" WHERE notafiscal.idnotafiscal = @Notafiscal ");
                        blnSqlWhere = true;
                    }
                    else
                    {
                        strSql.Append(" AND notafiscal.idnotafiscal = @Notafiscal ");
                    }
                }

                if (intIDEmitente != 0 )
                {
                    if (!blnSqlWhere)
                    {
                        blnSqlWhere = true;
                        strSql.Append(" WHERE notafiscal.idemitente = @idemitente ");
                    }
                    else
                    {
                        strSql.Append(" AND notafiscal.idemitente = @idemitente ");
                    }
                }
                if (intIDCliente != 0)
                {
                    if (!blnSqlWhere)
                    {
                        blnSqlWhere = true;
                        strSql.Append(" WHERE notafiscal.idcliente = @idcliente ");
                    }
                    else
                    {
                        strSql.Append(" AND notafiscal.idcliente = @idcliente ");
                    }
                }

                //string strSql = "SELECT notafiscal.*, emitente.nome as nomeEmitente, cliente.nome as nomeCliente FROM notafiscal INNER JOIN Emitente ON emitente.idEmitente = notafiscal.idemitente INNER JOIN Cliente On cliente.idCliente = notafiscal.idCliente";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@Notafiscal", strNumeroNota);
                cmd.Parameters.AddWithValue("@idemitente", intIDEmitente);
                cmd.Parameters.AddWithValue("@idcliente", intIDCliente);
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();

                while (adap.Read())
                {
                    NotaFiscalTO clsNotaFiscal = new NotaFiscalTO();

                    clsNotaFiscal.IDNotaFiscal = Convert.ToInt32(adap["IDNotaFiscal"]);
                    clsNotaFiscal.IDEmitente = Convert.ToInt32(adap["IDEmitente"]);
                    clsNotaFiscal.IDTransportadora = Convert.ToInt32(adap["IDTransportadora"]);
                    clsNotaFiscal.IDCliente = Convert.ToInt32(adap["IDCliente"]);
                    clsNotaFiscal.iDFormaPagamento = Convert.ToInt32(adap["iDFormaPagamento"]);
                    clsNotaFiscal.ValorTotal = Convert.ToInt32(adap["ValorTotal"]);
                    clsNotaFiscal.DataCadastro = Convert.ToDateTime(adap["DataCadastro"]);

                    clsNotaFiscal.TipoSaidaEntrada = adap["TipoSaidaEntrada"].ToString();

                    clsNotaFiscal.DataSaidaEntrada = Convert.ToDateTime(adap["DataSaidaEntrada"]);



                    clsNotaFiscal.QtdTransporte = Convert.ToInt32(adap["QtdTransporte"]);
                    clsNotaFiscal.TipoTransporte = adap["TipoTransporte"].ToString();
                    clsNotaFiscal.EspecieTransporte = adap["EspecieTransporte"].ToString();
                    clsNotaFiscal.MarcaTransporte = adap["MarcaTransporte"].ToString();
                    clsNotaFiscal.NumeroTransporte = Convert.ToInt32(adap["NumeroTransporte"]);
                    clsNotaFiscal.PesoBruto = Convert.ToDouble(adap["PesoBruto"]);
                    clsNotaFiscal.PesoLiquido = Convert.ToDouble(adap["PesoLiquido"]);

                    clsNotaFiscal.NomeCliente = adap["nomeCliente"].ToString();
                    clsNotaFiscal.NomeEmitente = adap["nomeEmitente"].ToString();

                    clsNotaFiscals.Add(clsNotaFiscal);
                }

                return clsNotaFiscals;
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
        public static void insert(NotaFiscalTO clsNotaFiscal)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("INSERT INTO NotaFiscal(IDEmitente, IDTransportadora,IDCliente,iDFormaPagamento,ValorTotal,DataCadastro, TipoSaidaEntrada,DataSaidaEntrada, QtdTransporte, TipoTransporte, EspecieTransporte, MarcaTransporte, NumeroTransporte, PesoBruto,  PesoLiquido) ");
                strSql.Append("VALUES (@IDEmitente, @IDTransportadora,@IDCliente,@iDFormaPagamento,@ValorTotal,@DataCadastro, @TipoSaidaEntrada,@DataSaidaEntrada, @QtdTransporte, @TipoTransporte, @EspecieTransporte, @MarcaTransporte, @NumeroTransporte, @PesoBruto,  @PesoLiquido); ");
                strSql.Append("SELECT NotaFiscal.* FROM NotaFiscal WHERE NotaFiscal.IDNotaFiscal=@@IDENTITY;");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDEmitente", clsNotaFiscal.IDEmitente);
                cmd.Parameters.AddWithValue("@IDTransportadora", clsNotaFiscal.IDTransportadora);
                cmd.Parameters.AddWithValue("@IDCliente", clsNotaFiscal.IDCliente);
                cmd.Parameters.AddWithValue("@iDFormaPagamento", clsNotaFiscal.iDFormaPagamento);
                cmd.Parameters.AddWithValue("@ValorTotal", clsNotaFiscal.ValorTotal);
                cmd.Parameters.AddWithValue("@DataCadastro", clsNotaFiscal.DataCadastro);

                cmd.Parameters.AddWithValue("@TipoSaidaEntrada", clsNotaFiscal.TipoSaidaEntrada);
                cmd.Parameters.AddWithValue("@DataSaidaEntrada", clsNotaFiscal.DataSaidaEntrada);
                cmd.Parameters.AddWithValue("@QtdTransporte", clsNotaFiscal.QtdTransporte);
                cmd.Parameters.AddWithValue("@TipoTransporte", clsNotaFiscal.TipoTransporte);
                cmd.Parameters.AddWithValue("@EspecieTransporte", clsNotaFiscal.EspecieTransporte);
                cmd.Parameters.AddWithValue("@MarcaTransporte", clsNotaFiscal.MarcaTransporte);
                cmd.Parameters.AddWithValue("@NumeroTransporte", clsNotaFiscal.NumeroTransporte);
                cmd.Parameters.AddWithValue("@PesoBruto", clsNotaFiscal.PesoBruto);
                cmd.Parameters.AddWithValue("@PesoLiquido", clsNotaFiscal.PesoLiquido);

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
        public static Boolean Delete(NotaFiscalTO clsNotaFiscal)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM NotaFiscal WHERE IDNotaFiscal=@IDNotaFiscal");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDNotaFiscal", clsNotaFiscal.IDNotaFiscal);

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
        public static Boolean Update(NotaFiscalTO clsNotaFiscal)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("UPDATE NotaFiscal SET IDEmitente=@IDEmitente, IDTransportadora=@IDTransportadora,IDCliente=@IDCliente,iDFormaPagamento=@iDFormaPagamento,ValorTotal=@ValorTotal,DataCadastro=@DataCadastro, TipoSaidaEntrada=@TipoSaidaEntrada, DataSaidaEntrada=@DataSaidaEntrada, QtdTransporte=@QtdTransporte, TipoTransporte=@TipoTransporte, EspecieTransporte=@EspecieTransporte, MarcaTransporte=@MarcaTransporte, NumeroTransporte=@NumeroTransporte, PesoBruto=@PesoBruto,  PesoLiquido=@PesoLiquido WHERE IDNotaFiscal=@IDNotaFiscal ");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDNotaFiscal", clsNotaFiscal.IDNotaFiscal);
                cmd.Parameters.AddWithValue("@IDEmitente", clsNotaFiscal.IDEmitente);
                cmd.Parameters.AddWithValue("@IDTransportadora", clsNotaFiscal.IDTransportadora);
                cmd.Parameters.AddWithValue("@IDCliente", clsNotaFiscal.IDCliente);
                cmd.Parameters.AddWithValue("@iDFormaPagamento", clsNotaFiscal.iDFormaPagamento);
                cmd.Parameters.AddWithValue("@ValorTotal", clsNotaFiscal.ValorTotal);
                cmd.Parameters.AddWithValue("@DataCadastro", clsNotaFiscal.DataCadastro);

                cmd.Parameters.AddWithValue("@TipoSaidaEntrada", clsNotaFiscal.TipoSaidaEntrada);
                cmd.Parameters.AddWithValue("@DataSaidaEntrada", clsNotaFiscal.DataSaidaEntrada);
                cmd.Parameters.AddWithValue("@QtdTransporte", clsNotaFiscal.QtdTransporte);
                cmd.Parameters.AddWithValue("@TipoTransporte", clsNotaFiscal.TipoTransporte);
                cmd.Parameters.AddWithValue("@EspecieTransporte", clsNotaFiscal.EspecieTransporte);
                cmd.Parameters.AddWithValue("@MarcaTransporte", clsNotaFiscal.MarcaTransporte);
                cmd.Parameters.AddWithValue("@NumeroTransporte", clsNotaFiscal.NumeroTransporte);
                cmd.Parameters.AddWithValue("@PesoBruto", clsNotaFiscal.PesoBruto);
                cmd.Parameters.AddWithValue("@PesoLiquido", clsNotaFiscal.PesoLiquido);

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
