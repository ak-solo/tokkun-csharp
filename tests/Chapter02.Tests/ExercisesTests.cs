using Xunit;

public class Chapter02Tests
{
    // --- 問題 2-1 ---
    [Theory]
    [InlineData("hello")]
    [InlineData("C#")]
    [InlineData("12345")]
    [InlineData("")]
    public void Test_2_1_ReturnInputString(string s)
    {
        Assert.Equal(s, Exercises.Problem2_1(s));
    }

    // --- 問題 2-2 ---
    [Theory]
    [InlineData(0)]
    [InlineData(42)]
    [InlineData(-7)]
    [InlineData(100)]
    public void Test_2_2_ReturnInputInteger(int x)
    {
        Assert.Equal(x, Exercises.Problem2_2(x));
    }

    // --- 問題 2-3 ---
    [Theory]
    [InlineData(3, "6,9,12")]
    [InlineData(5, "10,15,20")]
    [InlineData(1, "2,3,4")]
    [InlineData(10, "20,30,40")]
    public void Test_2_3_MultipleOfX(int x, string expected)
    {
        Assert.Equal(expected, Exercises.Problem2_3(x));
    }

    // --- 問題 2-4 ---
    [Theory]
    [InlineData(2, "2,4,8")]
    [InlineData(3, "3,9,27")]
    [InlineData(5, "5,25,125")]
    [InlineData(1, "1,1,1")]
    public void Test_2_4_PowersOfX(int x, string expected)
    {
        Assert.Equal(expected, Exercises.Problem2_4(x));
    }

    // --- 問題 2-5: 和 ---
    [Theory]
    [InlineData(10, 3, 13)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, 5, 0)]
    [InlineData(100, 200, 300)]
    public void Test_2_5_Sum(int x, int y, int expected)
    {
        Assert.Equal(expected, Exercises.Problem2_5_Sum(x, y));
    }

    // --- 問題 2-5: 差 ---
    [Theory]
    [InlineData(10, 3, 7)]
    [InlineData(5, 5, 0)]
    [InlineData(3, 10, -7)]
    [InlineData(0, 100, -100)]
    public void Test_2_5_Difference(int x, int y, int expected)
    {
        Assert.Equal(expected, Exercises.Problem2_5_Difference(x, y));
    }

    // --- 問題 2-5: 積 ---
    [Theory]
    [InlineData(10, 3, 30)]
    [InlineData(0, 5, 0)]
    [InlineData(-4, 3, -12)]
    [InlineData(7, 7, 49)]
    public void Test_2_5_Product(int x, int y, int expected)
    {
        Assert.Equal(expected, Exercises.Problem2_5_Product(x, y));
    }

    // --- 問題 2-5: 除算（double）---
    [Theory]
    [InlineData(10, 3)]
    [InlineData(7, 2)]
    [InlineData(1, 4)]
    public void Test_2_5_Division(int x, int y)
    {
        double expected = (double)x / y;
        Assert.Equal(expected, Exercises.Problem2_5_Division(x, y), 10);
    }

    // --- 問題 2-5: 商 ---
    [Theory]
    [InlineData(10, 3, 3)]
    [InlineData(7, 2, 3)]
    [InlineData(20, 4, 5)]
    [InlineData(1, 5, 0)]
    public void Test_2_5_Quotient(int x, int y, int expected)
    {
        Assert.Equal(expected, Exercises.Problem2_5_Quotient(x, y));
    }

    // --- 問題 2-5: 余り ---
    [Theory]
    [InlineData(10, 3, 1)]
    [InlineData(7, 2, 1)]
    [InlineData(20, 4, 0)]
    [InlineData(1, 5, 1)]
    public void Test_2_5_Remainder(int x, int y, int expected)
    {
        Assert.Equal(expected, Exercises.Problem2_5_Remainder(x, y));
    }

    // --- 問題 2-6 ---
    [Theory]
    [InlineData(10, 6, 8)]
    [InlineData(3, 4, 3)]
    [InlineData(0, 0, 0)]
    [InlineData(1, 100, 50)]
    public void Test_2_6_Average(int a, int b, int expected)
    {
        Assert.Equal(expected, Exercises.Problem2_6(a, b));
    }

    // --- 問題 2-7 ---
    [Theory]
    [InlineData(1, 365)]
    [InlineData(20, 7300)]
    [InlineData(50, 18250)]
    [InlineData(0, 0)]
    public void Test_2_7_AgeToDays(int age, int expected)
    {
        Assert.Equal(expected, Exercises.Problem2_7(age));
    }

    // --- 問題 2-8 ---
    [Theory]
    [InlineData(10, 3, "3,1")]
    [InlineData(17, 5, "3,2")]
    [InlineData(20, 4, "5,0")]
    [InlineData(7, 2, "3,1")]
    public void Test_2_8_QuotientAndRemainder(int x, int y, string expected)
    {
        Assert.Equal(expected, Exercises.Problem2_8(x, y));
    }
}
