using Xunit;

public class Chapter09Tests
{
    // ===== 問題 9-1: Trim + ToUpper =====

    [Theory]
    [InlineData("  hello world  ", "HELLO WORLD")]
    [InlineData("  C#  ", "C#")]
    [InlineData("already", "ALREADY")]
    [InlineData("  ", "")]
    public void Test_9_1_TrimAndUpperCase(string input, string expected)
    {
        Assert.Equal(expected, Exercises.Problem9_1(input));
    }

    [Fact]
    public void Test_9_1_MixedCase()
    {
        Assert.Equal("HELLO WORLD", Exercises.Problem9_1("  Hello World  "));
    }

    // ===== 問題 9-2: IndexOf + Substring =====

    [Theory]
    [InlineData("user@example.com", '@', "user")]
    [InlineData("first.last@mail.co.jp", '@', "first.last")]
    [InlineData("hello", '@', "hello")]
    public void Test_9_2_SubstringBeforeDelimiter(string text, char delimiter, string expected)
    {
        Assert.Equal(expected, Exercises.Problem9_2(text, delimiter));
    }

    [Fact]
    public void Test_9_2_SlashDelimiter()
    {
        Assert.Equal("https:", Exercises.Problem9_2("https://example.com", '/'));
    }

    // ===== 問題 9-3: Split + Trim =====

    [Fact]
    public void Test_9_3_SplitAndTrim()
    {
        Assert.Equal(new[] { "apple", "banana", "cherry" }, Exercises.Problem9_3("apple, banana, cherry"));
    }

    [Fact]
    public void Test_9_3_NoExtraSpaces()
    {
        Assert.Equal(new[] { "a", "b", "c" }, Exercises.Problem9_3("a,b,c"));
    }

    [Fact]
    public void Test_9_3_SingleElement()
    {
        Assert.Equal(new[] { "only" }, Exercises.Problem9_3("only"));
    }

    [Fact]
    public void Test_9_3_WithLeadingAndTrailingSpaces()
    {
        string[] result = Exercises.Problem9_3("  alpha , beta  ,  gamma  ");
        Assert.Equal("alpha", result[0]);
        Assert.Equal("beta", result[1]);
        Assert.Equal("gamma", result[2]);
    }

    // ===== 問題 9-4: Replace =====

    [Theory]
    [InlineData("Hello World World", "World", "C#", "Hello C# C#")]
    [InlineData("aabbcc", "b", "X", "aaXXcc")]
    [InlineData("no match here", "xyz", "ABC", "no match here")]
    public void Test_9_4_ReplaceAll(string text, string oldWord, string newWord, string expected)
    {
        Assert.Equal(expected, Exercises.Problem9_4(text, oldWord, newWord));
    }

    [Fact]
    public void Test_9_4_EmptyReplacement()
    {
        Assert.Equal("Hello ", Exercises.Problem9_4("Hello World", "World", ""));
    }

    // ===== 問題 9-5: StartsWith / EndsWith / Contains =====

    [Theory]
    [InlineData("Hello, World", "Hello", true)]
    [InlineData("Hello, World", "World", false)]
    [InlineData("Hello, World", "", true)]
    public void Test_9_5_StartsWith(string text, string prefix, bool expected)
    {
        Assert.Equal(expected, Exercises.Problem9_5_StartsWith(text, prefix));
    }

    [Theory]
    [InlineData("Hello, World", "World", true)]
    [InlineData("Hello, World", "Hello", false)]
    [InlineData("Hello, World", "", true)]
    public void Test_9_5_EndsWith(string text, string suffix, bool expected)
    {
        Assert.Equal(expected, Exercises.Problem9_5_EndsWith(text, suffix));
    }

    [Theory]
    [InlineData("Hello, World", "World", true)]
    [InlineData("Hello, World", "C#", false)]
    [InlineData("Hello, World", "Hello", true)]
    public void Test_9_5_Contains(string text, string keyword, bool expected)
    {
        Assert.Equal(expected, Exercises.Problem9_5_Contains(text, keyword));
    }

