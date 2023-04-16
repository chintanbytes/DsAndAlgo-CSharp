namespace MyLib;

public class Searching
{
    public int BinarySearch(int[] array, int key)
    {
        int start = 0;
        int end = array.Length;

        while (start < end)
        {
            int mid = start + (end - start) / 2;
            if (array[mid] == key)
                return array[mid];
            else if (array[mid] > key)
                start = mid + 1;
            else
                end = mid - 1;
        }
        return -1;
    }

    public int BinarySearchRecursive(int[] array, int start, int end, int key)
    {
        if (start > end)
            return -1;
        //4+()
        int mid = start + (end - start) / 2;

        if (array[mid] == key)
            return array[mid];
        else if (array[mid] < key)
            return BinarySearchRecursive(array, mid + 1, end, key);
        else
            return BinarySearchRecursive(array, start, mid - 1, key);
    }
}
