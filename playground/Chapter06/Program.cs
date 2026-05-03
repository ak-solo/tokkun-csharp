// Chapter 06 プレイグラウンド — メソッド
// 実行: dotnet run --project playground/Chapter06
//
// src/Chapter06/Exercises.cs に実装を書いてから実行しよう
// 値を変えながら繰り返し試してみよう

try
{
    int n1 = 5;
    Console.WriteLine($"{n1} の 2 乗 = {Exercises.Problem6_1(n1)}");
    int a1 = 7, b1 = 13;
    Console.WriteLine($"平均({a1}, {b1}) = {Exercises.Problem6_2(a1, b1)}");
    Console.WriteLine($"最大({a1}, {b1}) = {Exercises.Problem6_3(a1, b1)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 6-1 〜 6-3");
}

try
{
    int size = 5;
    Console.WriteLine("--- $ 三角形 ---");
    Console.WriteLine(Exercises.Problem6_4(size));
    Console.WriteLine();
    Console.WriteLine("--- * 三角形 ---");
    Console.WriteLine(Exercises.Problem6_5(size, '*'));
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 6-4 〜 6-5");
}

try
{
    int n6 = 3;
    Console.WriteLine($"--- {n6} の段 ---");
    Console.WriteLine(Exercises.Problem6_6(n6));
    for (int i = 1; i <= 9; i++)
    {
        Console.WriteLine($"=== {i} の段 ===");
        Console.WriteLine(Exercises.Problem6_6(i));
    }
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 6-6");
}

try
{
    int n7 = 97;
    string result7 = Exercises.Problem6_7(n7) ? "素数" : "素数ではない";
    Console.WriteLine($"{n7} は{result7}");
    var primes = new List<int>();
    for (int i = 2; i < 1000; i++)
        if (Exercises.Problem6_7(i)) primes.Add(i);
    Console.WriteLine($"1000 未満の素数: {primes.Count} 個");
    Console.WriteLine(string.Join(", ", primes));
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 6-7");
}

try
{
    int a8 = 42, b8 = 99;
    Console.WriteLine($"スワップ前: a={a8}, b={b8}");
    Exercises.Problem6_8(ref a8, ref b8);
    Console.WriteLine($"スワップ後: a={a8}, b={b8}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 6-8");
}

try
{
    int[] numbers9 = { 5, 3, 8, 1, 9, 2, 7, 4, 6 };
    Console.WriteLine($"ソート前: {string.Join(", ", numbers9)}");
    Exercises.Problem6_9(numbers9);
    Console.WriteLine($"ソート後: {string.Join(", ", numbers9)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 6-9");
}
