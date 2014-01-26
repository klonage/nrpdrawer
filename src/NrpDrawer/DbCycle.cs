using System;
using System.Data;

namespace NrpDrawer
{
    internal class DbCycle
    {
        public DateTime BeginDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public bool Affected { get; private set; }

        public DbCycle(DataRow row)
        {
            BeginDate = Convert.ToDateTime(row["begin_date"]);
            if (string.IsNullOrEmpty(row["end_date"].ToString()))
            {
                EndDate = DateTime.Now.AddDays(-1);
                Affected = true;
            }
            else
            {
                EndDate = Convert.ToDateTime(row["end_date"]);
                Affected = false;
            }
        }
    }
}
