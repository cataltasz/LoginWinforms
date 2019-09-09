using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Server
    {
        static SqlConnection myConnection;
        static DataSet ds;
        static SqlDataAdapter da;
        static SqlCommand command;

        public static Server instance;
        private Server() {
            try
            {
                myConnection = new SqlConnection(@"Data Source = localhost\sqlexpress;Initial Catalog = Users; Integrated Security = True");
            }catch(Exception e) { System.Windows.Forms.MessageBox.Show(e.Message); }
        }

        public static DataSet getData(String user)
        {
            string com = "Select * From User_Info where Username='" + user + "'";
            if (instance == null) instance = new Server();
            da = new SqlDataAdapter(com, myConnection);
            ds = new DataSet();
            myConnection.Open();

            da.Fill(ds, "User_Info");
            myConnection.Close();
            return ds;
        }

        public static void insert(String com)
        {
            if (instance == null) instance = new Server();
            command = new SqlCommand();
            myConnection.Open();
            command.Connection = myConnection;
            command.CommandText = com;
            command.ExecuteNonQuery();
            myConnection.Close();
        }
    }
}
