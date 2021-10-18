using MovieLinkedList.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLinkedList.LinkedLists
{

 

    class DLinkdList
    {

        CNode head;
        CNode current;
        CNode tail;
        CNode temp;
        int nodeCount = 0;
        List<string> nextList;
        List<string> previousList;

        public void append(string data)
        {

            CNode customNode = new CNode(data);

            if (head == null)
            {
                head = customNode;
                head.next = null;
                head.previous = null;
                nodeCount++;

                return;
            }

            else
            {
                current = head;

                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = customNode;
                customNode.previous = current;
                tail = customNode;
                nodeCount++;
            }

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


        public List<string> showPrevious()
        {
            previousList = new List<string>();

            current = tail;

            previousList.Add(current.data);

            while (current.previous != null)
            {
                previousList.Add(current.previous.data);
                current = current.previous;

            }

            return previousList;

        }


        public void insertAfter(int after , string data)
        {
            CNode customNode = new CNode(data);
            current = head;
            int ithNode = 1;

            while (ithNode != after)
            {
                current = current.next;
                ithNode++;
            }

            temp = current.next;
            current.next = customNode;
            customNode.next = temp;
            temp.previous = customNode;
            customNode.previous = current;


        }




    }
}
