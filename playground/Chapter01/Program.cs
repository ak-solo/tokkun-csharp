// Chapter 01 プレイグラウンド — 表示・変数・演算
// 実行: dotnet run --project playground/Chapter01
//
// src/Chapter01/Exercises.cs に実装を書いてから実行しよう
// 値を変えながら繰り返し試してみよう

try
{
    Console.WriteLine(Exercises.Problem1_1());
    Console.WriteLine(Exercises.Problem1_2());
    Console.WriteLine(Exercises.Problem1_3());
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 1-1 〜 1-3");
}

try
{
    Console.WriteLine($"13 + 17 = {Exercises.Problem1_4()}");
    Console.WriteLine($"13 * 17 = {Exercises.Problem1_5()}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 1-4 〜 1-5");
}

try
{
    Console.WriteLine($"x=7 を 3 倍→半分（商,半分）: {Exercises.Problem1_6()}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 1-6");
}

try
{
    int x9 = 3;   // ← この値を変えて実行してみよう
    Console.WriteLine($"{x9} の 2 倍・3 倍・4 倍: {Exercises.Problem1_9(x9)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 1-9");
}

try
{
    int x10 = 2;   // ← この値を変えて実行してみよう
    Console.WriteLine($"{x10} の 1 乗・2 乗・3 乗: {Exercises.Problem1_10(x10)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 1-10");
}

try
{
    Console.WriteLine($"10 / 3  = {Exercises.Problem1_11()} （double）");
    Console.WriteLine($"10 / 3  = {Exercises.Problem1_12()} （int）");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 1-11 〜 1-12");
}

try
{
    int x13 = 17;  // ← 変えて試そう（x > y であること）
    int y13 = 5;   // ← 変えて試そう
    Console.WriteLine($"{x13} ÷ {y13} の（商,余り）: {Exercises.Problem1_13(x13, y13)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 1-13");
}
