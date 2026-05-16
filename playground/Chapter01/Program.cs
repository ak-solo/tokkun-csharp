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
    Console.WriteLine(Exercises.Problem1_7());
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 1-7");
}

try
{
    Console.WriteLine($"19 * 23 = {Exercises.Problem1_8()}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 1-8");
}

try
{
    Console.WriteLine($"10 / 3  = {Exercises.Problem1_9()} （double）");
    Console.WriteLine($"10 / 3  = {Exercises.Problem1_10()} （int）");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 1-9 〜 1-10");
}
