using System;
using System.Reflection;
using System.Web;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace SevenH.MMCSB.Persistance
{
    class Factory
    {

        const string SessionKey = "MySession";

        private static NHibernate.ISessionFactory _sf;

        public static ISessionFactory SessionFactory
        {
            get
            {
                if ((_sf == null))
                {

                    _sf  = Fluently.Configure()
                           .Database(config: FluentNHibernate.Cfg.Db.MsSqlConfiguration.MsSql2008
                            .ConnectionString("data source=bo3-pc\\sqlexpressdnf;initial catalog=dbpengambilan;integrated security=true")
                            #if DEBUG
                            .ShowSql()
                            .FormatSql()
                            #endif
                            .Dialect<NHibernate.Dialect.MsSql2012Dialect>()
                            .AdoNetBatchSize(50))
                            .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.Load("atm.domain")))
                            .BuildSessionFactory();
   }
                return _sf;
            }
        }

        public static ISession OpenSession(int val = 0)
        {
            var context = HttpContext.Current;
            ISession newSession;
            try
            {
                if (context != null && context.Items.Contains(SessionKey))
                {
                    //Return already open ISession
                    if (val==0)
                    {
                       HttpRuntime.Cache["context"] = context;
                    return (ISession)context.Items[SessionKey];  
                    }
                    else
                    {
                        newSession = SessionFactory.OpenSession();
                        return newSession;
                    }
                 
                }
                else
                {
                    //Create new ISession and store in HttpContext
                    newSession = SessionFactory.OpenSession();
                    if (context != null && val == 0)
                    {
                        context.Items[SessionKey] = newSession;

                        return newSession;
                    }
                    if (context != null) return (ISession)context.Items[SessionKey];
                }
            }
            catch (Exception)
            {
                HttpContext.Current = (HttpContext) HttpRuntime.Cache["context"];
                if (context != null) return (ISession)context.Items[SessionKey];
            }
            return  newSession = SessionFactory.OpenSession();
        }
    }
}