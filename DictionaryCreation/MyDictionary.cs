using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryCreation
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TKey[] tempKeys;
        TValue[] values;
        TValue[] tempValues;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        
        public void Add(TKey tKey, TValue tValue)
        {
            tempKeys = keys;
            keys = new TKey[keys.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = tKey;

            tempValues = values;
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }
            values[values.Length - 1] = tValue;
        }
        public TKey[] Keys
        {
            get { return keys; }
        }
        public TValue[] Values
        {
            get { return values; }
        }
    }
}
