using System;
using System.Runtime.Serialization;
using Newtonsoft.Json.Serialization;

namespace SevenH.MMCSB.Atm.Web
{
    public class NHibernateContractResolver : DefaultContractResolver
    {
        protected override JsonContract CreateContract(Type objectType)
        {
            if (typeof(NHibernate.Proxy.INHibernateProxy).IsAssignableFrom(objectType))
                return base.CreateContract(objectType.BaseType);
            else
                return base.CreateContract(objectType);
        }
    }
}