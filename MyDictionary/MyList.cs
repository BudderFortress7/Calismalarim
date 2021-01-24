using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T veri)
        {
            T[] geciciyer = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < geciciyer.Length; i++)
            {
                items[i] = geciciyer[i];
            }
            items[items.Length - 1] = veri;

        }
        public T[] Items
        {
            get
            {
                return items;
            }
        }
    }
}
