using System;
using System.Runtime.Serialization;
using Newtonsoft.Json.Serialization;

namespace SevenH.MMCSB.Atm.Web
{
    public class NHibernateContractResolver : DefaultContractResolver
    {
        protected override JsonContract CreateContract(Type objectType)
        {
            /* Behavior in base we're overriding:
            if (typeof(ISerializable).IsAssignableFrom(objectType))
                return CreateISerializableContract(objectType);
            //*/

            if (objectType.IsAutoClass
                  && objectType.Namespace == null
                  && typeof(ISerializable).IsAssignableFrom(objectType))
            {

                return base.CreateObjectContract(objectType);
            }

            return base.CreateContract(objectType);
        }
    }
}