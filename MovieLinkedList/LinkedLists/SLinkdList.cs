using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLinkedList.Classes
{
    public class SLinkdList
    {

        CNode head;
        CNode current;
        static int nodeCount;
        List<string> nextList;

        public void append(string data)
        {
            if (head == null)
            {
                head = new CNode(data);
                current = head;

                nodeCount++;
            }


            else
            {

                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = new CNode(data);
                nodeCount++;

            }

        }


        public int count() 
        {
            return nodeCount++;
        }

        public List<string> showNext()
        {
            nextList = new List<string>();

            current = head;

            nextList.Add(current.data);

            while (current.next != null)
            {
                nextList.Add(current.next.data);
                current = current.next;
            }

            return nextList;

        }
       
    }
}
