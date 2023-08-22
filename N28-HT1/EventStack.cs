using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N28_HT1
{
    internal class EventStack<T> : List<T> where T : IEvent
    {
        public void Push(T even)
        {
            //// - Push(event) - agar push qilinayotgan 
            ///event stack da bor eventlardan keyin bo'
            ///ladigan bo'lsa ( vaqti bo'yicha ), 
            ///push bo'lsin, bo'lmasa esception
            ///
            if (!TrueForAll(eventing => eventing.Date < even.Date))
                throw new Exception("Xatolik");
            Add(even);

        }


        public T Peek()
        {
            if (Count == 0)
                throw new Exception("Bo'sh");
            return base[Count - 1];
        }

        
        public T Pop()
        {
            if (Count == 0)
                throw new Exception("Bo'sh");
            var a = base[Count - 1];
            Remove(a);
            return a;
        }
    }

}