using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LinkedList02
{
    internal class SLinkedList
    {
        public Node? Head { get; set; }
        public Node? Tail { get; set; }
        public int Count { get; set; }

        public SLinkedList() 
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public void AddFront(int val) 
        {
            Node temp = new Node(val);
            if (Head == null)
            {
                Head = temp;
                Tail = temp;
                Count++;
            }
            else
            {
                temp.Next = Head;
                Head = temp;
                Count++;
            }

        }

        public void AddEnd(int val)
        {
            Node? temp=new Node(val);

            if (Head == null)
            {
                Head = temp;
                Tail = temp;
                Count++;
            }
            else 
            {
                Tail.Next = temp;
                temp.Next = null;
                Tail = temp;
                Count++;
            }
                
        }
        
        public void AddAt(int value, int index)     //Sir's Version
        {
            Node newNode = new Node(value);

            if(index<0||index>Count)
            {
                Console.WriteLine("Invalid Index");
                return;
            }

            if(index==0)
            {
                AddFront(value);
            }
            else if(index==Count)
            {
                AddEnd(value);
            }
            else
            {
                Node current = Head;
                for(int i=0;i< index-1;i++)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
                Count++;
            }

        }

        public void RemoveThis(int val) //My Function
        {
            if (Head == null) return;

            if (Head.Data == val)
            {
                Head = Head.Next;
                Count--;
                if (Head == null) Tail = null;
                return;
            }

            Node? current = Head;
            while (current.Next != null)
            {
                if (current.Next.Data == val)
                {
                    current.Next = current.Next.Next;
                    Count--;
                    if (current.Next == null) Tail = current;
                    return;
                }
                current = current.Next;
            }
        }

        public void DeleteAt(int index) //sir's function
        {
            if(index>Count || index < 0) 
            {
                Console.WriteLine("Invalid Index");
                return;
            }

            if (Count == 1) 
            {
                Head = null;
                Tail = null;
            }
            Node current = Head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            if (index == 0)
            {
                Head = Head.Next;
            }
            else if (index == Count - 1)
            {
                current.Next = null;
                Tail = current;
            }
            else
            {
                current.Next = current.Next.Next;
                Count--;
            }

        }


        public void Print()
        {
            Node? current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }


    }
}
