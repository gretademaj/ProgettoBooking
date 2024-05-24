using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    internal class Db
    {
        public List<Tabella1Item> LeggiDati()
        {
            var connection = GetConnection();
            SqlDataReader sqlDataReader = null;
            try
            {
                var items = new List<Tabella1Item>();


                SqlCommand cmd;


                cmd = connection.CreateCommand();
                cmd.CommandText = SqlResources.LeggiDati;
                cmd.CommandType = System.Data.CommandType.Text;
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var item = new Tabella1Item();
                    item.Id = sqlDataReader.GetInt32(0);
                    item.Descrizione = sqlDataReader.GetString(1);
                    items.Add(item);
                }
                return items;

            }

            catch (Exception e)
            {
                Console.WriteLine($"Processing failed: {e.Message}");
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                    sqlDataReader = null;
                }
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return new List<Tabella1Item>();


        }

        public void ScriviDati()
        {
            

           var connection = GetConnection();

            try
            {
                var insertQuery = SqlResources.ScriviDati;
                var cmd = new SqlCommand(insertQuery, connection);
                cmd.Parameters.AddWithValue("@Id", 4);
                cmd.Parameters.AddWithValue("@Descrizione", "Test 4");
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {

            }
        }

        public List<Tabella1Item> UpdateDati()
        {
           var connection = GetConnection();    
            SqlDataReader sqlDataReader = null;
            try
            {
                var items = new List<Tabella1Item>();
                SqlCommand cmd;
                cmd = connection.CreateCommand();
                cmd.CommandText = SqlResources.UpdateDati;
                cmd.CommandType = System.Data.CommandType.Text;
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var item = new Tabella1Item();
                    item.Id = sqlDataReader.GetInt32(0);
                    item.Descrizione = sqlDataReader.GetString(1);
                    items.Add(item);
                }
                return items;

            }

            catch (Exception e)
            {
                Console.WriteLine($"Processing failed: {e.Message}");
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                    sqlDataReader = null;
                }
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return new List<Tabella1Item>();


        
         }
        public void CancellaDati()
        {
            var connection = GetConnection();

            try
            {
                var deleteQuery = SqlResources.CancellaDati;
                var cmd = new SqlCommand(deleteQuery, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {

            }
        }

        private SqlConnection GetConnection()
        {
            var connenctionString = "Server=GRETA-DESKTOP\\SQLEXPRESS;Database=Booking;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connenctionString);
            connection.Open();  
            return connection;
        }
        public List<AllDipendenti> GetAllData()
        {

            var connection = GetConnection();
            SqlDataReader sqlDataReader = null;
            try
            {
                var items = new List<AllDipendenti>();


                SqlCommand cmd;


                cmd = connection.CreateCommand();
                cmd.CommandText = SqlResources.GetAllData;
                cmd.CommandType = System.Data.CommandType.Text;
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    var item = new AllDipendenti();
                    item.Id = sqlDataReader.GetInt32(0);
                    item.Nome = sqlDataReader.GetString(1);
                    item.Cognome = sqlDataReader.GetString(2);
                    item.Eta = sqlDataReader.GetInt32(3);
                    item.IdRuolo= sqlDataReader.GetInt32(4);
                    item.IdAziendaAmministrazione = sqlDataReader.GetInt32(5);
                    item.Stipendio = sqlDataReader.GetString(6);
                    item.Azienda = sqlDataReader.GetString(7);
                    items.Add(item);
                }
            return items;

            }
            catch (Exception e)
            {
                Console.WriteLine($"Processing failed: {e.Message}");
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                    sqlDataReader = null;
                }
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return new List<AllDipendenti>();
        }

    }
}
