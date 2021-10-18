using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLinkedList.Classes
{
    public class CNode
    {

       public CNode next;
       public CNode previous;
       public string data;
       int NodeCount;


        public CNode()
        {

        }

        public CNode(string data)
        {
            this.data = data;
        }




    }
    
    
}
