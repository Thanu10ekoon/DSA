using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a new linked list of strings
        LinkedList<int> list = new LinkedList<int>();

        // Add elements to the linked list
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);

        // Display the elements in the linked list
        Console.WriteLine("Linked List elements:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Add an element at the start
        list.AddFirst(0);
        Console.WriteLine("\nAfter adding 'Zeroth' at the start:");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Remove an element
        list.Remove(2);
        Console.WriteLine("\nAfter removing 'Second':");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
