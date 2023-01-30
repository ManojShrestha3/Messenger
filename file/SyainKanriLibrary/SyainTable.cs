using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyainKanriLibrary
{
    public class SyainTable
    {
        public DataTable GetSyain()
        {
            DataTable table = new DataTable();

            string ConnectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM syain";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.Fill(table);
            }
        }
       
    }
}
