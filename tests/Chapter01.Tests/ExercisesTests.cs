using Xunit;

public class Chapter01Tests
{
    // --- 問題 1-1 ---
    [Fact]
    public void Test_1_1_HelloWorld()
    {
        Assert.Equal("Hello World", Exercises.Problem1_1());
    }

    // --- 問題 1-2 ---
    [Fact]
    public void Test_1_2_VariableDisplay()
    {
        Assert.Equal("x=11", Exercises.Problem1_2());
    }

    // --- 問題 1-3 ---
    [Fact]
    public void Test_1_3_TwoVariables()
    {
        Assert.Equal("x=13,y=17", Exercises.Problem1_3());
    }

    // --- 問題 1-4 ---
    [Fact]
    public void Test_1_4_SumOf13And17()
    {
        Assert.Equal(30, Exercises.Problem1_4());
    }

    // --- 問題 1-5 ---
    [Fact]
    public void Test_1_5_ProductOf13And17()
    {
        Assert.Equal(221, Exercises.Problem1_5());
    }

    // --- 問題 1-6 ---
    [Fact]
    public void Test_1_6_TripleThenHalf()
    {
        Assert.Equal("21,10", Exercises.Problem1_6());
    }

    // --- 問題 1-7 ---
    [Fact]
    public void Test_1_7_SwapVariables()
    {
        Assert.Equal("x=7,y=3", Exercises.Problem1_7());
    }

    // --- 問題 1-8 ---
    [Fact]
    public void Test_1_8_ProductOf19And23()
    {
        Assert.Equal(437, Exercises.Problem1_8());
    }

    // --- 問題 1-9 ---
    [Fact]
    public void Test_1_9_DivisionReturnsDouble()
    {
        double result = Exercises.Problem1_9();
        Assert.IsType<double>(result);
        Assert.Equal(10.0 / 3.0, result, 10);
    }

    // --- 問題 1-10 ---
    [Fact]
    public void Test_1_10_IntegerDivision()
    {
        Assert.Equal(3, Exercises.Problem1_10());
    }
}
