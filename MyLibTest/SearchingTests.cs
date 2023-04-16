using MyLib;
namespace MyLibTest;

[TestClass]
public class SearchingTests
{
    [TestMethod]
    public void Test_Binary_Search()
    {
        int[] array = { 7, 3, 5, 6, 9, 2 };

        //First sort. Mendatory to use binary search
        var sorting = new Sorting();
        sorting.BubleSort(array);

        Searching searching = new Searching();

        Assert.AreEqual(7, searching.BinarySearch(array, 7));
        Assert.AreEqual(-1, searching.BinarySearch(array, 11));
    }

    [TestMethod]
    public void Test_Binary_Search_Recursive()
    {
        int[] array = { 7, 3, 5, 6, 9, 2 };

        //First sort. Mendatory to use binary search
        var sorting = new Sorting();
        sorting.BubleSort(array);

        Searching searching = new Searching();

        Assert.AreEqual(2, searching.BinarySearchRecursive(array, 0, 5, 2));
        Assert.AreEqual(-1, searching.BinarySearchRecursive(array, 0, 5, 11));
    }
}