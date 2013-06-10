using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuario;

namespace Usuario
{
    public class UsuarioDAL
    {

        #region Search
        public static List<UsuarioTO> listaUsuarioAll()
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {
                List<UsuarioTO> clsUsuarios = new List<UsuarioTO>();

                string strSql = "SELECT Usuario.* FROM Usuario";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();

                while (adap.Read())
                {
                    UsuarioTO clsUsuario = new UsuarioTO();

                    clsUsuario.ID = Convert.ToInt32(adap["idusuario"]);
                    clsUsuario.Nome = adap["nome"].ToString();
                    clsUsuario.Email = adap["login"].ToString();
                    clsUsuario.Password = adap["password"].ToString();
                    clsUsuario.IDTipoUsuario = Convert.ToInt32(adap["tipousuario"]);
                    clsUsuarios.Add(clsUsuario);
                }

                return clsUsuarios;
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
       
        public static UsuarioTO GetUsuarioByID(int ID)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {

                UsuarioTO clsUsuario = new UsuarioTO();

                string strSql = "SELECT Usuario.* FROM Usuario WHERE Usuario.idUsuario = @idusuario";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.Parameters.AddWithValue("@idusuario", ID);
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();
                while (adap.Read())
                {
                    clsUsuario.ID = Convert.ToInt32(adap["idusuario"]);
                    clsUsuario.Nome = adap["nome"].ToString();
                    clsUsuario.Email = adap["login"].ToString();
                    clsUsuario.Password = adap["password"].ToString();
                    clsUsuario.IDTipoUsuario = Convert.ToInt32(adap["tipousuario"]);
                }

                return clsUsuario;
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
        public static UsuarioTO GetUsuarioByNomeAndPassword(String strLogin, String strPassword)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {

                UsuarioTO clsUsuario = new UsuarioTO();

                string strSql = "SELECT Usuario.* FROM Usuario WHERE Usuario.login = @login AND Usuario.password = @password ";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.Parameters.AddWithValue("@login", strLogin);
                cmd.Parameters.AddWithValue("@password", strPassword);
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();
                while (adap.Read())
                {
                    clsUsuario.ID = Convert.ToInt32(adap["idusuario"]);
                    clsUsuario.Nome = adap["nome"].ToString();
                    clsUsuario.Email = adap["login"].ToString();
                    clsUsuario.Password = adap["password"].ToString();
                    clsUsuario.IDTipoUsuario = Convert.ToInt32(adap["tipousuario"]);
                }

                return clsUsuario;
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
        public static void insert(UsuarioTO clsUsuario)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("INSERT INTO usuario(login, nome, password,tipousuario)VALUES (@login,@nome,@password,@tipousuario);");
                strSql.Append("SELECT usuario.* FROM usuario WHERE usuario.idusuario=@@IDENTITY;");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@login", clsUsuario.Email);
                cmd.Parameters.AddWithValue("@nome", clsUsuario.Nome);
                cmd.Parameters.AddWithValue("@password", clsUsuario.Password);
                cmd.Parameters.AddWithValue("@tipousuario", clsUsuario.IDTipoUsuario);
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
        public static Boolean Delete(UsuarioTO clsUsuario)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM usuario WHERE idUsuario=@idUsuario");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@idUsuario", clsUsuario.ID);

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
        public static Boolean Update(UsuarioTO clsUsuario)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("UPDATE usuario SET login=@login, nome=@nome, password=@password, tipousuario=@tipousuario WHERE idUsuario=@idUsuario");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@idUsuario", clsUsuario.ID);
                cmd.Parameters.AddWithValue("@login", clsUsuario.Email);
                cmd.Parameters.AddWithValue("@nome", clsUsuario.Nome);
                cmd.Parameters.AddWithValue("@password", clsUsuario.Password);
                cmd.Parameters.AddWithValue("@tipousuario", clsUsuario.IDTipoUsuario);

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
