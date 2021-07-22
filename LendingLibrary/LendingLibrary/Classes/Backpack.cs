using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary.Classes
{
    class Backpack<T> : IBag<T>
    {
        private List<T> bag = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Pack(T item)
        {
            bag.Add(item);
        }

        public T Unpack(int index)
        {
            T book = bag[index];
            bag.RemoveAt(index);
            return book;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
