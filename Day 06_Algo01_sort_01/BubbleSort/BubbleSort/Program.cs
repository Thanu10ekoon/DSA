//ME

//int[] arr1 = new int[6];

//arr1[0] = 8;
//arr1[1] = 6;
//arr1[2] = 9;
//arr1[3] = 2;
//arr1[4] = 5;
//arr1[5] = 4;

//for (int i = 0; i < arr1.Length; i++)
//{
//    for (int j = 0; j < arr1.Length; j++) 
//    {
//        int count = 0;
//        if (arr1[i] < arr1[j])
//        {
//            int temp = arr1[i];
//            arr1[i] = arr1[j];
//            arr1[j] = temp;
//            count++;
//        }
//        Console.WriteLine($"count={count}");
//    }
//}

//for (int i = 0;i < arr1.Length; i++) 
//{
//    Console.WriteLine(arr1[i]);
//}



//SIR

class BubbleSort 
{
    static void bubbleosrt(int[] array,int n) 
    {
        int i, j, temp;
        bool swapped;

        for (i=0; i< n-1; i++) 
        {
            swapped = false;
            for (j = 0; j < n - 1; j++) 
            {
                if (array[j] > array[j+1])
                {
                    temp = array[j];
                    array[j] = array[j+1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }
            if (swapped == false) { break; }

        }


    }

    static void PrintArray(int[] array, int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
    public static void Main(string[] args)
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        bubbleosrt(arr, 7);
        PrintArray(arr, 7);
    }
}

 