// Chapter 02 プレイグラウンド — 入力
// 実行: dotnet run --project playground/Chapter02
//
// src/Chapter02/Exercises.cs に実装を書いてから実行しよう
// 値を変えながら繰り返し試してみよう

try
{
    string s = "Hello C#";   // ← 変えて試そう
    Console.WriteLine(Exercises.Problem2_1(s));
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 2-1");
}

try
{
    int x2 = 42;   // ← 変えて試そう
    Console.WriteLine(Exercises.Problem2_2(x2));
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 2-2");
}

try
{
    int x3 = 3;   // ← 変えて試そう
    Console.WriteLine($"{x3} の 1 乗・2 乗・3 乗: {Exercises.Problem2_3(x3)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 2-3");
}

try
{
    int x4 = 10;   // ← 変えて試そう
    int y4 = 3;    // ← 変えて試そう
    Console.WriteLine($"和      : {Exercises.Problem2_4_Sum(x4, y4)}");
    Console.WriteLine($"差(x-y) : {Exercises.Problem2_4_Difference(x4, y4)}");
    Console.WriteLine($"積      : {Exercises.Problem2_4_Product(x4, y4)}");
    Console.WriteLine($"除算    : {Exercises.Problem2_4_Division(x4, y4)}");
    Console.WriteLine($"商      : {Exercises.Problem2_4_Quotient(x4, y4)}");
    Console.WriteLine($"余り    : {Exercises.Problem2_4_Remainder(x4, y4)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 2-4");
}

try
{
    int a5 = 3;   // ← 変えて試そう
    int b5 = 4;   // ← 変えて試そう
    Console.WriteLine($"{a5} と {b5} の平均: {Exercises.Problem2_5(a5, b5)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 2-5");
}

try
{
    int age = 20;   // ← 変えて試そう
    Console.WriteLine($"年齢 {age} 歳 → おおよそ {Exercises.Problem2_6(age)} 日");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 2-6");
}
