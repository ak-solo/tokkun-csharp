// Chapter 03 プレイグラウンド — 分岐
// 実行: dotnet run --project playground/Chapter03
//
// src/Chapter03/Exercises.cs に実装を書いてから実行しよう
// 値を変えながら繰り返し試してみよう

try
{
    int x34 = 10;   // ← 変えて試そう
    int y34 = 5;    // ← 変えて試そう
    Console.WriteLine($"3-1: {Exercises.Problem3_1(x34, y34)}");
    Console.WriteLine($"3-2: {Exercises.Problem3_2(x34, y34)}");
    Console.WriteLine($"3-3 大きい方: {Exercises.Problem3_3(x34, y34)}");
    Console.WriteLine($"3-4: {Exercises.Problem3_4(x34, y34)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 3-1 〜 3-4");
}

try
{
    int x56 = -4;   // ← 変えて試そう
    Console.WriteLine($"3-5: {Exercises.Problem3_5(x56)}");
    Console.WriteLine($"3-6: {Exercises.Problem3_6(x56)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 3-5 〜 3-6");
}

try
{
    int score = 75;   // ← 変えて試そう
    Console.WriteLine($"ケース1: {Exercises.Problem3_7_Case1(score)}");
    Console.WriteLine($"ケース2: {Exercises.Problem3_7_Case2(score)}");
    Console.WriteLine($"ケース3: {Exercises.Problem3_7_Case3(score)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 3-7");
}

try
{
    int midterm = 50;   // ← 変えて試そう
    int final_  = 90;   // ← 変えて試そう
    Console.WriteLine($"中間:{midterm} 期末:{final_} → {Exercises.Problem3_8(midterm, final_)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 3-8");
}

try
{
    string[] days  = { "日", "月", "火", "水", "木", "金", "土" };
    string[] times = { "午前", "午後", "夜間" };
    Console.Write("     ");
    foreach (string d in days) Console.Write($"{d}  ");
    Console.WriteLine();
    for (int t = 0; t <= 2; t++)
    {
        Console.Write($"{times[t]} ");
        for (int d = 0; d <= 6; d++)
            Console.Write($"{Exercises.Problem3_9(d, t)}  ");
        Console.WriteLine();
    }
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 3-9");
}

try
{
    int choice = 1;   // ← 1〜5 で変えて試そう
    Console.WriteLine(Exercises.Problem3_11(choice));
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 3-11");
}

try
{
    for (int month = 1; month <= 12; month++)
        Console.WriteLine(Exercises.Problem3_12(month));
    Console.WriteLine(Exercises.Problem3_12(13));
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 3-12");
}
