using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<KeyT,ValueT>
    {
        KeyT[] keyArray;
        KeyT[] tempKeyArray;
        ValueT[] valueArray;
        ValueT[] tempValueArray;

        public MyDictionary()
        {
            keyArray = new KeyT[0];
            valueArray = new ValueT[0];
        }

        public void Add(KeyT key,ValueT value)
        {
            if(Array.IndexOf(keyArray,key) == -1)
            {
                tempKeyArray = keyArray;
                keyArray = new KeyT[keyArray.Length + 1];
                for (int i = 0; i < tempKeyArray.Length; i++)
                {
                    keyArray[i] = tempKeyArray[i];
                }
                keyArray[keyArray.Length - 1] = key;

                tempValueArray = valueArray;
                valueArray = new ValueT[valueArray.Length + 1];
                for (int i = 0; i < tempValueArray.Length; i++)
                {
                    valueArray[i] = tempValueArray[i];
                }
                valueArray[valueArray.Length - 1] = value;
            }

            else
            {
                Console.WriteLine("\nKey must be unique!" + " "+ "Key index " + key + " is not empty. Enter another key for" + " " + value + ".");
                return;
            }
        }

        public void ListTheDictionary()
        {
            for (int i=0 ; i < keyArray.Length ; i++)
            {
                Console.WriteLine("( " + keyArray[i] + " , " + valueArray[i]  + " )");
            }
        }       
    }
}