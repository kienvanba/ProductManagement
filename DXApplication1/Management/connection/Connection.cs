using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Management.connection {
    class Connection {
        private static Connection instance;
        private Connection() { }
        public static Connection getInstance() {
            if(instance == null) {
                return new Connection();
            }
            return instance;
        }

        public void startConnect() {
            string con = "server=KENJI\\SERVER;database=QLVT;Integrated Security=SSPI;";
            SqlConnection connect = new SqlConnection(con);
            try {
                connect.Open();
                Debug.WriteLine("Connection open successfully");
            } catch(SqlException ex) {
                Console.WriteLine(ex);
                
            }
        }
    }
}
