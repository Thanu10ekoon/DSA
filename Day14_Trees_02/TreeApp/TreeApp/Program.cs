using TreeApp;

BST tree = new BST();

tree.Insert(10);
tree.Insert(20);
tree.Insert(30);
tree.Insert(5);
tree.Insert(6);
tree.Insert(7);
tree.Insert(25);
tree.Print();

Console.WriteLine("After removing 10");
tree.Delete(10);
tree.Print();
//After removing