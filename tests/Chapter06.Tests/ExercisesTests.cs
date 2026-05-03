using Xunit;

public class Chapter06Tests
{
    // --- 問題 6-1: 2 乗 ---
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(5, 25)]
    [InlineData(-3, 9)]
    [InlineData(10, 100)]
    public void Test_6_1_Square(int n, int expected)
    {
        Assert.Equal(expected, Exercises.Problem6_1(n));
    }

    // --- 問題 6-2: 平均（整数除算）---
    [Theory]
    [InlineData(3, 5, 4)]
    [InlineData(0, 10, 5)]
    [InlineData(7, 7, 7)]
    [InlineData(1, 2, 1)]
    [InlineData(-4, 4, 0)]
    public void Test_6_2_Average(int a, int b, int expected)
    {
        Assert.Equal(expected, Exercises.Problem6_2(a, b));
    }

    // --- 問題 6-3: 大きい方 ---
    [Theory]
    [InlineData(3, 5, 5)]
    [InlineData(5, 3, 5)]
    [InlineData(4, 4, 4)]
    [InlineData(-1, -5, -1)]
    [InlineData(0, 100, 100)]
    public void Test_6_3_Max(int a, int b, int expected)
    {
        Assert.Equal(expected, Exercises.Problem6_3(a, b));
    }

    // --- 問題 6-4: $ 三角形 ---
    [Fact]
    public void Test_6_4_TriangleSize1()
    {
        Assert.Equal("$", Exercises.Problem6_4(1));
    }

    [Fact]
    public void Test_6_4_TriangleSize3()
    {
        string expected = "$" + Environment.NewLine + "$$" + Environment.NewLine + "$$$";
        Assert.Equal(expected, Exercises.Problem6_4(3));
    }

    [Fact]
    public void Test_6_4_TriangleSize5_RowCount()
    {
        string result = Exercises.Problem6_4(5);
        string[] lines = result.Split(Environment.NewLine);
        Assert.Equal(5, lines.Length);
        for (int i = 0; i < 5; i++)
            Assert.Equal(i + 1, lines[i].Length);
    }

    // --- 問題 6-5: 任意文字の三角形 ---
    [Fact]
    public void Test_6_5_TriangleWithHash()
    {
        string expected = "#" + Environment.NewLine + "##" + Environment.NewLine + "###";
        Assert.Equal(expected, Exercises.Problem6_5(3, '#'));
    }

    [Fact]
    public void Test_6_5_TriangleWithStar_Size4()
    {
        string result = Exercises.Problem6_5(4, '*');
        string[] lines = result.Split(Environment.NewLine);
        Assert.Equal(4, lines.Length);
        for (int i = 0; i < 4; i++)
            Assert.Equal(new string('*', i + 1), lines[i]);
    }

    [Fact]
    public void Test_6_5_TriangleSingleRow()
    {
        Assert.Equal("A", Exercises.Problem6_5(1, 'A'));
    }

    // --- 問題 6-6: 九九の一段 ---
    [Fact]
    public void Test_6_6_KukuRow1()
    {
        string result = Exercises.Problem6_6(1);
        string[] lines = result.Split(Environment.NewLine);
        Assert.Equal(9, lines.Length);
        Assert.Equal("1×1=1", lines[0]);
        Assert.Equal("1×9=9", lines[8]);
    }

    [Fact]
    public void Test_6_6_KukuRow3()
    {
        string result = Exercises.Problem6_6(3);
        string[] lines = result.Split(Environment.NewLine);
        Assert.Equal(9, lines.Length);
        Assert.Equal("3×1=3", lines[0]);
        Assert.Equal("3×5=15", lines[4]);
        Assert.Equal("3×9=27", lines[8]);
    }

    [Fact]
    public void Test_6_6_KukuRow9()
    {
        string result = Exercises.Problem6_6(9);
        string[] lines = result.Split(Environment.NewLine);
        Assert.Equal("9×1=9", lines[0]);
        Assert.Equal("9×9=81", lines[8]);
    }

    // --- 問題 6-7: 素数判定 ---
    [Theory]
    [InlineData(1, false)]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(4, false)]
    [InlineData(17, true)]
    [InlineData(25, false)]
    [InlineData(97, true)]
    [InlineData(100, false)]
    public void Test_6_7_IsPrime(int n, bool expected)
    {
        Assert.Equal(expected, Exercises.Problem6_7(n));
    }

    // --- 問題 6-8: ref スワップ ---
    [Fact]
    public void Test_6_8_SwapPositiveNumbers()
    {
        int a = 10, b = 20;
        Exercises.Problem6_8(ref a, ref b);
        Assert.Equal(20, a);
        Assert.Equal(10, b);
    }

    [Fact]
    public void Test_6_8_SwapNegativeAndPositive()
    {
        int a = -5, b = 100;
        Exercises.Problem6_8(ref a, ref b);
        Assert.Equal(100, a);
        Assert.Equal(-5, b);
    }

    [Fact]
    public void Test_6_8_SwapSameValue()
    {
        int a = 7, b = 7;
        Exercises.Problem6_8(ref a, ref b);
        Assert.Equal(7, a);
        Assert.Equal(7, b);
    }

    // --- 問題 6-9: 配列のインプレースソート ---
    [Fact]
    public void Test_6_9_SortBasic()
    {
        int[] arr = {5, 3, 8, 1, 9, 2};
        Exercises.Problem6_9(arr);
        Assert.Equal(new[] {1, 2, 3, 5, 8, 9}, arr);
    }

    [Fact]
    public void Test_6_9_AlreadySorted()
    {
        int[] arr = {1, 2, 3};
        Exercises.Problem6_9(arr);
        Assert.Equal(new[] {1, 2, 3}, arr);
    }

    [Fact]
    public void Test_6_9_ReverseOrder()
    {
        int[] arr = {9, 7, 5, 3, 1};
        Exercises.Problem6_9(arr);
        Assert.Equal(new[] {1, 3, 5, 7, 9}, arr);
    }

    [Fact]
    public void Test_6_9_SingleElement()
    {
        int[] arr = {42};
        Exercises.Problem6_9(arr);
        Assert.Equal(new[] {42}, arr);
    }

    [Fact]
    public void Test_6_9_WithDuplicates()
    {
        int[] arr = {3, 1, 4, 1, 5, 9, 2, 6};
        Exercises.Problem6_9(arr);
        Assert.Equal(new[] {1, 1, 2, 3, 4, 5, 6, 9}, arr);
    }
}
