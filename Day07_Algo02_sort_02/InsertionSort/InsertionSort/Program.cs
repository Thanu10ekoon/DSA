class InsertionSort 
{
    void Sort(int[] array) 
    {
        int n = array.Length;

        for (int i = 0; i < n; i++) 
        {
            int key = array[i];
            int j = i-1;

            while (j >= 0 && array[j]>key) 
            {
                array[j+1] = array[j];
                j = j-1;
            }
            array[j + 1] = key;
        }
    }

    static void PrintArray(int[] array) 
    {
        for (int i = 0; i < array.Length; i++) 
        {
            Console.Write($"{array[i]} ");
        }
    }

    public static void Main(string[] args) 
    {
        int[] array = { 12, 11, 13, 5, 6 };
        InsertionSort ob = new InsertionSort();
        ob.Sort(array);
        PrintArray(array);
    }
}