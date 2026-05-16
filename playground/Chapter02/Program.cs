// Chapter 02 プレイグラウンド — 引数と戻り値
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
    Console.WriteLine($"{x3} の 2 倍・3 倍・4 倍: {Exercises.Problem2_3(x3)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 2-3");
}

try
{
    int x4 = 2;   // ← 変えて試そう
    Console.WriteLine($"{x4} の 1 乗・2 乗・3 乗: {Exercises.Problem2_4(x4)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 2-4");
}

try
{
    int x5 = 10;   // ← 変えて試そう
    int y5 = 3;    // ← 変えて試そう
    Console.WriteLine($"和      : {Exercises.Problem2_5_Sum(x5, y5)}");
    Console.WriteLine($"差(x-y) : {Exercises.Problem2_5_Difference(x5, y5)}");
    Console.WriteLine($"積      : {Exercises.Problem2_5_Product(x5, y5)}");
    Console.WriteLine($"除算    : {Exercises.Problem2_5_Division(x5, y5)}");
    Console.WriteLine($"商      : {Exercises.Problem2_5_Quotient(x5, y5)}");
    Console.WriteLine($"余り    : {Exercises.Problem2_5_Remainder(x5, y5)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 2-5");
}

try
{
    int a6 = 3;   // ← 変えて試そう
    int b6 = 4;   // ← 変えて試そう
    Console.WriteLine($"{a6} と {b6} の平均: {Exercises.Problem2_6(a6, b6)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 2-6");
}

try
{
    int age = 20;   // ← 変えて試そう
    Console.WriteLine($"年齢 {age} 歳 → おおよそ {Exercises.Problem2_7(age)} 日");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 2-7");
}

try
{
    int x8 = 17;  // ← 変えて試そう（x > y であること）
    int y8 = 5;   // ← 変えて試そう
    Console.WriteLine($"{x8} ÷ {y8} の（商,余り）: {Exercises.Problem2_8(x8, y8)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 2-8");
}
