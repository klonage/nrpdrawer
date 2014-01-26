using System;
using System.Data;

namespace NrpDrawer
{
    class DbItem
    {
        public double Temperature { private set; get; }
        public DateTime Date { get; private set; }

        public DbItem(DataRow row)
        {
            Temperature = Convert.ToDouble(row["temperature"]);
            Date = Convert.ToDateTime(row["insert_date"]);
        }
    }
}
