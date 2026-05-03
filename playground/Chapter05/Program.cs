// Chapter 05 プレイグラウンド — 配列
// 実行: dotnet run --project playground/Chapter05
//
// src/Chapter05/Exercises.cs に実装を書いてから実行しよう
// 値を変えながら繰り返し試してみよう

try
{
    int[] numbers12 = { 3, 7, 1, 9, 4 };   // ← 変えて試そう
    Console.WriteLine($"元: {string.Join(", ", numbers12)}");
    Console.WriteLine($"2倍: {string.Join(", ", Exercises.Problem5_1(numbers12))}");
    Console.WriteLine($"逆順: {string.Join(", ", Exercises.Problem5_2(numbers12))}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 5-1 〜 5-2");
}

try
{
    int[] numbers3 = { 42, 7, 54, 35, 71, 13, 21, 45, 32, 8 };   // ← 変えて試そう
    int[][] r3 = Exercises.Problem5_3(numbers3);
    Console.WriteLine($"偶数: {string.Join(" ", r3[0])}");
    Console.WriteLine($"奇数: {string.Join(" ", r3[1])}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 5-3");
}

try
{
    int value = 42;   // ← 変えて試そう（0〜65535）
    int[] binary = Exercises.Problem5_5(value);
    Console.WriteLine($"{value} = {string.Join("", binary)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 5-5");
}

try
{
    int[,] kuku = Exercises.Problem5_6();
    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
            Console.Write($"{kuku[i, j],3}");
        Console.WriteLine();
    }
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 5-6");
}

try
{
    int x7 = 7;   // ← 1〜9 で変えて試そう
    int y7 = 8;   // ← 1〜9 で変えて試そう
    Console.WriteLine($"{x7} × {y7} = {Exercises.Problem5_7(x7, y7)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 5-7");
}

try
{
    int[] numbers8 = { 5, 3, 8, 1, 9, 2, 7, 4, 6, 0 };   // ← 変えて試そう
    int[] sorted = Exercises.Problem5_8(numbers8);
    Console.WriteLine($"元:   {string.Join(", ", numbers8)}");
    Console.WriteLine($"並替: {string.Join(", ", sorted)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 5-8");
}

try
{
    int[] numbers9 = { 10, 20, 30, 40 };   // ← 変えて試そう
    Console.WriteLine($"平均: {Exercises.Problem5_9(numbers9)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 5-9");
}

try
{
    int[] results10 = { 1, 0, 1, 1, 0 };   // ← 変えて試そう（1=勝ち, 0=負け）
    int[] r10 = Exercises.Problem5_10(results10);
    Console.WriteLine($"勝ち: {r10[0]}, 負け: {r10[1]}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 5-10");
}

try
{
    int[] giants11 = { 1, 2, 0, 3, 0, 1, 0, 2, 0 };   // ← 変えて試そう
    int[] tigers11 = { 0, 0, 2, 0, 1, 0, 0, 0, 3 };   // ← 変えて試そう
    int g = Exercises.Problem5_11_TotalScore(giants11);
    int t = Exercises.Problem5_11_TotalScore(tigers11);
    Console.WriteLine($"巨人 {g} - {t} 阪神");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 5-11");
}

try
{
    int[] numbers13 = { 5, 3, 8, 1, 9 };   // ← 変えて試そう
    Console.WriteLine($"最大: {Exercises.Problem5_12(numbers13)}");
    int[] r13 = Exercises.Problem5_13(numbers13);
    Console.WriteLine($"最大: {r13[0]}, 最小: {r13[1]}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 5-12 〜 5-13");
}

try
{
    int[] numbers14 = { 30, 40, 50, 60 };   // ← 変えて試そう
    Console.WriteLine($"停止時の合計: {Exercises.Problem5_14(numbers14)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 5-14");
}

try
{
    int[] pitches15 = { 1, 2, 1, 1 };   // ← 変えて試そう（1=S, 2=B）
    Console.WriteLine($"5-15: {Exercises.Problem5_15(pitches15)}");

    int[] pitches16 = { 3, 3, 1 };      // ← 変えて試そう（1=S, 2=B, 3=F）
    Console.WriteLine($"5-16: {Exercises.Problem5_16(pitches16)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 5-15 〜 5-16");
}

try
{
    int[] numbers17 = { 5, 10, 3, 0, 99 };   // ← 変えて試そう
    Console.WriteLine($"0 の手前の合計: {Exercises.Problem5_17(numbers17)}");
    Console.WriteLine($"0 の手前の平均: {Exercises.Problem5_18(numbers17)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 5-17 〜 5-18");
}
