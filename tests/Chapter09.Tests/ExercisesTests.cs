using Xunit;

public class Chapter09Tests
{
    // ===== 問題 9-1: Where + OrderBy =====

    [Theory]
    [InlineData(new int[] { 5, 1, 8, 3, 9, 2 }, 4, new int[] { 5, 8, 9 })]
    [InlineData(new int[] { 10, 2, 5, 7, 1 }, 5, new int[] { 5, 7, 10 })]
    [InlineData(new int[] { 1, 2, 3 }, 10, new int[] { })]
    [InlineData(new int[] { 5, 5, 5 }, 3, new int[] { 5, 5, 5 })]
    public void Test_9_1_FilterAndSort(int[] numbers, int threshold, int[] expected)
    {
        Assert.Equal(expected, Exercises.Problem9_1(numbers, threshold));
    }

    [Fact]
    public void Test_9_1_ThresholdIsInclusive()
    {
        // threshold と同じ値は含まれる（以上）
        Assert.Equal(new[] { 4, 4 }, Exercises.Problem9_1(new[] { 4, 4 }, 4));
    }

    // ===== 問題 9-2: Select =====

    [Theory]
    [InlineData(new int[] { 3, 1, 4 }, new string[] { "3番", "1番", "4番" })]
    [InlineData(new int[] { 10 }, new string[] { "10番" })]
    [InlineData(new int[] { 1, 2, 3 }, new string[] { "1番", "2番", "3番" })]
    public void Test_9_2_ToLabel(int[] numbers, string[] expected)
    {
        Assert.Equal(expected, Exercises.Problem9_2(numbers));
    }

    [Fact]
    public void Test_9_2_PreservesOrder()
    {
        string[] result = Exercises.Problem9_2(new[] { 9, 1, 5 });
        Assert.Equal("9番", result[0]);
        Assert.Equal("1番", result[1]);
        Assert.Equal("5番", result[2]);
    }

    // ===== 問題 9-3: OrderBy + ThenBy =====

    [Fact]
    public void Test_9_3_SortByLengthThenAlphabetical()
    {
        string[] result = Exercises.Problem9_3(new[] { "banana", "fig", "apple", "kiwi" });
        Assert.Equal(new[] { "fig", "kiwi", "apple", "banana" }, result);
    }

    [Fact]
    public void Test_9_3_SameLengthSortedAlphabetically()
    {
        Assert.Equal(new[] { "ant", "bat", "cat" }, Exercises.Problem9_3(new[] { "cat", "ant", "bat" }));
    }

    [Fact]
    public void Test_9_3_SingleElement()
    {
        Assert.Equal(new[] { "hello" }, Exercises.Problem9_3(new[] { "hello" }));
    }

    // ===== 問題 9-4: Average =====

    [Theory]
    [InlineData(new int[] { 80, 60, 95, 70, 55 }, 72.0)]
    [InlineData(new int[] { 100, 0 }, 50.0)]
    [InlineData(new int[] { 75 }, 75.0)]
    [InlineData(new int[] { 1, 2, 3, 4 }, 2.5)]
    public void Test_9_4_Average(int[] scores, double expected)
    {
        Assert.Equal(expected, Exercises.Problem9_4(scores));
    }

    // ===== 問題 9-5: Where + Select + OrderBy チェーン =====

    [Fact]
    public void Test_9_5_EvenSquaredSorted()
    {
        Assert.Equal(new[] { 4, 16, 36, 64 }, Exercises.Problem9_5(new[] { 5, 2, 8, 3, 4, 6 }));
    }

    [Fact]
    public void Test_9_5_NoEvens()
    {
        Assert.Empty(Exercises.Problem9_5(new[] { 1, 3, 5 }));
    }

    [Fact]
    public void Test_9_5_SingleEven()
    {
        Assert.Equal(new[] { 16 }, Exercises.Problem9_5(new[] { 4 }));
    }

    [Fact]
    public void Test_9_5_ResultIsAscending()
    {
        int[] result = Exercises.Problem9_5(new[] { 6, 2, 4 });
        Assert.Equal(new[] { 4, 16, 36 }, result);
    }

