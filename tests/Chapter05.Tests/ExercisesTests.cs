using Xunit;

public class Chapter05Tests
{
    // --- 問題 5-1 ---
    [Theory]
    [InlineData(new int[] {1, 2, 3}, new int[] {2, 4, 6})]
    [InlineData(new int[] {5, 10, 15}, new int[] {10, 20, 30})]
    [InlineData(new int[] {0}, new int[] {0})]
    public void Test_5_1_Double(int[] numbers, int[] expected)
    {
        Assert.Equal(expected, Exercises.Problem5_1(numbers));
    }

    // --- 問題 5-2 ---
    [Theory]
    [InlineData(new int[] {1, 2, 3, 4, 5}, new int[] {5, 4, 3, 2, 1})]
    [InlineData(new int[] {10, 20}, new int[] {20, 10})]
    [InlineData(new int[] {7}, new int[] {7})]
    public void Test_5_2_Reverse(int[] numbers, int[] expected)
    {
        Assert.Equal(expected, Exercises.Problem5_2(numbers));
    }

    // --- 問題 5-3 ---
    [Fact]
    public void Test_5_3_ClassifyEvenOdd()
    {
        int[] numbers = {42, 7, 54, 35, 71, 13, 21, 45, 32, 8};
        int[][] result = Exercises.Problem5_3(numbers);
        Assert.Equal(new[] {42, 54, 32, 8}, result[0]);          // 偶数（入力順）
        Assert.Equal(new[] {7, 35, 71, 13, 21, 45}, result[1]);  // 奇数（入力順）
    }

    [Fact]
    public void Test_5_3_AllEvens()
    {
        int[][] result = Exercises.Problem5_3(new[] {2, 4, 6});
        Assert.Equal(new[] {2, 4, 6}, result[0]);
        Assert.Empty(result[1]);
    }

    [Fact]
    public void Test_5_3_AllOdds()
    {
        int[][] result = Exercises.Problem5_3(new[] {1, 3, 5});
        Assert.Empty(result[0]);
        Assert.Equal(new[] {1, 3, 5}, result[1]);
    }

    // --- 問題 5-4 ---
    [Fact]
    public void Test_5_4_StopWhenSumOver100()
    {
        // 20+30+10+50=110 で停止 → 4 要素返る
        int[] result = Exercises.Problem5_4(new[] {20, 30, 10, 50, 99});
        Assert.Equal(new[] {20, 30, 10, 50}, result);
    }

    [Fact]
    public void Test_5_4_StopAt10Items()
    {
        // 合計が 100 を超えないまま 10 個収集 → 10 要素返る
        int[] input = {5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 99};
        int[] result = Exercises.Problem5_4(input);
        Assert.Equal(10, result.Length);
        Assert.All(result, n => Assert.Equal(5, n));
    }

    [Fact]
    public void Test_5_4_StopImmediately()
    {
        // 1 つ目で即停止
        Assert.Equal(new[] {200}, Exercises.Problem5_4(new[] {200, 1, 2}));
    }

    // --- 問題 5-5 ---
    [Fact]
    public void Test_5_5_BinaryRepresentation()
    {
        int[] result0 = Exercises.Problem5_5(0);
        Assert.Equal(16, result0.Length);
        Assert.All(result0, b => Assert.Equal(0, b));  // 全ビット 0

        int[] result1 = Exercises.Problem5_5(1);
        Assert.Equal(0, result1[0]);    // MSB = 0
        Assert.Equal(1, result1[15]);   // LSB = 1

        int[] result5 = Exercises.Problem5_5(5);   // 0000000000000101
        Assert.Equal(1, result5[13]);
        Assert.Equal(0, result5[14]);
        Assert.Equal(1, result5[15]);
        Assert.Equal(0, result5[0]);
    }

    [Fact]
    public void Test_5_5_AllOnes()
    {
        // 65535 = 1111111111111111
        int[] result = Exercises.Problem5_5(65535);
        Assert.All(result, b => Assert.Equal(1, b));
    }

    // --- 問題 5-6 ---
    [Fact]
    public void Test_5_6_MultiplicationTable()
    {
        int[,] kuku = Exercises.Problem5_6();
        Assert.Equal(1, kuku[0, 0]);   // 1×1
        Assert.Equal(6, kuku[1, 2]);   // 2×3
        Assert.Equal(9, kuku[2, 2]);   // 3×3
        Assert.Equal(9, kuku[0, 8]);   // 1×9
        Assert.Equal(81, kuku[8, 8]);  // 9×9
    }

