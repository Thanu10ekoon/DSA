using LinkedList02;

SLinkedList list = new SLinkedList();

list.AddFront(10);
list.AddFront(20);
list.AddFront(30);

list.Print();

list.InsertAt(2,100);
Console.WriteLine("........");
list.Print();