using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammierenPraktikum3
{
    internal class SortedLinkedList<T> where T: IComparable<T>
    {
        public ListNode first, last;
       
        // erstelle enumerator um durchiterieren zu können
        public IEnumerator<T> GetEnumerator()
        {
            for (ListNode temp = first; temp != null; temp = temp.next)
            {
                yield return temp.Data;
            }
        }
        
        


        public class ListNode
        {
            public T Data { get; set; }
            public ListNode next, prev;
            public ListNode(T data)
            {
                Data = data;
            }

        }
        
        // erstelle methode Add um neues element alphabetisch einzusortieren
            
        public void Add(T item)
        {
            if(first == null)
            {
                first = new ListNode(item);
            }
            else
            {
                ListNode temp = first;
                ListNode neu = new ListNode(item);
                while (temp!= null)
                {
                    if(item.CompareTo(temp.Data)< 0)
                    {
                        neu.next = temp;
                        neu.prev = temp.prev;
                        if(temp.prev != null)
                        {
                            temp.prev.next = neu;
                        }
                        else
                        {
                            first = neu;
                        }
                        temp.prev = neu;
                        break;
                    }
                    else if ( temp.next == null)
                    {
                        temp.next = neu;
                        neu.prev = temp;
                        last = neu;
                        break;
                    }
                    temp = temp.next;
                }
                
            }
        }
        
    }

}

