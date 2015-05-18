using System;
using System.Collections.Generic;
using System.Text;
using Spring.Context.Support;

namespace SevenH.MMCSB.Atm.Domain
{
    public static class ObjectBuilder
    {
        /// <summary>
        /// ePayment
        /// </summary>
        public const string ContextName = "AtmIntake";

        /// <summary>
        /// Retrieve an implementation for the interface via Springs Framework, as specified by the default context name, i.e. ePayment
        /// </summary>
        /// <typeparam name="T">The interface type</typeparam>
        /// <param name="key">the key to the objert</param>
        /// <returns>the implementation</returns>
        public static T GetObject<T>(string key) where T : class
        {
            return ContextRegistry.GetContext().GetObject(key) as T;
        }

        /// <summary>
        /// Retrieve an implementation for the interface via Springs Framework, as specified by the context name
        /// </summary>
        /// <typeparam name="T">The interface type</typeparam>
        /// <param name="key">the key to the objert</param>
        /// <param name="contextName">Specify your own spring context name</param>
        /// <returns>the implementation</returns>
        public static T GetObject<T>(string key, string contextName) where T : class
        {
            return ContextRegistry.GetContext().GetObject(key) as T;
        }
    }
}
