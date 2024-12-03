class SelectionSort
{
    static void selectionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minindex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minindex])
                {
                    minindex = j;
                }
            }
            int tmp = array[i];
            array[i] = array[minindex];
            array[minindex] = tmp;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach(int i in array) 
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args) 
    {
        int[] array = {64, 25, 12, 22, 11};
        Console.WriteLine("Before Sroting: ");
        PrintArray(array);

        selectionSort(array);
        Console.WriteLine("After Sroting: ");
        PrintArray(array);
    }
}