    // ===== 問題 9-6: OrderByDescending + Take =====

    [Theory]
    [InlineData(new int[] { 70, 85, 60, 95, 75 }, 3, new int[] { 95, 85, 75 })]
    [InlineData(new int[] { 10, 20, 30 }, 2, new int[] { 30, 20 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1, new int[] { 5 })]
    public void Test_9_6_TopN(int[] scores, int n, int[] expected)
    {
        Assert.Equal(expected, Exercises.Problem9_6(scores, n));
    }

    [Fact]
    public void Test_9_6_AllElements()
    {
        Assert.Equal(new[] { 5, 5, 5 }, Exercises.Problem9_6(new[] { 5, 5, 5 }, 3));
    }

    // ===== 問題 9-7: Any / All / Count =====

    [Theory]
    [InlineData(new int[] { 3, -1, 5 }, true)]
    [InlineData(new int[] { 3, 1, 5 }, false)]
    [InlineData(new int[] { -1, -2, -3 }, true)]
    [InlineData(new int[] { 0, 1, 2 }, false)]
    public void Test_9_7_HasNegative(int[] numbers, bool expected)
    {
        Assert.Equal(expected, Exercises.Problem9_7_HasNegative(numbers));
    }

    [Theory]
    [InlineData(new int[] { 3, 1, 5 }, true)]
    [InlineData(new int[] { 3, 0, 5 }, false)]
    [InlineData(new int[] { 3, -1, 5 }, false)]
    [InlineData(new int[] { 1 }, true)]
    public void Test_9_7_AllPositive(int[] numbers, bool expected)
    {
        Assert.Equal(expected, Exercises.Problem9_7_AllPositive(numbers));
    }

    [Theory]
    [InlineData(new int[] { 3, 7, 2, 8, 5 }, 4, 3)]
    [InlineData(new int[] { 1, 2, 3 }, 10, 0)]
    [InlineData(new int[] { 5, 5, 5 }, 4, 3)]
    [InlineData(new int[] { 5, 5, 5 }, 5, 0)]
    public void Test_9_7_CountOver(int[] numbers, int threshold, int expected)
    {
        Assert.Equal(expected, Exercises.Problem9_7_CountOver(numbers, threshold));
    }

    // ===== 問題 9-8: クエリ構文 =====

    [Fact]
    public void Test_9_8_FilterByLengthDescending()
    {
        string[] words = { "cat", "elephant", "ox", "dog", "hippopotamus" };
        Assert.Equal(new[] { "hippopotamus", "elephant" }, Exercises.Problem9_8(words, 4));
    }

    [Fact]
    public void Test_9_8_MultipleSameLengthDescending()
    {
        string[] result = Exercises.Problem9_8(new[] { "hi", "hello", "hey" }, 3);
        Assert.Equal(new[] { "hello", "hey" }, result);
    }

    [Fact]
    public void Test_9_8_NoneMatch()
    {
        Assert.Empty(Exercises.Problem9_8(new[] { "a", "bb", "ccc" }, 5));
    }

    // ===== 問題 9-9: GroupBy =====

    [Fact]
    public void Test_9_9_GroupByFirstChar()
    {
        string[] words = { "apple", "ant", "banana", "bear", "cat" };
        var result = Exercises.Problem9_9(words);
        Assert.Equal(3, result.Count);
        Assert.Equal(2, result['a']);
        Assert.Equal(2, result['b']);
        Assert.Equal(1, result['c']);
    }

    [Fact]
    public void Test_9_9_AllSameFirstChar()
    {
        var result = Exercises.Problem9_9(new[] { "alpha", "arrow", "ant" });
        Assert.Single(result);
        Assert.Equal(3, result['a']);
    }

    [Fact]
    public void Test_9_9_AllDifferentFirstChar()
    {
        var result = Exercises.Problem9_9(new[] { "zoo", "yak", "xray" });
        Assert.Equal(3, result.Count);
        Assert.Equal(1, result['z']);
        Assert.Equal(1, result['y']);
        Assert.Equal(1, result['x']);
    }
}
