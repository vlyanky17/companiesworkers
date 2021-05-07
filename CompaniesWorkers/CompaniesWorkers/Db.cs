using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompaniesWorkers
{
    class Db //класс базы данных
    {
        MySqlConnection Connect = new MySqlConnection("server=localhost;port=8889;username=root;password=root;database=workerscompanies");
        public void OpenCon()
        {
            if (Connect.State == System.Data.ConnectionState.Closed)
            {
                Connect.Open();
            }
        }
        public void CloseCon()
        {
            if (Connect.State == System.Data.ConnectionState.Open)
            {
                Connect.Close();
            }
        }
        public MySqlConnection Connection()
        {
            return Connect;
        }
    }
}
