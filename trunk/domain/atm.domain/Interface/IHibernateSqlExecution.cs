using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;

namespace SevenH.MMCSB.Atm.Domain
{
    public interface IHibernateSqlExecution
    {
        IQuery SelectQuery(string sql);
        int ExecuteQuery(string sql);
    }
}
