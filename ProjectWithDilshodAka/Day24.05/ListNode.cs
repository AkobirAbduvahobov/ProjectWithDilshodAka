using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDilshodAka.Day24._05
{
    internal class ListNode<T>
    {
        public T val;
        public ListNode<T> next;
        public ListNode<T> pre;
        public ListNode(T x)
        {
            val = x;
        }
        public ListNode()
        {
            
        }
    }
}
