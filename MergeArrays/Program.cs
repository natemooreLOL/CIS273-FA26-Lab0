namespace MergeArrays;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello");
    }

    // TODO 
    public static int[] MergeSortedArrays(int[] array1, int[] array2)
    {
        if (array1.Length == 0)
        {
            return array2;
        }
        if (array2.Length == 0)
        {
            return array1;
        }
        List<int> SortedArray = new List<int> {};
        int Array1Index = 0;
        int Array2Index = 0;
        while (Array1Index < array1.Length || Array2Index < array2.Length)
        {
            if (Array1Index == array1.Length)
            {
                SortedArray.Add(array2[Array2Index]);
                Array2Index++;
            }
            else if(Array2Index == array2.Length)
            {
                SortedArray.Add(array1[Array1Index]);
                Array1Index++;
            }
            else if(array1[Array1Index] < array2[Array2Index])
            {
                SortedArray.Add(array1[Array1Index]);
                Array1Index++;
            }
            else
            {
                SortedArray.Add(array2[Array2Index]);
                Array2Index++;
            }
        }
        return SortedArray.ToArray();
    }


    private static bool IsSorted(int[] array)
    {
        if (array.Length == 0)
        {
            return true;
        }
        for (int i=1; i<array.Length; i++)
        {
            if (array[i - 1] > array[i])
            {
                return false;
            }
        }
        return true;
    }

    // TODO
    public static T[] MergeSortedArrays<T>(T[] array1, T[] array2) where T:IComparable<T>
    {
        if (array1.Length==0)
        {
            return array2;
        }
        if (array2.Length==0)
        {
            return array1;
        }
        List<T> SortedArray = new List<T> {};;
        int Array1Index = 0;
        int Array2Index = 0;
        while (Array1Index < array1.Length || Array2Index < array2.Length)
        {
            if (Array1Index == array1.Length)
            {
                SortedArray.Add(array2[Array2Index]);
                Array2Index++;
            }
            if(Array2Index == array2.Length)
            {
                SortedArray.Add(array1[Array1Index]);
                Array1Index++;
            }
            if(array1[Array1Index].CompareTo(array2[Array2Index]) > 0)
            {
                SortedArray.Add(array1[Array1Index]);
                Array1Index++;
            }
            else
            {
                SortedArray.Add(array2[Array2Index]);
                Array2Index++;
            }
        }
        return SortedArray.ToArray();   
    }
}

