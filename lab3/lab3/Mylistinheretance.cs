using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class MyListInheritance : List<int>
    {
        int[] arr;
        int top = -1;
        int size;

        public MyListInheritance(int _size = 5)
        {
            size = _size;
            arr = new int[size];
        }

        public new void Add(int element)
        {
            using (StreamWriter file = new StreamWriter("iti.txt", true))
            {
                top++;
                if (top < size)
                {
                    arr[top] = element;
                    file.WriteLine(element);
                }
                else
                {
                    file.WriteLine("new arr is created");
                    int[] newarr = new int[size * 2];
                    for (var i = 0; i < arr.Length; i++)
                    {
                        newarr[i] = arr[i];
                        file.WriteLine(arr[i]);
                    }
                    arr = newarr;
                    size *= 2;

                    arr[top] = element;
                    file.WriteLine(element);
                }
            }
        }
    }
}
