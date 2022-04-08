using System.Data;
using Npgsql;

namespace CarRental
{
    public class DatabaseConnection
    {
        public string auth = "Server=localhost;Port=5432;Database=CarRental;User Id=postgres;Password=aXk9JHacRVOXZqJfhzQP";
        public NpgsqlConnection conn;
        public NpgsqlCommand comm;
        public NpgsqlDataReader dr;
        public DataTable dt;

        public DatabaseConnection()
        {
            dt = new DataTable();
        }

        public void connectToDatabase()
        {
            conn = new NpgsqlConnection(auth);
            conn.Open();
            comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
        }
        public void disconnectFromDatabase()
        {
            comm.Dispose();
            conn.Close();
        }

        public void query(string s)
        {
            connectToDatabase();
            dt.Clear();
            comm.CommandText = s;
            dr = comm.ExecuteReader();
            if(dr.HasRows)
            {
                dt.Load(dr);
            }
            dr.Close();
            disconnectFromDatabase();
        }
    }
}
