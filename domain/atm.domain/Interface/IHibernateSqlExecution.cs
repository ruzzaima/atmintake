using NHibernate;

namespace SevenH.MMCSB.Atm.Domain
{
    public interface IHibernateSqlExecution
    {
        IQuery SelectQuery(string sql);
        int ExecuteQuery(string sql);
    }
}