    // ===== 問題 9-6: 曜日（日本語） =====

    [Fact]
    public void Test_9_6_Monday()
    {
        Assert.Equal("月曜日", Exercises.Problem9_6(new DateTime(2024, 1, 1)));
    }

    [Fact]
    public void Test_9_6_Sunday()
    {
        Assert.Equal("日曜日", Exercises.Problem9_6(new DateTime(2024, 1, 7)));
    }

    [Fact]
    public void Test_9_6_AllDaysOfWeek()
    {
        Assert.Equal("月曜日", Exercises.Problem9_6(new DateTime(2024, 1, 1)));
        Assert.Equal("火曜日", Exercises.Problem9_6(new DateTime(2024, 1, 2)));
        Assert.Equal("水曜日", Exercises.Problem9_6(new DateTime(2024, 1, 3)));
        Assert.Equal("木曜日", Exercises.Problem9_6(new DateTime(2024, 1, 4)));
        Assert.Equal("金曜日", Exercises.Problem9_6(new DateTime(2024, 1, 5)));
        Assert.Equal("土曜日", Exercises.Problem9_6(new DateTime(2024, 1, 6)));
        Assert.Equal("日曜日", Exercises.Problem9_6(new DateTime(2024, 1, 7)));
    }

    // ===== 問題 9-7: 日付の差分 =====

    [Fact]
    public void Test_9_7_DaysInSameMonth()
    {
        Assert.Equal(9, Exercises.Problem9_7(new DateTime(2024, 1, 1), new DateTime(2024, 1, 10)));
    }

    [Fact]
    public void Test_9_7_AcrossMonths()
    {
        Assert.Equal(60, Exercises.Problem9_7(new DateTime(2024, 1, 1), new DateTime(2024, 3, 1)));
    }

    [Fact]
    public void Test_9_7_SameDay()
    {
        Assert.Equal(0, Exercises.Problem9_7(new DateTime(2024, 5, 1), new DateTime(2024, 5, 1)));
    }

    [Fact]
    public void Test_9_7_AcrossYears()
    {
        // 2024 年はうるう年（366 日）
        Assert.Equal(366, Exercises.Problem9_7(new DateTime(2024, 1, 1), new DateTime(2025, 1, 1)));
    }

    // ===== 問題 9-8: 日付フォーマット =====

    [Fact]
    public void Test_9_8_FormatDate()
    {
        Assert.Equal("2024年3月5日", Exercises.Problem9_8(new DateTime(2024, 3, 5)));
    }

    [Fact]
    public void Test_9_8_EndOfYear()
    {
        Assert.Equal("2024年12月31日", Exercises.Problem9_8(new DateTime(2024, 12, 31)));
    }

    [Fact]
    public void Test_9_8_SingleDigitMonthAndDay()
    {
        Assert.Equal("2024年1月1日", Exercises.Problem9_8(new DateTime(2024, 1, 1)));
    }

    // ===== 問題 9-9: n 日後のフォーマット =====

    [Fact]
    public void Test_9_9_AddDays()
    {
        Assert.Equal("2024/01/31", Exercises.Problem9_9(new DateTime(2024, 1, 1), 30));
    }

    [Fact]
    public void Test_9_9_CrossMonth()
    {
        Assert.Equal("2024/02/01", Exercises.Problem9_9(new DateTime(2024, 1, 31), 1));
    }

    [Fact]
    public void Test_9_9_ZeroDays()
    {
        Assert.Equal("2024/01/01", Exercises.Problem9_9(new DateTime(2024, 1, 1), 0));
    }

    [Fact]
    public void Test_9_9_CrossYear()
    {
        Assert.Equal("2025/01/01", Exercises.Problem9_9(new DateTime(2024, 12, 31), 1));
    }
}
