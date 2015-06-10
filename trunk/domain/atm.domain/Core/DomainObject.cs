using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Serialization;

namespace SevenH.MMCSB.Atm.Domain
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public abstract class DomainObject : IDataErrorInfo, INotifyPropertyChanged, IEditableObject
    {
        [NonSerialized]
        private static TraceSource m_traceSource;

        protected virtual TraceSource TraceSource
        {
            get
            {
                if (null == m_traceSource)
                    m_traceSource = new TraceSource("Appication");
                return m_traceSource;
            }
        }

        /// <summary>
        /// Write into trace source
        /// </summary>
        /// <param name="id">error id</param>
        /// <param name="message">message format</param>
        /// <param name="args">args to the message format</param>
        protected virtual void TraceInfo(int id, string message, params object[] args)
        {
            TraceSource.TraceEvent(TraceEventType.Information, id, string.Format(message, args));
        }

        /// <summary>
        /// Write error trace source
        /// </summary>
        /// <param name="id">error id</param>
        /// <param name="message">message format</param>
        /// <param name="args">args to the message format</param>
        protected virtual void TraceError(int id, string message, params object[] args)
        {
            TraceSource.TraceEvent(TraceEventType.Error, id, string.Format(message, args));
        }

        [NonSerialized]
        private Dictionary<string, string> m_errors;

        [NonSerialized]
        private PropertyDescriptorCollection m_shape;
        [NonSerialized]
        Hashtable m_propertyHashtable;
        /// <summary>
        /// A flag to avoid stack calling OnPropertyChanging
        /// </summary>
        [NonSerialized]
        private bool m_setValueFlag;

        // private members	
        private bool m_dirty;
        ///<summary>
        ///A flag wether this instance has been modified or not</summary>
        [XmlIgnore]
        public virtual bool Dirty
        {
            get { return m_dirty; }
            set { m_dirty = value; }
        }

        private int m_bil;
        [XmlIgnore]
        public virtual int Bil
        {
            get { return m_bil; }
            set { m_bil = value; }
        }

        protected virtual bool IsInBlend()
        {
            return string.Equals(Process.GetCurrentProcess().ProcessName, "Blend", StringComparison.OrdinalIgnoreCase);
        }

        #region Public API
        public virtual bool HasErrors()
        {
            return (this.Errors.Count > 0);
        }
        #endregion

        #region Private API

        private Dictionary<string, string> Errors
        {
            get
            {
                if (null == m_errors)
                {
                    m_errors = new Dictionary<string, string>();
                }

                return m_errors;
            }
        }

        private PropertyDescriptorCollection Shape
        {
            get
            {
                if (null == m_shape)
                {
                    m_shape = TypeDescriptor.GetProperties(this);
                }

                return m_shape;
            }
        }
        #endregion

        #region INotifyPropertyChanged Members

        public virtual event PropertyChangedEventHandler PropertyChanged;
        public virtual event PropertyChangingEventHandler PropertyChanging;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            m_dirty = true;
            if (null != PropertyChanged)
            {
                PropertyChanged(this, e);
            }
        }
        #endregion

        #region IDataErrorInfo Members
        public virtual string Error
        {
            get { return ((Errors.Count > 0) ? "Business object is in an invalid state" : string.Empty); }
        }

        public virtual string this[string columnName]
        {
            get { return GetColumnError(columnName); }
        }

        private string GetColumn(string column)
        {
            string col = ((null == column) ? null : column.Trim().ToLower());

            if (string.IsNullOrEmpty(col) || (null == Shape.Find(col, true)))
            {
                throw new ArgumentException("Unable to find column: " + column);
            }

            return col;
        }

        protected virtual void SetColumnError(string column, string error)
        {
            string col = GetColumn(column);

            if (null == error)
            {
                Errors.Remove(col);
            }
            else
            {
                Errors[col] = error;
            }
        }

        protected virtual void ClearColumnErrors()
        {
            ClearColumnError(null);
        }

        protected virtual void ClearColumnError(string column)
        {
            if (String.IsNullOrEmpty(column))
            {
                Errors.Clear();
            }
            else
            {
                SetColumnError(column, null);
            }
        }

        protected virtual string GetColumnError(string column)
        {
            string col = GetColumn(column);

            return (Errors.ContainsKey(col) ? Errors[col] : null);
        }
        /// <summary>
        /// Validate the object and set the IDataError
        /// </summary>
        /// <returns></returns>
        public virtual bool Validate()
        {
            return true;
        }
        #endregion

        #region IEditableObject Members
        [NonSerialized]
        private bool m_usingIEditable;
        public virtual event EventHandler BeginEditFired;

        /// <summary>
        /// Workaround for Windows Forms BindingSource to have the tendency to call BeginEdit on every IEditableObject 
        /// </summary>
        /// <param name="useIEditableObject">true to begin to use IEditableObject</param>
        public virtual void BeginEdit(bool useIEditableObject)
        {
            m_usingIEditable = useIEditableObject;
            BeginEdit();
        }
        /// <summary>
        /// Creates a temporary store before changes made to this instance is commited, see EndEdit and CancelEdit for followup
        /// NOTE : call BeginEdit(true) to actually use this interface
        /// </summary>
        public virtual void BeginEdit()
        {
            if (!m_usingIEditable) return;
            if (null != BeginEditFired) BeginEditFired(this, EventArgs.Empty);

            if (null == m_propertyHashtable)
            {
                PropertyInfo[] props = (this.GetType()).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                m_propertyHashtable = new Hashtable(props.Length - 1);
            }
        }

        /// <summary>
        /// CancelEdit would discard the temporary store , since BeginEdit is called thus it would not be committed,
        /// use EndEdit to commit the changes to the instance
        /// </summary>
        public virtual void CancelEdit()
        {
            m_usingIEditable = false;
            m_propertyHashtable = null;
        }

        /// <summary>
        /// Calling EndEdit will commit all the transient values into the instance
        /// </summary>
        public virtual void EndEdit()
        {
            if (m_propertyHashtable == null) return;

            PropertyInfo[] props = (this.GetType()).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            for (int i = 0; i < props.Length; i++)
            {
                if (props[i].PropertyType.IsInterface) continue;
                if (!m_propertyHashtable.ContainsKey(props[i].Name)) continue;

                //check if there is set accessor
                try
                {
                    if (null != props[i].GetSetMethod())
                    {
                        m_setValueFlag = true;
                        props[i].SetValue(this, m_propertyHashtable[props[i].Name], null);
                    }
                }
                finally
                {
                    m_setValueFlag = false;
                }
            }
            CancelEdit();
        }


        /// <summary>
        /// Use for validation as well as IEditable object,
        /// for Editable object the value for the data will not be committed until the EndEdit is called
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="value"></param>
        protected virtual void OnPropertyChanging(PropertyChangingEventArgs e)
        {
            if (m_setValueFlag) return;
            if (null != PropertyChanging)
            {
                PropertyChanging(this, e);
                if (e.Cancel) return;
            }

            if (null != m_propertyHashtable)
            {
                if (m_propertyHashtable.ContainsKey(e.PropertyName))
                {
                    m_propertyHashtable[e.PropertyName] = e.NewValue;
                }
                else
                {
                    m_propertyHashtable.Add(e.PropertyName, e.NewValue);
                }
                e.Cancel = true;
            }
        }
        #endregion
    }
}
