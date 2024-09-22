using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSample
{
    public class GenericOlmayanSinif
    {
        public void EkranaYaz<T> (T value)
        {
            Console.Write($"T(Type) : {typeof(T)} türünde gelen data : {value}");
        }
    }
}
