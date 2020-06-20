using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Services
{
    class ConexaoBanco
    {
        protected MySqlConnection link;

        public ConexaoBanco()
        {
            try
            {
                link = new MySqlConnection("Server=localhost;Database=launchr;Uid=root;Pwd=password");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Connect()
        {
            if (link.State != ConnectionState.Open)
            {
                link.Open();
            }
        }

        public void Disconnect()
        {
            if (link.State != ConnectionState.Closed)
            {
                link.Close();
            }
        }

        public MySqlDataReader Search(MySqlCommand cmd)
        {
            try
            {

                cmd.Connection = link;
                return cmd.ExecuteReader();

            }
            catch (Exception e)
            {
                Disconnect();
                Console.WriteLine(e);
                throw;
            }
        }
        public void Exec(MySqlCommand cmd)
        {
            try
            {
                cmd.Connection = link;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Disconnect();
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
