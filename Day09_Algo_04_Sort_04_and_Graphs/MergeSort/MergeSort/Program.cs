//int[] arr = { 1, 5, 6, 7, 9, 2, 3, 4, 8 };

//if (arr.Length % 2 == 0)
//{
//    int arrs_len = arr.Length / 2;
//    int[] arr_left = new int[arrs_len];
//    int[] arr_right = new int[arrs_len];
//}
//else
//{
//    int arrs_len = arr.Length / 2;
//    int[] arr_left = new int[arrs_len];
//    int[] arr_right = new int[arrs_len+1];
//}

//for (int i = 0; i < arr.Length; i++)
//{

//}
class Sort
{
    static void MergeSort(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;


        //copy data to temp arrays
        for (i = 0; i < n1; i++)
        {
            L[i] = arr[left + i];
        }
        for (j = 0; j < n2; j++)
        {
            R[j] = arr[mid + 1 + j];
        }

        //reset indexes
        i = 0;
        j = 0;
        int k = left;

        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }
        while(i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }
        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            //
            int mid = left + (right - left) / 2;
            MergeSort(arr, left,right:mid);
            MergeSort(arr,left:mid + 1, right);
            MergeSort(arr, left, mid, right);
        }
    }

    static void print(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i] + " ");
        }
        Console.WriteLine();    
    }

    static void Main(string[] args)
    {
        int[] arr = { 12, 11, 13, 5, 6, 7, 8, 9, };
        Console.WriteLine("original");
        print(arr);
        MergeSort(arr, left:0,right: arr.Length - 1);
        Console.WriteLine("\n sorted");
        print(arr);
    }
}