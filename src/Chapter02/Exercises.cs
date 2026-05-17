public class Exercises
{
    // 問題 2-1: 入力された文字列をそのまま返す
    public static string Problem2_1(string s)
    {
        return s;
    }

    // 問題 2-2: 入力された整数をそのまま返す
    public static int Problem2_2(int x)
    {
        return x;
    }

    // 問題 2-3: x を 2 倍・3 倍・4 倍した結果をカンマ区切りの文字列で返す
    public static string Problem2_3(int x)
    {
        return $"{x * 2},{x * 3},{x * 4}";
    }

    // 問題 2-4: x の 1 乗・2 乗・3 乗をカンマ区切りの文字列で返す
    public static string Problem2_4(int x)
    {
        return $"{x},{(int)Math.Pow(x, 2)},{(int)Math.Pow(x, 3)}";
    }

    // 問題 2-5: x と y の和を返す
    public static int Problem2_5_Sum(int x, int y)
    {
        return x + y;
    }

    // 問題 2-5: x と y の差（x - y）を返す
    public static int Problem2_5_Difference(int x, int y)
    {
        return x - y;
    }

    // 問題 2-5: x と y の積を返す
    public static int Problem2_5_Product(int x, int y)
    {
        return x * y;
    }

    // 問題 2-5: x ÷ y の結果を double で返す（小数あり）
    public static double Problem2_5_Division(int x, int y)
    {
        return (double)x / y;
    }

    // 問題 2-5: x ÷ y の商（整数）を返す
    public static int Problem2_5_Quotient(int x, int y)
    {
        return x / y;
    }

    // 問題 2-5: x ÷ y の余りを返す
    public static int Problem2_5_Remainder(int x, int y)
    {
        return x % y;
    }

    // 問題 2-6: a と b の平均値（小数切り捨て）を返す
    public static int Problem2_6(int a, int b)
    {
        return (a + b) / 2;
    }

    // 問題 2-7: 年齢から生まれてからの日数（年齢 × 365）を返す
    public static int Problem2_7(int age)
    {
        return age * 365;
    }

    // 問題 2-8: x を y で割った商と余りをカンマ区切りの文字列で返す
    public static string Problem2_8(int x, int y)
    {
        return $"{x / y},{x % y}";
    }
}
