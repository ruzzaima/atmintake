using SevenH.MMCSB.Atm.Domain;

namespace SevenH.MMCSB.Persistance
{
    class HibernateSqlExecution : IHibernateSqlExecution
    {
        public NHibernate.IQuery SelectQuery(string sql)
        {
            if (!string.IsNullOrWhiteSpace(sql))
            {
                var result = Factory.OpenSession().CreateSQLQuery(sql);
                return result;
            }
            
            return null;
        }

        public int ExecuteQuery(string sql)
        {
            if (!string.IsNullOrWhiteSpace(sql))
            {
                var result = Factory.OpenSession().CreateSQLQuery(sql).ExecuteUpdate();
                return result;
            }

            return 0;
        }
    }
}
