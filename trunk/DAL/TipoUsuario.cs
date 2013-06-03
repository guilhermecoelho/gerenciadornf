using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipoUsuario;

namespace TipoUsuario
{
    public class TipoUsuarioDAL
    {
        public static List<TipoUsuarioTO> listaTipoUsuario()
        {


            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();
            try
            {
                List<TipoUsuarioTO> clstipoUsuarios = new List<TipoUsuarioTO>();


                string strSql = "SELECT tipousuario.* FROM tipousuario";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();

                while (adap.Read())
                {
                    TipoUsuarioTO clstipoUsuario = new TipoUsuarioTO();
                    clstipoUsuario.Tipo = adap["tipo"].ToString();
                    clstipoUsuario.IDTipoUsuario = Convert.ToInt32(adap["idtipousuario"]);
                    clstipoUsuarios.Add(clstipoUsuario);
                }

               // clstipoUsuario.Add(ds);

                return clstipoUsuarios;
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
    }
}
