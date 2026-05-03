using Xunit;

public class Chapter04Tests
{
    // --- 問題 4-1 ---
    [Fact]
    public void Test_4_1_Spam()
    {
        Assert.Equal("SPAM,SPAM,SPAM,SPAM,SPAM,SPAM,SPAM,SPAM,SPAM,SPAM", Exercises.Problem4_1());
    }

    // --- 問題 4-2 ---
    [Fact]
    public void Test_4_2_MultiplesOf3()
    {
        Assert.Equal("3,6,9,12,15,18,21,24,27", Exercises.Problem4_2());
    }

    // --- 問題 4-3 ---
    [Fact]
    public void Test_4_3_PowersOf2()
    {
        Assert.Equal("2,4,8,16,32,64,128,256", Exercises.Problem4_3());
    }

    // --- 問題 4-4 ---
    [Fact]
    public void Test_4_4_Factorial7()
    {
        Assert.Equal(5040, Exercises.Problem4_4());
    }

    // --- 問題 4-5 ---
    [Theory]
    [InlineData(0, "")]
    [InlineData(3, "***")]
    [InlineData(5, "*****")]
    public void Test_4_5_Asterisks(int n, string expected)
    {
        Assert.Equal(expected, Exercises.Problem4_5(n));
    }

    // --- 問題 4-6 ---
    [Theory]
    [InlineData(0, "")]
    [InlineData(5, "01234")]
    [InlineData(14, "01234567890123")]
    public void Test_4_6_CyclingDigits(int n, string expected)
    {
        Assert.Equal(expected, Exercises.Problem4_6(n));
    }

    // --- 問題 4-7 ---
    [Fact]
    public void Test_4_7_PrimeFactors()
    {
        Assert.Equal("2,2,3", Exercises.Problem4_7(12));
        Assert.Equal("2,2,3,5,5,67", Exercises.Problem4_7(20100));
        Assert.Equal("7", Exercises.Problem4_7(7));
        Assert.Equal("2", Exercises.Problem4_7(2));
    }

    // --- 問題 4-8 ---
    [Theory]
    [InlineData(7, true)]
    [InlineData(13, true)]
    [InlineData(4, false)]
    [InlineData(9, false)]
    [InlineData(100, false)]
    [InlineData(97, true)]
    public void Test_4_8_IsPrime(int n, bool expected)
    {
        Assert.Equal(expected, Exercises.Problem4_8(n));
    }

    // --- 問題 4-9 ---
    [Fact]
    public void Test_4_9_Triangle()
    {
        Assert.Equal("$", Exercises.Problem4_9(1));
        Assert.Equal(string.Join(Environment.NewLine, "$", "$$", "$$$"), Exercises.Problem4_9(3));
        Assert.Equal(string.Join(Environment.NewLine, "$", "$$", "$$$", "$$$$"), Exercises.Problem4_9(4));
    }

    // --- 問題 4-10 ---
    [Fact]
    public void Test_4_10_XPattern()
    {
        Assert.Equal(string.Join(Environment.NewLine, "X X", " X ", "X X"), Exercises.Problem4_10(3));
        Assert.Equal(string.Join(Environment.NewLine, "X  X", " XX ", " XX ", "X  X"), Exercises.Problem4_10(4));
        Assert.Equal(string.Join(Environment.NewLine, "X   X", " X X ", "  X  ", " X X ", "X   X"), Exercises.Problem4_10(5));
    }

    // --- 問題 4-11 ---
    [Fact]
    public void Test_4_11_Fibonacci()
    {
        Assert.Equal("0,1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987", Exercises.Problem4_11());
    }
}
