using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Data.SqlTypes;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

namespace SevenH.MMCSB.Atm.Domain
{
    public static class XmlSerializerService
    {
        /// <summary>
        /// Clone object, deep copy
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T Clone<T>(T source) where T : class
        {

            using (MemoryStream stream = new MemoryStream())
            {
                ToXmlStream<T>(stream, source);
                stream.Position = 0;
                T clone = XmlSerializerService.DeserializeFromXml<T>(stream);

                return clone;
            }

        }

        public static TOutput Convert<TInput, TOutput>(TInput input)
            where TInput : class
            where TOutput : class
        {
            using (MemoryStream stream = new MemoryStream())
            {
                ToXmlStream<TInput>(stream, input);
                stream.Position = 0;
                TOutput clone = XmlSerializerService.DeserializeFromXml<TOutput>(stream);

                return clone;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xmlReader"></param>
        /// <returns></returns>
        public static T DeserializeFromXml<T>(XmlReader xmlReader)
        {
            XmlSerializer ser = GetDefaultSerializer(typeof(T));
            return (T)ser.Deserialize(xmlReader);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="xmlReader"></param>
        /// <returns></returns>
        public static T DeserializeFromXml<T>(SqlXml sql)
        {
            if (sql.IsNull) return default(T);

            using (XmlReader xmlReader = sql.CreateReader())
            {
                XmlSerializer ser = GetDefaultSerializer(typeof(T));
                return (T)ser.Deserialize(xmlReader);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="xmlstring"></param>
        /// <returns></returns>
        public static T DeserializeFromXml<T>(string xmlString) where T : class
        {
            if (string.IsNullOrEmpty(xmlString))
            {
                return default(T);
            }

            XmlSerializer ser = GetDefaultSerializer(typeof(T));
            //
            // to write xml to memory stream and deserialize it
            using (MemoryStream stream = new MemoryStream())
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write((string)xmlString);
                    writer.Flush();

                    stream.Position = 0;
                    T data = ser.Deserialize(stream) as T;
                    return data;
                }
            }
        }

        /// <summary>
        /// Desrialize from stream
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static T DeserializeFromXml<T>(Stream stream) where T : class
        {
            if (null == stream)
            {
                return default(T);
            }

            XmlSerializer ser = GetDefaultSerializer(typeof(T));
            //
            // to write xml to memory stream and deserialize it
            stream.Position = 0;
            T data = ser.Deserialize(stream) as T;
            return data;

        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string ToXmlString<T>(T value)
        {
            XmlSerializer serializer = GetDefaultSerializer(value.GetType());
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, value);
                writer.Flush();
                return writer.ToString();
            }
        }


        private static Dictionary<Type, XmlSerializer> m_serializers = new Dictionary<Type, XmlSerializer>(16);
        private static XmlSerializer GetDefaultSerializer(Type type)
        {
            if (!m_serializers.ContainsKey(type))
            {
                XmlSerializer serializer = new XmlSerializer(type, Strings.DefaultNamespace);
                if (!m_serializers.ContainsKey(type)) m_serializers.Add(type, serializer); // for the race condition
            }

            return m_serializers[type];
        }

        public static string ToXmlString(object value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            XmlSerializer serializer = GetDefaultSerializer(value.GetType());

            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, value);
                writer.Flush();
                return writer.ToString();
            }
        }

        /// <summary>
        /// Just a helper for the XmlSerializerService.ToXmlString(value)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToXmlString(this DomainObject value)
        {
            XmlSerializer serializer = GetDefaultSerializer(value.GetType());
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, value);
                writer.Flush();
                return writer.ToString();
            }
        }

        /// <summary>
        /// Helps to deserialize the XElement to DomainObject
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="element"></param>
        /// <returns></returns>
        public static T Deserialize<T>(this XElement element) where T : class
        {
           return  XmlSerializerService.DeserializeFromXml<T>(element.ToString());
        }

        /// <summary>
        /// Just a helper for the XmlSerializerService.ToXmlString(value)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static XElement ToXElement(this DomainObject value)
        {
            XmlSerializer serializer = GetDefaultSerializer(value.GetType());
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, value);
                writer.Flush();
                string xml = writer.ToString();
                return XElement.Parse(xml);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SqlXml ToSqlXml<T>(T value)
        {
            XmlSerializer serializer = GetDefaultSerializer(value.GetType());
            using (MemoryStream stream = new MemoryStream())
            {
                serializer.Serialize(stream, value);
                stream.Position = 0;
                return new SqlXml(stream);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static void ToXmlStream<T>(Stream stream, T value)
        {
            XmlSerializer serializer = GetDefaultSerializer(value.GetType());
            serializer.Serialize(stream, value);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="stream"></param>
        /// <param name="value"></param>
        public static void ToXmlStream<T>(Stream stream, object value)
        {
            XmlSerializer serializer = GetDefaultSerializer(value.GetType());
            serializer.Serialize(stream, value);
        }

        private static string UTF8ByteArrayToString(byte[] characters)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            string constructedString = encoding.GetString(characters);
            return (constructedString);
        }

        /// <summary>
        /// Serialize the objects into UTF8 encoded XML string
        /// </summary>
        /// <param name="graph"></param>
        /// <returns></returns>
        public static string ToUTF8EncodedXmlString(object graph)
        {
            if (graph == null) return string.Empty;


            string xml = null;
            MemoryStream strm = new MemoryStream();
            XmlSerializer xs = GetDefaultSerializer(graph.GetType());
            XmlTextWriter xmlTextWriter = new XmlTextWriter(strm, Encoding.UTF8);
            xs.Serialize(xmlTextWriter, graph);
            strm = (MemoryStream)xmlTextWriter.BaseStream;
            xml = UTF8ByteArrayToString(strm.ToArray());

            strm.Dispose();
            xmlTextWriter.Close();

            return xml;
        }


        /// <summary>
        /// This returns an object which the undelrlying type is the typeName
        /// </summary>
        /// <typeparam name="T">Object</typeparam>
        /// <param name="graph">graph</param>
        /// <param name="typeName">The actual type to cast to</param>
        /// <returns></returns>
        public static T DeserializeFromXml<T>(string graph, string typeName) where T : class
        {
            Type type = Type.GetType(typeName);
            if (string.IsNullOrEmpty(graph))
            {
                return null;
            }
            if (null == type)
            {
                type = Assembly.LoadFrom("domain.epayment.dll").GetType(typeName);
            }

            XmlSerializer ser = GetDefaultSerializer(typeof(T));
            //
            // to write xml to memory stream and deserialize it
            using (MemoryStream stream = new MemoryStream())
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write((string)graph);
                    writer.Flush();

                    stream.Position = 0;
                    return (T)ser.Deserialize(stream);
                }
            }
        }

        /// <summary>
        /// Creates and XElement from object graph for used in LINQ queries
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="graph"></param>
        /// <returns></returns>
        public static XElement ToXElement<T>(T graph)
        {
            using (MemoryStream stream = new MemoryStream())
            {

                XmlSerializer serializer = GetDefaultSerializer(typeof(T));
                ToXmlStream<T>(stream, graph);
                stream.Position = 0;

                using (XmlReader reader = XmlReader.Create(stream))
                {
                    XElement e = XElement.Load(reader);
                    return e;
                }
            }
        }
    }
}
