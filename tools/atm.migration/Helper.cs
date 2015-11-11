using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace atm.migration
{
    public static class SqlPersistenceHelper
    {

        public static int? GetNullableInt32(this SqlDataReader reader, int col)
        {
            var val = reader.GetValue(col);
            if (val == DBNull.Value) return null;
            return (int) val;
        }

        public static DateTime? GetNullableDateTime(this SqlDataReader reader, int col)
        {
            var val = reader.GetValue(col);
            if (val == DBNull.Value) return null;
            return (DateTime) val;
        }

    }
}