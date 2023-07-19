using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWithDilshodAka.Day26._05
{
    internal class Runner26
    {
        public static void Start()
        {
            List<ListNode> listNodes = new List<ListNode>();
        }


        public bool HasCycle(ListNode head)
        {

            List<ListNode> listNodes = new List<ListNode>();
            ListNode first = head;
            ListNode first1;

            while (first != null)
            {
                listNodes.Add(first);
                first1 = head;
                first = first.next;
                for( int i = 0; i < listNodes.Count - 1; i++ )
                {
                    if (first1 == listNodes[i]) return true;
                    first1 = first.next;
                }
            }
            return false;
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode first ;
            ListNode first1;

            while (true)
            {
                first = head;
                while( first != null )
                {
                    first = first.next;
                }
                first1 = first;
                first1 = first1.next;
                first = null;
            }
           
            return first1;
        }


    }

    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int x)
      {
            val = x;
            next = null;
      }
    }
}
