using System;
using System.Data;

namespace NrpDrawer
{
    class DbItem
    {
        public double Temperature { private set; get; }
        public DateTime Date { get; private set; }
        public int Observation { get; private set; }
        public int MucusType { get; private set; }

        public DbItem(DataRow row)
        {
            Temperature = Convert.ToDouble(row["temperature"]);
            Date = Convert.ToDateTime(row["insert_date"]);
            Observation = Convert.ToInt32(row["base_observation"]);
            MucusType = Convert.ToInt32(row["mucus_type"]);
        }
    }
}
