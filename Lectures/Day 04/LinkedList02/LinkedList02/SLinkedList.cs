using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
        public void InsertAt(int val,int pos) 
        {
            if(val < 0 || pos > Count-1) { return; }
            else 
            {
                if (pos == 0) { AddFront(val); }
                else if (pos == Count - 1) { AddEnd(val); }
                else 
                {
                    Node? temp = new Node(val);///COMPLETE THIS
                    Node? current = Head;
                    int cnt = 0;
                    while (current != null) 
                    {
                        if (cnt == pos-1)
                        {
                            current.Next = current.Next.Next;
                        }
                        else
                        {
                            current = current.Next;
                            cnt++;
                        }
                    }
                } 

            }
        }
        public void RemoveThis(int val)
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
