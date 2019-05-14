using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        T[] items = new T[4];

        public T this[int i]
        {
            get { return items[i]; }
            set { items[i] = value; }
        }
    }
}
