using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  //for the db

namespace TexnologiaLogismikou
{
    /*
     we created here the connection between our app and mysql db
     */
    internal class DBconnect
    {
        //create the connection
        MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=studentdb");

        //get the connection
        public MySqlConnection getconnection
        {
            get
            {
                return connect;
            }
        }

        // function to open connection
        public void openConnect()
        {
            if (connect.State==System.Data.ConnectionState.Closed)
                connect.Open();
        }

        //funcrion to close connection
        public void closeConnect()
        {
            if (connect.State==System.Data.ConnectionState.Open)
                connect.Close();
        }
    }
}
