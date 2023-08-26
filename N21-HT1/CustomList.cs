using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21_HT1
{
    internal class CustomList<T>
    {


        private T[] items;
        public int count;
        private int capacity;

        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
        }

        public CustomList(int capacity)
        {
            this.capacity = capacity;
            items = new T[capacity];
        }

        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity *= 2;
                Array.Resize(ref items, capacity);
            }

            items[count] = item;
            count++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(items[i], item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array)
        {
            items.CopyTo(array, 1);
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(items[i], item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if (count == capacity)
            {
                capacity *= 2;
                Array.Resize(ref items, capacity);
            }

            for (int i = count; i > index; i--)
            {
                items[i] = items[i - 1];
            }

            items[index] = item;
            count++;
        }

        public void InsertRange(int index, IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Insert(index, item);
                index++;
            }
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index != -1)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                return false;
            }

            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }

            items[count - 1] = default(T);
            count--;
            return true;
        }

        public T[] ToArray()
        {
            T[] array = new T[count];
            Array.Copy(items, array, count);
            return array;
        }
    }
}