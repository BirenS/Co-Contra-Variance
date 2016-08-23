using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co_Contra_Variance
{
   public class GStack<T>: IPoppable<T>,IPushable<T>
    {
       int position;
       public int Count { get; set; }
       T[] data = new T[10];
       public void Push(T a)
       {
           data[position++] = a;
           Count++;
       }
       public T Pop()
       {
           Count--;
           return data[--position];
       }    

    }
}
