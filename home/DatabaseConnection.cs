using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace home
{
    public class DatabaseConnection
    {
        //kết nối với CSDL
        public string strCon = @"Data Source=Phong\SQLPXP;Initial Catalog=QLTV;Integrated Security=True;";
        public SqlConnection slqCon = null;

        //ham ket noi
        public void MoKetNoi()
        {
            if (slqCon == null)
            {
                slqCon = new SqlConnection(strCon);
            }

            if (slqCon.State == ConnectionState.Closed)
            {
                slqCon.Open();
            }
        }

        //ham ngat ket noi
        public void DongKetNoi()
        {
            if (slqCon != null && slqCon.State == ConnectionState.Open)
            {
                slqCon.Close();
            }
        }
    }
}
