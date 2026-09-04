public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10 };
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1 };
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var result = new List<int>();
        var list1CurrentIndex = 0;
        var list2CurrentIndex = 0;

        foreach (var val in select)
        {
            if (val == 1)
            {
                result.Add(list1[list1CurrentIndex]);
                list1CurrentIndex++;
            }
            else if (val == 2)
            {
                result.Add(list2[list2CurrentIndex]);
                list2CurrentIndex++;
            }
        }
        return [.. result];
    }
}