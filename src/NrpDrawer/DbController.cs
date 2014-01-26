﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;

namespace NrpDrawer
{
    internal class DbController
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

        public DbItem GetFromCurrentDate(DateTime value)
        {
            var da = new OleDbDataAdapter("select * from main_table where insert_date = #" + value.ToShortDateString() + "#",
                connection);
            var ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 1)
                throw new Exception("Unexpected row count in database. Expected 1 but has " + ds.Tables[0].Rows.Count);

            return new DbItem(ds.Tables[0].Rows[0]);
        }

        public IEnumerable<DbItem> GetFromRangeOfDate(DateTime begin, DateTime end)
        {
            var da =
                new OleDbDataAdapter(
                    "select * from main_table where insert_date BETWEEN @StartDate AND @EndDate order by insert_date",
                    connection);
            da.SelectCommand.Parameters.AddWithValue("@StartDate", begin);
            da.SelectCommand.Parameters.AddWithValue("@EndDate", end);

            var ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                yield return new DbItem(ds.Tables[0].Rows[i]);
        }

        public void InsertValue(double temperature, DateTime date, int observation, int mucusType)
        {
            bool update = true;
            try
            {
                GetFromCurrentDate(date);
            }
            catch (Exception)
            {
                update = false;
            }
            var cmd = new OleDbCommand
            {
                Connection = connection,
                CommandType = CommandType.Text
            };

            if (update)
                cmd.CommandText =
                    "update main_table set temperature = " + temperature.ToString(CultureInfo.InvariantCulture) +
                    ", base_observation = "+observation + ", mucus_type = " + mucusType + " where insert_date = #" +
                    date.ToShortDateString() +
                    "#";
            else
                cmd.CommandText = "insert into main_table(insert_date, temperature, base_observation, mucus_type) values(#" + date.ToShortDateString() +
                                  "#, " + temperature.ToString(CultureInfo.InvariantCulture) + ", " + observation + ", " + mucusType + ");";

            if (cmd.ExecuteNonQuery() != 1)
            {
                throw new Exception("Cannot " + (update ? "update" : "insert") + " value");
            }
        }

        public void RemoveValue(DateTime date)
        {
            var cmd = new OleDbCommand
            {
                Connection = connection,
                CommandType = CommandType.Text,
                CommandText = "delete from main_table where insert_date = #" + date.ToShortDateString() + "#"
            };

            if (cmd.ExecuteNonQuery() != 1)
            {
                throw new Exception("Cannot remove item");
            }
        }
    }
}