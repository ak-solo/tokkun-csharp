using System.Collections.Generic;
using System.Linq;

public class Exercises
{
    // 問題 10-1: threshold 以上の要素を昇順に返す（Where + OrderBy）
    public static int[] Problem10_1(int[] numbers, int threshold)
    {
        return numbers
            .Where(n => n >= threshold)
            .OrderBy(n => n)
            .ToArray();
    }

    // 問題 10-2: 各要素を "{n}番" の文字列に変換した配列を返す（Select）
    public static string[] Problem10_2(int[] numbers)
    {
        return numbers
            .Select(n => $"{n}番")
            .ToArray();
    }

    // 問題 10-3: 文字数の短い順（同じ文字数はアルファベット順）に並べた配列を返す（OrderBy + ThenBy）
    public static string[] Problem10_3(string[] words)
    {
        return words
            .OrderBy(w => w.Length)
            .ThenBy(w => w)
            .ToArray();
    }

    // 問題 10-4: 平均値（double）を返す（Average）
    public static double Problem10_4(int[] scores)
    {
        return scores.Average();
    }

    // 問題 10-5: 偶数を抽出 → 2乗 → 昇順（Where + Select + OrderBy のチェーン）
    public static int[] Problem10_5(int[] numbers)
    {
        return numbers
            .Where(n => n % 2 == 0)
            .Select(n => n * n)
            .OrderBy(n => n)
            .ToArray();
    }

    // 問題 10-6: 降順に並べて先頭 n 件を返す（OrderByDescending + Take）
    public static int[] Problem10_6(int[] scores, int n)
    {
        return scores
            .OrderByDescending(s => s)
            .Take(n)
            .ToArray();
    }

    // 問題 10-7: 負の数が 1 つでも含まれていれば true（Any）
    public static bool Problem10_7_HasNegative(int[] numbers)
    {
        return numbers.Any(n => n < 0);
    }

    // 問題 10-7: すべての要素が正の数（> 0）であれば true（All）
    public static bool Problem10_7_AllPositive(int[] numbers)
    {
        return numbers.All(n => n > 0);
    }

    // 問題 10-7: threshold を超える要素の個数を返す（Count）
    public static int Problem10_7_CountOver(int[] numbers, int threshold)
    {
        return numbers.Count(n => n > threshold);
    }

    // 問題 10-8: 文字数 minLength 以上の単語を文字数の降順に返す（クエリ構文）
    public static string[] Problem10_8(string[] words, int minLength)
    {
        return (from w in words
                where w.Length >= minLength
                orderby w.Length descending
                select w).ToArray();
    }

    // 問題 10-9: 先頭文字ごとの出現件数を Dictionary で返す（GroupBy）
    public static Dictionary<char, int> Problem10_9(string[] words)
    {
        return words
            .GroupBy(w => w[0])
            .ToDictionary(g => g.Key, g => g.Count());
    }
}
