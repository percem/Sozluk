using System;
using System.Collections.Generic;
using System.Text;

namespace Sozluk
{
    class MyDictionary<TKey,Value>
    {
        TKey[] key;
        Value[] val;
        public MyDictionary()
        {
            key = new TKey[0];
            val = new Value[0];
        }
        
        public void Add(TKey anahtar, Value deger)
        {
            TKey[] tempK = key;
            Value[] tempV = val;

            key = new TKey[key.Length+1];
            val = new Value[val.Length+1];

            for (int i = 0; i <tempK.Length; i++)
            {
                key[i] = tempK[i];
                val[i] = tempV[i];
            }
            key[key.Length - 1] = anahtar;
            val[val.Length - 1] = deger;
        }
        public void Getir()
        {
            for (int i = 0; i < key.Length; i++)
            {
                Console.WriteLine("Ürün/ " + key[i] + " " + "Birim Fiyatı:" + val[i]);
            }
        }

    }
}
