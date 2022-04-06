using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home06042022
{
    internal class CustomCollection<TKey,TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        CustomCollection<TKey, TValue>[] array;
        public void Add(TKey key , TValue value)
        {
            Array.Resize(ref array , array.Length + 1);
            array[^1].Value = value;    
            array[^1].Key = key;  
        }
    }
}
