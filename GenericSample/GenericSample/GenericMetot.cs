using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSample
{
    public class GenericMetot<T>
    {
        public T[] dizi = new T[5];

        public void ElemanEkle(int index,T data)
        {
            if(index>=0 && index <5)
                dizi[index] = data;
        }

        public void ElemanEkle(string index, T data)
        {
            //if (index >= 0 && index < 5)
            //    dizi[index] = data;
        }

        public void ElemanEkle( T data)
        {
            //if (index >= 0 && index < 5)
            //    dizi[index] = data;
        }

        public T VeriAl(int index)
        {
            if (index >= 0 && index < 5)
                return dizi[index];
            else
                return default(T);
        }
    }
}
