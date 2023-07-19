using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDilshodAka.Day29._05
{
    class MyCollection<t> : ICollection<t>
    {
        private int _count = 4;
        private t[] arr = new t[4];
       
        private int _currentIndex = 0;
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(t item)
        {
            if( arr.Length > _currentIndex )
            {
                arr[_currentIndex] = item;
                _currentIndex++;
            }
            else
            {
                _count *= 2;
                t[] arr1 = arr;
                arr = new t[_count];
                for( int i = 0; i < _currentIndex; i++ )
                {
                    arr[i] = arr1[i];
                }
                arr[_currentIndex] = item;
                _currentIndex++;
            }
        }

        public bool Contains(t item)
        {
            int x = Array.IndexOf(arr, item);
            if (x >= 0) return true;
            return false;
        }





        public void Clear()
        {
            throw new NotImplementedException();
        }

       

       

        public void CopyTo(t[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

    
        public bool Remove(t item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<t> IEnumerable<t>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static implicit operator MyCollection<t>(List<string> v)
        {
            throw new NotImplementedException();
        }
    }
}
