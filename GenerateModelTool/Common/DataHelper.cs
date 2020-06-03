using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateModelTool
{
    public class DataHelper
    {
        static MySqlConnection mysqlConn;
        public static string ConnDataBase(string conStr)
        {
            mysqlConn = new MySqlConnection(conStr);
            try
            {
                mysqlConn.Open();
                return "Y";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public static DataTable GetTable(string sql)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, mysqlConn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "sdm");
            return dataSet.Tables["sdm"];
        }
    }
}
