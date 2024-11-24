using LinkedList02;

SLinkedList list1 = new SLinkedList();

list1.AddEnd(10);    //0
list1.AddEnd(20);    //1
list1.AddEnd(30);    //2
list1.AddEnd(40);    //3
Console.WriteLine("Before changing anything");
list1.Print();
Console.WriteLine();

list1.AddEnd(50);
Console.WriteLine("After adding 50 to end");
list1.Print();
Console.WriteLine();

list1.AddFront(60);
Console.WriteLine("After adding 60 to front");
list1.Print();
Console.WriteLine();

list1.DeleteAt(2);
Console.WriteLine("After removing element in index 2");
list1.Print();
Console.WriteLine();

list1.RemoveThis(30);
Console.WriteLine("After deleting 30 from list");
list1.Print();