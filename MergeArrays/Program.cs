namespace MergeArrays;

public class Program
{
    public static void Main(string[] args)
    {

    }

    // TODO 
    public static int[] MergeSortedArrays(int[] array1, int[] array2)
    {
        int[] SortedArray = [];
        int Array1Index = 0;
        int Array2Index = 0;
        while (Array1Index < array1.Length || Array2Index < array2.Length)
        {
            if (Array1Index == array1.Length)
            {
                SortedArray.Append(array2[Array2Index]);
                Array2Index++;
            }
            if(Array2Index == array2.Length)
            {
                SortedArray.Append(array1[Array1Index]);
                Array1Index++;
            }
            if(array1[Array1Index] > array2[Array2Index])
            {
                SortedArray.Append(array1[Array1Index]);
                Array1Index++;
            }
            else
            {
                SortedArray.Append(array2[Array2Index]);
                Array2Index++;
            }
        }
        return SortedArray;
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
        T[] SortedArray = [];
        int Array1Index = 0;
        int Array2Index = 0;
        while (Array1Index < array1.Length || Array2Index < array2.Length)
        {
            if (Array1Index == array1.Length)
            {
                SortedArray.Append(array2[Array2Index]);
                Array2Index++;
            }
            if(Array2Index == array2.Length)
            {
                SortedArray.Append(array1[Array1Index]);
                Array1Index++;
            }
            if(array1[Array1Index].CompareTo(array2[Array2Index]) > 0)
            {
                SortedArray.Append(array1[Array1Index]);
                Array1Index++;
            }
            else
            {
                SortedArray.Append(array2[Array2Index]);
                Array2Index++;
            }
        }
        return SortedArray;
        return default;     
    }
}

