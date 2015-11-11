using System;
using System.Data;

namespace atm.migration
{
    static class Helper
    {
        public static DateTime? GetNullableDateTime(this IDataReader reader, int ordinal)
        {
            var val = reader[ordinal];
            if (val == DBNull.Value) return null;
            return (DateTime) val;
        }
        public static int? GetNullableInt32(this IDataReader reader, int ordinal)
        {
            var val = reader[ordinal];
            if (val == DBNull.Value) return null;
            return (int) val;
        }
        public static string ToString(this IDataReader reader, int ordinal)
        {
            var val = reader[ordinal];
            if (val == DBNull.Value) return null;
            return (string) val;
        }
    }
}