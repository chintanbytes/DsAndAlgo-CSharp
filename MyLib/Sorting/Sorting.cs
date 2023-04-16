namespace MyLib
{
    public class Sorting
    {
        //Sorts left to right every iteration
        public void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                var smallest = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }

                if (array[smallest] < array[i])
                {
                    swap(array, i, smallest);
                }
            }
        }

        /// <summary>
        /// Sorts right to left every iteration
        /// </summary>
        /// <param name="array"></param>
        public void BubleSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                bool sorted = true;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        sorted = false;
                        swap(array, j, j + 1);
                    }
                }
                if (sorted)
                    return;
            }
        }

        private static void swap(int[] array, int idx1, int idx2)
        {
            var temp = array[idx1];
            array[idx1] = array[idx2];
            array[idx2] = temp;
        }
    }
}