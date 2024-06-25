using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace santex
{
    class DBconnector
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ph1l1n\\source\\repos\\santex\\santex\\BDsantex.mdf;Integrated Security=True;Connect Timeout=30");

        public void OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
            }
            catch
            {
                MessageBox.Show("не работает подключение к бд");

            }
        }

        public void CloseConnection()
        {
            connection.Close();
        }
        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
