using MyLib;

namespace My
{
    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        public void Test_Selection_Sort()
        {
            int[] array = { 7, 3, 5, 6, 9, 2 };
            Sorting sorting = new Sorting();
            sorting.SelectionSort(array);
            Assert.AreEqual(2, array[0]);
            Assert.AreEqual(3, array[1]);
            Assert.AreEqual(5, array[2]);
            Assert.AreEqual(6, array[3]);
            Assert.AreEqual(7, array[4]);
            Assert.AreEqual(9, array[5]);
        }

        [TestMethod]
        public void Test_Buble_Sort()
        {
            int[] array = { 7, 3, 5, 6, 9, 2 };
            Sorting sorting = new Sorting();
            sorting.BubleSort(array);
            Assert.AreEqual(2, array[0]);
            Assert.AreEqual(3, array[1]);
            Assert.AreEqual(5, array[2]);
            Assert.AreEqual(6, array[3]);
            Assert.AreEqual(7, array[4]);
            Assert.AreEqual(9, array[5]);
        }
    }
}