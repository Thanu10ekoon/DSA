using LinkedList02;

SLinkedList list = new SLinkedList();

list.AddFront(10);
list.AddFront(20);
list.AddFront(30);

list.Print();

list.AddAt(100,2);
Console.WriteLine("........");
list.Print();

//list.RemoveThis(20);
//Console.WriteLine("..........");
//list.Print();

list.DeleteAt(1);
Console.WriteLine("..........");
list.Print();

//list.RemoveAt(2);
//Console.WriteLine("..........");
//list.Print();
