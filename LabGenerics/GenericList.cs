using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabGenerics
{
    class GenericList<T>:IEnumerable<T>
    {
        T[] array = new T[2];
        int index = 0;

        public void Add(T value)
        {
            if (index==array.Length)
            {
                Resize();
            }
            array[index] = value;
            index++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)array).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }

        void Resize()
        {
            T[] tempArr = new T[array.Length + 1];
            Array.Copy(array, tempArr, array.Length);
            array =tempArr;
        }

        public bool Contains(T value)
        {
            bool x = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                {
                    
                     x=true;
                    break;
                }
              
               
            }
            return x;
        }

        public void Remove(T value)
        {
            if (array.Contains(value))
            {
                int y = Array.IndexOf(array, value);
                T[] temp = new T[array.Length - 1];
                for (int i = 0; i < array.Length-1; i++)
                {
                    if (array[i].Equals(array[y]))
                    {
                        
                        continue;
                        
                    }
                    temp[i] = array[i];
                }
                array = temp;
            }
            else
            {
                Console.WriteLine("bele bir data yoxdur");
            }

        }
       
    }
}
