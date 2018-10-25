using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prtal.BIZ
{
    public class clsSystem
    {
        public static DataTable getSqlDataTypes(string DB)
        {
            DataTable dt = new DataTable();

            string query = "select ID,"+ DB + " from DATATYPES;";

            using (SQLiteConnection con = new SQLiteConnection("Data Source=datatypes.db3"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(con))
                {
                    con.Open();
                    cmd.CommandText = query;
                    SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                    da.Fill(dt);

                    con.Close();
                }
            }

            return dt;
        }
    }
}
