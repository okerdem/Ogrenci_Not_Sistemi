using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FacadeLayer
{
    class SqlBaglantisi
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-Q087NT7\SQLEXPRESS;Initial Catalog=dbkatman;Integrated Security=True");
    }
}
