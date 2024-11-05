using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    internal class Node
    {
        public int Data;
        public Node Next;
        public Node Prev;

        public Node(int value) 
        {
            Data = value;
            Next = null;
            Prev = null;
        }
    }
}