    // --- 問題 5-7 ---
    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(3, 4, 12)]
    [InlineData(7, 8, 56)]
    [InlineData(9, 9, 81)]
    public void Test_5_7_KukuLookup(int x, int y, int expected)
    {
        Assert.Equal(expected, Exercises.Problem5_7(x, y));
    }

    // --- 問題 5-8 ---
    [Theory]
    [InlineData(new int[] {5, 3, 8, 1}, new int[] {1, 3, 5, 8})]
    [InlineData(new int[] {-3, 7, -1, 2}, new int[] {-3, -1, 2, 7})]
    [InlineData(new int[] {1}, new int[] {1})]
    [InlineData(new int[] {3, 3, 1, 2}, new int[] {1, 2, 3, 3})]
    public void Test_5_8_Sort(int[] numbers, int[] expected)
    {
        Assert.Equal(expected, Exercises.Problem5_8(numbers));
    }

    [Fact]
    public void Test_5_8_DoesNotMutateInput()
    {
        // 元の配列を変更していないことを確認
        int[] original = {5, 3, 8, 1};
        Exercises.Problem5_8(original);
        Assert.Equal(new[] {5, 3, 8, 1}, original);
    }

    // --- 問題 5-9 ---
    [Theory]
    [InlineData(new int[] {10, 20, 30}, 20)]
    [InlineData(new int[] {1, 2, 3, 4}, 2)]
    [InlineData(new int[] {100}, 100)]
    public void Test_5_9_Average(int[] numbers, int expected)
    {
        Assert.Equal(expected, Exercises.Problem5_9(numbers));
    }

    // --- 問題 5-10 ---
    [Fact]
    public void Test_5_10_WinsLosses()
    {
        int[] r1 = Exercises.Problem5_10(new[] {1, 0, 1, 1, 0});
        Assert.Equal(3, r1[0]);
        Assert.Equal(2, r1[1]);

        int[] r2 = Exercises.Problem5_10(new[] {0, 0, 0});
        Assert.Equal(0, r2[0]);
        Assert.Equal(3, r2[1]);
    }

    // --- 問題 5-11 ---
    [Fact]
    public void Test_5_11_TotalScore()
    {
        Assert.Equal(9, Exercises.Problem5_11_TotalScore(new[] {1, 2, 0, 3, 0, 1, 0, 2, 0}));
        Assert.Equal(0, Exercises.Problem5_11_TotalScore(new[] {0, 0, 0, 0, 0, 0, 0, 0, 0}));
    }

    // --- 問題 5-12 ---
    [Theory]
    [InlineData(new int[] {5, 3, 8, 1}, 8)]
    [InlineData(new int[] {-1, -5, -3}, -1)]
    [InlineData(new int[] {7}, 7)]
    public void Test_5_12_Max(int[] numbers, int expected)
    {
        Assert.Equal(expected, Exercises.Problem5_12(numbers));
    }

    // --- 問題 5-13 ---
    [Fact]
    public void Test_5_13_MaxMin()
    {
        int[] r1 = Exercises.Problem5_13(new[] {5, 3, 8, 1, 9});
        Assert.Equal(9, r1[0]);
        Assert.Equal(1, r1[1]);

        int[] r2 = Exercises.Problem5_13(new[] {-3, -1, -5});
        Assert.Equal(-1, r2[0]);
        Assert.Equal(-5, r2[1]);
    }

    // --- 問題 5-14 ---
    [Theory]
    [InlineData(new int[] {30, 40, 50, 60}, 120)]
    [InlineData(new int[] {101}, 101)]
    [InlineData(new int[] {50, 51}, 101)]
    public void Test_5_14_SumUntilOver100(int[] numbers, int expected)
    {
        Assert.Equal(expected, Exercises.Problem5_14(numbers));
    }

    // --- 問題 5-15 ---
    [Theory]
    [InlineData(new int[] {1, 2, 1, 1}, "3ストライク,1ボール")]
    [InlineData(new int[] {2, 2, 2, 2}, "0ストライク,4ボール")]
    [InlineData(new int[] {1, 2, 1, 2, 2, 2}, "2ストライク,4ボール")]
    public void Test_5_15_StrikeBall(int[] pitches, string expected)
    {
        Assert.Equal(expected, Exercises.Problem5_15(pitches));
    }

    // --- 問題 5-16 ---
    [Theory]
    [InlineData(new int[] {3, 3, 1}, "3ストライク,0ボール")]
    [InlineData(new int[] {1, 1, 3, 1}, "3ストライク,0ボール")]
    [InlineData(new int[] {3, 3, 3, 2, 2, 2, 2}, "2ストライク,4ボール")]
    public void Test_5_16_StrikeBallFoul(int[] pitches, string expected)
    {
        Assert.Equal(expected, Exercises.Problem5_16(pitches));
    }

    // --- 問題 5-17 ---
    [Theory]
    [InlineData(new int[] {5, 10, 3, 0}, 18)]
    [InlineData(new int[] {100, 0}, 100)]
    [InlineData(new int[] {0}, 0)]
    public void Test_5_17_SumUntilZero(int[] numbers, int expected)
    {
        Assert.Equal(expected, Exercises.Problem5_17(numbers));
    }

    // --- 問題 5-18 ---
    [Theory]
    [InlineData(new int[] {5, 10, 3, 0}, 6)]
    [InlineData(new int[] {3, 4, 0}, 3)]
    [InlineData(new int[] {10, 0}, 10)]
    public void Test_5_18_AverageUntilZero(int[] numbers, int expected)
    {
        Assert.Equal(expected, Exercises.Problem5_18(numbers));
    }
}
