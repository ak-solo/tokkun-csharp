// Chapter 09 プレイグラウンド — LINQ
// 実行: dotnet run --project playground/Chapter09
//
// src/Chapter09/Exercises.cs に実装を書いてから実行しよう
// 値を変えながら繰り返し試してみよう

using System.Linq;

try
{
    int[] nums1 = { 5, 1, 8, 3, 9, 2 };
    int threshold1 = 4;   // ← この値を変えて試してみよう
    int[] r1 = Exercises.Problem9_1(nums1, threshold1);
    Console.WriteLine($"9-1 ({threshold1} 以上を昇順): {string.Join(", ", r1)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 9-1");
}

try
{
    int[] nums2 = { 3, 1, 4 };   // ← この配列を変えて試してみよう
    string[] r2 = Exercises.Problem9_2(nums2);
    Console.WriteLine($"9-2 (ラベル変換): {string.Join(", ", r2)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 9-2");
}

try
{
    string[] words3 = { "banana", "fig", "apple", "kiwi" };   // ← 単語を変えて試してみよう
    string[] r3 = Exercises.Problem9_3(words3);
    Console.WriteLine($"9-3 (文字数順): {string.Join(", ", r3)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 9-3");
}

try
{
    int[] scores4 = { 80, 60, 95, 70, 55 };   // ← 点数を変えて試してみよう
    double r4 = Exercises.Problem9_4(scores4);
    Console.WriteLine($"9-4 (平均): {r4}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 9-4");
}

try
{
    int[] nums5 = { 5, 2, 8, 3, 4, 6 };   // ← この配列を変えて試してみよう
    int[] r5 = Exercises.Problem9_5(nums5);
    Console.WriteLine($"9-5 (偶数を抽出→2乗→昇順): {string.Join(", ", r5)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 9-5");
}

try
{
    int[] scores6 = { 70, 85, 60, 95, 75 };
    int topN = 3;   // ← この値を変えて試してみよう
    int[] r6 = Exercises.Problem9_6(scores6, topN);
    Console.WriteLine($"9-6 (上位 {topN} 件): {string.Join(", ", r6)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 9-6");
}

try
{
    int[] nums7 = { 3, -1, 5, 0, 8 };   // ← この配列を変えて試してみよう
    Console.WriteLine($"9-7 HasNegative: {Exercises.Problem9_7_HasNegative(nums7)}");
    Console.WriteLine($"9-7 AllPositive: {Exercises.Problem9_7_AllPositive(nums7)}");
    int over7 = 4;   // ← この値を変えて試してみよう
    Console.WriteLine($"9-7 CountOver({over7}): {Exercises.Problem9_7_CountOver(nums7, over7)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 9-7");
}

try
{
    string[] words8 = { "cat", "elephant", "ox", "dog", "hippopotamus" };
    int minLen8 = 4;   // ← この値を変えて試してみよう
    string[] r8 = Exercises.Problem9_8(words8, minLen8);
    Console.WriteLine($"9-8 (文字数 {minLen8} 以上を長い順): {string.Join(", ", r8)}");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 9-8");
}

try
{
    string[] words9 = { "apple", "ant", "banana", "bear", "cat" };   // ← 単語を変えて試してみよう
    var r9 = Exercises.Problem9_9(words9);
    Console.WriteLine("9-9 (先頭文字ごとの件数):");
    foreach (var kvp in r9.OrderBy(p => p.Key))
        Console.WriteLine($"  '{kvp.Key}': {kvp.Value}件");
}
catch (NotImplementedException)
{
    Console.WriteLine("  [未実装] 問題 9-9");
}
