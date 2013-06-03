using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Item;
using System.Data;

namespace Item
{
    public class ItemDAL
    {
        #region Search
        public static List<ItemTO> listaItemAll()
        {
            try
            {
                List<ItemTO> clsItems = new List<ItemTO>();


                String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

                MySqlConnection connection = new MySqlConnection(myConnection);
                MySqlCommand cmd;
                connection.Open();

                string strSql = "SELECT Item.* FROM Item";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();

                while (adap.Read())
                {
                    ItemTO clsItem = new ItemTO();

                    clsItem.IDItem = Convert.ToInt32(adap["IDItem"]);
                    clsItem.Nome = adap["nome"].ToString();
                    clsItem.Descricao = adap["Descricao"].ToString();

                    clsItems.Add(clsItem);
                }

                return clsItems;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }
       
        public static ItemTO GetItemByID(int IDItem)
        {
            try
            {

                ItemTO clsItem = new ItemTO();

                String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

                MySqlConnection connection = new MySqlConnection(myConnection);
                MySqlCommand cmd;
                connection.Open();

                string strSql = "SELECT Item.* FROM Item WHERE Item.IDItem = @IDItem";

                cmd = connection.CreateCommand();
                cmd.CommandText = strSql;
                cmd.Parameters.AddWithValue("@IDItem", IDItem);
                cmd.ExecuteNonQuery();

                MySqlDataReader adap = cmd.ExecuteReader();
                while (adap.Read())
                {
                    clsItem.IDItem = Convert.ToInt32(adap["IDItem"]);
                    clsItem.Nome = adap["nome"].ToString();
                    clsItem.Descricao = adap["Descricao"].ToString();

                }

                return clsItem;
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
        public static void insert(ItemTO clsItem)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("INSERT INTO Item(IDItem, Nome, Descricao) ");
                strSql.Append("VALUES (@IDItem, @Nome, @Descricao); ");
                strSql.Append("SELECT Item.* FROM Item WHERE Item.IDItem=@@IDENTITY;");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDItem", clsItem.IDItem);
                cmd.Parameters.AddWithValue("@Nome", clsItem.Nome );
                cmd.Parameters.AddWithValue("@Descricao", clsItem.Descricao);



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
        public static Boolean Delete(ItemTO clsItem)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM Item WHERE IDItem=@IDItem");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDItem", clsItem.IDItem);

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
        public static Boolean Update(ItemTO clsItem)
        {

            String myConnection = "Server=localhost;Database=gerenciadornf;Uid=root;Pwd=;";

            MySqlConnection connection = new MySqlConnection(myConnection);
            MySqlCommand cmd;
            connection.Open();

            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("UPDATE Item SET IDItem=@IDItem,Nome=@Nome,Descricao=@Descricao ");

                cmd = connection.CreateCommand();

                cmd.CommandText = strSql.ToString();
                cmd.Parameters.AddWithValue("@IDItem", clsItem.IDItem);
                cmd.Parameters.AddWithValue("@Nome", clsItem.Nome);
                cmd.Parameters.AddWithValue("@Descricao", clsItem.Descricao);

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
