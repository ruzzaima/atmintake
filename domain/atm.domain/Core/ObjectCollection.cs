using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SevenH.MMCSB.Atm.Domain
{
    [Serializable]
    /// <summary>
    /// Use this collection for all "value objects" collection, we've got tonnes of use events,
    /// checkout the OnCollectionItemChanged
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ObjectCollection<T> : ObservableCollection<T>
    {

        #region "private methods and ovveridden methods"
        public ObjectCollection()
        {

        }



        public ObjectCollection(IEnumerable<T> list)
        {
            AddRange(list);
        }
        /// <summary>
        /// Add the collection of the items in to the collection
        /// </summary>
        /// <param name="items"></param>
        public void AddRange(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                Add(item);
            }

        }

        /// <summary>
        /// Add the collection of the items in to the collection
        /// </summary>
        /// <param name="items"></param>
        public void AddRange(params T[] items)
        {

            foreach (T item in items)
            {
                Add(item);
            }
        }

        #endregion

        #region "ILIst stuff"
        public void Sort(Comparison<T> comparison)
        {
            var list = new List<T>(this);
            list.Sort(comparison);

            base.ClearItems();
            int index = 0;
            foreach (T item in list)
            {
                base.InsertItem(index, item);
                index++;
            }


        }

        public void Sort(IComparer<T> comparer)
        {
            this.Sort(0, this.Count, comparer);
        }
        public void Sort()
        {
            this.Sort(0, this.Count, null);
        }


        public void Sort(int index, int count, IComparer<T> comparer)
        {
            if ((index < 0) || (count < 0))
            {
                throw new ArgumentOutOfRangeException();
            }
            if ((this.Count - index) < count)
            {
                throw new ArgumentException("ExceptionResource.Argument_InvalidOffLen");
            }
            Array.Sort(this.ToArray(), index, count, comparer);
        }




        public T[] ToArray()
        {
            var list = new List<T>(this);
            return list.ToArray();
        }

        public int FindIndex(int startIndex, Predicate<T> match)
        {
            return this.FindIndex(startIndex, this.Count - startIndex, match);
        }

        public int FindIndex(int startIndex, int count, Predicate<T> match)
        {
            if (startIndex > this.Count)
            {
                //ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_Index);
            }
            if ((count < 0) || (startIndex > (this.Count - count)))
            {
                //ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_Count);
            }
            if (match == null)
            {
                //ThrowHelper.ThrowArgumentNullException(ExceptionArgument.match);
            }
            int num1 = startIndex + count;
            for (int num2 = startIndex; num2 < num1; num2++)
            {
                if (match != null)
                    if (match(this[num2]))
                    {
                        return num2;
                    }
            }
            return -1;

        }

#if !SILVERLIGHT
        /// <summary>
        /// Removes the all the elements that match the conditions defined by the specified  predicate.
        /// </summary>
        /// <param name="match">The System.Predicate delegate that defines the conditions of the elements  to remove</param>
        /// <returns>The number of elements removed from the System.Collections.Generic.List<T></returns>
        public int RemoveAll(Predicate<T> match)
        {
            var list = new List<T>(this);
            int result = list.RemoveAll(match);

            base.ClearItems();
            int index = 0;
            foreach (T item in list)
            {
                base.InsertItem(index, item);
                index++;
            }

            return result;
        }
#else

        public int RemoveAll(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException("match");
            }

            int index = 0;
            while (this.Items.Any(t => match(t)))
            {
                index = 0;
                var has = false;
                for (int i = 0; i < this.Count; i++)
                {
                    if (match(this.Items[i]))
                    {
                        index = i;
                        has = true;
                        break;
                    }
                }
                //
                if (has)
                    this.RemoveAt(index);
            }

            return index;


        }
#endif

        /// <summary>
        /// Find an item 
        /// </summary>
        /// <param name="match"></param>
        /// <exception cref="ArgumentNullException">if the math predicate is null</exception>
        /// <returns></returns>
        public T Find(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException("match", "match is null");
            }

            foreach (T item in this.Items)
            {
                if (match(item))
                {
                    return item;
                }
            }
            return default(T);
        }

        public ObjectCollection<T> FindAll(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException("match", "match is null");
            }
            var list1 = new ObjectCollection<T>();
            for (int num1 = 0; num1 < this.Count; num1++)
            {
                if (match(this.Items[num1]))
                {
                    list1.Add(this.Items[num1]);
                }
            }
            return list1;
        }

        public void ForEach(Action<T> action)
        {
            if (action == null)
            {
                throw new ArgumentNullException("action", "action is null");
            }
            for (int num1 = 0; num1 < this.Count; num1++)
            {
                action(this.Items[num1]);
            }
        }


        /// <summary>
        /// just a helper for
        /// itemCollection.Clear();
        /// itemCollection.AddRange(someOtherItemsCollection);</summary>
        /// <param name="items"></param>
        public void ClearAndAddRange(IEnumerable<T> items)
        {
            base.ClearItems();
            this.AddRange(items);
        }

        /// <summary>
        /// just a helper for
        /// itemCollection.Clear();
        /// itemCollection.AddRange(someOtherItemsCollection);</summary>
        /// <param name="items"></param>
        public void ClearAndAddRange(IList<T> items)
        {
            base.ClearItems();
            this.AddRange(items);
        }


        public ObjectCollection<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter)
        {
            if (converter == null)
            {
                throw new ArgumentNullException("converter", "cenverter is null");
            }
            var list = new ObjectCollection<TOutput>();
            for (int i = 0; i < this.Count; i++)
            {
                list.Add(converter(this[i]));
            }
            return list;
        }



        #endregion

        public string[] ToArrayString()
        {
            return this.Select(t => t.ToString()).ToArray();
        }

        public override string ToString()
        {
            return string.Join(", ", this.ToArrayString());
        }

    }
}
