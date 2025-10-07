using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class MyList<T> where T : IComparable<T>
    {
         T[] arr;
         int count;
         int size;

        public MyList(int _size = 5)
        {
            size = _size;
            arr = new T[size];
            count = 0;
        }


        public void Add(T element)
        {
            if (count == size)
            {
                T[] newarr = new T[size * 2];
                for (var i = 0; i < arr.Length; i++)
                {
                    newarr[i] = arr[i];
                }
                arr = newarr;
                size *= 2;
            }

            arr[count] = element;
            count++;
        }


        public bool Remove(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (arr[i].CompareTo(element) == 0)
                {

                    for (int j = i; j < count - 1; j++)
                        arr[j] = arr[j + 1];

                    count--;
                    return true;
                }
            }
            return false;
        }


        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                {
                    return arr[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }

        }


        public void Print()
        {
            for (int i = 0; i < count; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
