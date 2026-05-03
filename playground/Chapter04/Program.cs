// Chapter 04 プレイグラウンド — 繰り返し
// 実行: dotnet run --project playground/Chapter04
//
// src/Chapter04/Exercises.cs に実装を書いてから実行しよう
// 値を変えながら繰り返し試してみよう

try
{
    Console.WriteLine(Exercises.Problem4_1());
    Console.WriteLine(Exercises.Problem4_2());
    Console.WriteLine(Exercises.Problem4_3());
    Console.WriteLine($"7! = {Exercises.Problem4_4()}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 4-1 〜 4-4");
}

try
{
    int n7 = 20100;   // ← 変えて試そう（2 以上）
    Console.WriteLine($"{n7} の素因数: {Exercises.Problem4_7(n7)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 4-7");
}

try
{
    int n8 = 97;   // ← 変えて試そう
    Console.WriteLine($"{n8} は素数か: {Exercises.Problem4_8(n8)}");

    Console.Write("100 以下の素数: ");
    for (int i = 2; i <= 100; i++)
        if (Exercises.Problem4_8(i)) Console.Write($"{i} ");
    Console.WriteLine();
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 4-8");
}

try
{
    int size9 = 5;   // ← 変えて試そう
    Console.WriteLine(Exercises.Problem4_9(size9));
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 4-9");
}

try
{
    int size10 = 5;   // ← 変えて試そう（2 以上）
    Console.WriteLine(Exercises.Problem4_10(size10));
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 4-10");
}

try
{
    Console.WriteLine(Exercises.Problem4_11());
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 4-11");
}
