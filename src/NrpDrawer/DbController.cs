using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace NrpDrawer
{
    class DbController
    {
        private OleDbConnection connection;

        public void Connect(string filename)
        {
            connection =
                new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filename +
                                    ";Persist Security Info=False;");
            try
            {
                connection.Open();
                var da = new OleDbDataAdapter("select * from main_table", connection);
                var ds = new DataSet();
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Cannot connect to a database: " + ex.Message);
            }
        }

        public void Disconnect()
        {
            if (connection != null)
                connection.Close();
        }

        public void GetFromCurrentDate(DateTime value)
        {
            var da = new OleDbDataAdapter("select * from main_table where date = #" + value.ToShortDateString() + "#", connection);
            var ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                MessageBox.Show(ds.Tables[0].Rows[i]["temperature"].ToString());
        }
    }
}
